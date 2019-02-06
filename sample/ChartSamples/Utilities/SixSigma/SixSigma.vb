'=================================================================
'  File:		SixSigma.vb
'
'  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities
'
'	Classes:	SixSigma
'
'  Purpose:	To create SixSigma charts.
'
'===================================================================
' Chart Control for .NET Framework
' Copyright © Microsoft Corporation, all rights reserved
'===================================================================
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Drawing
Imports System.Windows.Forms.DataVisualization.Charting


Namespace System.Windows.Forms.DataVisualization.Charting.Utilities
    ''' <summary>
    ''' SixSigma is a utility that includes useful functions related to the Six Sigma strategy.
    ''' This utility mainly focuses on those parts of the strategy that involve charting, and producing
    ''' those charts.
    ''' </summary>
    Public Class SixSigma
        ''' <summary>
        ''' sBar holds a value if an schart has been created. sBar is used for a XBAR chart.
        ''' </summary>
        Private mysBar As Single = 0

        ''' <summary>
        ''' rBar holds a value if an rchart has been created. rBar is used for a XBAR chart.
        ''' </summary>
        Private myrBar As Single = 0

        ''' <summary>
        ''' Holds the n value passed into sChart or rChart for use by XBAR.
        ''' </summary>
        Private mynValue As Integer = 0

        Private myAutoFitLines As Boolean
        Private myShowLineLabels As Boolean
        Private myLineColor As Color
        Private myForeColor As Color
        Private myFont As Font

        ''' <summary>
        ''' Controls whether the AxisY will have an automatic Maximum set so that the chart will always
        ''' contain the UCL annotation. If left to false, it is up to the user to set a maximum AxisY value
        ''' such that all annotations appear on the graph.
        ''' </summary>
        Public Property AutoFitLines() As Boolean
            Get
                Return myAutoFitLines
            End Get
            Set(ByVal value As Boolean)
                myAutoFitLines = value
            End Set
        End Property

        ''' <summary>
        ''' Controls whether text is added to the lines to label what they are.
        ''' </summary>
        Public Property ShowLineLabels() As Boolean
            Get
                Return myShowLineLabels
            End Get
            Set(ByVal value As Boolean)
                myShowLineLabels = value
            End Set
        End Property

        ''' <summary>
        ''' Specifies the colour of the line annotations added to each chart.
        ''' </summary>
        Public Property LineColor() As Color
            Get
                Return myLineColor
            End Get
            Set(ByVal value As Color)
                myLineColor = value
            End Set
        End Property

        ''' <summary>
        ''' Specifies the colour of the text that will label the lines.
        ''' </summary>
        Public Property ForeColor() As Color
            Get
                Return myForeColor
            End Get
            Set(ByVal value As Color)
                myForeColor = value
            End Set
        End Property

        ''' <summary>
        ''' Specifies the font of the text that will label the lines.
        ''' </summary>
        Public Property Font() As Font
            Get
                Return myFont
            End Get
            Set(ByVal value As Font)
                myFont = value
            End Set
        End Property

        ''' <summary>
        ''' Default Constructor.
        ''' </summary>
        Public Sub New()
            myAutoFitLines = False
            myShowLineLabels = False
            myLineColor = Color.Red
            myForeColor = Color.Red
            myFont = New Font("Arial", 8)
        End Sub 'New

        ''' <summary>
        ''' Creates a C-Chart with lines indicating cBar, UCL and LCL. A C-Chart is a measure of the number of
        ''' non-conformities per unit, where unit is a fixed rate.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the nonconform array.</param>
        ''' <param name="nonconform">An array holding the non-conformity data associated with the subgroups. Must aline with the subgroups.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Public Function cChart(ByVal subgroup() As Single, ByVal nonconform() As Single, ByVal output As Chart) As Series
            'Assure the input all have the same number of items.
            If subgroup.Length <> nonconform.Length Then
                Throw New ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform")
            End If
            'c holds the total number of items (subgroups).
            Dim c As Integer = subgroup.Length

            'Declare and initialize cBar, LCL and UCL.
            Dim cbar As Single = 0
            Dim LCL As Single = 0
            Dim UCL As Single = 0

            'Calculate cbar.
            Dim i As Integer
            For i = 0 To c - 1
                cbar += CSng(nonconform(i))
            Next i
            cbar /= c

            'Calculate UCL and LCL.
            UCL = CSng(cbar + 3 * System.Math.Sqrt(cbar))
            LCL = CSng(cbar - 3 * System.Math.Sqrt(cbar))

            'If LCL is less than zero, then it should be zero.
            If LCL < 0 Then
                LCL = 0
            End If
            'Create the series for the cchart data.
            Dim cseries As New Series("cseries")
            'Graph subgroups vs. non-conformities.
            For i = 0 To c - 1
                cseries.Points.AddXY(subgroup(i), nonconform(i))
            Next i
            'Set the series type to a line.
            cseries.ChartType = SeriesChartType.Line

            'Add the series to the chart.
            output.Series.Add(cseries)

            'Add the lines to the graph as annotations.
            'cBar line.
            addLineAnnotation(output.ChartAreas(cseries.ChartArea).AxisX, output.ChartAreas(cseries.ChartArea).AxisY, cseries.Points(0).XValue, cbar, cseries.Points((c - 1)).XValue, 0, output)

            'UCL line.
            addLineAnnotation(output.ChartAreas(cseries.ChartArea).AxisX, output.ChartAreas(cseries.ChartArea).AxisY, cseries.Points(0).XValue, UCL, cseries.Points((c - 1)).XValue, 0, output)

            'LCL line.
            addLineAnnotation(output.ChartAreas(cseries.ChartArea).AxisX, output.ChartAreas(cseries.ChartArea).AxisY, cseries.Points(0).XValue, LCL, cseries.Points((c - 1)).XValue, 0, output)

            'Add Text Annotations (line labels) if the user desired.
            If myShowLineLabels Then
                addTextAnnotation("CBAR", output.ChartAreas(cseries.ChartArea).AxisX, output.ChartAreas(cseries.ChartArea).AxisY, cseries.Points(0).XValue, cbar, output)

                addTextAnnotation("UCL", output.ChartAreas(cseries.ChartArea).AxisX, output.ChartAreas(cseries.ChartArea).AxisY, cseries.Points(0).XValue, UCL, output)

                addTextAnnotation("LCL", output.ChartAreas(cseries.ChartArea).AxisX, output.ChartAreas(cseries.ChartArea).AxisY, cseries.Points(0).XValue, LCL, output)
            End If

            'Scale the chart if the user has requested it.
            FitChart(UCL, cseries.ChartArea, output)

            'Return the series.
            Return cseries
        End Function 'cChart


        ''' <summary>
        ''' Creates a P-Chart with lines indicating pBar, UCL and LCL. A P-Chart is the same as an NP-Chart except
        ''' with a variable number of items in each subgroup.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the nonconform array and the number tested.</param>
        ''' <param name="nonconform">An array holding the non-conformity data associated with the subgroups. Must aline with the subgroups and the number tested.</param>
        ''' <param name="numbertested">An array holding the number of items in each subgroup. Must aline with the subgroups and the nonconform array.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Public Function pChart(ByVal subgroup() As Single, ByVal nonconform() As Single, ByVal numbertested() As Single, ByVal output As Chart) As Series
            'Assure the input all have the same number of items.
            If subgroup.Length <> nonconform.Length Or subgroup.Length <> numbertested.Length Or nonconform.Length <> numbertested.Length Then
                Throw New ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform, numbertested")
            End If
            'c holds the total number of items (subgroups).
            Dim c As Integer = subgroup.Length

            'Declare and initialize phat, UCL, LCL and pBar.
            Dim phat(c) As Single
            Dim UCL(c) As Single
            Dim LCL(c) As Single
            Dim pbar As Single = 0

            'Calculate phat(i).
            Dim i As Integer
            For i = 0 To c - 1
                phat(i) = nonconform(i) / numbertested(i)
            Next i
            'Calculate pbar.
            For i = 0 To c - 1
                pbar += phat(i)
            Next i
            pbar /= c

            'Calculate UCL and LCL.
            For i = 0 To c - 1
                UCL(i) = CSng(pbar + 3 * System.Math.Sqrt((pbar * (1 - pbar) / numbertested(i))))
                LCL(i) = CSng(pbar - 3 * System.Math.Sqrt((pbar * (1 - pbar) / numbertested(i))))
            Next i

            'Create the series for the pchart data.
            Dim pseries As New Series("pseries")
            'Graph subgroup vs. proportion.
            For i = 0 To c - 1
                pseries.Points.AddXY(subgroup(i), phat(i))
            Next i
            'Set the series type to a line.
            pseries.ChartType = SeriesChartType.Line

            'Add the series to the chart.
            output.Series.Add(pseries)

            'Add the lines to the graph as annotations.
            'PBAR line.
            addLineAnnotation(output.ChartAreas(pseries.ChartArea).AxisX, output.ChartAreas(pseries.ChartArea).AxisY, pseries.Points(0).XValue, pbar, pseries.Points((c - 1)).XValue, 0, output)

            'Add the UCL and LCL line segments as individual line annotations.
            For i = 0 To (c - 1) - 1
                'UCL line.
                addLineAnnotation(output.ChartAreas(pseries.ChartArea).AxisX, output.ChartAreas(pseries.ChartArea).AxisY, subgroup(i), UCL(i), subgroup((i + 1)) - subgroup(i), UCL((i + 1)) - UCL(i), output)

                'LCL line.
                addLineAnnotation(output.ChartAreas(pseries.ChartArea).AxisX, output.ChartAreas(pseries.ChartArea).AxisY, subgroup(i), LCL(i), subgroup((i + 1)) - subgroup(i), LCL((i + 1)) - LCL(i), output)
            Next i

            'Add Text Annotations (line labels) if the user desired.
            If myShowLineLabels Then
                addTextAnnotation("PBAR", output.ChartAreas(pseries.ChartArea).AxisX, output.ChartAreas(pseries.ChartArea).AxisY, pseries.Points(0).XValue, pbar, output)

                addTextAnnotation("UCL", output.ChartAreas(pseries.ChartArea).AxisX, output.ChartAreas(pseries.ChartArea).AxisY, pseries.Points(0).XValue, UCL(0), output)

                addTextAnnotation("LCL", output.ChartAreas(pseries.ChartArea).AxisX, output.ChartAreas(pseries.ChartArea).AxisY, pseries.Points(0).XValue, LCL(0), output)
            End If

            'Find the maximum UCL value and store the index of it.
            Dim maxUCL As Integer = 0
            For i = 1 To c - 1
                If UCL(maxUCL) < UCL(i) Then
                    maxUCL = i
                End If
            Next i 'Scale the chart if the user has requested it.
            FitChart(UCL(maxUCL), pseries.ChartArea, output)

            'Return the series.
            Return pseries
        End Function 'pChart


        ''' <summary>
        ''' Creates an NP-Chart with lines indicating CL, UCL and LCL. An NP chart is the same as a P-chart except
        ''' that the number of items in each subgroup is the same.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the nonconform array.</param>
        ''' <param name="nonconform">An array holding the non-conformity data associated with the subgroups. Must aline with the subgroups.</param>
        ''' <param name="numbertested">An array holding the number of items in each subgroup. Must aline with the subgroups and the nonconform array.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Public Function npChart(ByVal subgroup() As Single, ByVal nonconform() As Single, ByVal numbertested As Integer, ByVal output As Chart) As Series
            'Assure the input all have the same number of items.
            If subgroup.Length <> nonconform.Length Then
                Throw New ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform, numbertested")
            End If
            'c holds the total number of items (subgroups).
            Dim c As Integer = subgroup.Length

            'Declare and initialize UCL, LCL and pBar.
            Dim UCL As Single = 0
            Dim LCL As Single = 0
            Dim pbar As Single = 0

            'Calculate pbar.
            Dim i As Integer
            For i = 0 To c - 1
                pbar += nonconform(i)
            Next i
            pbar /= c * numbertested

            'Calculate UCL and LCL.
            UCL = CSng(numbertested * pbar + 3 * System.Math.Sqrt((numbertested * pbar * (1 - pbar))))
            LCL = CSng(numbertested * pbar - 3 * System.Math.Sqrt((numbertested * pbar * (1 - pbar))))

            'If LCL is less than zero, then it should be zero.
            If LCL < 0 Then
                LCL = 0
            End If
            'Create the npseries
            Dim npseries As New Series("npseries")
            'Graph subgroup vs. non-conforming values.
            For i = 0 To c - 1
                npseries.Points.AddXY(subgroup(i), nonconform(i))
            Next i
            'Set the type to line series.
            npseries.ChartType = SeriesChartType.Line

            'Add the series to the chart.
            output.Series.Add(npseries)

            'Add the lines to the graph as annotations.
            'CL line.
            addLineAnnotation(output.ChartAreas(npseries.ChartArea).AxisX, output.ChartAreas(npseries.ChartArea).AxisY, npseries.Points(0).XValue, pbar * 100, npseries.Points((c - 1)).XValue, 0, output)

            'UCL line.
            addLineAnnotation(output.ChartAreas(npseries.ChartArea).AxisX, output.ChartAreas(npseries.ChartArea).AxisY, npseries.Points(0).XValue, UCL, npseries.Points((c - 1)).XValue, 0, output)

            'LCL line.
            addLineAnnotation(output.ChartAreas(npseries.ChartArea).AxisX, output.ChartAreas(npseries.ChartArea).AxisY, npseries.Points(0).XValue, LCL, npseries.Points((c - 1)).XValue, 0, output)

            'Add Text Annotations (line labels) if the user desired.
            If myShowLineLabels Then
                addTextAnnotation("PBAR", output.ChartAreas(npseries.ChartArea).AxisX, output.ChartAreas(npseries.ChartArea).AxisY, npseries.Points(0).XValue, pbar * 100, output)

                addTextAnnotation("UCL", output.ChartAreas(npseries.ChartArea).AxisX, output.ChartAreas(npseries.ChartArea).AxisY, npseries.Points(0).XValue, UCL, output)

                addTextAnnotation("LCL", output.ChartAreas(npseries.ChartArea).AxisX, output.ChartAreas(npseries.ChartArea).AxisY, npseries.Points(0).XValue, LCL, output)
            End If

            'Scale the chart if the user has requested it.
            FitChart(UCL, npseries.ChartArea, output)

            'Return the series.
            Return npseries
        End Function 'npChart


        ''' <summary>
        ''' Creates a U-Chart with UBar, UCL and LCL lines. A U-Chart is used when the desired chart
        ''' is that of the number of non-conformities per inspection unit, where the inspection unit is variable size.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the nonconform array.</param>
        ''' <param name="nonconform">An array holding the non-conformity data associated with the subgroups. Must aline with the subgroups.</param>
        ''' <param name="numbertested">The number of items in each subgroup.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Public Function uChart(ByVal subgroup() As Single, ByVal nonconform() As Single, ByVal numbertested() As Single, ByVal output As Chart) As Series
            'Assure the input all have the same number of items.
            If subgroup.Length <> nonconform.Length Or subgroup.Length <> numbertested.Length Or nonconform.Length <> numbertested.Length Then
                Throw New ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform, numbertested")
            End If
            'c holds the total number of items (subgroups).
            Dim c As Integer = subgroup.Length

            'Declare and initialize UCL, LCL and uBar.
            Dim UCL(c) As Single
            Dim LCL(c) As Single
            Dim ubar As Single = 0

            'Initialize temporary variables to hold temp sums for the ubar calculation
            Dim sumNumerator As Single = 0
            Dim sumDenominator As Single = 0

            'Calculate ubar.
            Dim i As Integer
            For i = 0 To c - 1
                sumNumerator += nonconform(i)
                sumDenominator += numbertested(i)
            Next i
            ubar = sumNumerator / sumDenominator

            'Calculate the Yvalues
            Dim yvalues(c) As Single
            For i = 0 To c - 1
                yvalues(i) = nonconform(i) / numbertested(i)
            Next i
            'Calculate UCL and LCL.
            For i = 0 To c - 1
                UCL(i) = CSng(ubar + 3 * System.Math.Sqrt((ubar / numbertested(i))))
                LCL(i) = CSng(ubar - 3 * System.Math.Sqrt((ubar / numbertested(i))))
            Next i

            'Create the series for the pchart data.
            Dim useries As New Series("useries")
            'Graph subgroup vs. proportion.
            For i = 0 To c - 1
                useries.Points.AddXY(subgroup(i), yvalues(i))
            Next i
            'Set the series type to a line.
            useries.ChartType = SeriesChartType.Line

            'Add the series to the chart.
            output.Series.Add(useries)

            'Add the lines to the graph as annotations.
            'UBAR line.
            addLineAnnotation(output.ChartAreas(useries.ChartArea).AxisX, output.ChartAreas(useries.ChartArea).AxisY, useries.Points(0).XValue, ubar, useries.Points((c - 1)).XValue, 0, output)

            'Add the UCL and LCL line segments as individual line annotations.
            For i = 0 To (c - 1) - 1
                'UCL line.
                addLineAnnotation(output.ChartAreas(useries.ChartArea).AxisX, output.ChartAreas(useries.ChartArea).AxisY, subgroup(i), UCL(i), subgroup((i + 1)) - subgroup(i), UCL((i + 1)) - UCL(i), output)

                'LCL line.
                addLineAnnotation(output.ChartAreas(useries.ChartArea).AxisX, output.ChartAreas(useries.ChartArea).AxisY, subgroup(i), LCL(i), subgroup((i + 1)) - subgroup(i), LCL((i + 1)) - LCL(i), output)
            Next i

            'Add Text Annotations (line labels) if the user desired.
            If myShowLineLabels Then
                addTextAnnotation("UBAR", output.ChartAreas(useries.ChartArea).AxisX, output.ChartAreas(useries.ChartArea).AxisY, useries.Points(0).XValue, ubar, output)

                addTextAnnotation("UCL", output.ChartAreas(useries.ChartArea).AxisX, output.ChartAreas(useries.ChartArea).AxisY, useries.Points(0).XValue, UCL(0), output)

                addTextAnnotation("LCL", output.ChartAreas(useries.ChartArea).AxisX, output.ChartAreas(useries.ChartArea).AxisY, useries.Points(0).XValue, LCL(0), output)
            End If

            'Find the maximum UCL value and store the index of it.
            Dim maxUCL As Integer = 0
            For i = 1 To c - 1
                If UCL(maxUCL) < UCL(i) Then
                    maxUCL = i
                End If
            Next i 'Scale the chart if the user has requested it.
            FitChart(UCL(maxUCL), useries.ChartArea, output)

            'Return the series.
            Return useries
        End Function 'uChart


        ''' <summary>
        ''' Creates a Run Chart of the data and adds an average line. A run chart is a plot of the data without
        ''' manipulation along with a line indicating where the average of the points is.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the data array.</param>
        ''' <param name="data">An array holding the data. Must aline with the subgroup array.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Public Function runChart(ByVal subgroup() As Single, ByVal data() As Single, ByVal output As Chart) As Series
            'Assure the input all have the same number of items.
            If subgroup.Length <> data.Length Then
                Throw New ArgumentException("Input arrays must all be the same length.", "subgroup, data")
            End If
            'c holds the total number of items (subgroups).
            Dim c As Integer = subgroup.Length

            'Declare and initialize a variable to hold the average.
            Dim average As Single = 0

            'Create the series for the runchart data.
            Dim runseries As New Series("runseries")
            'Graph subgroups vs. data.
            Dim i As Integer
            For i = 0 To c - 1
                runseries.Points.AddXY(subgroup(i), data(i))
            Next i
            'Set the series type to a line.
            runseries.ChartType = SeriesChartType.Line

            'Add the series to the chart.
            output.Series.Add(runseries)

            'Calculate the average.
            average = CSng(output.DataManipulator.Statistics.Mean("runseries"))

            'Add the lines to the graph as annotations.
            'average line.
            addLineAnnotation(output.ChartAreas(runseries.ChartArea).AxisX, output.ChartAreas(runseries.ChartArea).AxisY, runseries.Points(0).XValue, average, runseries.Points((c - 1)).XValue, 0, output)

            'Return the series.
            Return runseries
        End Function 'runChart


        ''' <summary>
        ''' Creates an S-Chart of prepared data that can be evaluated. If the data is deemed to be in statistical control
        ''' an XBAR chart can be created via XBARChart function.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the data array. There must be at least 20 subgroups.</param>
        ''' <param name="data">Array holding the Standard Deviation of each subgroup.</param>
        ''' <param name="n">Number of measurements per subgroup. Must be between 2 and 9.</param>
        ''' <param name="processStdDev">Variable returning the process standard deviation estimation.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Public Function sChart(ByVal subgroup() As Single, ByVal data() As Single, ByVal n As Integer, ByRef processStdDev As Single, ByVal output As Chart) As Series
            'Assure the input all have the same number of items.
            If subgroup.Length <> data.Length Then
                Throw New ArgumentException("Input arrays must all be the same length.", "subgroup, data")
            End If
            'Assure there are at least 20 subgroups
            If subgroup.Length < 20 Then
                Throw New ArgumentOutOfRangeException("There must be at least 20 subgroups.", "subgroup")
            End If
            'Assure n is between 2 and 9
            If n < 2 Or n > 9 Then
                Throw New ArgumentOutOfRangeException("n must be between 1 and 9.", "n")
            End If
            'c holds the total number of items (subgroups).
            Dim c As Integer = subgroup.Length

            'Declare and initialize a variable to hold sbar, UCL and LCL.
            Dim sbar As Single = 0
            Dim UCL As Single = 0
            Dim LCL As Single = 0

            'Declare the constants needed for calculations.
            Dim B3 As Single() = {0, 0, 0, 0, 0.03F, 0.118F, 0.185F, 0.239F}
            Dim B4 As Single() = {3.267F, 2.568F, 2.266F, 2.089F, 1.97F, 1.882F, 1.815F, 1.761F}
            Dim C4 As Single() = {0.7979F, 0.8862F, 0.9213F, 0.94F, 0.9515F, 0.9594F, 0.965F, 0.9693F}

            'Calculate sbar which is the center line of the standard deviation of each subgroup.
            Dim i As Integer
            For i = 0 To c - 1
                sbar += data(i)
            Next i
            sbar /= c

            'Calculate UCL and LCL.
            'It is n-2 as the number is between 2 and 9, but the array starts at 0.
            UCL = B4((n - 2)) * sbar
            LCL = B3((n - 2)) * sbar

            'If LCL is less than zero, then it should be zero.
            If LCL < 0 Then
                LCL = 0
            End If
            'Create the series for the sChart data.
            Dim sseries As New Series("sseries")
            'Graph subgroups vs. data.
            For i = 0 To c - 1
                sseries.Points.AddXY(subgroup(i), data(i))
            Next i
            'Set the series type to a line.
            sseries.ChartType = SeriesChartType.Line

            'Add the series to the chart.
            output.Series.Add(sseries)

            'Add the lines to the graph as annotations.
            'sbar line.
            addLineAnnotation(output.ChartAreas(sseries.ChartArea).AxisX, output.ChartAreas(sseries.ChartArea).AxisY, sseries.Points(0).XValue, sbar, sseries.Points((c - 1)).XValue, 0, output)

            'UCL line.
            addLineAnnotation(output.ChartAreas(sseries.ChartArea).AxisX, output.ChartAreas(sseries.ChartArea).AxisY, sseries.Points(0).XValue, UCL, sseries.Points((c - 1)).XValue, 0, output)

            'LCL line.
            addLineAnnotation(output.ChartAreas(sseries.ChartArea).AxisX, output.ChartAreas(sseries.ChartArea).AxisY, sseries.Points(0).XValue, LCL, sseries.Points((c - 1)).XValue, 0, output)

            'Add Text Annotations (line labels) if the user desired.
            If myShowLineLabels Then
                addTextAnnotation("SBAR", output.ChartAreas(sseries.ChartArea).AxisX, output.ChartAreas(sseries.ChartArea).AxisY, sseries.Points(0).XValue, sbar, output)

                addTextAnnotation("UCL", output.ChartAreas(sseries.ChartArea).AxisX, output.ChartAreas(sseries.ChartArea).AxisY, sseries.Points(0).XValue, UCL, output)

                addTextAnnotation("LCL", output.ChartAreas(sseries.ChartArea).AxisX, output.ChartAreas(sseries.ChartArea).AxisY, sseries.Points(0).XValue, LCL, output)
            End If

            'Scale the chart if the user has requested it.
            FitChart(UCL, sseries.ChartArea, output)

            'Calculate process standard deviation.
            processStdDev = CSng(sbar / C4((n - 2)) * System.Math.Sqrt((1 - System.Math.Pow(C4((n - 2)), 2))))

            'Set the sBar class variable and clear rBar.
            Me.mysBar = sbar
            Me.myrBar = 0

            'Store the n value for use by XBAR.
            Me.mynValue = n

            'Return the series.
            Return sseries
        End Function 'sChart


        ''' <summary>
        ''' Creates an R-Chart of prepared data that can be evaluated. If the data is deemed to be in statistical control
        ''' an XBAR chart can be created via XBARChart function.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the data array. There must be at least 20 subgroups.</param>
        ''' <param name="data">Array holding the Range (biggest value - smallest value) of each subgroup.</param>
        ''' <param name="n">Number of measurements per subgroup. Must be between 2 and 9.</param>
        ''' <param name="processStdDev">Variable returning the process standard deviation estimation.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Public Function rChart(ByVal subgroup() As Single, ByVal data() As Single, ByVal n As Integer, ByRef processStdDev As Single, ByVal output As Chart) As Series
            'Assure the input all have the same number of items.
            If subgroup.Length <> data.Length Then
                Throw New ArgumentException("Input arrays must all be the same length.", "subgroup, data")
            End If
            'Assure there are at least 20 subgroups
            If subgroup.Length < 20 Then
                Throw New ArgumentOutOfRangeException("There must be at least 20 subgroups.", "subgroup")
            End If
            'Assure n is between 2 and 9
            If n < 2 Or n > 9 Then
                Throw New ArgumentOutOfRangeException("n must be between 1 and 9.", "n")
            End If
            'c holds the total number of items (subgroups).
            Dim c As Integer = subgroup.Length

            'Declare and initialize a variable to hold sbar, UCL and LCL.
            Dim rbar As Single = 0
            Dim UCL As Single = 0
            Dim LCL As Single = 0

            'Declare the constants needed for calculations.
            Dim D3 As Single() = {0, 0, 0, 0, 0, 0.076F, 0.136F, 0.184F}
            Dim D4 As Single() = {3.267F, 2.574F, 2.282F, 2.114F, 2.004F, 1.924F, 1.864F, 1.816F}
            Dim D2 As Single() = {1.128F, 1.693F, 2.059F, 2.326F, 2.534F, 2.704F, 2.847F, 2.97F}

            'Calculate rbar which is the center line of the range of each subgroup.
            Dim i As Integer
            For i = 0 To c - 1
                rbar += data(i)
            Next i
            rbar /= c

            'Calculate UCL and LCL.
            'It is n-2 as the number is between 2 and 9, but the array starts at 0.
            UCL = D4((n - 2)) * rbar
            LCL = D3((n - 2)) * rbar

            'If LCL is less than zero, then it should be zero.
            If LCL < 0 Then
                LCL = 0
            End If
            'Create the series for the sChart data.
            Dim rseries As New Series("rseries")
            'Graph subgroups vs. data.
            For i = 0 To c - 1
                rseries.Points.AddXY(subgroup(i), data(i))
            Next i
            'Set the series type to a line.
            rseries.ChartType = SeriesChartType.Line

            'Add the series to the chart.
            output.Series.Add(rseries)

            'Add the lines to the graph as annotations.
            'sbar line.
            addLineAnnotation(output.ChartAreas(rseries.ChartArea).AxisX, output.ChartAreas(rseries.ChartArea).AxisY, rseries.Points(0).XValue, rbar, rseries.Points((c - 1)).XValue, 0, output)

            'UCL line.
            addLineAnnotation(output.ChartAreas(rseries.ChartArea).AxisX, output.ChartAreas(rseries.ChartArea).AxisY, rseries.Points(0).XValue, UCL, rseries.Points((c - 1)).XValue, 0, output)

            'LCL line.
            addLineAnnotation(output.ChartAreas(rseries.ChartArea).AxisX, output.ChartAreas(rseries.ChartArea).AxisY, rseries.Points(0).XValue, LCL, rseries.Points((c - 1)).XValue, 0, output)

            'Add Text Annotations (line labels) if the user desired.
            If myShowLineLabels Then
                addTextAnnotation("RBAR", output.ChartAreas(rseries.ChartArea).AxisX, output.ChartAreas(rseries.ChartArea).AxisY, rseries.Points(0).XValue, rbar, output)

                addTextAnnotation("UCL", output.ChartAreas(rseries.ChartArea).AxisX, output.ChartAreas(rseries.ChartArea).AxisY, rseries.Points(0).XValue, UCL, output)

                addTextAnnotation("LCL", output.ChartAreas(rseries.ChartArea).AxisX, output.ChartAreas(rseries.ChartArea).AxisY, rseries.Points(0).XValue, LCL, output)
            End If

            'Scale the chart if the user has requested it.
            FitChart(UCL, rseries.ChartArea, output)

            'Calculate process standard deviation.
            processStdDev = CSng(rbar / D2((n - 2)))

            'Set the rBar class variable and clear sBar.
            Me.myrBar = rbar
            Me.mysBar = 0

            'Store the n value for use by XBAR.
            Me.mynValue = n

            'Return the series.
            Return rseries
        End Function 'rChart


        ''' <summary>
        ''' Creates an XBAR chart of the prepared data. sChart or rChart must have already been called to create a XBAR chart.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the data array.</param>
        ''' <param name="data">Array holding the Mean of each subgroup. Must aline with the subgroup array.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Public Function XBARChart(ByVal subgroup() As Single, ByVal data() As Single, ByVal output As Chart) As Series
            'Call the private function with no MRBAR to graph a separate XBAR chart.
            Return XBARChartImplementation(subgroup, data, output, 0)
        End Function 'XBARChart


        ''' <summary>
        ''' Creates an Individuals Chart of the data and places the MRBar, XBAR, UCL and LCL upon it.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the data array.</param>
        ''' <param name="data">An array holding the data. Must aline with the subgroup array.</param>
        ''' <param name="processStdDev">Variable returning the process standard deviation estimation.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Public Function individualsChart(ByVal subgroup() As Single, ByVal data() As Single, ByRef processStdDev As Single, ByVal output As Chart) As Series
            'Assure the input all have the same number of items.
            If subgroup.Length <> data.Length Then
                Throw New ArgumentException("Input arrays must all be the same length.", "subgroup, data")
            End If
            'c holds the total number of items (subgroups).
            Dim c As Integer = subgroup.Length

            'Declare and initialize MRBAR.
            Dim mrbar As Single = 0

            'Calculate cbar.
            Dim i As Integer
            For i = 0 To (c - 1) - 1
                mrbar += CSng(System.Math.Abs((data((i + 1)) - data(i))))
            Next i
            mrbar /= c - 1

            'Calculate the process standard deviation.
            processStdDev = CSng(mrbar / 1.128)

            'Return the series
            Return XBARChartImplementation(subgroup, data, output, mrbar)
        End Function 'individualsChart


        ''' <summary>
        ''' Creates an XBAR chart of the prepared data. This function contains the implementation for the public function with one extra
        ''' parameter for MRBAR. If MRBAR is specified, then only one chart is created with all the values.
        ''' </summary>
        ''' <param name="subgroup">An array holding the subgroups. Must aline with the data array.</param>
        ''' <param name="data">Array holding the Mean of each subgroup. Must aline with the subgroup array.</param>
        ''' <param name="output">The chart which will have the created series added to it.</param>
        ''' <param name="mrbar">The value of MRBAR if it has been calculated by Individuals Chart.</param>
        ''' <returns>Series which has been created and added to the output chart.</returns>
        Private Function XBARChartImplementation(ByVal subgroup() As Single, ByVal data() As Single, ByVal output As Chart, ByVal mrbar As Single) As Series
            'Assure the input all have the same number of items.
            If subgroup.Length <> data.Length Then
                Throw New ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform, numbertested")
            End If
            'Assure that either rBar or sBar have a value, and n has a value. If MRBAR has been specified, do not check.
            If mrbar = 0 Then
                If Me.myrBar = 0 And Me.mysBar = 0 Or (Me.mynValue < 2 Or Me.mynValue > 9) Then
                    Throw New ArgumentException("sChart or rChart must be called before XBAR.")
                End If
            End If 'c holds the total number of items (subgroups).
            Dim c As Integer = subgroup.Length

            'Declare and initialize a variable to hold sbar, UCL and LCL.
            Dim xbar As Single = 0
            Dim UCL As Single = 0
            Dim LCL As Single = 0

            'Declare the constants needed for calculations.
            Dim A2 As Single() = {1.88F, 1.023F, 0.729F, 0.577F, 0.483F, 0.419F, 0.373F, 0.337F}
            Dim A3 As Single() = {2.659F, 1.954F, 1.628F, 1.427F, 1.287F, 1.182F, 1.099F, 1.032F}

            'Calculate xbar, which is the mean of all the subgroup means.
            Dim i As Integer
            For i = 0 To c - 1
                xbar += data(i)
            Next i
            xbar /= c

            'Calculate UCL and LCL.
            'Switch based on if we're calculating from a rChart or a sChart, or if a MRBAR was given.
            'It is n-2 as the number is between 2 and 9, but the array starts at 0
            If mrbar <> 0 Then
                UCL = CSng(xbar + 2.66 * mrbar)
                LCL = CSng(xbar - 2.66 * mrbar)
            Else
                If Me.mysBar <> 0 Then
                    UCL = xbar + A3((Me.mynValue - 2)) * Me.mysBar
                    LCL = xbar - A3((Me.mynValue - 2)) * Me.mysBar
                Else
                    If Me.myrBar <> 0 Then
                        UCL = xbar + A2((Me.mynValue - 2)) * Me.myrBar
                        LCL = xbar - A2((Me.mynValue - 2)) * Me.myrBar
                    End If
                End If
            End If 'If LCL is less than zero, then it should be zero.
            If LCL < 0 Then
                LCL = 0
            End If
            'Create the series for the xbar data.
            Dim xbarseries As New Series("xbarseries")
            'Graph subgroups vs. data.
            For i = 0 To c - 1
                xbarseries.Points.AddXY(subgroup(i), data(i))
            Next i
            'Set the series type to a line.
            xbarseries.ChartType = SeriesChartType.Line

            'Add the series to the chart.
            output.Series.Add(xbarseries)

            'Add the lines to the graph as annotations.
            'xbar line.
            addLineAnnotation(output.ChartAreas(xbarseries.ChartArea).AxisX, output.ChartAreas(xbarseries.ChartArea).AxisY, xbarseries.Points(0).XValue, xbar, xbarseries.Points((c - 1)).XValue, 0, output)

            'UCL line.
            addLineAnnotation(output.ChartAreas(xbarseries.ChartArea).AxisX, output.ChartAreas(xbarseries.ChartArea).AxisY, xbarseries.Points(0).XValue, UCL, xbarseries.Points((c - 1)).XValue, 0, output)

            'LCL line.
            addLineAnnotation(output.ChartAreas(xbarseries.ChartArea).AxisX, output.ChartAreas(xbarseries.ChartArea).AxisY, xbarseries.Points(0).XValue, LCL, xbarseries.Points((c - 1)).XValue, 0, output)

            'MBAR line if it has been specified
            If mrbar <> 0 Then
                addLineAnnotation(output.ChartAreas(xbarseries.ChartArea).AxisX, output.ChartAreas(xbarseries.ChartArea).AxisY, xbarseries.Points(0).XValue, mrbar, xbarseries.Points((c - 1)).XValue, 0, output)
            End If

            'Add Text Annotations (line labels) if the user desired.
            If myShowLineLabels Then
                addTextAnnotation("XBAR", output.ChartAreas(xbarseries.ChartArea).AxisX, output.ChartAreas(xbarseries.ChartArea).AxisY, xbarseries.Points(0).XValue, xbar, output)

                addTextAnnotation("UCL", output.ChartAreas(xbarseries.ChartArea).AxisX, output.ChartAreas(xbarseries.ChartArea).AxisY, xbarseries.Points(0).XValue, UCL, output)

                addTextAnnotation("LCL", output.ChartAreas(xbarseries.ChartArea).AxisX, output.ChartAreas(xbarseries.ChartArea).AxisY, xbarseries.Points(0).XValue, LCL, output)

                If mrbar <> 0 Then
                    addTextAnnotation("MRBAR", output.ChartAreas(xbarseries.ChartArea).AxisX, output.ChartAreas(xbarseries.ChartArea).AxisY, xbarseries.Points(0).XValue, mrbar, output)
                End If
            End If

            'Scale the chart if the user has requested it.
            FitChart(UCL, xbarseries.ChartArea, output)

            'Return the series.
            Return xbarseries
        End Function 'XBARChartImplementation

        ''' <summary>
        ''' Calculates the mean of an array of numbers.
        ''' </summary>
        ''' <param name="data">The input array of items of which the mean will be calculated.</param>
        ''' <returns>The mean of the data.</returns>
        Public Function MeanF(ByVal data() As Single) As Single
            'Create a temporary variable to hold the sum.
            Dim sum As Single = 0

            'Calculate the sum of the data items.
            Dim i As Integer
            For i = 0 To data.Length - 1
                sum += data(i)
            Next i
            'Divide them by the total number of items.
            sum /= data.Length

            'Return the mean.
            Return sum
        End Function 'Mean


        ''' <summary>
        ''' Calculates the range of an array of numbers.
        ''' </summary>
        ''' <param name="data">The input array of items of which the range will be calculated.</param>
        ''' <returns>The range of the data.</returns>
        Public Function Range(ByVal data() As Single) As Single
            'Create two variables: one to hold the index of the largest value and one to hold the index of the smallest value.
            Dim maxIndex As Integer = 0
            Dim minIndex As Integer = 0

            'Find the largest and smallest values in the array.
            Dim i As Integer
            For i = 1 To data.Length - 1
                If data(maxIndex) < data(i) Then
                    maxIndex = i
                End If
                If data(minIndex) > data(i) Then
                    minIndex = i
                End If
            Next i
            'Return the Range.
            Return data(maxIndex) - data(minIndex)
        End Function 'Range


        ''' <summary>
        ''' Calculates the standard deviation of an array of numbers.
        ''' </summary>
        ''' <param name="data">The input array of items of which the standard deviation will be calculated.</param>
        ''' <returns>The standard deviation of the data.</returns>
        Public Function StandardDeviation(ByVal data() As Single) As Single
            'Create two variables: one to hold the sum of the deviations, and one to hold the mean of the data.
            Dim sumdeviation As Single = 0
            Dim mean As Single = 0

            'Calculate the mean.
            mean = MeanF(data)

            'Calculate the sum of the squared deviations.
            Dim i As Integer
            For i = 0 To data.Length - 1
                sumdeviation += CSng(System.Math.Pow(data(i) - mean, 2))
            Next i
            'Return the standard deviation.
            Return CSng(System.Math.Sqrt((sumdeviation / (data.Length - 1))))
        End Function 'StandardDeviation

        ''' <summary>
        ''' Scales the chart so that the UCL line will always be within the chart.
        ''' </summary>
        ''' <param name="UCL">The maximum UCL value.</param>
        ''' <param name="ChartArea">The name of the chart area we are plotting to.</param>
        ''' <param name="output">The chart which contains the chart area.</param>
        Private Sub FitChart(ByVal UCL As Single, ByVal ChartArea As String, ByVal output As Chart)
            'Check to see if scaling is enabled.
            If myAutoFitLines Then
                'Force the chartarea to recalculate the axis values so that we can find the Y-axis maximum.
                output.ChartAreas(ChartArea).ReCalculateAxesScale()

                'Check if UCL is outside the maximum Y value.
                If UCL > CSng(output.ChartAreas(ChartArea).AxisY.Maximum) Then
                    'If so set the Y-axis maximum to be the UCL value.
                    output.ChartAreas(ChartArea).AxisY.Maximum = UCL
                End If
            End If
        End Sub 'FitChart

        ''' <summary>
        ''' Function to add a line annotation to the desired chart in the format which is followed by
        ''' all the line annotations in this add-on.
        ''' </summary>
        ''' <param name="AxisX">X-Axis that the line annotation is to use for co-ordinates.</param>
        ''' <param name="AxisY">Y-Axis that the line annotation is to use for co-ordinates.</param>
        ''' <param name="X">X value for the start of the line.</param>
        ''' <param name="Y">Y value for the start of the line.</param>
        ''' <param name="Width">Width of the line.</param>
        ''' <param name="Height">Height of the line.</param>
        ''' <param name="output">The chart that the line annotation is being added to.</param>
        Private Sub addLineAnnotation(ByVal AxisX As Axis, ByVal AxisY As Axis, ByVal X As Double, ByVal Y As Double, ByVal Width As Double, ByVal Height As Double, ByVal output As Chart)
            'Create a new line annotation.
            Dim lineAnnotation As New LineAnnotation()

            'Set each property to the parameters passed in.
            lineAnnotation.AxisX = AxisX
            lineAnnotation.AxisY = AxisY
            lineAnnotation.Y = Y
            lineAnnotation.X = X
            lineAnnotation.Height = Height
            lineAnnotation.Width = Width

            'Turn off relative size to get graph-oriented co-ordinates and set the line color.
            lineAnnotation.IsSizeAlwaysRelative = False
            lineAnnotation.LineColor = myLineColor

            'Add the annotation to the chart.
            output.Annotations.Add(lineAnnotation)
        End Sub 'addLineAnnotation

        ''' <summary>
        ''' Function to add text as an annotation to the chart.
        ''' </summary>
        ''' <param name="text">The text that we wish to display.</param>
        ''' <param name="AxisX">X-Axis that the text annotation is to use for co-ordinates.</param>
        ''' <param name="AxisY">Y-Axis that the text annotation is to use for co-ordinates.</param>
        ''' <param name="X">X value for the start of the text.</param>
        ''' <param name="Y">Y value for the start of the text.</param>
        ''' <param name="output">The chart that the line annotation is being added to.</param>
        Private Sub addTextAnnotation(ByVal [text] As String, ByVal AxisX As Axis, ByVal AxisY As Axis, ByVal X As Double, ByVal Y As Double, ByVal output As Chart)
            'Create a new line annotation.
            Dim textAnnotation As New TextAnnotation()

            'Set each property to the parameters passed in.
            textAnnotation.AxisX = AxisX
            textAnnotation.AxisY = AxisY
            textAnnotation.Y = Y
            textAnnotation.X = X
            textAnnotation.Text = [text]

            'Turn off relative size to get graph-oriented co-ordinates and set the aesthetic properties.
            textAnnotation.IsSizeAlwaysRelative = False
            textAnnotation.ForeColor = myForeColor
            textAnnotation.Font = myFont

            'Add the annotation to the chart.
            output.Annotations.Add(textAnnotation)
        End Sub 'addTextAnnotation
    End Class 'SixSigma '
End Namespace 'System.Windows.Forms.DataVisualization.Charting.Utilities