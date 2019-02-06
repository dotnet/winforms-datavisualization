//==============================================================================
//  File:		TabPageButton.cs
//
//  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain
//
//	Classes:	VerticalTabPageButton
//
//  Purpose:	Button class used inside the VerticalTabControl.
//
//==============================================================================
// Copyright © Microsoft Corporation, all rights reserved
//==============================================================================

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain
{
	/// <summary>
	/// This class represents a button that is used for a vertical tab page, which is 
	/// displayed in a vertical tab control.
	/// <seealso cref="VerticalTabControl"/>
	/// <seealso cref="VerticalTabPage"/>
	/// </summary>
	public class VerticalTabPageButton : Button
	{
		#region Fields

		/// <summary>
		/// Indicates that button is pressed
		/// </summary>
		private	bool	pressed = false;

		/// <summary>
		/// Indicates button orientation in the tab control
		/// </summary>
		private	bool	vertical = false;

		/// <summary>
		/// Indicates button represent selected tab in control.
		/// </summary>
		private	bool	selectedTab = false;

		/// <summary>
		/// Indicates that separator line should be drawn on the right side of the button.
		/// </summary>
		private	bool	separatorLine = true;

		/// <summary>
		/// Offset between image and text
		/// </summary>
		private int		offset = 4;

		/// <summary>
		/// Button border color
		/// </summary>
		internal Color	borderColor = Color.FromArgb(191,191,191);

		/// <summary>
		/// Unselected button back color
		/// </summary>
		internal Color	nonSelectedBackColor = Color.FromArgb(229,229,229);

		/// <summary>
		/// Gradient color used for the selected tab
		/// </summary>
		internal Color	selectedGradientBackColor = Color.FromArgb(254,218,162);

		/// <summary>
		/// Selected text color.
		/// </summary>
		internal Color	textColorSelected = Color.FromArgb(26,59,105);

		/// <summary>
		/// UnSelected text color.
		/// </summary>
		internal Color	textColorUnSelected = Color.FromArgb(117,117,117);

		/// <summary>
		/// Background image horizontal offset;
		/// </summary>
		public	int		BackImageOffsetX = 0;

		/// <summary>
		/// Background image vertical offset;
		/// </summary>
		public	int		BackImageOffsetY = 0;

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets the button orientation in the tab control.
		/// </summary>
		[
		Category("Misc"),
		DefaultValue(false),
		Description("Gets or sets the button orientation in the tab control."),
		]
		public bool Vertical
		{
			get
			{
				return vertical;
			}
			set
			{
				if(vertical != value)
				{
					vertical = value;
					this.Invalidate();
				}
			}
		}

		/// <summary>
		/// Gets or sets the button orientation in the tab control.
		/// </summary>
		[
		Category("Misc"),
		DefaultValue(false),
		Description("Gets or sets the button orientation in the tab control."),
		]
		public bool SelectedTab
		{
			get
			{
				return selectedTab;
			}
			set
			{
				if(selectedTab != value)
				{
					selectedTab = value;
					this.Invalidate();
				}
			}
		}

		/// <summary>
		/// Gets or sets the flag that determines if the separation line should be drawn on the 
		/// right side of the button.
		/// </summary>
		[
		Category("Misc"),
		DefaultValue(false),
		Description("Determines if the separation line should be drawn on the right side of the button."),
		]
		public bool SeparatorLine
		{
			get
			{
				return separatorLine;
			}
			set
			{
				if(separatorLine != value)
				{
					separatorLine = value;
					this.Invalidate();
				}
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VerticalTabPageButton()
		{
			// Set button style
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.DoubleBuffer, true);

			this.SetStyle(ControlStyles.ResizeRedraw, true);

			this.AllowDrop = true;
		}

		#endregion

		#region Overriden methods of the base class

		/// <summary>
		/// Called when the mouse pointer is over the control and a 
		/// mouse button is released.
		/// <seealso cref="MouseEventArgs"/>
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			pressed = false;
			this.Invalidate();
			this.Capture = false;
		}
		
		/// <summary>
		/// Called when the mouse pointer is over the control and a mouse button is 
		/// pressed.
		/// <seealso cref="MouseEventArgs"/>
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			pressed = true;
			this.Invalidate();
			this.Capture = true;
		}

		/// <summary>
		/// Called when the mouse pointer is moved over the control.
		/// <seealso cref="MouseEventArgs"/>
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			// If left mouse button is still pressed and we moved outside of the button - start button dragging
			if( (e.Button & MouseButtons.Left) == MouseButtons.Left &&
				!this.ClientRectangle.Contains(e.X, e.Y))
			{
				// Make sure the button is not in pressed mode
				if(this.pressed)
				{
					this.pressed = false;
					this.Invalidate();
				}

				this.Capture = false;

				// fire start dragging event
				OnStartDragging();
			}
		}

		/// <summary>
		/// Called when the control is painted.
		/// <seealso cref="PaintEventArgs"/>
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected override void OnPaint( PaintEventArgs e )
		{
			this.DrawButton(e.Graphics);
		}

		#endregion

		#region Button drawing methods

		/// <summary>
		/// Draws the vertical button back onto the specified graphics.
		/// <seealso cref="Graphics"/>
		/// </summary>
		/// <param name="graphics">Button graphics object.</param>
		private void DrawVerticalButtonBack(Graphics graphics)
		{
			// Draw button border
			ButtonState buttonState = (this.pressed) ? ButtonState.Pushed : ButtonState.Normal;
			ControlPaint.DrawButton(graphics, this.ClientRectangle, buttonState);
		}

		/// <summary>
		/// Draw horizontal button back on  the graphics specified.
		/// </summary>
		/// <param name="graphics">Button graphics object.</param>
		private void DrawHorizontalButtonBack(Graphics graphics)
		{
			// Define button radius
			int radius = (int)Math.Round(this.ClientRectangle.Height / 3.0);

			// Draw background image
			VerticalTabControl tabControl = this.Parent as VerticalTabControl;
			if(tabControl != null && tabControl.BackgroundImage != null)
			{
				int height = tabControl.GetButtonHeight() + 1;

				// Draw image in the background of the tab controls.
				// Image must be aligne to the bottom-right corner of the tabs area.
				Rectangle destRect = new Rectangle(
					tabControl.Right - tabControl.BackgroundImage.Width + tabControl.BackImageOffsetX - this.Left,
					0,
					tabControl.BackgroundImage.Width,
					height);
				ImageAttributes imageAttributes = new ImageAttributes();
				graphics.DrawImage(
					tabControl.BackgroundImage, 
					destRect, 
					0, 
					tabControl.BackImageOffsetY + this.Top, 
					tabControl.BackgroundImage.Width, 
					height,
					GraphicsUnit.Pixel,
					imageAttributes);
			}

			// Create button border path
			using( GraphicsPath buttonPath = new GraphicsPath() )
			{
				// Left vertical line
				buttonPath.AddLine(
					this.ClientRectangle.X, 
					this.ClientRectangle.Bottom,
					this.ClientRectangle.X, 
					this.ClientRectangle.Y + radius);

				// Top left arc
				buttonPath.AddArc(
					this.ClientRectangle.X, 
					this.ClientRectangle.Y,
					2 * radius, 
					2 * radius,
					180,
					90);

				// Top horizontal line
				buttonPath.AddLine(
					this.ClientRectangle.X + radius, 
					this.ClientRectangle.Y,
					this.ClientRectangle.Right - radius, 
					this.ClientRectangle.Y);

				// Top right arc
				buttonPath.AddArc(
					this.ClientRectangle.Right - 1 - 2 * radius, 
					this.ClientRectangle.Y,
					2 * radius, 
					2 * radius,
					270,
					90);

				// Right vertical line
				buttonPath.AddLine(
					this.ClientRectangle.Right - 1, 
					this.ClientRectangle.Y + radius,
					this.ClientRectangle.Right - 1, 
					this.ClientRectangle.Bottom);

				// Bottom horizontal line
				if(!this.SelectedTab)
				{
					buttonPath.AddLine(
						this.ClientRectangle.X, 
						this.ClientRectangle.Bottom - 1,
						this.ClientRectangle.Right, 
						this.ClientRectangle.Bottom - 1);
				}

				// Fill button background
				if(this.SelectedTab)
				{
					Rectangle brushRect = this.ClientRectangle;
					using( LinearGradientBrush backBrush = new LinearGradientBrush(brushRect, this.selectedGradientBackColor, this.BackColor, 90 ) )
					{
						Blend blend = new Blend(3);
						blend.Positions[0] = 0.0f;
						blend.Positions[1] = 0.8f;
						blend.Positions[2] = 1.0f;
						blend.Factors[0] = 0.0f;
						blend.Factors[1] = 1.0f;
						blend.Factors[2] = 1.0f;

						backBrush.Blend = blend;
						graphics.FillPath(backBrush, buttonPath);
					}
				}
				else
				{
					using( SolidBrush backBrush = new SolidBrush( (this.SelectedTab) ? this.BackColor : nonSelectedBackColor) )
					{
						graphics.FillPath(backBrush, buttonPath);
					}
				}

				// Draw button border using Anti-Aliasing
				using( Pen pen = new Pen(this.borderColor, 1) )
				{
					SmoothingMode oldMode = graphics.SmoothingMode;
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.DrawPath(pen, buttonPath);
					graphics.SmoothingMode = oldMode;
				}
			}
		}

		/// <summary>
		/// Draws the button on the specified graphics.
		/// <seealso cref="Graphics"/>
		/// </summary>
		/// <param name="graphics">Button graphics object.</param>
		protected virtual void DrawButton(Graphics graphics)
		{
			// Cleat the background with the Back color
			graphics.Clear(this.BackColor);

			// Draw background
			if(this.Vertical)
			{
				DrawVerticalButtonBack(graphics);
			}
			else
			{
				DrawHorizontalButtonBack(graphics);
			}

			// Draw image
			Rectangle	imageRect = Rectangle.Empty;
			if(this.Image != null)
			{
				// Calculate image rectangle position
				imageRect.X = this.ClientRectangle.X + this.offset;
				imageRect.Y = this.ClientRectangle.Y + (this.ClientRectangle.Height - this.Image.Height) / 2;
				imageRect.Width = this.Image.Width;
				imageRect.Height = this.Image.Height;

				// Shift image by 1 pixel when in pressed state
				if(this.pressed && this.Vertical)
				{
					++imageRect.X;
					++imageRect.Y;
				}

				// Replace transparent color (White) with button back color 
				ColorMap[] myColorMap = new ColorMap[1];
				myColorMap[0] = new ColorMap();
				myColorMap[0].OldColor = Color.White;
				myColorMap[0].NewColor = this.BackColor;

				// Create an ImageAttributes object
				ImageAttributes imageAttr = new ImageAttributes();
				imageAttr.SetRemapTable(myColorMap);

				// Draw image
				graphics.DrawImage(
					this.Image, 
					imageRect, 
					0,
					0,
					this.Image.Width, 
					this.Image.Height,
					GraphicsUnit.Pixel,
					imageAttr);

				imageAttr.Dispose();
			}

			// Draw button text
			if(this.Text.Length > 0)
			{
				Rectangle	textRect = new Rectangle(this.ClientRectangle.Location, this.ClientRectangle.Size);
				textRect.X += this.offset - 2;
				textRect.Width -= 2 * this.offset;
				if(this.Image != null)
				{
					textRect.X += this.offset + this.Image.Width;
					textRect.Width -= this.offset + this.Image.Width;
				}
				
				// Shift image by 1 pixel when in pressed state
				if(this.pressed && this.Vertical)
				{
					++textRect.X;
					++textRect.Y;
				}

				StringFormat format = new StringFormat();
				format.LineAlignment = StringAlignment.Center;
				format.Alignment = StringAlignment.Center;
				format.Trimming = StringTrimming.EllipsisCharacter;
				format.FormatFlags = StringFormatFlags.LineLimit;
				using( SolidBrush brush = new SolidBrush( (this.SelectedTab) ? textColorSelected : textColorUnSelected ) )
				{
					graphics.DrawString(this.Text, this.Font, brush, textRect, format);
				}

				format.Dispose();
			}

		}

		#endregion

		#region Events

		/// <summary>
		/// This event is called when a mouse button is dragged with the mouse.
		/// </summary>
		public event EventHandler StartDragging;

		/// <summary>
		/// Event is called when  a mouse button is dragged with the mouse.
		/// </summary>
		protected virtual void OnStartDragging()
		{
			if(StartDragging != null)
			{
				StartDragging(this, new EventArgs());
			}
		}

		#endregion
	}
}
