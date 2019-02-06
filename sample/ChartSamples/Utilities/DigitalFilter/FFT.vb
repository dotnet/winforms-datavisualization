'=================================================================
'  File:		FFT.vb
'
'  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities
'
'	Classes:	FFT
'
'  Purpose:	Used for the fast fourier transformation algorithm
'
'===================================================================
' Chart Control for .NET Framework
' Copyright © Microsoft Corporation, all rights reserved
'===================================================================

Imports System
Imports System.Collections.Generic
Imports System.Text


Namespace System.Windows.Forms.DataVisualization.Charting.Utilities
    ''' <summary>
    ''' Helper class which implements the various window functions for determination of the filter
    ''' coefficients.
    ''' </summary>
    Class FFT
        ''' <summary>
        ''' Filter type enumeration for identification of what type of filter we want coefficients
        ''' for.
        ''' </summary>
        Public Enum FilterType
            HighPass
            LowPass
            BandPass
        End Enum 'FilterType

        ''' <summary>
        ''' Algorithm enumeration for choice of algorithm
        ''' </summary>
        Public Enum Algorithm
            Kaiser
            Hann
            Hamming
            Blackman
            Rectangular
        End Enum 'Algorithm

        Private myRate As Single
        Private myFreqFrom As Single
        Private myFreqTo As Single
        Private myAttenuation As Single
        Private myBand As Single
        Private myAlpha As Single
        Private myOrder As Integer

        ''' <summary>
        ''' Shannon sampling frequency
        ''' </summary>
        Private myFS As Single

        ''' <summary>
        ''' Sampling rate
        ''' </summary>
        Public Property Rate() As Single
            Get
                Return myRate
            End Get
            Set(ByVal value As Single)
                myRate = value
                myFS = 0.5F * myRate
            End Set
        End Property

        ''' <summary>
        ''' Starting frequency for passband. Must be lower than the ending frequency.
        ''' </summary>
        Public Property FreqFrom() As Single
            Get
                Return myFreqFrom
            End Get
            Set(ByVal value As Single)
                myFreqFrom = value
            End Set
        End Property

        ''' <summary>
        ''' Ending frequency for passband. Must be higher than the starting frequency.
        ''' </summary>
        Public Property FreqTo() As Single
            Get
                Return myFreqTo
            End Get
            Set(ByVal value As Single)
                myFreqTo = value
            End Set
        End Property

        ''' <summary>
        ''' Stopband attenuation.
        ''' </summary>
        Public Property StopBandAttenuation() As Single
            Get
                Return myAttenuation
            End Get
            Set(ByVal value As Single)
                myAttenuation = value
            End Set
        End Property

        ''' <summary>
        ''' Transition band.
        ''' </summary>
        Public Property TransitionBand() As Single
            Get
                Return myBand
            End Get
            Set(ByVal value As Single)
                myBand = value
            End Set
        End Property

        ''' <summary>
        ''' Alpha value used for the Kaiser algorithm.
        ''' </summary>
        Public Property Alpha() As Single
            Get
                Return myAlpha
            End Get
            Set(ByVal value As Single)
                myAlpha = value
            End Set
        End Property

        ''' <summary>
        ''' Filter order. Must be an even number.
        ''' </summary>
        Public Property Order() As Integer
            Get
                Return myOrder
            End Get
            Set(ByVal value As Integer)
                myOrder = value
            End Set
        End Property

        ''' <summary>
        ''' Construct a FFT instance and initialize with default values.
        ''' </summary>
        Public Sub New()
            'default rate to 8000
            Rate = 8000

            'default attenuation to 60db
            Me.myAttenuation = 60

            'default transition band to 500hz
            Me.myBand = 500

            'default order to 0 so that we'll know if it was changed by the user or not
            Me.myOrder = 0

            'default Alpha to 4
            Me.myAlpha = 4
        End Sub 'New

        ''' <summary>
        ''' Bessel is the zeroth order Bessel function which is used in the Kaiser window.
        ''' This is a polynomial approximation of the zeroth order modified Bessel function found in:
        ''' W.H. Press, B.P. Flannery, S.A. Teukolsky, and W.T. Vetterling.
        ''' Numerical Recipes in C: The Art of Scientific Computing.
        ''' Cambridge UP, 1988.
        ''' P. 237
        ''' </summary>
        ''' <param name="x">Input number which the Bessel will be performed on</param>
        Private Function Bessel(ByVal x As Single) As Single
            Dim ax, ans As Double
            Dim y As Double

            ax = System.Math.Abs(x)
            If ax < 3.75 Then
                y = x / 3.75
                y *= y
                ans = 1.0 + y * (3.5156229 + y * (3.0899424 + y * (1.2067492 + y * (0.2659732 + y * (0.0360768 + y * 0.0045813)))))
            Else
                y = 3.75 / ax
                ans = System.Math.Exp(ax) / System.Math.Sqrt(ax) * (0.39894228 + y * (0.01328592 + y * (0.00225319 + y * (-0.00157565 + y * (0.00916281 + y * (-0.02057706 + y * (0.02635537 + y * (-0.01647633 + y * 0.00392377))))))))
            End If

            Return CSng(ans)
        End Function 'Bessel

        ''' <summary>
        ''' Calculate the coefficients to be used by the filter function.
        ''' </summary>
        ''' <param name="filterType">Enum type which specifies the filter to be performed.</param>
        ''' <param name="alg">Enum type which specifies which algorithm to be used for the window
        ''' algorithm.</param>
        Public Function GenerateCoefficients(ByVal filterType As FilterType, ByVal alg As Algorithm) As Single()
            'Calculate order if it hasn't been set
            If Me.myOrder = 0 Then
                Me.myOrder = CInt(((Me.myAttenuation - 7.95F) / (Me.myBand * 14.36F / Me.myFS) + 1.0F) * 2.0F) - 1
            End If
            Dim window(Me.myOrder / 2 + 1) As Single
            Dim coEff(Me.myOrder + 1) As Single
            Dim ps As Single
            Dim pe As Single
            Const PI As Single = CSng(System.Math.PI)
            Dim o2 As Integer = Me.myOrder / 2

            Dim i As Integer

            'Switch based on algorithm
            Select Case alg
                Case Algorithm.Kaiser
                    'Kaiser Window function
                    For i = 1 To o2
                        window(i) = Bessel((Me.myAlpha * CSng(System.Math.Sqrt((1.0F - CSng(System.Math.Pow(CSng(i) / o2, 2))))))) / Bessel(Me.myAlpha)
                    Next i

                    'Stopband attenuation and transition band should be set by the user

                Case Algorithm.Hann
                    'Hann window function
                    For i = 1 To o2
                        window(i) = 0.5F + 0.5F * CSng(System.Math.Cos((PI / (o2 + 1) * i)))
                    Next i

                    'Set the min stopband attenuation
                    Me.StopBandAttenuation = 44.0F

                    'Set the transition band
                    Me.TransitionBand = 6.22F * Me.myFS / Me.myOrder

                Case Algorithm.Hamming
                    'Hamming window function
                    For i = 1 To o2
                        window(i) = 0.54F + 0.46F * CSng(System.Math.Cos((PI / o2 * i)))
                    Next i

                    'Set the min stopband attenuation
                    Me.StopBandAttenuation = 53.0F

                    'Set the transition band
                    Me.TransitionBand = 6.64F * Me.myFS / Me.myOrder

                Case Algorithm.Blackman
                    'Blackman window function
                    For i = 1 To o2
                        window(i) = 0.42F + 0.5F * CSng(Math.Cos((PI / o2 * i))) + 0.08F * CSng(Math.Cos((2.0F * (PI / o2) * i)))
                    Next i

                    'Set the min stopband attenuation
                    Me.StopBandAttenuation = 74.0F

                    'Set the transition band
                    Me.TransitionBand = 11.13F * Me.myFS / Me.myOrder

                Case Algorithm.Rectangular
                    'Rectangular window function
                    For i = 1 To o2
                        window(i) = 1.0F
                    Next i

                    'Set the min stopband attenuation
                    Me.StopBandAttenuation = 21.0F

                    'Set the transition band
                    Me.TransitionBand = 1.84F * Me.myFS / Me.myOrder

                Case Else
                    'Zero all values if nothing was set (error)
                    For i = 1 To o2
                        window(i) = 0.0F
                    Next i
            End Select

            'Switch based on filtertype
            Select Case filterType
                Case filterType.BandPass
                    pe = PI / 2 * (Me.FreqTo - Me.FreqFrom + Me.myBand) / Me.myFS
                    ps = PI / 2 * (Me.FreqFrom + Me.FreqTo) / Me.myFS

                Case filterType.LowPass
                    pe = PI * (Me.FreqTo + Me.myBand / 2) / Me.myFS
                    ps = 0.0F

                Case filterType.HighPass
                    pe = PI * (1.0F - (Me.FreqFrom - Me.myBand / 2) / Me.myFS)
                    ps = PI

                Case Else
                    pe = 0.0F
                    ps = 0.0F
            End Select

            'Set first coefficient value
            coEff(0) = pe / PI

            'Calculate coefficientsw
            For i = 1 To o2
                coEff(i) = window(i) * CSng(System.Math.Sin((i * pe))) * CSng(System.Math.Cos((i * ps))) / (i * PI)
            Next i

            'Shift Impulse
            For i = o2 + 1 To Me.myOrder
                coEff(i) = coEff((i - o2))
            Next i
            For i = 0 To o2 - 1
                coEff(i) = coEff((Me.myOrder - i))
            Next i
            coEff(o2) = pe / PI

            Return coEff
        End Function 'GenerateCoefficients
    End Class 'FFT '
End Namespace 'System.Windows.Forms.DataVisualization.Charting.Utilities