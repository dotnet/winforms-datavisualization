'=================================================================
'  File:		FIRFilters.vb
'
'  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities
'
'	Classes:	FIRFilters, FFT
'
'  Purpose:	Used to perform digital filters on charts
'
'===================================================================
' Chart Control for .NET Framework
' Copyright © Microsoft Corporation, all rights reserved
'===================================================================

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting


Namespace System.Windows.Forms.DataVisualization.Charting.Utilities
    ''' <summary>
    ''' Helper class which implements the filtering functions. Currently Low Pass, High Pass and
    ''' Band Pass are implemented.
    ''' </summary>
    Class FIRFilters
        ''' <summary>
        ''' The number of samples is the same as the number of points
        ''' </summary>
        Private mySamples As Integer

        ''' <summary>
        ''' Holds the coefficient from the window function
        ''' </summary>
        Private myCoeff() As Single

        ''' <summary>
        ''' Holds the series which has the input data
        ''' </summary>
        Private myInputSeries As Series

        ''' <summary>
        ''' Holds the series which we are outputting to
        ''' </summary>
        Private myFilterSeries As Series

        ''' <summary>
        ''' FFT algorithm object
        ''' </summary>
        Private myFFT As FFT

        ''' <summary>
        ''' Holds the current algorithm selected. Enumeration type is drawn from the FFT object.
        ''' </summary>
        Public CurrentAlgorithm As FFT.Algorithm

        Private myFreqFrom As Single
        Private myFreqTo As Single
        Private myAttenuation As Single
        Private myBand As Single
        Private myAlpha As Single
        Private myTaps As Integer
        Private myOrder As Integer

        ''' <summary>
        ''' The starting passband frequency, must be lower than ending frequency.
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
        ''' The ending passband frequency, must be higher than starting frequency.
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
        ''' Stopband attenuation
        ''' </summary>
        Public Property StopBandAttenuation() As Single
            Get
                Return myAttenuation
            End Get
            Set(ByVal value As Single)
                myAttenuation = value
                Me.myFFT.StopBandAttenuation = myAttenuation
            End Set
        End Property

        ''' <summary>
        ''' Transition band
        ''' </summary>
        Public Property TransitionBand() As Single
            Get
                Return myBand
            End Get
            Set(ByVal value As Single)
                myBand = value
                Me.myFFT.TransitionBand = myBand
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
                Me.myFFT.Alpha = myAlpha
            End Set
        End Property

        ''' <summary>
        ''' Number of taps to be used. Taps is the number of samples processed at any one time.
        ''' </summary>
        Public Property Taps() As Integer
            Get
                Return myTaps
            End Get
            Set(ByVal value As Integer)
                myTaps = value
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
                'Assure value is even
                If value Mod 2 = 0 Then
                    myOrder = value
                    Me.myFFT.Order = myOrder
                Else
                    Throw New ArgumentOutOfRangeException("Order", "Filter order must be an even number.")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Main constructor. Resets all settings within the FFT algorithm object.
        ''' </summary>
        Public Sub New()
            'Create a new FFT object
            Me.myFFT = New FFT()

            'Default algorithm to Kaiser
            Me.CurrentAlgorithm = FFT.Algorithm.Kaiser

            'Default taps to 35
            Me.myTaps = 35
        End Sub 'New

        ''' <summary>
        ''' Performs a low pass filter. Output series will be cleared before being
        ''' output to. If passband start and end frequencies are left at 0, defaults are used.
        ''' </summary>
        ''' <param name="iseries">Input series that contains input data. Input Y-Values must be contained in YValues[0] or unexpected output will occur</param>
        ''' <param name="oseries">Output series to which filter will be written. Output Y-Values are written to YValues[0]</param>
        Public Sub LowPassFilter(ByVal iseries As Series, ByVal oseries As Series)
            'If no start and end frequencies are specified, default low pass frequency range to:
            '0 - 1000hz
            If Me.myFreqFrom = 0.0F And Me.myFreqTo = 0.0F Then
                Me.myFFT.FreqFrom = 0.0F
                Me.myFFT.FreqTo = 1000.0F
            Else
                Me.myFFT.FreqFrom = Me.myFreqFrom
                Me.myFFT.FreqTo = Me.myFreqTo
            End If

            'Generate the actual coefficients
            Me.myCoeff = Me.myFFT.GenerateCoefficients(FFT.FilterType.LowPass, CurrentAlgorithm)

            'Filter the series based on the coefficients generated
            Filter(iseries, oseries)
        End Sub 'LowPassFilter


        ''' <summary>
        ''' Performs a high pass filter. Output series will be cleared before being
        ''' output to. If passband start and end frequencies are left at 0, defaults are used.
        ''' </summary>
        ''' <param name="iseries">Input series that contains input data. Input Y-Values must be contained in YValues[0] or unexpected output will occur</param>
        ''' <param name="oseries">Output series to which filter will be written. Output Y-Values are written to YValues[0]</param>
        Public Sub HighPassFilter(ByVal iseries As Series, ByVal oseries As Series)
            'If no start and end frequencies are specified, default high pass frequency range to:
            '2000 - 4000hz
            If Me.myFreqFrom = 0.0F And Me.myFreqTo = 0.0F Then
                Me.myFFT.FreqFrom = 2000.0F
                Me.myFFT.FreqTo = 4000.0F
            Else
                Me.myFFT.FreqFrom = Me.myFreqFrom
                Me.myFFT.FreqTo = Me.myFreqTo
            End If

            'Generate the actual coefficients
            Me.myCoeff = Me.myFFT.GenerateCoefficients(FFT.FilterType.HighPass, CurrentAlgorithm)

            'Filter the series based on the coefficients generated
            Filter(iseries, oseries)
        End Sub 'HighPassFilter


        ''' <summary>
        ''' Performs a band pass filter. Output series will be cleared before being
        ''' output to. If passband start and end frequencies are left at 0, defaults are used.
        ''' </summary>
        ''' <param name="iseries">Input series that contains input data. Input Y-Values must be contained in YValues[0] or unexpected output will occur</param>
        ''' <param name="oseries">Output series to which filter will be written. Output Y-Values are written to YValues[0]</param>
        Public Sub BandPassFilter(ByVal iseries As Series, ByVal oseries As Series)
            'If no start and end frequencies are specified, default band pass frequency range to:
            '1000 - 1000hz
            If Me.myFreqFrom = 0.0F And Me.myFreqTo = 0.0F Then
                Me.myFFT.FreqFrom = 1000.0F
                Me.myFFT.FreqTo = 1000.0F
            Else
                Me.myFFT.FreqFrom = Me.myFreqFrom
                Me.myFFT.FreqTo = Me.myFreqTo
            End If

            'Generate the actual coefficients
            Me.myCoeff = Me.myFFT.GenerateCoefficients(FFT.FilterType.BandPass, CurrentAlgorithm)

            'Filter the series based on the coefficients generated
            Filter(iseries, oseries)
        End Sub 'BandPassFilter

        ''' <summary>
        ''' Initializes the FIRFilters object by setting the input and output series members for use
        ''' by the filter.
        ''' </summary>
        ''' <param name="iseries">Input series that contains input data</param>
        ''' <param name="oseries">Output series to which filter will be written</param>
        Private Sub SetIOSeries(ByVal iseries As Series, ByVal oseries As Series)
            Me.myInputSeries = iseries
            Me.myFilterSeries = oseries

            'Samples is the number of points contained in the input
            Me.mySamples = myInputSeries.Points.Count
        End Sub 'SetIOSeries

        ''' <summary>
        ''' Performs the actual filter. Coefficients should have already be generated by the calling
        ''' function, this function merely applies them and physically adds the points to the output series.
        ''' </summary>
        ''' <param name="iseries">Input series that contains input data</param>
        ''' <param name="oseries">Output series to which filter will be written</param>
        Private Sub Filter(ByVal iseries As Series, ByVal oseries As Series)
            Dim x(myTaps) As Single
            Dim y As Single

            'Set the series
            SetIOSeries(iseries, oseries)

            'Clear series
            myFilterSeries.Points.Clear()

            'Initialize x
            Dim i As Integer
            Dim j As Integer

            For i = 1 To myTaps - 1
                x(i) = 0.0F
            Next i
            'Loop through every data point
            For i = 0 To mySamples - 1
                'Initialize y
                y = 0.0F

                'Obtain the data value (Y value) at the specified X value (i)
                x(0) = Convert.ToSingle(myInputSeries.Points(i).YValues(0))

                'Loop through from 0 to number of taps and calculate the sum
                Try
                    For j = 0 To myTaps - 1
                        y = y + x(j) * myCoeff(j)
                    Next j
                Catch e As Exception
                    System.Diagnostics.Debug.WriteLine((e.Message + " Check filter order."))
                    Throw
                End Try

                'Shift all x values by 1 to the right
                For j = myTaps - 1 To -1 Step -1
                    x(j) = x((j - 1))
                Next j
                'Add the y value to the output series at the current x value
                myFilterSeries.Points.Add(New System.Windows.Forms.DataVisualization.Charting.DataPoint(i, y))
            Next i
        End Sub 'Filter
    End Class 'FIRFilters
End Namespace 'System.Windows.Forms.DataVisualization.Charting.Utilities