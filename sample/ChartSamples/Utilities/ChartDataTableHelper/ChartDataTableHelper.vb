Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.Windows.Forms.DataVisualization.Charting

Namespace System.Windows.Forms.DataVisualization.Charting.Utilities
    ''' <summary>
    ''' This class helps create a chart data table.
    ''' </summary>
    Public Class ChartDataTableHelper

#Region "Members"
        Protected ChartObj As System.Windows.Forms.DataVisualization.Charting.Chart = Nothing
        Protected ChartAreas As ArrayList = Nothing
        Protected AddTableTotals As Boolean = False
        Protected tableColor_Renamed As System.Drawing.Color = Color.White
        Protected borderColor_Renamed As System.Drawing.Color = Color.Black
        Protected enabled_Renamed As Boolean = True
        Protected Initialized As Boolean = False

#End Region

#Region "Properties"

        ''' <summary>
        ''' Enables or Disables the painting of the Data Table.
        ''' </summary>
        Public Property Enabled() As Boolean
            Get
                Return Enabled
            End Get
            Set(ByVal Value As Boolean)
                enabled_Renamed = Value
            End Set
        End Property

        ''' <summary>
        ''' Sets or gets the Chart object.
        ''' </summary>
        Public Property Chart() As System.Windows.Forms.DataVisualization.Charting.Chart
            Get
                Return ChartObj
            End Get
            Set(ByVal Value As System.Windows.Forms.DataVisualization.Charting.Chart)
                ChartObj = Value
            End Set
        End Property


        ''' <summary>
        ''' Sets or gets the Table Color that will be painted.
        ''' </summary>
        Public Property TableColor() As System.Drawing.Color
            Get
                Return tableColor_Renamed
            End Get
            Set(ByVal Value As System.Drawing.Color)
                tableColor_Renamed = Value
            End Set
        End Property

        ''' <summary>
        ''' Sets or gets the Table Border Color that will be painted.
        ''' </summary>
        Public Property BorderColor() As System.Drawing.Color
            Get
                Return borderColor_Renamed
            End Get
            Set(ByVal Value As System.Drawing.Color)
                borderColor_Renamed = Value
            End Set
        End Property

#End Region

#Region "Constructors"
        ''' <summary>
        ''' Construct a ChartDataTableHelper instance.
        ''' </summary>
        Public Sub New()
            ChartObj = Nothing
            ChartAreas = New ArrayList()
        End Sub

        ''' <summary>
        ''' Construct a ChartDataTableHelper instance and Initialize all ChartAreas with a table.
        ''' </summary>
        Public Sub New(ByVal chartObj_Renamed As System.Windows.Forms.DataVisualization.Charting.Chart)
            ChartAreas = New ArrayList()
            Initialize(chartObj_Renamed)
        End Sub


        ''' <summary>
        ''' Construct a ChartDataTableHelper instance and Initialize the specified ChartArea with a table.
        ''' </summary>
        Public Sub New(ByVal chartObj_Renamed As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal chartAreaName As String)
            ChartAreas = New ArrayList()
            Initialize(chartObj_Renamed, chartAreaName)

        End Sub

        ''' <summary>
        ''' Construct a ChartDataTableHelper instance, Initialize the specified ChartArea with a table and
        ''' set a boolean to show or hide total columns.
        ''' </summary>
        Public Sub New(ByVal chartObj_Renamed As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal chartAreaName As String, ByVal addTableTotals_Renamed As Boolean)
            ChartAreas = New ArrayList()
            Initialize(chartObj_Renamed, chartAreaName, addTableTotals_Renamed)

        End Sub

#End Region

#Region "Initialization Methods"
        ''' <summary>
        ''' Initialize all ChartAreas with a table.
        ''' </summary>
        Public Sub Initialize(ByVal chartObj_Renamed As System.Windows.Forms.DataVisualization.Charting.Chart)
            ChartObj = chartObj_Renamed

            Dim area As ChartArea
            For Each area In ChartObj.ChartAreas
                AddDataTable(area.Name)
            Next area

            If (Not Initialized) Then
                AddHandler ChartObj.PostPaint, AddressOf Chart_PostPaint
            End If

            Initialized = True
        End Sub



        ''' <summary>
        ''' Initialize all ChartAreas with a table and
        ''' set a boolean to show or hide total columns.
        ''' </summary>
        Public Sub Initialize(ByVal chartObj_Renamed As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal addTableTotals_Renamed As Boolean)
            AddTableTotals = addTableTotals_Renamed
            Initialize(chartObj_Renamed)
        End Sub

        ''' <summary>
        ''' Initialize the specified ChartArea with a table.
        ''' </summary>
        Public Sub Initialize(ByVal chartObj_Renamed As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal chartAreaName As String)
            ChartObj = chartObj_Renamed

            AddDataTable(chartAreaName)

            If (Not Initialized) Then
                AddHandler ChartObj.PostPaint, AddressOf Chart_PostPaint
            End If

            Initialized = True
        End Sub

        ''' <summary>
        ''' Initialize the specified ChartArea with a table and
        ''' set a boolean to show or hide total columns.
        ''' </summary>
        Public Sub Initialize(ByVal chartObj_Renamed As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal chartAreaName As String, ByVal addTableTotals_Renamed As Boolean)
            ChartObj = chartObj_Renamed
            AddTableTotals = addTableTotals_Renamed

            AddDataTable(chartAreaName)

            If (Not Initialized) Then
                AddHandler ChartObj.PostPaint, AddressOf Chart_PostPaint
            End If

            Initialized = True
        End Sub

        ''' <summary>
        ''' Initialize the specified ChartArea with a table.
        ''' </summary>
        Public Sub AddDataTable(ByVal chartAreaName As String)
            If ChartObj Is Nothing OrElse ChartAreas.IndexOf(chartAreaName) >= 0 Then
                Return
            End If

            ' add this chart area to the list of chart areas that need to 
            ' have a data table attached
            ChartAreas.Add(chartAreaName)

            Dim Row As Integer = 0


            If AddTableTotals Then
                ' create a dummy series that will not be shown but is used for 
                ' showing the totals in the data table
                ChartObj.Series.Add("DUMMY")
                ChartObj.Series("DUMMY").ChartArea = chartAreaName
                ChartObj.Series("DUMMY").Enabled = False
                ChartObj.Series("DUMMY").Color = Color.Gainsboro
            End If


            ' for each of the series that are attached to this 
            ' named chart area, create a custom axis label.
            ' All tables lines will be drawn on a paint event.
            ' ****************************************************
            ' NOTE: ALL SERIES MUST HAVE THE SAME NUMBER OF POINTS!
            ' ****************************************************

            Dim ser As Series
            For Each ser In ChartObj.Series
                If chartAreaName = ser.ChartArea Then
                    If AddTableTotals Then
                        ' shadows must be turned off otherwise
                        ' they will still show up for the transparent points
                        ser.ShadowOffset = 0

                        ' adjust the series values to ensure they are not
                        ' indexed and they are sorted... plus adding each point
                        ' to make the dummy series data 
                        AdjustXValues(ser)
                    End If


                    Row += 1
                    Dim From As Double = 0.0
                    Dim To_Renamed As Double = 0.0
                    Dim firstPoint As Boolean = True

                    Dim YValueTotal As Double = 0

                    Dim dp As DataPoint
                    For Each dp In ser.Points
                        If AddTableTotals Then
                            YValueTotal += dp.YValues(0)
                        End If

                        If firstPoint AndAlso dp.XValue = 0 Then
                            From = 0.5
                        ElseIf firstPoint Then
                            From = dp.XValue - 0.5
                        End If

                        If firstPoint Then
                            ChartObj.ChartAreas(chartAreaName).AxisX.Minimum = From
                            ChartObj.ChartAreas(chartAreaName).AxisX.MajorGrid.Interval = 1
                            ChartObj.ChartAreas(chartAreaName).AxisX.MajorTickMark.Interval = 1
                            ChartObj.ChartAreas(chartAreaName).AxisX.LabelStyle.Interval = 1
                            ChartObj.ChartAreas(chartAreaName).AxisX.MajorGrid.IntervalOffset = 0.5
                            ChartObj.ChartAreas(chartAreaName).AxisX.MajorTickMark.IntervalOffset = 0.5
                            ChartObj.ChartAreas(chartAreaName).AxisX.LabelStyle.IntervalOffset = 0.5

                            ChartObj.ChartAreas(chartAreaName).CursorX.IntervalOffset = 0.5
                        End If

                        To_Renamed = From + 1

                        ChartObj.ChartAreas(chartAreaName).AxisX.CustomLabels.Add(From, To_Renamed, " ", Row, LabelMarkStyle.None, GridTickTypes.None)

                        firstPoint = False
                        From += 1
                    Next dp

                    If AddTableTotals Then
                        ser.Points(ser.Points.Count - 1).YValues(0) = YValueTotal
                    End If

                    ChartObj.ChartAreas(chartAreaName).AxisX.Maximum = To_Renamed

                End If
            Next ser

            If AddTableTotals Then
                AdjustYMaximum(chartAreaName)
            End If

        End Sub

        ''' <summary>
        ''' With the addition of Totals, the chart will try to set the maximum
        ''' values according to these totals.  This will cause some series to be
        ''' barely visible.  Since the points are transparent this is a poor behavior.
        ''' This method will find and explicitly set the YAxis maximum to something
        ''' a little more with the user expectations.
        ''' </summary>
        Private Sub AdjustYMaximum(ByVal chartAreaName As String)
            Dim MaxYValue As Double = 0

            Dim ser As Series
            ' find the max YValue from all points in all series
            For Each ser In ChartObj.Series
                If chartAreaName = ser.ChartArea AndAlso ser.Enabled Then
                    ' check agains all points except the last point
                    ' which is the totals column
                    Dim index As Integer = 0
                    'ORIGINAL LINE: for(int index = 0; index < ser.Points.Count-1; index += 1)
                    'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                    Do While index < ser.Points.Count - 1
                        Dim pt As DataPoint = ser.Points(index)
                        If pt.YValues(0) > MaxYValue Then
                            MaxYValue = pt.YValues(0)
                        End If
                        index += 1
                    Loop
                End If
            Next ser

            Dim LogValue As Double = CInt(Math.Log10(MaxYValue)) + 1
            Dim NewMaxYValue As Double = Math.Pow(10, LogValue)
            Dim ratio As Double = MaxYValue / NewMaxYValue
            Dim divisor As Double = 1

            If ratio <= 0.1 Then
                divisor = 10
            ElseIf ratio < 0.2 Then
                divisor = 5
            ElseIf ratio < 0.25 Then
                divisor = 4
            ElseIf ratio < 0.4 Then
                divisor = 2.5
            ElseIf ratio < 0.5 Then
                divisor = 2
            ElseIf ratio < 0.8 Then
                divisor = 1.25
            End If

            ChartObj.ChartAreas(chartAreaName).AxisY.Maximum = NewMaxYValue / divisor
            ChartObj.ChartAreas(chartAreaName).AxisY.RoundAxisValues()

        End Sub


        ''' <summary>
        ''' A cleanup method that ensures the XValues are sorted accordingly and set explicitly.  
        ''' It will also create the totals for the DUMMY series.
        ''' </summary>
        Private Sub AdjustXValues(ByVal series As System.Windows.Forms.DataVisualization.Charting.Series)
            Dim AddDummyPoints As Boolean = True

            If series.Name = "DUMMY" Then
                Return
            ElseIf ChartObj.Series("DUMMY").Points.Count > 0 Then
                AddDummyPoints = False
            End If

            ' sort the series
            series.Sort(PointSortOrder.Ascending, "X")

            Dim IsIndexed As Boolean = False

            If series.IsXValueIndexed Then
                IsIndexed = True
            Else
                Dim IsFirstPoint As Boolean = True
                Dim IsLastPointZero As Boolean = False

                ' the series X values must be set and greater than zero
                Dim pt2 As DataPoint
                For Each pt2 In series.Points
                    If pt2.XValue = 0 AndAlso (Not IsFirstPoint) AndAlso IsLastPointZero Then
                        IsIndexed = True
                        Exit For
                    ElseIf pt2.XValue = 0 AndAlso IsFirstPoint Then
                        IsLastPointZero = True
                    End If

                    IsFirstPoint = False
                Next pt2
            End If

            If IsIndexed Then
                series.IsXValueIndexed = False
                Dim XValue As Integer = 0

                Dim pt3 As DataPoint
                For Each pt3 In series.Points
                    pt3.XValue = ++XValue
                Next pt3
            End If

            series.Points.AddXY(series.Points(series.Points.Count - 1).XValue + 1, 0)
            series.Points(series.Points.Count - 1).AxisLabel = "Total"
            series.Points(series.Points.Count - 1).Color = Color.Transparent
            series.Points(series.Points.Count - 1).BorderColor = Color.Transparent

            Dim index As Integer = 0
            Dim pt As DataPoint
            For Each pt In series.Points
                If AddDummyPoints Then
                    ChartObj.Series("DUMMY").Points.AddXY(pt.XValue, pt.YValues(0))
                Else
                    ChartObj.Series("DUMMY").Points(index).YValues(0) += pt.YValues(0)
                End If

                index += 1
            Next pt
        End Sub


#End Region

#Region "Remove Table "

        Public Sub RemoveDataTable(ByVal chartAreaName As String)
            If ChartObj.ChartAreas.GetIndex(chartAreaName) >= 0 Then
                ChartObj.ChartAreas(chartAreaName).AxisX.CustomLabels.Clear()
            End If

            If ChartAreas.IndexOf(chartAreaName) >= 0 Then
                ChartAreas.RemoveAt(ChartAreas.IndexOf(chartAreaName))
            End If
        End Sub

#End Region

#Region "Paint Event Handling"

        ''' <summary>
        ''' Chart Paint event handler.
        ''' </summary>
        Private Sub Chart_PostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs)
            If TypeOf sender Is ChartArea Then
                Dim area As ChartArea = CType(sender, ChartArea)
                ' call the paint method.
                If ChartAreas.IndexOf(area.Name) >= 0 AndAlso enabled_Renamed Then
                    PaintDataTable(sender, e)
                End If
            End If

        End Sub

        ''' <summary>
        ''' This method does all the work for the painting of the data table.
        ''' </summary>
        Private Sub PaintDataTable(ByVal sender As Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs)
            Dim area As ChartArea = CType(sender, ChartArea)

            ' get the rect of the chart area
            Dim rect As RectangleF = e.ChartGraphics.GetAbsoluteRectangle(area.Position.ToRectangleF())

            ' get the inner plot position
            Dim elemPos As ElementPosition = area.InnerPlotPosition

            ' find the coordinates of the inner plot position
            Dim x As Single = rect.X + (rect.Width / 100 * elemPos.X)
            Dim y As Single = rect.Y + (rect.Height / 100 * elemPos.Y)
            Dim ChartAreaBottomY As Single = rect.Y + rect.Height

            ' offset the bottom by the width+1 of the scrollbar if it is visible
            If area.AxisX.ScrollBar.IsVisible() AndAlso (Not area.AxisX.ScrollBar.IsPositionedInside) Then
                ChartAreaBottomY -= (CSng(area.AxisX.ScrollBar.Size) + 1)
            End If

            Dim width As Single = (rect.Width / 100 * elemPos.Width)
            Dim height As Single = (rect.Height / 100 * elemPos.Height)

            ' find the height of the font that will be used
            Dim axisFont As Font = area.AxisX.LabelStyle.Font
            Dim testString As String = "ForFontHeight"
            Dim axisFontSize As SizeF = e.ChartGraphics.Graphics.MeasureString(testString, axisFont)

            ' find the height of the font that will be used
            Dim titleFont As Font = area.AxisX.TitleFont
            testString = area.AxisX.Title
            Dim titleFontSize As SizeF = e.ChartGraphics.Graphics.MeasureString(testString, titleFont)

            Dim seriesCount As Integer = 0

            ' for each series that is attached to the chart area,
            ' draw some boxes around the labels in the color provided
            Dim i As Integer
            For i = e.Chart.Series.Count - 1 To 0 Step -1
                If area.Name = e.Chart.Series(i).ChartArea Then
                    seriesCount += 1
                End If
            Next i

            ' now, if a box was actually drawn, then draw 
            ' the verticle lines to separate the columns of the table.
            If seriesCount > 0 Then
                Dim int As Integer = 0
                Do While int < e.Chart.Series.Count
                    If area.Name = e.Chart.Series(int).ChartArea Then
                        Dim min As Double = area.AxisX.Minimum
                        Dim max As Double = area.AxisX.Maximum

                        ' modify the min value for the current axis view
                        If area.AxisX.ScaleView.Position - 1 > min Then
                            min = area.AxisX.ScaleView.Position - 1
                        End If

                        ' modify the max value for the currect axis view
                        If (area.AxisX.ScaleView.Position + area.AxisX.ScaleView.Size + 0.5) < max Then
                            max = area.AxisX.ScaleView.Position + area.AxisX.ScaleView.Size + 0.5
                        End If


                        ' find the starting point that will be display.
                        ' this is dependent on the current axis view.
                        ' this sample assumes the same number of points in each
                        ' series so always take from the zeroth series
                        Dim pointIndex As Integer = 0
                        Dim pt As DataPoint
                        For Each pt In ChartObj.Series(0).Points
                            If pt.XValue > min Then
                                Exit For
                            End If

                            pointIndex += 1
                        Next pt

                        Dim TableLegendDrawn As Boolean = False

                        Dim AxisValue As Double = min
                        Do While AxisValue < max
                            Dim pixelX As Single = CSng(e.ChartGraphics.GetPositionFromAxis("Default", AxisName.X, AxisValue))
                            Dim nextPixelX As Single = CSng(e.ChartGraphics.GetPositionFromAxis("Default", AxisName.X, AxisValue + 1))
                            Dim pixelY As Single = ChartAreaBottomY - titleFontSize.Height - (seriesCount * axisFontSize.Height)

                            Dim point1 As PointF = PointF.Empty
                            Dim point2 As PointF = PointF.Empty

                            ' Set Maximum and minimum points
                            point1.X = pixelX
                            point1.Y = 0

                            ' Convert relative coordinates to absolute coordinates.
                            point1 = e.ChartGraphics.GetAbsolutePoint(point1)
                            point2.X = point1.X
                            point2.Y = ChartAreaBottomY - titleFontSize.Height
                            point1.Y = pixelY

                            ' Draw connection line
                            e.ChartGraphics.Graphics.DrawLine(New Pen(borderColor_Renamed), point1, point2)


                            point2.X = nextPixelX
                            point2.Y = 0
                            point2 = e.ChartGraphics.GetAbsolutePoint(point2)

                            Dim format As StringFormat = New StringFormat()
                            format.Alignment = StringAlignment.Center
                            format.LineAlignment = StringAlignment.Center

                            ' for each series draw one value in the column
                            Dim row As Integer = 0
                            Dim ser As Series
                            For Each ser In ChartObj.Series
                                If area.Name = ser.ChartArea Then
                                    If (Not TableLegendDrawn) Then
                                        ' draw the series color box 
                                        e.ChartGraphics.Graphics.FillRectangle(New SolidBrush(ser.Color), x - 10, row * (axisFont.Height) + (point1.Y), 10, axisFontSize.Height)

                                        e.ChartGraphics.Graphics.DrawRectangle(New Pen(borderColor_Renamed), x - 10, row * (axisFont.Height) + (point1.Y), 10, axisFontSize.Height)

                                        e.ChartGraphics.Graphics.FillRectangle(New SolidBrush(tableColor_Renamed), x, row * (axisFont.Height) + (point1.Y), width, axisFontSize.Height)

                                        e.ChartGraphics.Graphics.DrawRectangle(New Pen(borderColor_Renamed), x, row * (axisFont.Height) + (point1.Y), width, axisFontSize.Height)

                                    End If

                                    If pointIndex < ser.Points.Count Then
                                        Dim label As String = ser.Points(pointIndex).YValues(0).ToString()
                                        Dim textRect As RectangleF = New RectangleF(point1.X, row * (axisFont.Height) + (point1.Y + 1), point2.X - point1.X, axisFont.Height)
                                        e.ChartGraphics.Graphics.DrawString(label, axisFont, New SolidBrush(area.AxisX.LabelStyle.ForeColor), textRect, format)
                                    End If

                                    row += 1

                                End If
                            Next ser

                            TableLegendDrawn = True

                            pointIndex += 1
                            AxisValue += 1
                        Loop

                        ' do this only once so break!
                        Exit Do
                    End If
                    i += 1
                Loop
            End If
        End Sub


#End Region


    End Class
End Namespace