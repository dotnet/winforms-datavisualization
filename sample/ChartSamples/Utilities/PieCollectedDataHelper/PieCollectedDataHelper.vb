Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Collections

Namespace System.Windows.Forms.DataVisualization.Charting.Utilities
    ''' <summary>
    ''' Helper class which improves the readability of the small segments in the Pie chart.
    ''' Pie segments which are too small are shown in a supplemental pie chart series.
    ''' </summary>
    Public Class PieCollectedDataHelper
#Region "Fields"

        ''' <summary>
        ''' Specifies the percentage of the total series values. This value determines 
        ''' if the data point value is a "small" value and should be shown as collected.
        ''' </summary>
        Public CollectedPercentage As Double = 5.0

        ''' <summary>
        ''' Position in relative coordinates ( 0,0 - top left corner; 100,100 - bottom right corner)
        ''' where original and supplemental pie charts should be placed.
        ''' </summary>
        Public ChartAreaPosition As RectangleF = New RectangleF(5.0F, 5.0F, 90.0F, 90.0F)

        ''' <summary>
        ''' Indicates if small segments should be shown as one "collected" segment in the original series
        ''' </summary>
        Public ShowCollectedDataAsOneSlice As Boolean = False

        ''' <summary>
        ''' Spacing between the original and supplemental chart areas in percentage
        ''' </summary>
        Public ChartAreaSpacing As Single = 5.0F

        ''' <summary>
        ''' Size ratio between the original and supplemental chart areas.
        ''' Value of 1.0f indicates that same area size will be used.
        ''' </summary>
        Public SupplementedAreaSizeRatio As Single = 0.9F

        ''' <summary>
        ''' Color of the connection lines
        ''' </summary>
        Public ConnectionLinesColor As Color = Color.FromArgb(64, 64, 64)

        ''' <summary>
        ''' Collected pie segment label
        ''' </summary>
        Public CollectedLabel As String = "Other"


        ' Reference to the parameters
        Private chartControl As Chart = Nothing
        Private series As series = Nothing

        ' Internal use fields
        Private supplementalSeries As series = Nothing
        Private originalChartArea As ChartArea = Nothing
        Private supplementalChartArea As ChartArea = Nothing
        Private collectedPieSliceAngle As Single = 0.0F

#End Region   ' Fields

#Region "Constructor"

        ''' <summary>
        ''' Public constructor.
        ''' </summary>
        ''' <param name="chartControl">Reference to the chart control.</param>
        Public Sub New(ByVal chartControl As Chart)
            Me.chartControl = chartControl

            ' Handle chart PostPaint event to draw the "connection" between the 
            ' collected pie slice and supplemental chart.
            AddHandler chartControl.PostPaint, AddressOf chart_PostPaint
        End Sub

#End Region   ' Constructor

#Region "Methods"

        ''' <summary>
        ''' Shows small pie segments as supplemental pie chart series in the new chart area.
        ''' </summary>
        ''' <param name="seriesName">Series name </param>
        Public Sub ShowSmallSegmentsAsSupplementalPie(ByVal seriesName As String)
            ' Validate input
            If Me.chartControl Is Nothing Then
                Throw (New ArgumentNullException("chartControl"))
            End If
            If Me.CollectedPercentage > 100.0 OrElse Me.CollectedPercentage < 0.0 Then
                Throw (New ArgumentException("Value must be in range from 0 to 100 percent.", "CollectedPercentage"))
            End If

            ' Initialize reference to the series
            Me.series = Me.chartControl.Series(seriesName)

            ' Check input series type
            If Me.series.ChartType <> SeriesChartType.Pie AndAlso Me.series.ChartType <> SeriesChartType.Doughnut Then
                Throw (New InvalidOperationException("Only series with Pie or Doughnut chart type can be used."))
            End If

            ' Check if specified series has data points
            If series.Points.Count = 0 Then
                Throw (New InvalidOperationException("Cannot perform operatiuon on an empty series."))
            End If

            ' Create "collected" pie slice in original series
            Me.supplementalChartArea = Nothing
            If CreateCollectedPie() Then
                ' Calculate width of supplemental chart area
                Dim supplementalWidth As Single = (Me.ChartAreaPosition.Width - Me.ChartAreaSpacing) / 2.0F * Me.SupplementedAreaSizeRatio

                ' Adjust position of the original chart area
                Me.originalChartArea = Me.chartControl.ChartAreas(Me.series.ChartArea)
                originalChartArea.Position.X = Me.ChartAreaPosition.X
                originalChartArea.Position.Y = Me.ChartAreaPosition.Y
                originalChartArea.Position.Width = Me.ChartAreaPosition.Width - supplementalWidth - Me.ChartAreaSpacing
                originalChartArea.Position.Height = Me.ChartAreaPosition.Height

                ' Original chart area must be in 2D mode
                originalChartArea.Area3DStyle.Enable3D = False

                ' Create and adjust position of the supplemental chart area
                Me.supplementalChartArea = New ChartArea()
                supplementalChartArea.Name = originalChartArea.Name & "_Supplemental"
                supplementalChartArea.Position.X = originalChartArea.Position.Right() + Me.ChartAreaSpacing
                supplementalChartArea.Position.Y = Me.ChartAreaPosition.Y
                supplementalChartArea.Position.Width = supplementalWidth
                supplementalChartArea.Position.Height = Me.ChartAreaPosition.Height
                Me.chartControl.ChartAreas.Add(supplementalChartArea)

                ' Create supplemental pie chart series to show all the collected data
                Me.supplementalSeries.Name = Me.series.Name & "_Supplemental"
                Me.supplementalSeries.ChartArea = supplementalChartArea.Name
                Me.chartControl.Series.Add(supplementalSeries)

                ' Copy some attributes from the original chart area
                supplementalChartArea.BackColor = originalChartArea.BackColor
                supplementalChartArea.BorderColor = originalChartArea.BorderColor
                supplementalChartArea.BorderWidth = originalChartArea.BorderWidth
                supplementalChartArea.ShadowOffset = originalChartArea.ShadowOffset

                ' Copy some attributes from the original series
                Me.supplementalSeries.ChartType = Me.series.ChartType
                Me.supplementalSeries.Palette = Me.series.Palette
                Me.supplementalSeries.ShadowOffset = Me.series.ShadowOffset
                Me.supplementalSeries.BorderColor = Me.series.BorderColor
                Me.supplementalSeries.BorderWidth = Me.series.BorderWidth
                Me.supplementalSeries.IsValueShownAsLabel = Me.series.IsValueShownAsLabel
                Me.supplementalSeries.LabelBackColor = Me.series.LabelBackColor
                Me.supplementalSeries.LabelBorderColor = Me.series.LabelBorderColor
                Me.supplementalSeries.LabelBorderWidth = Me.series.LabelBorderWidth
                Me.supplementalSeries.LabelFormat = Me.series.LabelFormat
                Me.supplementalSeries.Font = Me.series.Font
            End If
        End Sub

        ''' <summary>
        ''' Creates the "collected" pie slice data point by re moving and accumulating all
        ''' the values of the data points which values are less then specified percentage.
        ''' </summary>
        ''' <returns>True if collected pie slice was created.</returns>
        Private Function CreateCollectedPie() As Boolean
            ' Create supplemental series
            Me.supplementalSeries = New Series()

            ' Calculate total vale of all point in series
            Dim total As Double = 0.0
            Dim dataPoint As DataPoint
            For Each dataPoint In Me.series.Points
                total += Math.Abs(dataPoint.YValues(0))
            Next dataPoint

            ' Count how many data points will be presented as collected
            Dim minValue As Double = total / 100.0 * Me.CollectedPercentage
            Dim collectedPointsCount As Integer = 0
            Dim index As Integer = 0
            Do While index < Me.series.Points.Count
                Dim pointValue As Double = Math.Abs(Me.series.Points(index).YValues(0))
                If pointValue <= minValue Then
                    collectedPointsCount += 1
                End If
                index += 1
            Loop

            ' Do not collect data points if one or less points left in the original series
            If (Me.series.Points.Count - collectedPointsCount) <= 1 OrElse collectedPointsCount <= 1 Then
                Return False
            End If

            ' Add Collected data point into series before applying palette colors
            Dim colectedDataPoint As DataPoint = Nothing
            If Me.ShowCollectedDataAsOneSlice Then
                colectedDataPoint = New DataPoint(Me.series)
                Me.series.Points.Add(colectedDataPoint)
            End If


            ' Apply pallete colors to series to save same data point colors
            ' in supplemental series.
            Me.chartControl.ApplyPaletteColors()
            Dim dataPoint2 As DataPoint
            For Each dataPoint2 In Me.series.Points
                ' Setting data point color to itself will clear the internal flag which
                ' indicates that point color should be taken from the palette again when
                ' control is rendered next time.
                dataPoint2.Color = dataPoint2.Color
            Next dataPoint2

            ' Remove points which value is less than specified percentage from total
            Dim collectedValue As Double = 0.0
            index = 0
            Do While index < Me.series.Points.Count
                Dim pointValue As Double = Math.Abs(Me.series.Points(index).YValues(0))
                If pointValue <= minValue AndAlso Not Me.series.Points(index) Is colectedDataPoint Then
                    ' Add point value to the collected value
                    collectedValue += pointValue

                    ' Add point to supplemental series
                    Me.supplementalSeries.Points.Add(Me.series.Points(index).Clone())

                    ' Remove point from the series
                    Me.series.Points.RemoveAt(index)
                    index -= 1
                End If
                index += 1
            Loop

            ' Add all collected data points at the end of the series
            If (Not ShowCollectedDataAsOneSlice) Then
                Dim dataPt As DataPoint
                For Each dataPt In Me.supplementalSeries.Points
                    Dim dataPointCollected As DataPoint = dataPt.Clone()
                    dataPt.IsVisibleInLegend = False
                    Me.series.Points.Add(dataPointCollected)

                    ' Disable labels in collected slices
                    dataPointCollected.Label = String.Empty
                    dataPointCollected.LegendText = dataPointCollected.AxisLabel
                    dataPointCollected.AxisLabel = String.Empty
                    dataPointCollected.IsValueShownAsLabel = False
                Next dataPt
            End If

            ' Check if we need to add the "collected" data point
            If collectedValue > 0.0 Then
                ' Set collected data point value and other attributes
                If Me.ShowCollectedDataAsOneSlice Then
                    colectedDataPoint.YValues(0) = collectedValue
                    colectedDataPoint.Label = Me.CollectedLabel
                    colectedDataPoint.IsVisibleInLegend = False

                    ' Note: Collected data point may be exploded
                    'colectedDataPoint["Exploded"] = "true";
                End If

                ' Calculate collected pie slice angle
                Me.collectedPieSliceAngle = CSng((360.0F / 100.0F) * (collectedValue / (total / 100)))

                ' Adjust the Pie chart start angle, so that the middle of the 
                ' collected slice looks directly at 3 o'clock.
                Dim startAngle As Integer = CInt(Math.Round(Me.collectedPieSliceAngle / 2.0))
                Me.series("PieStartAngle") = startAngle.ToString()

                Return True
            ElseIf Not colectedDataPoint Is Nothing Then
                ' Remove collected data point
                Me.series.Points.Remove(colectedDataPoint)
            End If

            Return False
        End Function

        ''' <summary>
        ''' Chart post paint event handler. 
        ''' Used to draw the "connection" lines between the original and supplemental pies.
        ''' </summary>
        ''' <param name="sender">Event sender.</param>
        ''' <param name="e">Event arguments.</param>
        Private Sub chart_PostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs)
            If TypeOf sender Is ChartArea Then
                Dim area As ChartArea = CType(sender, ChartArea)
                If Not Me.supplementalChartArea Is Nothing AndAlso area.Name = Me.supplementalChartArea.Name Then
                    ' Get position of the plotting areas in pixels
                    Dim originalPosition As RectangleF = GetChartAreaPlottingPosition(Me.originalChartArea, e.ChartGraphics)
                    Dim supplementalPosition As RectangleF = GetChartAreaPlottingPosition(Me.supplementalChartArea, e.ChartGraphics)

                    ' Get coordinates of the "connection" lines
                    Dim p1 As PointF = GetRotatedPlotAreaPoint(supplementalPosition, 325.0F)
                    Dim p2 As PointF = GetRotatedPlotAreaPoint(supplementalPosition, 215.0F)
                    Dim p3 As PointF = GetRotatedPlotAreaPoint(originalPosition, 90.0F - Me.collectedPieSliceAngle / 2.0F)
                    Dim p4 As PointF = GetRotatedPlotAreaPoint(originalPosition, 90.0F + Me.collectedPieSliceAngle / 2.0F)

                    ' Draw "connection lines"
                    'INSTANT VB NOTE: The following 'using' block is replaced by its pre-Visual Basic 2005 equivalent:
                    '					using(Pen pen = New Pen(Me.ConnectionLinesColor, 1))
                    Dim pen As Pen = New Pen(Me.ConnectionLinesColor, 1)
                    Try
                        e.ChartGraphics.Graphics.DrawLine(pen, p1, p3)
                        e.ChartGraphics.Graphics.DrawLine(pen, p2, p4)
                    Finally
                        If TypeOf pen Is IDisposable Then
                            Dim disp As IDisposable = pen
                            disp.Dispose()
                        End If
                    End Try
                End If
            End If
        End Sub

        ''' <summary>
        ''' Helper method which calculates a point on the edje of the pie chart using 
        ''' specified angle.
        ''' </summary>
        ''' <param name="areaPosition">Chart are position in pixels.</param>
        ''' <param name="angle">Point angle in degrees.</param>
        ''' <returns>Point location in pixels.</returns>
        Private Function GetRotatedPlotAreaPoint(ByVal areaPosition As RectangleF, ByVal angle As Single) As PointF
            Dim points As PointF() = New PointF(0) {}
            points(0) = New PointF(areaPosition.X + areaPosition.Width / 2.0F, areaPosition.Y)
            Dim transformMatrix As Matrix = New Matrix()
            Try
                transformMatrix.RotateAt(angle, New PointF(areaPosition.X + areaPosition.Width / 2.0F, areaPosition.Y + areaPosition.Height / 2.0F))

                transformMatrix.TransformPoints(points)
            Finally
                If TypeOf transformMatrix Is IDisposable Then
                    Dim disp As IDisposable = transformMatrix
                    disp.Dispose()
                End If
            End Try
            Return points(0)
        End Function

        ''' <summary>
        ''' Helper method which calculates chart area plotting position in pixels.
        ''' </summary>
        ''' <param name="area">Chart area to get the plotting area position.</param>
        ''' <param name="chartGraphics">Chart graphics object.</param>
        ''' <returns>Chart area ploting area position in pixels.</returns>
        Private Function GetChartAreaPlottingPosition(ByVal area As ChartArea, ByVal chartGraphics As ChartGraphics) As RectangleF
            Dim plottingRect As RectangleF = area.Position.ToRectangleF()
            plottingRect.X += (area.Position.Width / 100.0F) * area.InnerPlotPosition.X
            plottingRect.Y += (area.Position.Height / 100.0F) * area.InnerPlotPosition.Y
            plottingRect.Width = (area.Position.Width / 100.0F) * area.InnerPlotPosition.Width
            plottingRect.Height = (area.Position.Height / 100.0F) * area.InnerPlotPosition.Height
            plottingRect = chartGraphics.GetAbsoluteRectangle(plottingRect)
            Return plottingRect
        End Function

#End Region   ' Methods
    End Class
End Namespace