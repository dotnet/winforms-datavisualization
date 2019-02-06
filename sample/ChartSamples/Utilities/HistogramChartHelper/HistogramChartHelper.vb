Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Collections

Namespace System.Windows.Forms.DataVisualization.Charting.Utilities
    ''' <summary>
    ''' Helper class that creates a histogram chart. Histogram is a data
    ''' distribution chart which shows how many values, from the data series,
    ''' are inside each segment interval.  
    ''' 
    ''' You can define how many intervals you want to have using the SegmentIntervalNumber
    ''' field or the exact length of the interval using the SegmentIntervalWidth
    ''' field. Actual segment interval number can be slightly different due
    ''' to the automatic interval rounding.
    ''' </summary>
    Public Class HistogramChartHelper
#Region "Fields"

        ''' <summary>
        ''' Number of class intervals the data range is devided in.
        ''' This property only has affect when "SegmentIntervalWidth" is 
        ''' set to double.NaN.
        ''' </summary>
        Public SegmentIntervalNumber As Integer = 20

        ''' <summary>
        ''' Histogram class interval width. Setting this value to "double.NaN"
        ''' will result in automatic width calculation based on the data range
        ''' and number of required interval specified in "SegmentIntervalNumber".
        ''' </summary>
        Public SegmentIntervalWidth As Double = Double.NaN

        ''' <summary>
        ''' Indicates that percent frequency should be shown on the right axis
        ''' </summary>
        Public ShowPercentOnSecondaryYAxis As Boolean = True

#End Region   ' Fields

#Region "Methods"

        ''' <summary>
        ''' Creates a histogram chart.
        ''' </summary>
        ''' <param name="chartControl">Chart control reference.</param>
        ''' <param name="dataSeriesName">Name of the series which stores the original data.</param>
        ''' <param name="histogramSeriesName">Name of the histogram series.</param>
        Public Sub CreateHistogram(ByVal chartControl As Chart, ByVal dataSeriesName As String, ByVal histogramSeriesName As String)
            ' Validate input
            If chartControl Is Nothing Then
                Throw (New ArgumentNullException("chartControl"))
            End If
            If chartControl.Series.GetIndex(dataSeriesName) < 0 Then
                Throw (New ArgumentException("Series with name'" & dataSeriesName & "' was not found.", "dataSeriesName"))
            End If

            ' Make data series invisible
            chartControl.Series(dataSeriesName).Enabled = False

            ' Check if histogram series exsists
            Dim histogramSeries As Series = Nothing
            If chartControl.Series.GetIndex(histogramSeriesName) < 0 Then
                ' Add new series
                histogramSeries = chartControl.Series.Add(histogramSeriesName)

                ' Set new series chart type and other attributes
                histogramSeries.ChartType = SeriesChartType.Column
                histogramSeries.BorderColor = Color.Black
                histogramSeries.BorderWidth = 1
                histogramSeries.BorderDashStyle = ChartDashStyle.Solid
            Else
                histogramSeries = chartControl.Series(histogramSeriesName)
                histogramSeries.Points.Clear()
            End If

            ' Get data series minimum and maximum values
            Dim minValue As Double = Double.MaxValue
            Dim maxValue As Double = Double.MinValue
            Dim pointCount As Integer = 0
            Dim dataPoint As DataPoint
            For Each dataPoint In chartControl.Series(dataSeriesName).Points
                ' Process only non-empty data points
                If (Not dataPoint.Empty) Then
                    If dataPoint.YValues(0) > maxValue Then
                        maxValue = dataPoint.YValues(0)
                    End If
                    If dataPoint.YValues(0) < minValue Then
                        minValue = dataPoint.YValues(0)
                    End If
                    pointCount += 1
                End If
            Next dataPoint

            ' Calculate interval width if it's not set
            If Double.IsNaN(Me.SegmentIntervalWidth) Then
                Me.SegmentIntervalWidth = (maxValue - minValue) / SegmentIntervalNumber
                Me.SegmentIntervalWidth = RoundInterval(Me.SegmentIntervalWidth)
            End If

            ' Round minimum and maximum values
            minValue = Math.Floor(minValue / Me.SegmentIntervalWidth) * Me.SegmentIntervalWidth
            maxValue = Math.Ceiling(maxValue / Me.SegmentIntervalWidth) * Me.SegmentIntervalWidth

            ' Create histogram series points
            Dim currentPosition As Double = minValue
            currentPosition = minValue
            Do While currentPosition <= maxValue
                ' Count all points from data series that are in current interval
                Dim count As Integer = 0
                Dim datPoint As DataPoint
                For Each datPoint In chartControl.Series(dataSeriesName).Points
                    If (Not datPoint.Empty) Then
                        Dim endPosition As Double = currentPosition + Me.SegmentIntervalWidth
                        If datPoint.YValues(0) >= currentPosition AndAlso datPoint.YValues(0) < endPosition Then
                            count += 1

                            ' Last segment includes point values on both segment boundaries
                        ElseIf endPosition >= maxValue Then
                            If datPoint.YValues(0) >= currentPosition AndAlso datPoint.YValues(0) <= endPosition Then
                                count += 1
                            End If
                        End If
                    End If
                Next datPoint


                ' Add data point into the histogram series
                histogramSeries.Points.AddXY(currentPosition + Me.SegmentIntervalWidth / 2.0, count)
                currentPosition += Me.SegmentIntervalWidth
            Loop

            ' Adjust series attributes
            histogramSeries("PointWidth") = "1"

            ' Adjust chart area
            Dim chartArea As ChartArea = chartControl.ChartAreas(histogramSeries.ChartArea)
            chartArea.AxisY.Title = "Frequency"
            chartArea.AxisX.Minimum = minValue
            chartArea.AxisX.Maximum = maxValue

            ' Set axis interval based on the histogram class interval
            ' and do not allow more than 10 labels on the axis.
            Dim axisInterval As Double = Me.SegmentIntervalWidth
            Do While (maxValue - minValue) / axisInterval > 10.0
                axisInterval *= 2.0
            Loop
            chartArea.AxisX.Interval = axisInterval

            ' Set chart area secondary Y axis
            chartArea.AxisY2.Enabled = AxisEnabled.Auto
            If Me.ShowPercentOnSecondaryYAxis Then
                chartArea.ReCalculateAxesScale()

                chartArea.AxisY2.Enabled = AxisEnabled.True
                chartArea.AxisY2.LabelStyle.Format = "P0"
                chartArea.AxisY2.MajorGrid.Enabled = False
                chartArea.AxisY2.Title = "Percent of Total"

                chartArea.AxisY2.Minimum = 0
                chartArea.AxisY2.Maximum = chartArea.AxisY.Maximum / (pointCount / 100.0)
                Dim minStep As Double = IIf((chartArea.AxisY2.Maximum > 20.0), 5.0, 1.0)
                chartArea.AxisY2.Interval = Math.Ceiling((chartArea.AxisY2.Maximum / 5.0 / minStep)) * minStep

            End If
        End Sub

        ''' <summary>
        ''' Helper method which rounds specified axsi interval.
        ''' </summary>
        ''' <param name="interval">Calculated axis interval.</param>
        ''' <returns>Rounded axis interval.</returns>
        Friend Function RoundInterval(ByVal interval As Double) As Double
            ' If the interval is zero return error
            If interval = 0.0 Then
                Throw (New ArgumentOutOfRangeException("interval", "Interval can not be zero."))
            End If

            ' If the real interval is > 1.0
            Dim step_Renamed As Double = -1
            Dim tempValue As Double = interval
            Do While tempValue > 1.0
                step_Renamed += 1
                tempValue = tempValue / 10.0
                If step_Renamed > 1000 Then
                    Throw (New InvalidOperationException("Auto interval error due to invalid point values or axis minimum/maximum."))
                End If
            Loop

            ' If the real interval is < 1.0
            tempValue = interval
            If tempValue < 1.0 Then
                step_Renamed = 0
            End If

            Do While tempValue < 1.0
                step_Renamed -= 1
                tempValue = tempValue * 10.0
                If step_Renamed < -1000 Then
                    Throw (New InvalidOperationException("Auto interval error due to invalid point values or axis minimum/maximum."))
                End If
            Loop

            Dim tempDiff As Double = interval / Math.Pow(10.0, step_Renamed)
            If tempDiff < 3.0 Then
                tempDiff = 2.0
            ElseIf tempDiff < 7.0 Then
                tempDiff = 5.0
            Else
                tempDiff = 10.0
            End If

            ' Make a correction of the real interval
            Return tempDiff * Math.Pow(10.0, step_Renamed)
        End Function

#End Region   ' Methods
    End Class
End Namespace