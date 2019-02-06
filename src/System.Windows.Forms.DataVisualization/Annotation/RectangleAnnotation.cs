// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Rectangle, Ellipse and 3DBorder annotation classes.
//


using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting.Borders3D;
using System.Windows.Forms.DataVisualization.Charting.Utilities;
using System.Windows.Forms.Design.DataVisualization.Charting;

namespace System.Windows.Forms.DataVisualization.Charting
{
    /// <summary>
    /// <b>RectangleAnnotation</b> is a class that represents a rectangle annotation.
    /// </summary>
    /// <remarks>
    /// A rectangle annotation can also display text inside the rectangle.
    /// </remarks>
    [
		SRDescription("DescriptionAttributeRectangleAnnotation_RectangleAnnotation"),
	]
    public class RectangleAnnotation : TextAnnotation
	{
		#region Fields

		// Indicates that annotion rectangle should be drawn
		internal	bool		isRectVisible = true;

		#endregion

		#region Construction and Initialization

		/// <summary>
		/// Default public constructor.
		/// </summary>
		public RectangleAnnotation() 
            : base()
		{
		}

		#endregion

		#region Properties

		#region Applicable Annotation Appearance Attributes (set as Browsable)

        /// <summary>
        /// Gets or sets the color of an annotation line.
        /// <seealso cref="LineWidth"/>
        /// <seealso cref="LineDashStyle"/>
        /// </summary>
        /// <value>
        /// A <see cref="Color"/> value used to draw an annotation line.
        /// </value>
		[
		SRCategory("CategoryAttributeAppearance"),
		Browsable(true),
		DefaultValue(typeof(Color), "Black"),
		SRDescription("DescriptionAttributeLineColor"),
        TypeConverter(typeof(ColorConverter)),
        Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
        ]
        override public Color LineColor
		{
			get
			{
				return base.LineColor;
			}
			set
			{
				base.LineColor = value;
			}
		}

        /// <summary>
        /// Gets or sets the width of an annotation line.
        /// <seealso cref="LineColor"/>
        /// <seealso cref="LineDashStyle"/>
        /// </summary>
        /// <value>
        /// An integer value defining the width of an annotation line in pixels.
        /// </value>
		[
		SRCategory("CategoryAttributeAppearance"),
		Browsable(true),
		DefaultValue(1),
		SRDescription("DescriptionAttributeLineWidth"),
		]
		override public int LineWidth
		{
			get
			{
				return base.LineWidth;
			}
			set
			{
				base.LineWidth = value;

			}
		}

        /// <summary>
        /// Gets or sets the style of an annotation line.
        /// <seealso cref="LineWidth"/>
        /// <seealso cref="LineColor"/>
        /// </summary>
        /// <value>
        /// A <see cref="ChartDashStyle"/> value used to draw an annotation line.
        /// </value>
		[
		SRCategory("CategoryAttributeAppearance"),
		Browsable(true),
		DefaultValue(ChartDashStyle.Solid),
        SRDescription("DescriptionAttributeLineDashStyle"),
		]
		override public ChartDashStyle LineDashStyle
		{
			get
			{
				return base.LineDashStyle;
			}
			set
			{
				base.LineDashStyle = value;
			}
		}

        /// <summary>
        /// Gets or sets the background color of an annotation.
        /// <seealso cref="BackSecondaryColor"/>
        /// <seealso cref="BackHatchStyle"/>
        /// <seealso cref="BackGradientStyle"/>
        /// </summary>
        /// <value>
        /// A <see cref="Color"/> value used for the background of an annotation.
        /// </value>
		[
		SRCategory("CategoryAttributeAppearance"),
		Browsable(true),
		DefaultValue(typeof(Color), ""),
        SRDescription("DescriptionAttributeBackColor"),
		NotifyParentPropertyAttribute(true),
        TypeConverter(typeof(ColorConverter)),
        Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
        ]
        override public Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
			}
		}

        /// <summary>
        /// Gets or sets the background hatch style of an annotation.
        /// <seealso cref="BackSecondaryColor"/>
        /// <seealso cref="BackColor"/>
        /// <seealso cref="BackGradientStyle"/>
        /// </summary>
        /// <value>
        /// A <see cref="ChartHatchStyle"/> value used for the background of an annotation.
        /// </value>
        /// <remarks>
        /// Two colors are used to draw the hatching, <see cref="BackColor"/> and <see cref="BackSecondaryColor"/>.
        /// </remarks>
		[
		SRCategory("CategoryAttributeAppearance"),
		Browsable(true),
		DefaultValue(ChartHatchStyle.None),
		NotifyParentPropertyAttribute(true),
        SRDescription("DescriptionAttributeBackHatchStyle"),
        Editor(typeof(HatchStyleEditor), typeof(UITypeEditor))
        ]
        override public ChartHatchStyle BackHatchStyle
		{
			get
			{
				return base.BackHatchStyle;
			}
			set
			{
				base.BackHatchStyle = value;
			}
		}

        /// <summary>
        /// Gets or sets the background gradient style of an annotation.
        /// <seealso cref="BackSecondaryColor"/>
        /// <seealso cref="BackColor"/>
        /// <seealso cref="BackHatchStyle"/>
        /// </summary>
        /// <value>
        /// A <see cref="GradientStyle"/> value used for the background of an annotation.
        /// </value>
        /// <remarks>
        /// Two colors are used to draw the gradient, <see cref="BackColor"/> and <see cref="BackSecondaryColor"/>.
        /// </remarks>
		[
		SRCategory("CategoryAttributeAppearance"),
		Browsable(true),
		DefaultValue(GradientStyle.None),
		NotifyParentPropertyAttribute(true),
        SRDescription("DescriptionAttributeBackGradientStyle"),
        Editor(typeof(GradientEditor), typeof(UITypeEditor))
        ]
        override public GradientStyle BackGradientStyle
		{
			get
			{
				return base.BackGradientStyle;
			}
			set
			{
				base.BackGradientStyle = value;
			}
		}

        /// <summary>
        /// Gets or sets the secondary background color of an annotation.
        /// <seealso cref="BackColor"/>
        /// <seealso cref="BackHatchStyle"/>
        /// <seealso cref="BackGradientStyle"/>
        /// </summary>
        /// <value>
        /// A <see cref="Color"/> value used for the secondary color of an annotation background with 
        /// hatching or gradient fill.
        /// </value>
        /// <remarks>
        /// This color is used with <see cref="BackColor"/> when <see cref="BackHatchStyle"/> or
        /// <see cref="BackGradientStyle"/> are used.
        /// </remarks>
		[
		SRCategory("CategoryAttributeAppearance"),
		Browsable(true),
		DefaultValue(typeof(Color), ""),
		NotifyParentPropertyAttribute(true),
        SRDescription("DescriptionAttributeBackSecondaryColor"),
        TypeConverter(typeof(ColorConverter)),
        Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
        ]
        override public Color BackSecondaryColor
		{
			get
			{
				return base.BackSecondaryColor;
			}
			set
			{
				base.BackSecondaryColor = value;
			}
		}

		#endregion

		#region Other

        /// <summary>
        /// Gets or sets an annotation's type name.
        /// </summary>
        /// <remarks>
        /// This property is used to get the name of each annotation type 
        /// (e.g. Line, Rectangle, Ellipse). 
        /// <para>
        /// This property is for internal use and is hidden at design and run time.
        /// </para>
        /// </remarks>
		[
		SRCategory("CategoryAttributeMisc"),
		Bindable(true),
		Browsable(false),
		EditorBrowsableAttribute(EditorBrowsableState.Never),
		DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden),
		SerializationVisibilityAttribute(SerializationVisibility.Hidden),
		SRDescription("DescriptionAttributeAnnotationType"),
		]
		public override string AnnotationType
		{
			get
			{
				return "Rectangle";
			}
		}

		/// <summary>
		/// Gets or sets an annotation's selection points style.
		/// </summary>
		/// <value>
		/// A <see cref="SelectionPointsStyle"/> value that represents the annotation 
		/// selection style.
		/// </value>
		/// <remarks>
        /// This property is for internal use and is hidden at design and run time.
		/// </remarks>
		[
		SRCategory("CategoryAttributeAppearance"),
		DefaultValue(SelectionPointsStyle.Rectangle),
		ParenthesizePropertyNameAttribute(true),
		Browsable(false),
		EditorBrowsableAttribute(EditorBrowsableState.Never),
		DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden),
		SerializationVisibilityAttribute(SerializationVisibility.Hidden),
		SRDescription("DescriptionAttributeSelectionPointsStyle"),
		]
		override internal SelectionPointsStyle SelectionPointsStyle
		{
			get
			{
				return SelectionPointsStyle.Rectangle;
			}
		}

		#endregion

		#endregion

		#region Methods

		/// <summary>
		/// Paints an annotation object on the specified graphics.
		/// </summary>
		/// <param name="graphics">
		/// A <see cref="ChartGraphics"/> object, used to paint an annotation object.
		/// </param>
		/// <param name="chart">
		/// Reference to the <see cref="Chart"/> control.
		/// </param>
		override internal void Paint(Chart chart, ChartGraphics graphics)
		{
			// Get annotation position in relative coordinates
			PointF firstPoint = PointF.Empty;
			PointF anchorPoint = PointF.Empty;
			SizeF size = SizeF.Empty;
			GetRelativePosition(out firstPoint, out size, out anchorPoint);
			PointF	secondPoint = new PointF(firstPoint.X + size.Width, firstPoint.Y + size.Height);

			// Create selection rectangle
			RectangleF selectionRect = new RectangleF(firstPoint, new SizeF(secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y));

			// Get text position
			RectangleF rectanglePosition = new RectangleF(selectionRect.Location, selectionRect.Size);
			if(rectanglePosition.Width < 0)
			{
				rectanglePosition.X = rectanglePosition.Right;
				rectanglePosition.Width = -rectanglePosition.Width;
			}
			if(rectanglePosition.Height < 0)
			{
				rectanglePosition.Y = rectanglePosition.Bottom;
				rectanglePosition.Height = -rectanglePosition.Height;
			}

			// Check if position is valid
			if( float.IsNaN(rectanglePosition.X) || 
				float.IsNaN(rectanglePosition.Y) || 
				float.IsNaN(rectanglePosition.Right) || 
				float.IsNaN(rectanglePosition.Bottom) )
			{
				return;
			}

			if(this.isRectVisible && 
				this.Common.ProcessModePaint)
			{
				// Draw rectangle
				graphics.FillRectangleRel(
					rectanglePosition,
					this.BackColor,
					this.BackHatchStyle,
					String.Empty,
					ChartImageWrapMode.Scaled,
					Color.Empty,
					ChartImageAlignmentStyle.Center,
					this.BackGradientStyle,
					this.BackSecondaryColor,
					this.LineColor,
					this.LineWidth,
					this.LineDashStyle,
					this.ShadowColor,
					this.ShadowOffset,
					PenAlignment.Center,
					this.isEllipse,
					1,
					false);
			}

			// Call base class to paint text, selection handles and process hot regions
			base.Paint(chart, graphics);
		}

		#endregion
	}

	/// <summary>
	/// <b>EllipseAnnotation</b> is a class that represents an ellipse annotation.
	/// </summary>
	/// <remarks>
	/// An ellipse annotation can also display text inside the ellipse.
	/// </remarks>
	[
		SRDescription("DescriptionAttributeEllipseAnnotation_EllipseAnnotation"),
	]
    public class EllipseAnnotation : RectangleAnnotation
	{
		#region Construction and Initialization

		/// <summary>
		/// Default public constructor.
		/// </summary>
		public EllipseAnnotation() 
            : base()
		{
			this.isEllipse = true;
		}

		#endregion

		#region Properties

        /// <summary>
        /// Gets or sets an annotation's type name.
        /// </summary>
        /// <remarks>
        /// This property is used to get the name of each annotation type 
        /// (e.g. Line, Rectangle, Ellipse). 
        /// <para>
        /// This property is for internal use and is hidden at design and run time.
        /// </para>
        /// </remarks>
		[
		SRCategory("CategoryAttributeMisc"),
		Bindable(true),
		Browsable(false),
		EditorBrowsableAttribute(EditorBrowsableState.Never),
		DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden),
		SerializationVisibilityAttribute(SerializationVisibility.Hidden),
		SRDescription("DescriptionAttributeAnnotationType"),
		]
		public override string AnnotationType
		{
			get
			{
				return "Ellipse";
			}
		}

		#endregion
	}


	/// <summary>
	/// <b>Border3DAnnotation</b> is a class that represents an annotation with a 3D border.
	/// </summary>
	/// <remarks>
	/// A Border3D annotation can also display inner text.
	/// </remarks>
	[
		SRDescription("DescriptionAttributeBorder3DAnnotation_Border3DAnnotation"),
	]
    public class Border3DAnnotation : RectangleAnnotation
	{
		#region Fields

		// 3D border properties
		private BorderSkin	_borderSkin;

		#endregion		

		#region Construction and Initialization

		/// <summary>
		/// Default public constructor.
		/// </summary>
		public Border3DAnnotation() 
            : base()
		{
			this.isRectVisible = false;
            this._borderSkin = new BorderSkin(this);
			this._borderSkin.PageColor = Color.Transparent;
			this._borderSkin.SkinStyle = BorderSkinStyle.Raised;

            // Change default appearance styles
			this.lineColor = Color.Empty;
		}

		#endregion

		#region Properties

        /// <summary>
        /// Gets or sets an annotation's type name.
        /// </summary>
        /// <remarks>
        /// This property is used to get the name of each annotation type 
        /// (e.g. Line, Rectangle, Ellipse). 
        /// <para>
        /// This property is for internal use and is hidden at design and run time.
        /// </para>
        /// </remarks>
		[
		SRCategory("CategoryAttributeMisc"),
		Bindable(true),
		Browsable(false),
		EditorBrowsableAttribute(EditorBrowsableState.Never),
		DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden),
		SerializationVisibilityAttribute(SerializationVisibility.Hidden),
		SRDescription("DescriptionAttributeAnnotationType"),
		]
		public override string AnnotationType
		{
			get
			{
				return "Border3D";
			}
		}

		/// <summary>
		/// Gets or sets the skin style of the 3D border.
		/// </summary>
		/// <value>
		/// A <see cref="BorderSkin"/> 
		/// </value>
		[
		SRCategory("CategoryAttributeAppearance"),
		Bindable(true),
		DefaultValue(null),
		SRDescription("DescriptionAttributeBorderSkin"),
		NotifyParentPropertyAttribute(true),
		TypeConverterAttribute(typeof(LegendConverter)),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Content)
		]
		public BorderSkin BorderSkin
		{
			get
			{
				return _borderSkin;
			}
			set
			{
				_borderSkin = value;
				this.Invalidate();
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Paints the annotation object on the specified graphics.
		/// </summary>
		/// <param name="graphics">
		/// A <see cref="ChartGraphics"/> 
		/// </param>
		/// <param name="chart">
		/// Reference to the <see cref="Chart"/> control that owns the annotation.
		/// </param>
        override internal void Paint(Chart chart, ChartGraphics graphics)
		{
			// Get annotation position in relative coordinates
			PointF firstPoint = PointF.Empty;
			PointF anchorPoint = PointF.Empty;
			SizeF size = SizeF.Empty;
			GetRelativePosition(out firstPoint, out size, out anchorPoint);
			PointF	secondPoint = new PointF(firstPoint.X + size.Width, firstPoint.Y + size.Height);

			// Create selection rectangle
			RectangleF selectionRect = new RectangleF(firstPoint, new SizeF(secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y));

			// Get text position
			RectangleF	rectanglePosition = new RectangleF(selectionRect.Location, selectionRect.Size);
			if(rectanglePosition.Width < 0)
			{
				rectanglePosition.X = rectanglePosition.Right;
				rectanglePosition.Width = -rectanglePosition.Width;
			}
			if(rectanglePosition.Height < 0)
			{
				rectanglePosition.Y = rectanglePosition.Bottom;
				rectanglePosition.Height = -rectanglePosition.Height;
			}

			// Check if position is valid
			if( float.IsNaN(rectanglePosition.X) || 
				float.IsNaN(rectanglePosition.Y) || 
				float.IsNaN(rectanglePosition.Right) || 
				float.IsNaN(rectanglePosition.Bottom) )
			{
				return;
			}

			if(this.Common.ProcessModePaint)
			{
				// Do not draw border if size is less that 10 pixels
				RectangleF absRectanglePosition = graphics.GetAbsoluteRectangle(rectanglePosition);
				if(absRectanglePosition.Width > 30f &&
					absRectanglePosition.Height > 30f)
				{
					// Draw rectangle
					graphics.Draw3DBorderRel(
						_borderSkin,
						rectanglePosition,
						this.BackColor,
						this.BackHatchStyle,
						String.Empty,
						ChartImageWrapMode.Scaled,
						Color.Empty,
						ChartImageAlignmentStyle.Center,
						this.BackGradientStyle,
						this.BackSecondaryColor,
						this.LineColor,
						this.LineWidth,
						this.LineDashStyle);
				}
			}

			// Call base class to paint text, selection handles and process hot regions
			base.Paint(chart, graphics);
		}

		/// <summary>
		/// Gets text spacing on four different sides in relative coordinates.
		/// </summary>
		/// <param name="annotationRelative">Indicates that spacing is in annotation relative coordinates.</param>
		/// <returns>Rectangle with text spacing values.</returns>
		internal override RectangleF GetTextSpacing(out bool annotationRelative)
		{
			annotationRelative = false;
			RectangleF rect = new RectangleF(3f, 3f, 3f, 3f);
			if(GetGraphics() != null)
			{
				rect = GetGraphics().GetRelativeRectangle(rect);
			}

			if(_borderSkin.SkinStyle != BorderSkinStyle.None &&
				this.GetGraphics() != null &&
				this.Chart != null &&
				this.Chart.chartPicture != null &&
				this.Common != null)
			{
				IBorderType	border3D = this.Common.BorderTypeRegistry.GetBorderType(_borderSkin.SkinStyle.ToString());
				if(border3D != null)
				{
					// Adjust are position to the border size
					RectangleF rectangle = new RectangleF(0f, 0f, 100f, 100f);
					border3D.AdjustAreasPosition(this.GetGraphics(), ref rectangle);
					rect = new RectangleF(
						rectangle.X + 1, 
						rectangle.Y + 1,
						100f - rectangle.Right + 2,
						100f - rectangle.Bottom + 2);
				}
			}

			return rect;
		}

		#endregion
	}
}
