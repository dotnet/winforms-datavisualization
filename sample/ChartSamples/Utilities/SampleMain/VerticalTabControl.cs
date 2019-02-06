//==============================================================================
//  File:		VerticalTabControl.cs
//
//  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain
//
//	Classes:	VerticalTabControl, VerticalTabPage, VerticalTabPageCollection
//
//  Purpose:	Custom tab control which supports vertical tap pages buttons 
//				mode. 
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
    using Point = System.Drawing.Point;
    using Size = System.Drawing.Size;

	/// <summary>
	/// This class represents a custom vertical tab control that is used by docking windows.
	/// <seealso cref="DockingWindow"/>
	/// <seealso cref="VerticalTabPage"/>
	/// <seealso cref="VerticalTabPageButton"/>
	/// </summary>
	/// <remarks>A <b>VerticalTabControl</b> object displays one or more tab pages via its 
	/// <see cref="VerticalTabPageCollection"/>.<para>This class is exposed as the 
	/// <see cref="DockingWindow.TabControl"/> property of the <see cref="DockingWindow"/> class.
	/// </para></remarks>
	public class VerticalTabControl : UserControl
	{
		#region Fields

		/// <summary>
		/// Control tab pages collection.
		/// </summary>
		private	VerticalTabPageCollection	tabPages = null;

		/// <summary>
		/// Selected tab page or null.
		/// </summary>
		private	VerticalTabPage				selectedTabPage = null;

		/// <summary>
		/// Indicates that tab control is vertical
		/// </summary>
		private bool						vertical = true;

		/// <summary>
		/// Tab buttons offset from the left and right side.
		/// </summary>
		private int							buttonOffset = 7;

		/// <summary>
		/// Tab button text spacing
		/// </summary>
		private Rectangle					buttonTextSpacing = new Rectangle(12, 4, 12, 4);

		/// <summary>
		/// List of images used to draw on the tab pages buttons.
		/// </summary>
		private	ImageList					imageList = null;

		/// <summary>
		/// Control used to draw a horizontal splitter line
		/// </summary>
		private	Label						tabSplitterLine = null;

		/// <summary>
		/// Color of the box border.
		/// </summary>
		private Color	borderColor = Color.Black;

		/// <summary>
		/// Box border size.
		/// </summary>
		private	int		borderSize = 1;

		/// <summary>
		/// Background image horizontal offset;
		/// </summary>
		public	int		BackImageOffsetX = 0;

		/// <summary>
		/// Background image vertical offset;
		/// </summary>
		public	int		BackImageOffsetY = 0;

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VerticalTabControl()
		{
			// Create tab pages collection
			this.tabPages = new VerticalTabPageCollection(this);

			// Initialize splitter line control
			tabSplitterLine = new Label();
			tabSplitterLine.Text = String.Empty;
			tabSplitterLine.Visible = false;
			tabSplitterLine.BorderStyle = BorderStyle.FixedSingle;
			this.Controls.Add(tabSplitterLine);

			this.SetStyle(ControlStyles.ResizeRedraw, true);
		}

		#endregion

		#region Properties

		/// <summary>
		/// Border color of the box.
		/// </summary>
		[
		Category("Appearance"),
		DefaultValue(typeof(Color), "Black"),
		Description("Border color of the box."),
		]
		public Color BorderColor
		{
			set
			{
				this.borderColor = value;
				this.Invalidate();
			}
			get
			{
				return this.borderColor;
			}
		}

		/// <summary>
		/// Border size of the box.
		/// </summary>
		[
		Category("Appearance"),
		DefaultValue(1),
		Description("Border size of the box."),
		]
		public int BorderSize
		{
			set
			{
				this.borderSize = value;
				this.Invalidate();
			}
			get
			{
				return this.borderSize;
			}
		}

		/// <summary>
		/// Gets the number of non-hidden tab pages in the control.
		/// </summary>
		/// <value>The number of non-hidden tab pages in the control.</value>
		[
		Category("Misc"),
		DefaultValue(0),
		Description("Gets the number of non-hidden tab pages in the control."),
		]
		public int VisibleTabPagesCount
		{
			get
			{
				int count = 0;
				foreach(VerticalTabPage tabPage in this.TabPages)
				{
					if(!tabPage.Hidden)
					{
						++count;
					}
				}
				return count;
			}
		}

		/// <summary>
		/// Gets the control's tab pages collection.
		/// <seealso cref="VerticalTabPageCollection"/>
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <value>The control's <see cref="VerticalTabPageCollection"/> object.</value>
		[
		Category("Misc"),
		DefaultValue(""),
		Description("Gets control tab pages collection."),
		]
		public VerticalTabPageCollection TabPages
		{
			get
			{
				return tabPages;
			}
		}

		/// <summary>
		/// Gets or sets the vertical style of the tab control.
		/// </summary>
		/// <value>If <b>true</b> the control is displayed vertically, if <b>false</b> it 
		/// is not.</value>
		[
		Category("Appearance"),
		DefaultValue(""),
		Description("Gets or sets the vertical style of the tab control."),
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
					OnVerticalChanged();
				}
			}
		}

		/// <summary>
		/// Gets or sets the control's image list, which is used for the vertical tab page 
		/// buttons.
		/// <seealso cref="ImageList"/>
		/// <seealso cref="VerticalTabPage.ImageIndex"/>
		/// </summary>
		/// <value>The control's <see cref="ImageList"/> object.</value>
		[
		Category("Appearance"),
		DefaultValue(""),
		Description("Gets or sets the control's image list."),
		]
		public ImageList ImageList
		{
			get
			{
				return imageList;
			}
			set
			{
				imageList = value;
			}
		}

		/// <summary>
		/// Gets or sets the index of the selected tab page.
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <value>The  index of the selected tab page.</value>
		[
		Category("Misc"),
		DefaultValue(""),
		Description("Gets or sets the index of the selected tab page."),
		]
		public int SelectedIndex
		{
			get
			{
				// Get index of selected tab page
				if(selectedTabPage != null)
				{
					return selectedTabPage.Index;
				}
				return -1;
			}
			set
			{
				// Select tab page using index
				if(value < this.TabPages.Count && value >= 0)
				{
					this.SelectedTab = this.TabPages[value];
				}
				else
				{
					this.SelectedTab = null;
				}
			}
		}

		/// <summary>
		/// Gets or sets the selected tab page.
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <value>The selected <see cref="VerticalTabPage"/> object of the control.</value>
		[
		Category("Misc"),
		DefaultValue(""),
		Description("Sets or gets selected tab page."),
		]
		public VerticalTabPage SelectedTab
		{
			get
			{
				return selectedTabPage;
			}
			set
			{
				if(value == null || this.Contains(value))
				{
					// Hidden tabs cannot be selected
					if(this.VisibleTabPagesCount == 0)
					{
						value = null;
					}
					else if(value != null && value.Hidden)
					{
						// Try to find non-hidden tab page next to current
						int index = value.Index + 1;
						while(value.Hidden && index < this.TabPages.Count)
						{
							value = this.TabPages[index++];
						}

						// Try to find non-hidden tab page prev. to current
						index = value.Index - 1;
						while(value.Hidden && index >= 0)
						{
							value = this.TabPages[index--];
						}

					}

					selectedTabPage = value;
					OnSelectedTabPageChanged();
				}
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Called when the control is resized.
		/// <seealso cref="EventArgs"/>
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected override void OnResize(EventArgs e)
		{
			// Call base class
			base.OnResize(e);

			// Resize horizontal splitter line 
			if(!this.Vertical)
			{
				//this.tabSplitterLine.Visible = (this.VisibleTabPagesCount > 1) ? true : false;
				this.tabSplitterLine.Location = new Point(0, this.ClientRectangle.Bottom - GetButtonHeight());
				this.tabSplitterLine.Size = new Size(this.Width, 1);
				tabSplitterLine.SendToBack();
			}

			// Reposition buttons in horizontal style
			if(!this.Vertical)
			{
				this.SuspendLayout();
				ResizeHorizontalTabPages();
				this.ResumeLayout();
			}
		}

		/// <summary>
		/// Called when the tab pages are changed. 
		/// </summary>
		internal void OnTabPagesChanged()
		{
			ReorderTabButtons();
		}

		/// <summary>
		/// Called when the vertical style of the tab control is changed.
		/// </summary>
		protected virtual void OnVerticalChanged()
		{
			// Hide/Show horizontal splitter line 
			//this.tabSplitterLine.Visible = !this.Vertical;

			// Reorder tabs
			ReorderTabButtons();
		}

		/// <summary>
		/// Called when the selected tab page is changed.
		/// </summary>
		protected virtual void OnSelectedTabPageChanged()
		{
			ReorderTabButtons();

			// Fire event
			if(this.SelectedIndexChanged != null)
			{
				this.SelectedIndexChanged(this, new EventArgs());
			}
		}

		/// <summary>
		/// Sets tab buttons order, visibility and docking style.
		/// </summary>
		private void ReorderTabButtons()
		{
			this.SuspendLayout();

			// Hide paneles of all tab pages except of selected one
			bool	beforeSelectedTab = true;
			int		childControlIndex = this.TabPages.Count - 1;
			int		tabIndex = 0;
			foreach(VerticalTabPage tabPage in this.TabPages)
			{
				// Set button orientation 
				tabPage.TabButton.Vertical = this.Vertical;

				// Set buttons docking and child order for vertical tabs
				if(this.Vertical)
				{
					// Hide button if there is only one
//					if(this.VisibleTabPagesCount == 1)
//					{
//						tabPage.TabButton.Visible = false;
//					}
//					else
					{
						tabPage.TabButton.Visible = (tabPage.Hidden) ? false : true;
					}


					// Set button height
					tabPage.TabButton.Height = GetButtonHeight();

					// Dock buttons to Top or Bottom
					tabPage.TabButton.Dock = (beforeSelectedTab) ? DockStyle.Top : DockStyle.Bottom;

					// Set button child index
					this.Controls.SetChildIndex(tabPage.TabButton, childControlIndex);
				}

                if(tabPage == this.SelectedTab)
				{
					// Rest of the buttons should be docked to the bottom
					beforeSelectedTab = false;
					childControlIndex = 0;

					// Set selected style of the button
					tabPage.TabButton.SelectedTab = true;

					// Make sure the previous button has no separator line
					if(tabIndex > 0)
					{
						this.TabPages[tabIndex - 1].TabButton.SeparatorLine = false;
					}
				}
				else
				{
					// Hide non selected tab panels
					tabPage.Visible = false;

					// Set non-selected style of the button
					tabPage.TabButton.SelectedTab = false;
					tabPage.TabButton.SeparatorLine = true;
				}

				// Get next child index 
				if(beforeSelectedTab)
				{
					--childControlIndex;
				}
				else
				{
					++childControlIndex;
				}

				// Show selected tab panel
				if(this.SelectedTab != null)
				{
					// Make sure panel is on the top of the Z order
					this.SelectedTab.BringToFront();

					// set fill docking style
					if(this.Vertical)
					{
						this.SelectedTab.Dock = DockStyle.Fill;
					}

					// Show selected tab panel
					this.SelectedTab.Visible = true;
				}

				++tabIndex;
			}

			// Make sure all buttons fit in horizontal mode
			if(!this.Vertical)
			{
				ResizeHorizontalTabPages();
			}

			this.ResumeLayout();
		}

		/// <summary>
		/// Returns the height of the tab page button.
		/// </summary>
		/// <returns>The tab button's height.</returns>
		/// <remarks>The height of button is the same for all vertical tab pages.
		/// </remarks>
		public int GetButtonHeight()
		{
			int	height = 0;
			if(this.TabPages.Count > 0)
			{
				// Get text size
				Graphics graphics = this.CreateGraphics();
				SizeF	textSize = graphics.MeasureString(this.TabPages[0].TabButton.Text, this.TabPages[0].TabButton.Font);
				height = (int)textSize.Height;
				graphics.Dispose();

				// Get image size
				if(this.TabPages[0].TabButton.Image != null)
				{
					height = Math.Max(height, this.TabPages[0].TabButton.Image.Height);
				}

				// Add extra spacing
				height += buttonTextSpacing.Y + buttonTextSpacing.Height;
			}
			return height;
		}

		/// <summary>
		/// Sets tab page button and panel position for non-vertical tab control.
		/// </summary>
		internal void ResizeHorizontalTabPages()
		{
			//************************************************************
			//** Reposition all tab page panel controls.
			//************************************************************
			Rectangle	panelPosition = this.ClientRectangle;
			panelPosition.Inflate(-1, -1);
			if(this.VisibleTabPagesCount >= 1)
			{
				int tabButtonsHeight = GetButtonHeight() + 1;
				panelPosition.Height -= tabButtonsHeight;
				panelPosition.Y += tabButtonsHeight;
			}
			foreach(VerticalTabPage tabPage in this.TabPages)
			{
				tabPage.Dock = DockStyle.None;
				tabPage.Location = panelPosition.Location;
				tabPage.Size = panelPosition.Size;
			}

			//************************************************************
			//** Calculate positions for all buttons.
			//************************************************************

			// Create an arry of rectangles
			Rectangle[]	buttonPos = new Rectangle[this.TabPages.Count];

			// Calculate position of each button
			int	tabIndex = 0;
			int	currentX = this.buttonOffset;
			foreach(VerticalTabPage tabPage in this.TabPages)
			{
				if(!tabPage.Hidden)
				{
					buttonPos[tabIndex] = new Rectangle(0, 0, 0, 0);

					// Hide all buttons if only one tap page in control
//					if(this.VisibleTabPagesCount == 1)
//					{
//						tabPage.TabButton.Visible = false;
//					}
//					else
					{
						tabPage.TabButton.Visible = (tabPage.Hidden) ? false : true;
					}

					// Get left button coordinate using previous page button
					buttonPos[tabIndex].X = currentX;

					// Set button Top and Height
					buttonPos[tabIndex].Y = (tabPage == this.SelectedTab) ? 1 : 1;
					buttonPos[tabIndex].Height = GetButtonHeight();

					// Set button width
					Graphics graphics = this.CreateGraphics();
					SizeF	textSize = graphics.MeasureString(tabPage.TabButton.Text, tabPage.TabButton.Font);
					buttonPos[tabIndex].Width = (int)textSize.Width + buttonTextSpacing.X + buttonTextSpacing.Width;
					graphics.Dispose();

					// Add image width
					if(tabPage.TabButton.Image != null)
					{
						buttonPos[tabIndex].Width += tabPage.TabButton.Image.Width + 3;
					}

					// Move current X coordinate
					currentX = buttonPos[tabIndex].Right - 1;
				}

				// Increase index
				++tabIndex;
			}

			//************************************************************
			//** Adjust buttons position if total width is too big.
			//************************************************************

			// Calculate max width for all buttons
			int maxX = this.ClientRectangle.Width - 2 * this.buttonOffset;

			// Check if buttons width adjustment is required
			bool	adjustmentRequired = false;
			foreach(Rectangle rect in buttonPos)
			{
				if(rect.Right > maxX)
				{
					adjustmentRequired = true;
					break;
				}
			}

			// Make the adjustment
			if(adjustmentRequired)
			{
				// Calculate new button width
				int newWidth = maxX / this.TabPages.Count - this.TabPages.Count;
				if(newWidth < 10)
				{
					newWidth = 10;
				}

				// Set new width
				currentX = this.buttonOffset;
				for(int rectIndex = 0; rectIndex < buttonPos.Length; rectIndex++)
				{
					buttonPos[rectIndex].X = currentX;
					buttonPos[rectIndex].Width = newWidth;
					currentX = buttonPos[rectIndex].Right + 1;
				}
			}

			//************************************************************
			//** Set buttons position.
			//************************************************************
			tabIndex = 0;
			foreach(VerticalTabPage tabPage in this.TabPages)
			{
				if(tabPage.TabButton.Dock != DockStyle.None)
				{
					tabPage.TabButton.Dock = DockStyle.None;
				}
				tabPage.TabButton.Location = buttonPos[tabIndex].Location;
				tabPage.TabButton.Size = buttonPos[tabIndex].Size;
				tabPage.SendToBack();

				// Increase index
				++tabIndex;
			}

		}

		#endregion

		#region Overriden painting methods

		protected override void OnPaintBackground( PaintEventArgs e )
		{
			int height = this.GetButtonHeight() + 1;
			if(this.BackgroundImage != null)
			{
				e.Graphics.Clear(this.BackColor);

				// Draw image in the background of the tab controls.
				// Image must be aligne to the bottom-right corner of the tabs area.
				Rectangle destRect = new Rectangle(
					this.Right - this.BackgroundImage.Width + this.BackImageOffsetX,
					0,
					this.BackgroundImage.Width,
					height);
				ImageAttributes imageAttributes = new ImageAttributes();
				e.Graphics.DrawImage(
					this.BackgroundImage, 
					destRect, 
					0, 
					this.BackImageOffsetY, 
					this.BackgroundImage.Width, 
					height,
					GraphicsUnit.Pixel,
					imageAttributes);
			}
			else
			{
				base.OnPaintBackground( e );
			}

			// Border rectangle
			height -= 1;
			Rectangle rectBorder = new Rectangle(0, height, this.Width - 1, this.Height - height - 1);

			// Draw simple border
			using(Pen pen = new Pen(BorderColor, BorderSize))
			{
				e.Graphics.DrawRectangle(pen, rectBorder);
			}
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			base.OnPaint(e);
		}

		#endregion

		#region Events

		/// <summary>
		/// Event that occurs when selected index is changed in the tab control.
		/// </summary>
		public event EventHandler SelectedIndexChanged;

		/// <summary>
		/// The tab page button's dragging started event.
		/// </summary>
		public event EventHandler TabPageButtonStartDragging;

		/// <summary>
		/// Tab page button dragging started event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		internal void OnTabPageButtonStartDragging(object sender, EventArgs e)
		{
			// Fire TabPageButtonStartDragging event
			if(this.TabPageButtonStartDragging != null)
			{
				this.TabPageButtonStartDragging(sender, e);
			}
		}

		#endregion
	}

	/// <summary>
	/// This class represents a vertical tab page.
	/// <seealso cref="VerticalTabControl"/>
	/// <seealso cref="VerticalTabPageButton"/>
	/// <seealso cref="VerticalTabPageCollection"/>
	/// <seealso cref="DockingWindow"/>
	/// </summary>
	/// <remarks>One or more vertical tab pages can be displayed by the vertical tab control of a 
	/// docking window.<para>A vertical tab page displays a tab page button that has an image and 
	/// some text.
	/// </para>
	/// <para>These pages are stored in the <see cref="VerticalTabPageCollection"/> object property 
	/// of a vertical tab control.</para>
	/// <para>You can use the inherited properties to set panel-specific properties 
	/// (e.g. text, etc.).</para></remarks>
	public class VerticalTabPage : Panel
	{
		#region Fields

		/// <summary>
		/// Tab control this page belongs to.
		/// </summary>
		internal VerticalTabControl		tabControl = null;

		/// <summary>
		/// Tab page button.
		/// </summary>
		internal	VerticalTabPageButton	tabButton = null;

		/// <summary>
		/// Indicates that tab page is hidden.
		/// </summary>
		private bool					hidden = false;

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VerticalTabPage()
		{
			Initialize("TabName");
		}

		/// <summary>
		/// Default constructor that takes the text to be displayed on the tab.
		/// <seealso cref="VerticalTabControl"/>
		/// </summary>
		/// <param name="text">Text to be displayed on the tab.</param>
		public VerticalTabPage(string text)
		{
			Initialize(text);
		}

		/// <summary>
		/// Initialize tab control page.
		/// </summary>
		/// <param name="text">Text to be displayed on the tab.</param>
		private void Initialize(string text)
		{
			// Set button text
			this.Text = text;

			// Initialize Panel properties
			this.Visible = false;
			this.Dock = DockStyle.Fill;
			this.DockPadding.Left = 5;
			this.DockPadding.Right = 2;
			this.DockPadding.Top = 5;
			this.DockPadding.Bottom = 2;

			// Change control style
			//this.SetStyle(ControlStyles.ResizeRedraw, true);
			
			// Create tab page button
			tabButton = new VerticalTabPageButton();
			tabButton.Text = text;
			tabButton.Dock = DockStyle.Top;
			tabButton.FlatStyle = FlatStyle.Standard;
			tabButton.ImageAlign = ContentAlignment.MiddleLeft;
			tabButton.TextAlign = ContentAlignment.MiddleLeft;

			// Hookup to the button events
			tabButton.DragOver += new DragEventHandler(OnButtonDragOver);
			tabButton.MouseDown += new MouseEventHandler(OnButtonMouseDown);
			tabButton.Click += new EventHandler(OnButtonMouseClick);
			tabButton.StartDragging += new EventHandler(OnButtonStartDragging);
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets the tab page's hidden flag.
		/// <seealso cref="VerticalTabControl"/>
		/// </summary>
		/// <value>If <b>true</b> the tab page is hidden, if <b>false</b> it is not.</value>
		[
		Category("Appearance"),
		DefaultValue(false),
		Description("Gets or sets the tab page's hidden flag."),
		]
		public bool Hidden
		{
			get
			{
				return hidden;
			}
			set
			{
				if(hidden != value)
				{
					hidden = value;
					OnHiddenChanged();
				}
			}
		}

		/// <summary>
		/// Gets or sets the index of the image to be drawn on the tab button.
		/// <seealso cref="VerticalTabControl"/>
		/// </summary>
		/// <value>Index of the tab button's image.</value>
		[
		Category("Misc."),
		DefaultValue(""),
		Description("Gets or sets the index of the image to be drawn on the tab button."),
		]
		public int ImageIndex
		{
			get
			{
				return this.TabButton.ImageIndex;
			}
			set
			{
				// Set image list of the button
				if(this.tabControl != null)
				{
					if(this.TabButton.ImageList != this.tabControl.ImageList)
					{
						this.TabButton.ImageList = this.tabControl.ImageList;
					}
				}

				// Set image index
				this.TabButton.ImageIndex = value;
			}
		}

		/// <summary>
		/// Gets the tab page's button control.
		/// <seealso cref="VerticalTabPageButton"/>
		/// <seealso cref="VerticalTabControl"/>
		/// </summary>
		/// <value>The tab page's <see cref="VerticalTabPageButton"/> object.</value>
		[
		Category("Misc."),
		DefaultValue(""),
		Description("Gets the tab page's button control."),
		]
		public VerticalTabPageButton TabButton
		{
			get
			{
				return tabButton;
			}
		}

		/// <summary>
		/// Gets the index of the page in the tab control's vertical tab page collection.
		/// <seealso cref="VerticalTabControl"/>
		/// <seealso cref="VerticalTabPageCollection"/>
		/// </summary>
		/// <value>The index of the tab page.</value>
		[
		Category("Misc."),
		DefaultValue(""),
		Description("Gets the index of the tab page in the collection."),
		]
		public int Index
		{
			get
			{
				if(this.tabControl != null)
				{
					// Find index of this tab page
					int	tabPageIndex = 0;
					foreach(VerticalTabPage tabPage in this.tabControl.TabPages)
					{
						if(tabPage == this)
						{
							return tabPageIndex;
						}
						++tabPageIndex;
					}
				}
				return -1;
			}
		}


		#endregion

		#region Methods

		private void OnButtonDragOver(object sender, DragEventArgs e)
		{
			if(this.tabControl != null && this != tabControl.SelectedTab)
			{
				// Change selected tab control
				tabControl.SelectedTab = this;
				this.Invalidate();
				this.Update();
			}
		}

		/// <summary>
		/// Mouse button was pressed inside tab page button.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments</param>
		private void OnButtonMouseDown(object sender, MouseEventArgs e)
		{
			if(this.tabControl != null && !this.tabControl.Vertical)
			{
				// Change selected tab control
				tabControl.SelectedTab = this;
			}
		}

		/// <summary>
		/// Mouse button was pressed inside tab page button.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments</param>
		private void OnButtonMouseClick(object sender, EventArgs e)
		{
			if(this.tabControl != null && this.tabControl.Vertical)
			{
				// Change selected tab control
				tabControl.SelectedTab = this;
			}
		}
		
		/// <summary>
		/// Event is called when button was dragged with the mouse.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments</param>
		private void OnButtonStartDragging(object sender, EventArgs e)
		{
			if(this.tabControl != null)
			{
				// Notify tab control
				tabControl.OnTabPageButtonStartDragging(sender, e);
			}
		}
		
		/// <summary>
		/// Called after the controls text is changed.
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected override void OnTextChanged(EventArgs e)
		{
			// Update button text
			if(this.TabButton != null)
			{
				this.TabButton.Text = this.Text;
			}
		}

		/// <summary>
		/// Called after the  controls hidden flag is changed.
		/// </summary>
		protected void OnHiddenChanged()
		{
			// Change visibility of the tab button
			this.TabButton.Visible = !this.Hidden;

			// Check if control reference is not null
			if(this.tabControl != null)
			{
				// Hidden tab page can't be selected
				if(this.tabControl.SelectedTab == this)
				{
					int newIndex = this.Index;
					if(newIndex >= this.tabControl.TabPages.Count)
					{
						newIndex = this.tabControl.TabPages.Count - 1;
					}
					this.tabControl.SelectedIndex = newIndex;
				}

				// If there is only one tab page in control - select it
				if(this.tabControl.SelectedTab == null)
				{
					this.tabControl.SelectedTab = this;
				}

				// Notify tab control about the changes
				this.tabControl.OnTabPagesChanged();
			}
		}

		#endregion

	}

	/// <summary>
	/// This class represents a collection of tab pages that belong to a vertical tab control.
	/// <seealso cref="VerticalTabControl"/>
	/// <seealso cref="VerticalTabPage"/>
	/// </summary>
	/// <remarks><b>VerticalTabPageCollection</b> is exposed as the 
	/// <see cref="VerticalTabControl.TabPages"/> property of the <see cref="VerticalTabControl"/> 
	/// class.<para>A vertical tab control can display one or more tab pages.</para></remarks>
	public class VerticalTabPageCollection : CollectionBase
	{
		#region Fields

		/// <summary>
		/// Reference to the owner tab control.
		/// </summary>
		private	VerticalTabControl	tabControl = null;

		#endregion

		#region Constructor and initialization

		/// <summary>
		/// Default public constructor is not accessible.
		/// </summary>
		private VerticalTabPageCollection()
		{
		}

		/// <summary>
		/// The constructor, which takes the vertical tab control owner of this object.
		/// <seealso cref="VerticalTabControl"/>
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <param name="tabControl">Owner of the collection.</param>
		public VerticalTabPageCollection(VerticalTabControl tabControl)
		{
			this.tabControl = tabControl;
		}

		#endregion

		#region Indexer

		/// <summary>
		/// Strongly typed indexer of the collection.
		/// <seealso cref="VerticalTabControl"/>
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		public VerticalTabPage this[int index] 
		{
			get 
			{ 
				return (VerticalTabPage)this.List[index]; 
			} 

			set 
			{ 
				this.List[index] = value;
			}
		}

		#endregion

		#region Add and Insert methods

		/// <summary>
		/// Adds the specified <b>VerticalTabPage</b> object to the end of the collection.
		/// <seealso cref="Insert"/>
		/// <seealso cref="Remove"/>
		/// <seealso cref="SetTabIndex"/>
		/// <seealso cref="VerticalTabControl"/>
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <param name="tabPage">Tab page object.</param>
		/// <returns>Index of the added object.</returns>
		public int Add(VerticalTabPage tabPage)
		{
			return this.List.Add(tabPage);
		}

		/// <summary>
		/// Adds a new <b>VerticalTabPage</b> object to the end of the collection, 
		/// taking the tab page's text.
		/// <seealso cref="Insert"/>
		/// <seealso cref="SetTabIndex"/>
		/// <seealso cref="Remove"/>
		/// <seealso cref="VerticalTabControl"/>
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <param name="text">Tab page's text.</param>
		/// <returns>Newly created object.</returns>
		public VerticalTabPage Add(string text)
		{
			VerticalTabPage tabPage = new VerticalTabPage(text);
			this.List.Add(tabPage);
			return tabPage;
		}

		/// <summary>
		/// Inserts the specified <b>VerticalTabPage</b> object into the collection.
		/// <seealso cref="Add"/>
		/// <seealso cref="Remove"/>
		/// <seealso cref="SetTabIndex"/>
		/// <seealso cref="VerticalTabControl"/>
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <param name="index">Index where the tab page will be inserted.</param>
		/// <param name="tabPage">Tab page object.</param>
		public void Insert(int index, VerticalTabPage tabPage)
		{
			this.List.Insert(index, tabPage);
		}

		/// <summary>
		/// Changes the index of the tab page in the collection.
		/// <seealso cref="Add"/>
		/// <seealso cref="Remove"/>
		/// <seealso cref="VerticalTabControl"/>
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <param name="tabPage">Tab page object.</param>
		/// <param name="index">New index of the tab page.</param>
		public void SetTabIndex(VerticalTabPage tabPage, int index)
		{
			// Check if tab page exsists in the collection
			if(this.List.Contains(tabPage))
			{
				// Remove item from the list without notifications
				this.InnerList.Remove(tabPage);

				// Check insert index
				if(index > this.Count)
				{
					index = this.Count;
				}

				// Insert item into the list without notifications
				this.InnerList.Insert(index, tabPage);

				// Notify control that tab pages where changed
				this.tabControl.OnTabPagesChanged();
			}
		}

		/// <summary>
		/// Inserts a new tab page into the collection.
		/// <seealso cref="Add"/>
		/// <seealso cref="Remove"/>
		/// <seealso cref="SetTabIndex"/>
		/// <seealso cref="VerticalTabControl"/>
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <param name="index">Index where the tab page will be inserted.</param>
		/// <param name="text">Tab page's text.</param>
		public void Insert(int index, string text)
		{
			VerticalTabPage tabPage = new VerticalTabPage(text);
			this.List.Insert(index, tabPage);
		}

		/// <summary>
		/// Removes the specified tab page from the collection.
		/// <seealso cref="Add"/>
		/// <seealso cref="Insert"/>
		/// <seealso cref="SetTabIndex"/>
		/// <seealso cref="VerticalTabControl"/>
		/// <seealso cref="VerticalTabPage"/>
		/// </summary>
		/// <param name="tabPage">Tab page to remove.</param>
		public void Remove(VerticalTabPage tabPage)
		{
			this.List.Remove(tabPage);
		}

		#endregion

		#region Items Inserting and Removing Notification methods

		/// <summary>
		/// Called before an item is inserted into the collection.
		/// </summary>
		/// <param name="index">Index where the item is being inserted.</param>
		/// <param name="value">Inserted object.</param>
		protected override void OnInsert(int index, object value)
		{
			VerticalTabPage	tabPage = (VerticalTabPage)value;

			// Set referense to the tab control
			tabPage.tabControl = this.tabControl;

			// Set referense to the tab control image list
			if(this.tabControl.ImageList != null)
			{
				tabPage.TabButton.ImageList = this.tabControl.ImageList;
			}

			// Set button orientation
			tabPage.TabButton.Vertical = this.tabControl.Vertical;

			// Add panel and button controls as child controls of the TabControl
			if(!this.tabControl.Contains(tabPage))
			{
				this.tabControl.Controls.Add(tabPage.TabButton);
				this.tabControl.Controls.Add(tabPage);
			}
		}

		/// <summary>
		/// Called before an item is removed from the collection.
		/// </summary>
		/// <param name="index">Index of the item to be removed.</param>
		/// <param name="value">Object to be removed.</param>
		protected override void OnRemove(int index, object value)
		{
			VerticalTabPage	tabPage = (VerticalTabPage)value;

			// Remove panel and button controls from child controls of the TabControl
			if(this.tabControl.Contains(tabPage))
			{
				this.tabControl.Controls.Remove(tabPage.TabButton);
				this.tabControl.Controls.Remove(tabPage);
			}
		}

		/// <summary>
		/// Called before all items are removed from the collection.
		/// </summary>
		protected override void OnClear()
		{
			for(int tabIndex = 0; tabIndex < this.List.Count; tabIndex++)
			{
				OnRemove(tabIndex, this.List[tabIndex]);
			}
		}

		/// <summary>
		/// Called after a new item is inserted into the collection.
		/// </summary>
		/// <param name="index">Index of the inserted item.</param>
		/// <param name="value">Object that was inserted.</param>
		protected override void OnInsertComplete(int index, object value)
		{
			VerticalTabPage	tabPage = (VerticalTabPage)value;

			// Set selected item
			if(this.tabControl.SelectedTab == null)
			{
				this.tabControl.SelectedTab = tabPage;
			}

			// Notify control that tab pages where changed
			this.tabControl.OnTabPagesChanged();
		}

		/// <summary>
		/// Called after an item is removed from the collection.
		/// </summary>
		/// <param name="index">Index of the removed item.</param>
		/// <param name="value">Object that was removed.</param>
		protected override void OnRemoveComplete(int index, object value)
		{
			VerticalTabPage	tabPage = (VerticalTabPage)value;

			// Check if selected tab page should be updated
			if(this.tabControl.SelectedTab == tabPage)
			{
				int newIndex = index;
				if(newIndex >= this.tabControl.TabPages.Count)
				{
					newIndex = this.tabControl.TabPages.Count - 1;
				}
				this.tabControl.SelectedIndex = newIndex;
			}

			// Notify control that tab pages where changed
			this.tabControl.OnTabPagesChanged();
		}

		/// <summary>
		/// Called after all items are removed from the collection.
		/// </summary>
		protected override void OnClearComplete()
		{
			// Clear selected index
			this.tabControl.SelectedTab = null;

			// Notify control that tab pages where changed
			this.tabControl.OnTabPagesChanged();
		}

		#endregion
	}

	/// <summary>
	/// Helper class that draws horizontally tiled image .
	/// </summary>
	public class TiledPictureBox : PictureBox
	{
		#region Constructor

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TiledPictureBox()
		{
			// Change control style
			this.SetStyle(ControlStyles.ResizeRedraw, true);
		}

		#endregion

		#region Overriden painting methods

		protected override void OnPaintBackground( PaintEventArgs e )
		{
			if(this.Image != null)
			{
				using( Bitmap bitmap = new Bitmap(e.ClipRectangle.Width, e.ClipRectangle.Height) )
				{
					using( Graphics graphics = Graphics.FromImage(bitmap) )
					{
						ImageAttributes imageAttributes = new ImageAttributes();
						for(int curentX = 0; curentX < e.ClipRectangle.Width; curentX += this.Image.Width)
						{
							graphics.DrawImage(
								this.Image, 
								new Rectangle(curentX, 0, this.Image.Width, e.ClipRectangle.Height), 
								0, e.ClipRectangle.Y, this.Image.Width, e.ClipRectangle.Height,
								GraphicsUnit.Pixel,
								imageAttributes);
						}

						e.Graphics.DrawImage(
							bitmap,
							e.ClipRectangle, 
							0, 0, bitmap.Width, bitmap.Height,
							GraphicsUnit.Pixel,
							imageAttributes);
					}
				}
			}
		}

		protected override void OnPaint( PaintEventArgs e )
		{
		}

		#endregion
	}

	/// <summary>
	/// Helper class that adds background image to the label.
	/// </summary>
	public class LabelWithBackImage : Label
	{
		#region Constructor

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LabelWithBackImage()
		{
			// Change control style
			this.SetStyle(ControlStyles.ResizeRedraw, true);
		}

		#endregion

		#region Overriden painting methods

		internal	Image	BackImage = null;

		protected override void OnPaintBackground( PaintEventArgs e )
		{
			base.OnPaintBackground( e );
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			// Clear background
			e.Graphics.Clear(this.BackColor);

			// Draw back image
			if(this.BackImage != null)
			{
				int imageLeft = this.Right - this.BackImage.Width - this.Left;
				Rectangle	dest = e.ClipRectangle;
				if(dest.X < imageLeft)
				{
					dest.Width -= imageLeft - dest.X;
					dest.X = imageLeft;
				}
				ImageAttributes imageAttributes = new ImageAttributes();
				e.Graphics.DrawImage(
					this.BackImage,
					dest, 
					dest.X - imageLeft, 
					e.ClipRectangle.Y + this.Top, 
					dest.Width, dest.Height,
					GraphicsUnit.Pixel,
					imageAttributes);
			}

			// Get text position
			Rectangle	textRect = new Rectangle(this.ClientRectangle.Location, this.ClientRectangle.Size);
			textRect.X += 5;
			textRect.Width -= 10;

			// Draw text
			StringFormat format = new StringFormat();
			format.LineAlignment = StringAlignment.Center;
			format.Alignment = StringAlignment.Near;
			format.Trimming = StringTrimming.EllipsisCharacter;
			format.FormatFlags = StringFormatFlags.LineLimit;
			using( SolidBrush brush = new SolidBrush( this.ForeColor ) )
			{
				e.Graphics.DrawString(this.Text, this.Font, brush, textRect, format);
			}

			format.Dispose();
		}

		#endregion
	}

}
