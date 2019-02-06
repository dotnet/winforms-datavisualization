//==============================================================================
//  File:		MainForms.cs
//
//  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain
//
//	Classes:	MainForm
//
//  Purpose:	Sample framework main form class.
//
//==============================================================================
// Copyright © Microsoft Corporation, all rights reserved
//==============================================================================

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain
{
    using FontStyle = System.Drawing.FontStyle;
    using Size = System.Drawing.Size;

	/// <summary>
	/// Sample framework main form class.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		#region Fields

		private		XmlDocument		samplesContentXMLDoc;
		private		XmlDocument		samplesXMLDoc;
		private		XmlDocument		tocXMLDoc;
		public		string			applicationPath = "";
		internal	float			scaleRatioX = 1f;
		internal	float			scaleRatioY = 1f;
		private		ArrayList		indexInfoList = new ArrayList();
		private		bool			indexEditorChanged = false;
		private		bool			ignoreTextChange = false;
		public		string			CurrentSamplePath = "";
		public		SampleInfo		CurrentSampleInfo = null;
		internal	RichTextBox		CurrentRichTextBox = null;
		private		ArrayList		contentNodes = new ArrayList();
		private		string			samplesNamespace = "";
		private		TreeNode		lastSelectedNode = null;

		private System.Windows.Forms.Panel panelTree;
        public System.Windows.Forms.TreeView treeSamples;
		private	VerticalTabControl	tabControlContent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelIndex;
		private System.Windows.Forms.TextBox textBoxIndex;
		private System.Windows.Forms.ListBox listBoxIndex;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.PictureBox pictureBoxHeaderLeft;
		private TiledPictureBox pictureBoxHeaderMidle;
		private System.Windows.Forms.PictureBox pictureBoxHeaderRight;
		private System.Windows.Forms.Panel panelContent;
		private System.Windows.Forms.Splitter splitterVertical;
		private LabelWithBackImage labelSampleTitle;
		//private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain.VerticalTabControl tabControlSample;
		//private System.Windows.Forms.PictureBox pictureBoxFooterRight;
		//private TiledPictureBox pictureBoxFotterMiddle;
        private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Panel panelWebBrowser;
		private System.Windows.Forms.Button buttonSamplePrevious;
		private System.Windows.Forms.Button buttonSampleNext;
		private System.Windows.Forms.ContextMenu contextMenuRTF;
		private System.Windows.Forms.MenuItem menuItemCopy;
		private System.Windows.Forms.MenuItem menuItemCopyAll;
        private ImageList imageListTree;	
		private System.ComponentModel.IContainer components;

		#endregion // Fields

		#region Constructor

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Analyse current graphics resolution
			Graphics g = this.CreateGraphics();
			if(g != null)
			{
				if(g.DpiX != 96 || g.DpiY != 96)
				{
					this.scaleRatioX = g.DpiX/96f;
					this.scaleRatioY = g.DpiY/96f;
				}
			}
			g.Dispose();

			// Load settings from XML data file
			LoadSettings();

			// Initialize content/index tab control
			tabControlContent = new VerticalTabControl();
			tabControlContent.Vertical = false;
			tabControlContent.Dock = DockStyle.Fill;
			tabControlContent.BackColor = Color.White;
			tabControlContent.BorderColor = Color.FromArgb(191,191,191);
			tabControlContent.Font = new Font("Verdana", 8, FontStyle.Bold);

			// Add Content page
			tabControlContent.TabPages.Add("Contents");
			tabControlContent.TabPages[0].Controls.Add(this.treeSamples);			
			this.treeSamples.Dock = DockStyle.Fill;

			// Add Index page
			tabControlContent.TabPages.Add("Index");
			tabControlContent.TabPages[1].Controls.Add(this.panelIndex);
			this.panelIndex.Dock = DockStyle.Fill;

			// Add event handler when selected tab changes
			tabControlContent.SelectedIndexChanged += new System.EventHandler(this.tabControlContent_SelectedIndexChanged);

			// Add tab control into the panel
			this.panelTree.Controls.Add(tabControlContent);


			// Initialize sample tab control
			tabControlSample.Vertical = false;
			tabControlSample.BackColor = Color.White;
			tabControlSample.BorderColor = Color.FromArgb(191,191,191);
			tabControlSample.Font = new Font("Verdana", 8, FontStyle.Bold);
			tabControlSample.ForeColor = Color.FromArgb(117,117,117);

			// Position sample tab control so that top of the tabs aligned with the
			// bottom of content tabs
			int tabHeight = tabControlContent.GetButtonHeight() + 1;
			tabControlSample.Height += tabControlSample.Top - tabHeight;
			tabControlSample.Top = tabControlContent.Top + tabHeight;

			// Set sample tab control image
			tabControlSample.BackgroundImage = (Image)pictureBoxHeaderRight.Image.Clone();
			tabControlSample.BackImageOffsetX = pictureBoxHeaderRight.Right - (tabControlSample.Right + panelContent.Left) + 4;
			tabControlSample.BackImageOffsetY = panelContent.Top + tabControlSample.Top;

			// Add Content page
			tabControlSample.TabPages.Add("Sample");
			tabControlSample.TabPages[0].Font = new Font("Verdana", 9);
			tabControlSample.TabPages[0].ForeColor = Color.FromArgb(26,59,105);

			// Add event handler when selected sample tab changes
			tabControlSample.SelectedIndexChanged += new System.EventHandler(this.tabControlSample_SelectedIndexChanged);

			// Set sample title image and position
			labelSampleTitle.Top = tabControlSample.Top + panelContent.Top - labelSampleTitle.Height;
			labelSampleTitle.BackImage = (Image)pictureBoxHeaderRight.Image.Clone();
			
			// Align sample title with the splitter
			labelSampleTitle.Left = splitterVertical.Right + 5;
			if(labelSampleTitle.Left < 264)
			{
				labelSampleTitle.Left = 264;
			}
			labelSampleTitle.Width = this.Width - labelSampleTitle.Left - 4;

			// Update size of the components to fit specified images
			panelHeader.Height = pictureBoxHeaderLeft.Image.Height;
			//panelFooter.Height = pictureBoxFooterRight.Image.Height;

			// Scale Prev/Next buttons
			if(this.scaleRatioX != 1f || this.scaleRatioY != 1f)
			{
				buttonSamplePrevious.Width = (int)(buttonSamplePrevious.Width * this.scaleRatioX);
				buttonSamplePrevious.Height = (int)(buttonSamplePrevious.Height *this.scaleRatioY);
				buttonSampleNext.Width = (int)(buttonSampleNext.Width * this.scaleRatioX);
				buttonSampleNext.Height = (int)(buttonSampleNext.Height * this.scaleRatioY);
			}

			// Position Prev/Next buttons
			buttonSamplePrevious.Top = labelSampleTitle.Bottom + 1;
			buttonSampleNext.Top = labelSampleTitle.Bottom + 1;
			buttonSampleNext.Left = this.Width - buttonSampleNext.Width - 15;
			buttonSamplePrevious.Left = buttonSampleNext.Left - buttonSamplePrevious.Width - 5;

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

	#endregion // Constructor

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTree = new System.Windows.Forms.Panel();
            this.panelIndex = new System.Windows.Forms.Panel();
            this.listBoxIndex = new System.Windows.Forms.ListBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeSamples = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxHeaderRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeaderLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeaderMidle = new System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain.TiledPictureBox();
            this.splitterVertical = new System.Windows.Forms.Splitter();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelWebBrowser = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControlSample = new System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain.VerticalTabControl();
            this.buttonSamplePrevious = new System.Windows.Forms.Button();
            this.buttonSampleNext = new System.Windows.Forms.Button();
            this.contextMenuRTF = new System.Windows.Forms.ContextMenu();
            this.menuItemCopy = new System.Windows.Forms.MenuItem();
            this.menuItemCopyAll = new System.Windows.Forms.MenuItem();
            this.labelSampleTitle = new System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain.LabelWithBackImage();
            this.panelTree.SuspendLayout();
            this.panelIndex.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderMidle)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelWebBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTree
            // 
            this.panelTree.BackColor = System.Drawing.Color.White;
            this.panelTree.Controls.Add(this.panelIndex);
            this.panelTree.Controls.Add(this.treeSamples);
            this.panelTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTree.Location = new System.Drawing.Point(0, 157);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(256, 436);
            this.panelTree.TabIndex = 0;
            // 
            // panelIndex
            // 
            this.panelIndex.BackColor = System.Drawing.SystemColors.Window;
            this.panelIndex.Controls.Add(this.listBoxIndex);
            this.panelIndex.Controls.Add(this.textBoxIndex);
            this.panelIndex.Controls.Add(this.label1);
            this.panelIndex.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelIndex.Location = new System.Drawing.Point(24, 168);
            this.panelIndex.Name = "panelIndex";
            this.panelIndex.Size = new System.Drawing.Size(192, 272);
            this.panelIndex.TabIndex = 2;
            // 
            // listBoxIndex
            // 
            this.listBoxIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIndex.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIndex.IntegralHeight = false;
            this.listBoxIndex.ItemHeight = 15;
            this.listBoxIndex.Location = new System.Drawing.Point(0, 40);
            this.listBoxIndex.Name = "listBoxIndex";
            this.listBoxIndex.Size = new System.Drawing.Size(192, 232);
            this.listBoxIndex.TabIndex = 2;
            this.listBoxIndex.SelectedIndexChanged += new System.EventHandler(this.listBoxIndex_SelectedIndexChanged);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.AcceptsReturn = true;
            this.textBoxIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIndex.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndex.Location = new System.Drawing.Point(0, 17);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(192, 21);
            this.textBoxIndex.TabIndex = 1;
            this.textBoxIndex.TextChanged += new System.EventHandler(this.textBoxIndex_TextChanged);
            this.textBoxIndex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxIndex_MouseDown);
            this.textBoxIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIndex_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Look for sample:";
            // 
            // treeSamples
            // 
            this.treeSamples.BackColor = System.Drawing.SystemColors.Window;
            this.treeSamples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeSamples.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeSamples.HideSelection = false;
            this.treeSamples.HotTracking = true;
            this.treeSamples.ImageIndex = 0;
            this.treeSamples.ImageList = this.imageListTree;
            this.treeSamples.Indent = 16;
            this.treeSamples.Location = new System.Drawing.Point(32, 24);
            this.treeSamples.Name = "treeSamples";
            this.treeSamples.SelectedImageIndex = 0;
            this.treeSamples.ShowLines = false;
            this.treeSamples.Size = new System.Drawing.Size(168, 112);
            this.treeSamples.TabIndex = 1;
            this.treeSamples.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeSamples_AfterCollapse);
            this.treeSamples.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSamples_AfterSelect);
            this.treeSamples.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeSamples_AfterExpand);
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "");
            this.imageListTree.Images.SetKeyName(1, "");
            this.imageListTree.Images.SetKeyName(2, "");
            this.imageListTree.Images.SetKeyName(3, "");
            this.imageListTree.Images.SetKeyName(4, "");
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBoxHeaderRight);
            this.panelHeader.Controls.Add(this.pictureBoxHeaderLeft);
            this.panelHeader.Controls.Add(this.pictureBoxHeaderMidle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(840, 157);
            this.panelHeader.TabIndex = 1;
            // 
            // pictureBoxHeaderRight
            // 
            this.pictureBoxHeaderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxHeaderRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHeaderRight.Image")));
            this.pictureBoxHeaderRight.Location = new System.Drawing.Point(416, 0);
            this.pictureBoxHeaderRight.Name = "pictureBoxHeaderRight";
            this.pictureBoxHeaderRight.Size = new System.Drawing.Size(424, 157);
            this.pictureBoxHeaderRight.TabIndex = 3;
            this.pictureBoxHeaderRight.TabStop = false;
            // 
            // pictureBoxHeaderLeft
            // 
            this.pictureBoxHeaderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHeaderLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHeaderLeft.Image")));
            this.pictureBoxHeaderLeft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHeaderLeft.Name = "pictureBoxHeaderLeft";
            this.pictureBoxHeaderLeft.Size = new System.Drawing.Size(247, 157);
            this.pictureBoxHeaderLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHeaderLeft.TabIndex = 1;
            this.pictureBoxHeaderLeft.TabStop = false;
            // 
            // pictureBoxHeaderMidle
            // 
            this.pictureBoxHeaderMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHeaderMidle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHeaderMidle.Image")));
            this.pictureBoxHeaderMidle.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHeaderMidle.Name = "pictureBoxHeaderMidle";
            this.pictureBoxHeaderMidle.Size = new System.Drawing.Size(840, 157);
            this.pictureBoxHeaderMidle.TabIndex = 2;
            this.pictureBoxHeaderMidle.TabStop = false;
            // 
            // splitterVertical
            // 
            this.splitterVertical.BackColor = System.Drawing.Color.White;
            this.splitterVertical.Location = new System.Drawing.Point(256, 157);
            this.splitterVertical.MinSize = 100;
            this.splitterVertical.Name = "splitterVertical";
            this.splitterVertical.Size = new System.Drawing.Size(3, 436);
            this.splitterVertical.TabIndex = 2;
            this.splitterVertical.TabStop = false;
            this.splitterVertical.SplitterMoving += new System.Windows.Forms.SplitterEventHandler(this.splitterVertical_SplitterMoving);
            this.splitterVertical.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitterVertical_SplitterMoved);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.panelWebBrowser);
            this.panelContent.Controls.Add(this.tabControlSample);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(259, 157);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(581, 436);
            this.panelContent.TabIndex = 3;
            this.panelContent.Resize += new System.EventHandler(this.panelContent_Resize);
            // 
            // panelWebBrowser
            // 
            this.panelWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWebBrowser.Controls.Add(this.webBrowser1);
            this.panelWebBrowser.Location = new System.Drawing.Point(32, 32);
            this.panelWebBrowser.Name = "panelWebBrowser";
            this.panelWebBrowser.Size = new System.Drawing.Size(488, 80);
            this.panelWebBrowser.TabIndex = 4;
            this.panelWebBrowser.Visible = false;
            this.panelWebBrowser.Resize += new System.EventHandler(this.panelWebBrowser_Resize);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-2, -2);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(300, 150);
            this.webBrowser1.TabIndex = 3;
            // 
            // tabControlSample
            // 
            this.tabControlSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSample.ImageList = null;
            this.tabControlSample.Location = new System.Drawing.Point(0, 136);
            this.tabControlSample.Name = "tabControlSample";
            this.tabControlSample.SelectedIndex = -1;
            this.tabControlSample.SelectedTab = null;
            this.tabControlSample.Size = new System.Drawing.Size(581, 300);
            this.tabControlSample.TabIndex = 2;
            this.tabControlSample.Vertical = true;
            // 
            // buttonSamplePrevious
            // 
            this.buttonSamplePrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSamplePrevious.BackColor = System.Drawing.Color.White;
            this.buttonSamplePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSamplePrevious.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSamplePrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.buttonSamplePrevious.Location = new System.Drawing.Point(648, 180);
            this.buttonSamplePrevious.Name = "buttonSamplePrevious";
            this.buttonSamplePrevious.Size = new System.Drawing.Size(104, 21);
            this.buttonSamplePrevious.TabIndex = 5;
            this.buttonSamplePrevious.Text = "<  Previous";
            this.buttonSamplePrevious.UseVisualStyleBackColor = false;
            this.buttonSamplePrevious.Click += new System.EventHandler(this.buttonSamplePrevious_Click);
            // 
            // buttonSampleNext
            // 
            this.buttonSampleNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSampleNext.BackColor = System.Drawing.Color.White;
            this.buttonSampleNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSampleNext.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSampleNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.buttonSampleNext.Location = new System.Drawing.Point(760, 180);
            this.buttonSampleNext.Name = "buttonSampleNext";
            this.buttonSampleNext.Size = new System.Drawing.Size(72, 21);
            this.buttonSampleNext.TabIndex = 6;
            this.buttonSampleNext.Text = "Next  >";
            this.buttonSampleNext.UseVisualStyleBackColor = false;
            this.buttonSampleNext.Click += new System.EventHandler(this.buttonSampleNext_Click);
            // 
            // contextMenuRTF
            // 
            this.contextMenuRTF.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemCopy,
            this.menuItemCopyAll});
            this.contextMenuRTF.Popup += new System.EventHandler(this.contextMenuRTF_Popup);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Index = 0;
            this.menuItemCopy.Text = "&Copy";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemCopyAll
            // 
            this.menuItemCopyAll.Index = 1;
            this.menuItemCopyAll.Text = "Copy &All";
            this.menuItemCopyAll.Click += new System.EventHandler(this.menuItemCopyAll_Click);
            // 
            // labelSampleTitle
            // 
            this.labelSampleTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSampleTitle.BackColor = System.Drawing.Color.White;
            this.labelSampleTitle.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.labelSampleTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSampleTitle.Location = new System.Drawing.Point(264, 144);
            this.labelSampleTitle.Name = "labelSampleTitle";
            this.labelSampleTitle.Size = new System.Drawing.Size(580, 33);
            this.labelSampleTitle.TabIndex = 0;
            this.labelSampleTitle.Text = "This is a sample title.";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(840, 593);
            this.Controls.Add(this.labelSampleTitle);
            this.Controls.Add(this.buttonSampleNext);
            this.Controls.Add(this.buttonSamplePrevious);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.splitterVertical);
            this.Controls.Add(this.panelTree);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samples Environment for Chart Control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelTree.ResumeLayout(false);
            this.panelIndex.ResumeLayout(false);
            this.panelIndex.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderMidle)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelWebBrowser.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region Methods

		/// <summary>
		/// Loads settings from the sample framework configuration file.
		/// </summary>
		private void LoadSettings()
		{
			string errorMsg = "Invalid configuration file format.";

			// Load setting from the congig XML file
			XmlDocument configXmlDocument = new XmlDocument();
			configXmlDocument.Load(Application.StartupPath + "\\config.xml");

			// Frame Title
			XmlNodeList elemList = configXmlDocument.GetElementsByTagName("FormTitle");
			if(elemList != null && elemList.Count == 1)
			{
				this.Text = elemList[0].InnerText.Trim();
			}
			else
			{
				throw(new InvalidOperationException(errorMsg));
			}

			// Samples namespace
			elemList = configXmlDocument.GetElementsByTagName("SamplesNamespace");
			if(elemList != null && elemList.Count == 1)
			{
				this.samplesNamespace = elemList[0].InnerText.Trim();
			}
			else
			{
				throw(new InvalidOperationException(errorMsg));
			}

			// Frame Icon
			elemList = configXmlDocument.GetElementsByTagName("FormIcon");
			if(elemList != null && elemList.Count == 1)
			{
				this.Icon = new Icon(Application.StartupPath + "\\" + elemList[0].InnerText.Trim());
			}
			else
			{
				throw(new InvalidOperationException(errorMsg));
			}

			// Header/Footer images
			this.pictureBoxHeaderLeft.Image = LoadConfigImage(configXmlDocument, "HeaderImageLeft");
			this.pictureBoxHeaderMidle.Image = LoadConfigImage(configXmlDocument, "HeaderImageMiddle");
			this.pictureBoxHeaderRight.Image = LoadConfigImage(configXmlDocument, "HeaderImageRight");
			//this.pictureBoxFotterMiddle.Image = LoadConfigImage(configXmlDocument, "FooterImageMiddle");
			//this.pictureBoxFooterRight.Image = LoadConfigImage(configXmlDocument, "FooterImageRight");

			// Footer Links
/*			elemList = configXmlDocument.GetElementsByTagName("FooterLinks");
			if(elemList != null && elemList.Count == 1)
			{
				int	spacing = 10;
				int currentX = spacing;
				foreach(XmlNode node in elemList[0].ChildNodes)
				{
					LinkLabel linkLabel = new LinkLabel();
					linkLabel.Text = node.InnerText.Trim(); 
					linkLabel.BackColor = Color.FromArgb(241, 241, 241);
					linkLabel.LinkColor = Color.FromArgb(26, 59, 105);
					linkLabel.TextAlign = ContentAlignment.MiddleCenter;
					linkLabel.Font = new Font("Verdana", 8);
					linkLabel.Links.Add(0, linkLabel.Text.Length, node.Attributes["URL"].InnerText);

					// Add link label to the footer
					panelFooter.Controls.Add(linkLabel);
					linkLabel.BringToFront();

					// Set label position
					linkLabel.AutoSize = true;
					linkLabel.Top = (panelFooter.Height - linkLabel.Height + spacing) / 2;
					linkLabel.Left = currentX;
					currentX += linkLabel.Width + spacing;

					// Hookup to the link clicked event
					linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
				}
			}
			else
			{
				throw(new InvalidOperationException(errorMsg));
			}*/
		}

		private Image LoadConfigImage(XmlDocument configXmlDocument, string name)
		{
			XmlNodeList elemList = configXmlDocument.GetElementsByTagName(name);
			if(elemList != null && elemList.Count == 1)
			{
				return Image.FromFile(Application.StartupPath + "\\" + elemList[0].InnerText.Trim());
			}
			else
			{
				throw(new InvalidOperationException("Invalid configuration file format."));
			}
		}

		/// <summary>
		/// Loads sample.
		/// </summary>
		/// <param name="sampleInfo">Sample information.</param>
		private void LoadSample(SampleInfo sampleInfo)
		{
			this.tabControlSample.SuspendLayout();
			this.panelContent.SuspendLayout();
			this.SuspendLayout();

			UserControl	userControl = null;
			userControl = (UserControl)Assembly.GetEntryAssembly().CreateInstance(this.samplesNamespace + "." + sampleInfo.sampleControl);

			// Save current sample path
			this.CurrentSampleInfo = sampleInfo;
			this.CurrentSamplePath = this.applicationPath + "\\";
			this.CurrentSamplePath += sampleInfo.path;

			// Make sure sample tab is the first one
			if(this.tabControlSample.TabPages[0].Text != "Sample")
			{
				for(int index = 0; index < this.tabControlSample.TabPages.Count; index++)
				{
					if(this.tabControlSample.TabPages[index].Text == "Sample")
					{
						this.tabControlSample.TabPages.SetTabIndex(this.tabControlSample.TabPages[index], 0);
						break;
					}
				}
			}

			// Hide/show sample tab control
			tabControlSample.TabPages[0].Hidden = (userControl == null);

			// Load selected user control
			if(userControl != null)
			{
				// Scale control
				if(this.scaleRatioX != 1f || this.scaleRatioY != 1f)
				{
					userControl.Scale(this.scaleRatioX, this.scaleRatioY);
				}

				userControl.AutoScroll = true;
				userControl.Dock = System.Windows.Forms.DockStyle.Fill;
				userControl.Size = new Size(800, 600);
				userControl.TabIndex = 0;

				if(this.tabControlSample.TabPages[0].Controls.Count > 0)
				{
					int count = this.tabControlSample.TabPages[0].Controls[0].Controls.Count;
					for (int i = (count-1); i >= 0; i-- )
					{
						Control control = this.tabControlSample.TabPages[0].Controls[0].Controls[i];
						if (control != null)
						{
							control.Dispose();
						}
					}
					this.tabControlSample.TabPages[0].Controls[0].Dispose();
				}
				this.tabControlSample.TabPages[0].Controls.Add(userControl);
			}

			// Check if tabs can be resused.
			for(int index = 1; index < this.tabControlSample.TabPages.Count; index++)
			{
				bool	reuse = false;

				// Check if tab name matches one of the required names
				foreach(InfoPage infoPage in sampleInfo.infoPages)
				{
					if(infoPage.title == this.tabControlSample.TabPages[index].Text)
					{
						reuse = true;
						break;
					}
				}

				// Remove tab control if cannot be reused
				if(!reuse)
				{
					// If tab contains the IE ActiveX control - move it into the form
					if(this.tabControlSample.TabPages[index].Controls[0] == this.panelWebBrowser)
					{
						this.panelWebBrowser.Visible = false;
						this.Controls.Add(this.panelWebBrowser);
					}
					this.tabControlSample.TabPages.Remove(this.tabControlSample.TabPages[index]);
					--index;
				}
			}

			// Add new pages into the tab control
			int tabIndex = 1;
			foreach(object obj in sampleInfo.infoPages)
			{
				InfoPage infoPage = (InfoPage)obj;

				// Skip sample placeholder
				if(infoPage.title == "Sample")
				{
					continue;
				}

				// check if we can use reused tab
				VerticalTabPage tabPage = null;
				for(int index = 0; index < this.tabControlSample.TabPages.Count; index++)
				{
					if(infoPage.title == this.tabControlSample.TabPages[index].Text)
					{
						tabPage = this.tabControlSample.TabPages[index];

						// Adjust tab control index
						if(tabIndex != index)
						{
							this.tabControlSample.TabPages.SetTabIndex(tabPage, tabIndex);
						}
					}
				}

				// Add a new tab
				if(tabPage == null)
				{
					tabControlSample.TabPages.Insert(tabIndex, infoPage.title);
					tabPage = tabControlSample.TabPages[tabIndex];
				}
				tabPage.Font = new Font("Arial", 9);

				// Load info text from file
				string	infoFileName = this.applicationPath + "\\" + sampleInfo.path + "\\" + infoPage.data;
				infoFileName = infoFileName.ToUpper();
				StreamReader sr = new StreamReader(infoFileName);
				string	infoText = sr.ReadToEnd();
				sr.Close();

				// Apply color syntax hilighting
				SourceCodeToRtf	sourceConverter = null;
				bool			rtfFormat = false;
				if(infoPage.title.ToUpper().IndexOf("C#") >= 0)
				{
					sourceConverter	= new SourceCodeToRtf();
					sourceConverter.LoadLanguageDefinition(this.applicationPath + "\\cs_langDef.xml");
				}
				else if(infoPage.title.IndexOf("Visual Basic") >= 0)
				{
					sourceConverter	= new SourceCodeToRtf();
					sourceConverter.LoadLanguageDefinition(this.applicationPath + "\\vbnet_langDef.xml");
				}

				// Convert source text using selected converter
				if(sourceConverter != null)
				{
					infoText = sourceConverter.Convert(infoText);
					rtfFormat = true;
				}

				// Check if RTF or IE ActiveX control should be created
				bool reusedControl = false;
				if(infoFileName.EndsWith(".HTM") || infoFileName.EndsWith(".HTML"))
				{
					// Check if control can be reused
					if(tabPage.Controls.Count > 0)
					{
						if(tabPage.Controls[0] == this.panelWebBrowser)
						{
							reusedControl = true;
						}
						else
						{
							tabPage.Controls.RemoveAt(0);
						}
					}

					// Add IE control into the tab
					if(!reusedControl)
					{
						this.panelWebBrowser.Visible = true;
						this.panelWebBrowser.Dock = DockStyle.Fill;
						tabPage.Controls.Add(this.panelWebBrowser);
					}

					webBrowser1.Navigate(infoFileName);
				}
				else
				{
					// Check if control can be reused
					RichTextBox richTextBox = null;
					if(tabPage.Controls.Count > 0)
					{
						if(tabPage.Controls[0] is RichTextBox)
						{
							reusedControl = true;
							richTextBox = (RichTextBox)tabPage.Controls[0];
						}
						else
						{
							if(tabPage.Controls[0] == this.panelWebBrowser)
							{
								this.panelWebBrowser.Visible = false;
								this.Controls.Add(this.panelWebBrowser);
							}
							else
							{
								tabPage.Controls.RemoveAt(0);
							}
						}
					}

					// Create rich-text control
					tabPage.DockPadding.Top = 10;
					tabPage.DockPadding.Left = 10;
					if(!reusedControl)
					{
						richTextBox = new RichTextBox();
						richTextBox.BackColor = Color.White;
						richTextBox.BorderStyle = BorderStyle.None;
						richTextBox.Dock = DockStyle.Fill;
						richTextBox.ReadOnly = true;
						richTextBox.WordWrap = false;

						// Add rich-text control into the tab
						tabPage.Controls.Add(richTextBox);

						// Add context menu to the RTF control
						richTextBox.ContextMenu = this.contextMenuRTF;
					}

					// Set rich-text control text
					if(rtfFormat || infoFileName.EndsWith(".RTF"))
					{
						richTextBox.Rtf = infoText;
						if(infoFileName.EndsWith(".RTF"))
							richTextBox.WordWrap = true;

						// Note: setting text the second time to solve image drawing issue
						richTextBox.Rtf = infoText;
					}
					else 
					{
						richTextBox.Text = infoText;
					}
				}

				++tabIndex;
			}

			// Check and set sample tab index
			tabIndex = 0;
			foreach(object obj in sampleInfo.infoPages)
			{
				// Check if it's a sample placeholder
				InfoPage infoPage = (InfoPage)obj;
				if(infoPage.title == "Sample")
				{
					// Position the Sample tab
					if(tabIndex > 0)
					{
						VerticalTabPage page = this.tabControlSample.TabPages[0];
						this.tabControlSample.TabPages.RemoveAt(0);
						this.tabControlSample.TabPages.Insert(tabIndex, page);
					}
					break;
				}
				++tabIndex;
			}


			// Always make first tab visible
			this.tabControlSample.SelectedIndex = 0;
			this.tabControlSample.TabPages[0].Invalidate();

			// Set sample title
			labelSampleTitle.Text = sampleInfo.shortBlurb;

			// Resume layout
			this.tabControlSample.ResumeLayout(false);
			this.panelContent.ResumeLayout(false);
			this.ResumeLayout(false);

			// IVOR: I made these changes so the labels that have their text set to
			// Verdana will interpret "\n". Also all the other controls will have their
			// colors set to black.
			if (userControl != null)
			{
				foreach (Control control in userControl.Controls)
				{
					Label label = control as Label;
					if (label != null && label.Font.Name == "Verdana")
					{
						// IVOR: Take care of all line breaks
						label.Text = label.Text.Replace("\\n", "\n");
					}
					else
					{
						// IVOR: Make the font color black
						control.ForeColor = Color.Black;
					}
				}
			}
		}

		/// <summary>
		/// MS bug workaround. 
		/// Forces application closing on WM_CLOSE
		/// </summary>
		/// <param name="m"></param>
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			// Process WM_CLOSE message
			if(m.Msg == 16)
			{
				Application.Exit();
			}
		}

		private void BuildNodeList(TreeNode node)
		{
			// Add node into the list
			contentNodes.Add(node);

			// Add all child nodes
			foreach(TreeNode childNode in node.Nodes)
			{
				BuildNodeList(childNode);
			}
		}


		private void buttonSampleNext_Click(object sender, System.EventArgs e)
		{
			// Build nodes list
			if(contentNodes.Count == 0)
			{
				foreach(TreeNode childNode in treeSamples.Nodes)
				{
					this.BuildNodeList(childNode);
				}
			}

			// Get current node
			TreeNode selectedNode = this.lastSelectedNode;
			if(selectedNode == null)
			{
				selectedNode = treeSamples.Nodes[0];
			}

			// Find index of the current node
			int curentNodeIndex = contentNodes.IndexOf(selectedNode);

			// Find Next node
			TreeNode	nextSampleNode = null;
			while(nextSampleNode == null)
			{
				++curentNodeIndex;
				if(curentNodeIndex >= contentNodes.Count)
				{
					curentNodeIndex = 0;
				}
				TreeNode node = (TreeNode)contentNodes[curentNodeIndex];
				if(node.Tag != null && node.Tag is SampleInfo)
				{
					nextSampleNode = node;;
				}
			}

			// Select next sample node
			treeSamples.SelectedNode = nextSampleNode;
		}

		private void buttonSamplePrevious_Click(object sender, System.EventArgs e)
		{
			// Build nodes list
			if(contentNodes.Count == 0)
			{
				foreach(TreeNode childNode in treeSamples.Nodes)
				{
					this.BuildNodeList(childNode);
				}
			}

			// Get current node
			TreeNode selectedNode = this.lastSelectedNode;
			if(selectedNode == null)
			{
				selectedNode = treeSamples.Nodes[0];
			}

			// Find index of the current node
			int curentNodeIndex = contentNodes.IndexOf(selectedNode);

			// Find Next node
			TreeNode	prevSampleNode = null;
			while(prevSampleNode == null)
			{
				--curentNodeIndex;
				if(curentNodeIndex < 0)
				{
					curentNodeIndex = contentNodes.Count - 1;
				}
				TreeNode node = (TreeNode)contentNodes[curentNodeIndex];
				if(node.Tag != null && node.Tag is SampleInfo)
				{
					prevSampleNode = node;;
				}
			}

			// Select prev sample node
			treeSamples.SelectedNode = prevSampleNode;
		}

		#endregion // Methods

		#region Event handlers

		private void panelWebBrowser_Resize(object sender, System.EventArgs e)
		{
			this.webBrowser1.Width = panelWebBrowser.Width + 4;
			this.webBrowser1.Height = panelWebBrowser.Height + 4;
		}

		/// <summary>
		/// Main form is loading
		/// </summary>
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			// Get application path
			applicationPath = Application.ExecutablePath;
			int slashIndex = applicationPath.LastIndexOf('\\');
			applicationPath = applicationPath.Substring(0, slashIndex);

			// Fill dynamic content tree
			FillSamplesTree(this.treeSamples);

			// Load first sample
			if(this.treeSamples.Nodes.Count > 0)
			{
				foreach(TreeNode treeNode in this.treeSamples.Nodes[0].Nodes)
				{
					if(treeNode.Tag != null)
					{
						this.treeSamples.SelectedNode = treeNode;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Tree node selected.
		/// </summary>
		private void treeSamples_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			// Check if sample information attached to the node 
			if(e.Node.Tag != null && e.Node.Tag is SampleInfo)
			{
				LoadSample((SampleInfo)e.Node.Tag);

				// Save last selected index
				this.lastSelectedNode = e.Node;
			}
		}

		/// <summary>
		/// Text changed in the index editor
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Arguments</param>
		private void textBoxIndex_TextChanged(object sender, System.EventArgs e)
		{
			if(textBoxIndex.Text.Length > 0 && !this.ignoreTextChange)
			{
				int foundIndex = this.listBoxIndex.FindString(textBoxIndex.Text);
				if(foundIndex != ListBox.NoMatches)
				{
					this.indexEditorChanged = true;
					this.listBoxIndex.SelectedIndex = foundIndex;
					this.listBoxIndex.TopIndex = foundIndex;
				}
			}
		}

		/// <summary>
		/// User clicked on the index editor.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Arguments</param>
		private void textBoxIndex_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Select all text in the control
			textBoxIndex.SelectAll();
		}

		/// <summary>
		/// User pressed key in the index editor.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Arguments</param>
		private void textBoxIndex_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			// Enter key is handled
			if(e.KeyChar == '\r')
			{
				// Force the sample to be loaded
				listBoxIndex_SelectedIndexChanged(this, new System.EventArgs());

				// Select all text in the control
				textBoxIndex.SelectAll();

				e.Handled = true;
			}
		}

		/// <summary>
		/// Set form minimum size when horizontal splitter positio is changed
		/// </summary>
		private void splitterHorizontal_Move(object sender, System.EventArgs e)
		{
			//this.MinimumSize = new Size(this.MinimumSize.Width, this.panelSourceCode.Size.Height + 200);
		}

		/// <summary>
		/// Selected item in the sample tab control changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabControlSample_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.CurrentRichTextBox = null;
			if(tabControlSample.SelectedIndex >= 0)
			{
				if(tabControlSample.TabPages[tabControlSample.SelectedIndex].Controls.Count > 0 &&
					tabControlSample.TabPages[tabControlSample.SelectedIndex].Controls[0] is RichTextBox)
				{
					this.CurrentRichTextBox = (RichTextBox)tabControlSample.TabPages[tabControlSample.SelectedIndex].Controls[0];
				}
			}
		}

		/// <summary>
		/// Selected item in the content tab control changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabControlContent_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Check if content becomes selected
			if(tabControlContent.SelectedIndex == 0)
			{
				// Make sure current sample is selected in the content tree
				bool	findSample = false;
				if(this.CurrentSampleInfo != null &&
					treeSamples.SelectedNode != null && 
					treeSamples.SelectedNode.Tag != null && 
					treeSamples.SelectedNode.Tag is SampleInfo &&
					this.CurrentSampleInfo != treeSamples.SelectedNode.Tag)
				{
					findSample = true;
				}

				// Find first occurance of the sample in the content tree
				if(findSample)
				{
					// Build nodes list
					if(contentNodes.Count == 0)
					{
						foreach(TreeNode childNode in treeSamples.Nodes)
						{
							this.BuildNodeList(childNode);
						}
					}

					// Find first node 
					foreach(TreeNode treeNode in contentNodes)
					{
						if(treeNode.Tag != null && treeNode.Tag == this.CurrentSampleInfo)
						{
							treeSamples.SelectedNode = treeNode;
							break;
						}
					}
				}
			}
		}

		/// <summary>
		/// Selected item in the index changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBoxIndex_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.indexEditorChanged)
			{
				this.indexEditorChanged = false;
				return;
			}

			this.ignoreTextChange = true;
			if(listBoxIndex.SelectedItem != null && 
				listBoxIndex.SelectedItem is IndexInfo)
			{
				IndexInfo	indexInfo = (IndexInfo)listBoxIndex.SelectedItem;

				// Set index edit control text
				textBoxIndex.Text = indexInfo.Key + ((indexInfo.SubKey.Length == 0 ) ? 
					"" : ", " + indexInfo.SubKey);

				// Load sample
				if(indexInfo.SampleInfo != null &&
					indexInfo.SampleInfo.sampleControl.Length > 0)
				{
					LoadSample(indexInfo.SampleInfo);
				}
			}

			this.ignoreTextChange = false;
		}

		private void splitterVertical_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			// Align sample title with the splitter
			labelSampleTitle.Left = splitterVertical.Right + 5;
			if(labelSampleTitle.Left < 264)
			{
				labelSampleTitle.Left = 264;
			}
			labelSampleTitle.Width = this.Width - labelSampleTitle.Left - 4;

			// Show hide LinkLabels if they are overlapped by the footer image
			//ShowHideFooterLinks();
		}

		private void splitterVertical_SplitterMoving(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			// Restrict the movement of the vertical splitter
			if(e.SplitX > pictureBoxHeaderRight.Left)
			{
				e.SplitX = pictureBoxHeaderRight.Left;
			}
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			if(this.WindowState != FormWindowState.Minimized)
			{
				// Restrict the width of the content tree panel
				if(panelTree.Width > this.Width - pictureBoxHeaderRight.Image.Width - splitterVertical.Width)
				{
					panelTree.Width = this.Width - pictureBoxHeaderRight.Image.Width - splitterVertical.Width;
					splitterVertical.Left = panelTree.Right + 1;
				}

				// Align sample title with the splitter
				labelSampleTitle.Left = splitterVertical.Right + 5;
				if(labelSampleTitle.Left < 264)
				{
					labelSampleTitle.Left = 264;
				}
				labelSampleTitle.Width = this.Width - labelSampleTitle.Left - 4;

				// Show hide LinkLabels if they are overlapped by the footer image
				//ShowHideFooterLinks();
			}
		}

		private void panelContent_Resize(object sender, System.EventArgs e)
		{
			// Sample tab page buttons need to be redrawn, so that background image is 
			// correctly aligned.
			foreach(VerticalTabPage tabPage in tabControlSample.TabPages)
			{
				tabPage.tabButton.Invalidate();
			}
		}

		private void linkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			// Launch associated URL in the Web Browser
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}
/*
		private void ShowHideFooterLinks()
		{
			// Show hide LinkLabels if they are overlapped by the footer image
			foreach(Control control in panelFooter.Controls)
			{
				if(control is LinkLabel)
				{
					bool	isVisible = true;
					if(control.Right + 8 > pictureBoxFooterRight.Left)
					{
						isVisible = false;
					}
						
					if(control.Visible != isVisible)
					{
						control.Visible = isVisible;
					}
				}
			}
		}
*/
		private void treeSamples_AfterCollapse(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			e.Node.ImageIndex = 0;
			e.Node.SelectedImageIndex = 0;
		}

		private void treeSamples_AfterExpand(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			e.Node.ImageIndex = 1;
			e.Node.SelectedImageIndex = 1;
		}

		private void contextMenuRTF_Popup(object sender, System.EventArgs e)
		{
			bool	copyEnabled = true;
			if(this.CurrentRichTextBox != null &&
				this.CurrentRichTextBox.SelectedText.Length == 0)
			{
				copyEnabled = false;
			}
			contextMenuRTF.MenuItems[0].Enabled = copyEnabled;
		}

		private void menuItemCopy_Click(object sender, System.EventArgs e)
		{
			if(this.CurrentRichTextBox != null)
			{
				Clipboard.SetDataObject(this.CurrentRichTextBox.SelectedText.Replace("\n", "\r\n"));
			}
		}

		private void menuItemCopyAll_Click(object sender, System.EventArgs e)
		{
			if(this.CurrentRichTextBox != null)
			{
				Clipboard.SetDataObject(this.CurrentRichTextBox.Text.Replace("\n", "\r\n"));
			}
		}

		#endregion	// Event handlers

		#region Dynamic content handling methods

		/// <summary>
		/// Fills specified tree with dynamically generated samples list.
		/// </summary>
		/// <param name="tree">Tree control to fill.</param>
		private void FillSamplesTree(TreeView tree)
		{
			// Loads sample XML data
			LoadInXMLData(applicationPath);

			// Fill samples tree
			tree.BeginUpdate();
			XmlNode rootNode = samplesContentXMLDoc["SampleContentList"];
			FillSampleListIntern(rootNode, tree.Nodes);
			tree.EndUpdate();

			// Prepare index list
			PrepareIndexInfoList();

			// Fill index list
			this.listBoxIndex.BeginUpdate();
			foreach(object obj in this.indexInfoList)
			{
				this.listBoxIndex.Items.Add(obj);
			}
			this.listBoxIndex.EndUpdate();
		}

		/// <summary>
		/// Prepare index info array list.
		/// </summary>
		private void PrepareIndexInfoList()
		{
			// Define item names
			for(int index = 0; index < this.indexInfoList.Count; index++)
			{
				IndexInfo indexInfo = (IndexInfo)this.indexInfoList[index];

				// Only for items with sub-key
				if(indexInfo.SubKey.Length > 0)
				{
					indexInfo.Name = "   " + indexInfo.SubKey;

					IndexInfo mainKeyInfo = new IndexInfo();
					mainKeyInfo.Key = indexInfo.Key;
					this.indexInfoList.Insert(index, mainKeyInfo);
					++index;
				}
			}

			// Remove duplicated items
			for(int index1 = 0; index1 < this.indexInfoList.Count; index1++)
			{
				IndexInfo indexInfo1 = (IndexInfo)this.indexInfoList[index1];
				for(int index2 = index1 + 1; index2 < this.indexInfoList.Count; index2++)
				{
					IndexInfo indexInfo2 = (IndexInfo)this.indexInfoList[index2];

					// Remove completly identical items
					if(indexInfo1.Key == indexInfo2.Key &&
						indexInfo1.SubKey == indexInfo2.SubKey)
					{
						if(indexInfo1.SampleInfo.sampleControl == indexInfo2.SampleInfo.sampleControl ||
							indexInfo2.SampleInfo.sampleControl.Length == 0)
						{
							this.indexInfoList.RemoveAt(index2);
							--index2;
						}
						else if(indexInfo1.SampleInfo.sampleControl.Length == 0)
						{
							this.indexInfoList.RemoveAt(index1);
							--index1;
							--index2;
						}
						
					}
				}

			}
			

			// Sort items in the list using Key + SubKey
			this.indexInfoList.Sort();
		}

		/// <summary>
		/// Searches all the sub directories within the given root directory for 'sampleConfig.xml' files
		/// Then adds the XML data to the master XML document under the 'Samples' root node
		/// </summary>
		/// <param name="rootDirectory"></param>
		private void LoadInXMLData(String rootDirectory)
		{

			//check to see if the master XML documents exist
			try
			{					
				StreamReader	fileIn;
				String			path;

				path = rootDirectory + "\\DynSampleConfig.xml";
				fileIn = new StreamReader(path);
				samplesContentXMLDoc = new XmlDocument();
				samplesContentXMLDoc.Load(fileIn);
				fileIn.Close();
			}

			catch
			{
				//prepare the master XML documents
				samplesXMLDoc = new XmlDocument();
				samplesXMLDoc.AppendChild(samplesXMLDoc.CreateElement("SampleList"));
				tocXMLDoc = new XmlDocument();
				tocXMLDoc.AppendChild(tocXMLDoc.CreateElement("TOC"));
				XmlAttribute newAttr = tocXMLDoc.CreateAttribute("ID");
				newAttr.Value = "Root";
				tocXMLDoc["TOC"].Attributes.Append(newAttr);

				//prepare the unique ID counter
				int uniqueID = 1;

				//start searching for all of the XML data files			
				SearchDirectories(rootDirectory, ref uniqueID);

				// Create samples content XML document
				samplesContentXMLDoc = new XmlDocument();
				samplesContentXMLDoc.AppendChild(samplesContentXMLDoc.CreateElement("SampleContentList"));
				XmlNode rootNode = tocXMLDoc["TOC"];
				XmlNode contentNode = samplesContentXMLDoc["SampleContentList"];
				FillSampleListXML(rootNode, contentNode);

				//save the master XML documents
				samplesContentXMLDoc.Save(rootDirectory + "\\DynSampleConfig.xml");
			}
		}
		
		private void SearchDirectories(String rootDirectory, ref int uniqueID)
		{
		
			StreamReader	fileIn;
			String[]		dirs;
			XmlDocument		doc;
			String			path;
			XmlAttribute	newAttr;
			
			dirs = Directory.GetDirectories(rootDirectory);

			for(int loop = 0; loop < dirs.Length; loop++)
			{
				// check and see if this directory has a "SampleConfig.xml" file
				// if so, then retrieve it, prepare it, and add it to the master 
				// samples XML document
				try
				{					
					//load in the XML data into an XmlDocument
					path = dirs[loop] + "\\sampleConfig.xml";
					fileIn = new StreamReader(path);
					doc = new XmlDocument();
					doc.Load(fileIn);
					fileIn.Close();
					
					XmlNode sampleNode = doc["SampleConfigs"];
					if(sampleNode != null)
						sampleNode = sampleNode["SampleConfig"];
					else
						sampleNode = doc["SampleConfig"];
					while(sampleNode != null)
					{
						if(sampleNode.Name == "SampleConfig")
						{
							//add the samples path to the node as an attribute
							newAttr = doc.CreateAttribute("Path");
							//newAttr.Value = dirs[loop].Remove(0, rootDirectory.Length+1);
							newAttr.Value = dirs[loop].Remove(0, this.applicationPath.Length+1);
							sampleNode.Attributes.Append(newAttr);
							//add the samples unique ID as an attribute
							newAttr = doc.CreateAttribute("ID");
							newAttr.Value = "Sample" + uniqueID.ToString();
							sampleNode.Attributes.Append(newAttr);
							uniqueID++;

							//add the node to the master XML doc
							InsertChildNodeByPriority(samplesXMLDoc, samplesXMLDoc.FirstChild, sampleNode); 
							// Old code: samplesXMLDoc.FirstChild.AppendChild(samplesXMLDoc.ImportNode(sampleNode,true));
						}

						//get the next sample node
						sampleNode = sampleNode.NextSibling;
					}					
				}
				catch
				{
					//just ignore if the file is not found
				}

				// check and see if this directory has a "TOCNodes.xml" file
				// if so, then retrieve it, prepare it, and add it to the master 
				// TOC XML document
				try
				{					
					//load in the XML data into an XmlDocument
					path = dirs[loop] + "\\TOCNodes.xml";
					fileIn = new StreamReader(path);
					doc = new XmlDocument();
					doc.Load(fileIn);
					fileIn.Close();

					InsertIntotocXMLDoc(doc,dirs[loop].Remove(0,rootDirectory.Length+1));
				}
				catch
				{
					//just ignore if the file is not found
				}

				//check for sub directories
				SearchDirectories(dirs[loop], ref uniqueID);
			}
		}

		private void InsertIntotocXMLDoc(XmlDocument nodes, String XmlFilePath)
		{

			XmlNodeList nodeList = nodes.GetElementsByTagName("TOCNode");
			for(int listLoop = 0; listLoop < nodeList.Count; listLoop++)
			{

				//add the path to each TOCNode as an attribute
				XmlAttribute newAttr = nodes.CreateAttribute("Path");
				newAttr.Value = XmlFilePath;
				nodeList[listLoop].Attributes.Append(newAttr);

				//get the priority
				int priority = 0;
				if(nodeList[listLoop].Attributes["Priority"] != null)
					priority = int.Parse(nodeList[listLoop].Attributes["Priority"].Value);

				//find the items parent node
				XmlNode parentNode = tocXMLDoc["TOC"];
				if(nodeList[listLoop].Attributes["ParentNodeID"] != null)
				{
					parentNode = FindNodeByAttribute(tocXMLDoc,"ID",
						nodeList[listLoop].Attributes["ParentNodeID"].Value);
				}
				if(parentNode == null)
					continue;

				//find where to insert the node (by priority)
				XmlNode XmlSiblingNode = parentNode.FirstChild;

				//if there are no child nodes already then at it as the first child
				if(XmlSiblingNode == null)
				{
					parentNode.AppendChild(tocXMLDoc.ImportNode(nodeList[listLoop],true));
				}

				//otherwise search through the list of child nodes and add it in order of priority
				while(XmlSiblingNode != null)
				{
					if(XmlSiblingNode.Name == "TOCNode")
					{
						int sibPriority = int.Parse(XmlSiblingNode.Attributes["Priority"].Value);
						if(priority < sibPriority)
						{
							XmlSiblingNode.ParentNode.InsertBefore(tocXMLDoc.ImportNode(nodeList[listLoop],true),
								XmlSiblingNode);
							break;
						}
					}

					if(XmlSiblingNode.NextSibling == null)
					{
						XmlSiblingNode.ParentNode.InsertAfter(tocXMLDoc.ImportNode(nodeList[listLoop],true),
							XmlSiblingNode);
						break;
					}
					XmlSiblingNode = XmlSiblingNode.NextSibling;
				}
			}					
		}

		public XmlNode FindNodeByAttribute(XmlNode nodes, String attrib, String val)
		{
			bool bPrevFound = true;
			return FindNextNodeByAttributeIntern(null,nodes, attrib, val, ref bPrevFound);			
		}

		public XmlNode FindNextNodeByAttribute(XmlNode prevNode,XmlNode nodes, String attrib, String val)
		{
			bool bPrevFound = false;
			return FindNextNodeByAttributeIntern(prevNode,nodes, attrib, val, ref bPrevFound);
		}

		private XmlNode FindNextNodeByAttributeIntern(XmlNode prevNode,XmlNode nodes, String attrib, String val, ref bool bPrevFound)
		{
			XmlNode node;

			if(nodes.HasChildNodes == false)
				return null;
			
			node = nodes.FirstChild;

			while(node != null)
			{
				if(node.Attributes != null &&
					node.Attributes[attrib] != null &&
					node.Attributes[attrib].Value == val)
				{
					if(bPrevFound)
						return node;
					else if(node == prevNode)
						bPrevFound = true;
				}

				if(node.HasChildNodes)
				{
					XmlNode returnNode = FindNextNodeByAttributeIntern(prevNode,node,attrib,val,ref bPrevFound);
					if(returnNode != null)
					{
						return returnNode;
					}					  
				}
				node = node.NextSibling;
			}
			return null;
		}


		private void InsertChildNodeByPriority(XmlDocument xmlDoc, XmlNode parentNode, XmlNode childNode)
		{
			//get the priority of this child Node
			int priority = 10000;
			if(childNode.Attributes["Priority"] != null)
			{
				priority = int.Parse(childNode.Attributes["Priority"].Value);
			}

			//find where to insert the node (by priority)
			XmlNode XmlSiblingNode = parentNode.FirstChild;

			//if there are no child nodes already then at it as the first child
			if(XmlSiblingNode == null)
			{
				parentNode.AppendChild(xmlDoc.ImportNode(childNode,true));
			}
			//otherwise search through the list of child nodes and add it in order of priority
			while(XmlSiblingNode != null)
			{
				string ss = XmlSiblingNode.Attributes["ParentNodeID"].Value;
				if(XmlSiblingNode.Name == childNode.Name)
				{
					int sibPriority = 10000;
					if(XmlSiblingNode.Attributes["Priority"] != null)
					{
						sibPriority = int.Parse(XmlSiblingNode.Attributes["Priority"].Value);
					}
					if(priority < sibPriority)
					{
						XmlSiblingNode.ParentNode.InsertBefore(xmlDoc.ImportNode(childNode,true),XmlSiblingNode);
						break;
					}
				}
				if(XmlSiblingNode.NextSibling == null)
				{
					XmlSiblingNode.ParentNode.InsertAfter(xmlDoc.ImportNode(childNode,true),XmlSiblingNode);
					break;
				}
				XmlSiblingNode = XmlSiblingNode.NextSibling;
			}
		}					
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="TOCnode"></param>
		/// <param name="tree"></param>
		/// <param name="level"></param>
		private void FillSampleListIntern(XmlNode TOCnode, TreeNodeCollection nodes)
		{
			// Loop through all XML nodes
			int nodeID = 0;
			XmlNode node = TOCnode.FirstChild;			
			while(node != null)
			{
				if(node.Name == "TOCNode")
				{
					// Add node into the tree
					nodeID = nodes.Add(new TreeNode(node.Attributes["Title"].Value));

					// Add all child nodes
					FillSampleListIntern(node, nodes[nodeID].Nodes);
				}
				else if(node.Name == "SampleConfig")
				{
					// Add node into the tree
					nodeID = nodes.Add(new TreeNode(node["Title"].InnerText));

					// Create sample information object
					if(node["SampleControl"] != null)
					{
						SampleInfo	sampleInfo = new SampleInfo();
						sampleInfo.sampleControl = node["SampleControl"].InnerText;
						sampleInfo.path = node.Attributes["Path"].Value;
						if(node["Keywords"] != null)
							sampleInfo.keywords = node["Keywords"].InnerText;
						if(node["ShortBlurb"] != null)
							sampleInfo.shortBlurb = node["ShortBlurb"].InnerText;
						if(node["Thumbnail"] != null)
							sampleInfo.thumbnail = node["Thumbnail"].InnerText;
						if(node["Title"] != null)
							sampleInfo.title = node["Title"].InnerText;
						
						// Fill info pages list
						XmlNode nodeInfoPages = node["InfoPages"];
						if(nodeInfoPages != null && nodeInfoPages.HasChildNodes)
						{
							XmlNode nodeInfo = nodeInfoPages.FirstChild;			
							while(nodeInfo != null)
							{
								if(nodeInfo.Name == "InfoPage")
								{
									InfoPage newInfoPage = new InfoPage();
									newInfoPage.title = nodeInfo.Attributes["Title"].Value;
									newInfoPage.data = nodeInfo.InnerText;
									sampleInfo.infoPages.Add(newInfoPage);
								}

								nodeInfo = nodeInfo.NextSibling;
							}
						}

						// Fill keywords array
						XmlNode nodeKeywords = node["Keywords"];
						if(nodeKeywords != null && nodeKeywords.HasChildNodes)
						{
							XmlNode nodeInfo = nodeKeywords.FirstChild;			
							while(nodeInfo != null)
							{
								if(nodeInfo.Name == "Keyword")
								{
									IndexInfo indexInfo = new IndexInfo();
									indexInfo.SampleInfo = sampleInfo;
									indexInfo.Key = nodeInfo.InnerText.Trim();

									// Check if string has a sub index separated with comma
									int commaIndex = indexInfo.Key.IndexOf(',');
									if(commaIndex > 0)
									{
										indexInfo.SubKey = indexInfo.Key.Substring(commaIndex + 1).Trim();
										indexInfo.Key = indexInfo.Key.Substring(0, commaIndex).Trim();
									}

									this.indexInfoList.Add(indexInfo);
								}

								nodeInfo = nodeInfo.NextSibling;
							}
						}

						// Add sample information to the tree node
						nodes[nodeID].Tag = sampleInfo;

						// Set node image
						int imageIndex = 2;
						if(sampleInfo.infoPages != null && 
							sampleInfo.infoPages.Count == 1)
						{
							InfoPage infoPage = (InfoPage)sampleInfo.infoPages[0];
							if(infoPage.title == "Gallery")
							{
								// Set Gallery list image
								imageIndex = 3;
							}
							else if(infoPage.title == "Overview")
							{
								// Set Gallery list image
								imageIndex = 4;
							}
						}
						nodes[nodeID].ImageIndex = imageIndex;
						nodes[nodeID].SelectedImageIndex = imageIndex;
					}
				}

				// Get next node
				node = node.NextSibling;
			}
		}

		private void FillSampleListXML(XmlNode TOCnode, XmlNode nodeParent)
		{
			// Add all child sample nodes			
			XmlNode sampleNode = FindNodeByAttribute(samplesXMLDoc, "ParentNodeID", TOCnode.Attributes["ID"].Value);
			while(sampleNode != null)
			{
				if(sampleNode.Name == "SampleConfig")
				{
					// Add child item into the XML
					nodeParent.AppendChild(nodeParent.OwnerDocument.ImportNode(sampleNode, true));
				}

				// Find next child node
				sampleNode = FindNextNodeByAttribute(sampleNode, samplesXMLDoc, "ParentNodeID",TOCnode.Attributes["ID"].Value);
			}


			XmlNode node = TOCnode.FirstChild;			
			while(node != null)
			{
				if(node.Name == "TOCNode")
				{
					sampleNode = FindNodeByAttribute(samplesXMLDoc, "ParentNodeID",node.Attributes["ID"].Value);

					//headers 
					XmlNode	newTOCNode = null;
					if(node["TOCNode"] != null || sampleNode != null)
					{
						//*** Position TOC node in the parent node depending on its priority

						// Get node priority 
						int priority = 20000;
						if(node.Attributes["Priority"] != null)
						{
							priority = int.Parse(node.Attributes["Priority"].Value);
						}

						// Check if node should be moved
						XmlNode moveBeforeNode = null;
						XmlNode currentNode = nodeParent.LastChild;
						while(currentNode != null)
						{
							if(currentNode.Name == "SampleConfig")
							{
								int currentPriority = 10000;
								if(currentNode.Attributes["Priority"] != null)
								{
									currentPriority = int.Parse(currentNode.Attributes["Priority"].Value);
								}

								if(priority < currentPriority)
								{
									moveBeforeNode = currentNode;
								}
							}
							currentNode = currentNode.PreviousSibling;
						}


						// Add child item into the XML
						if(moveBeforeNode == null)
						{
							newTOCNode = nodeParent.AppendChild(nodeParent.OwnerDocument.ImportNode(node, false));
						}
						else
						{
							newTOCNode = nodeParent.InsertBefore(nodeParent.OwnerDocument.ImportNode(node, false), moveBeforeNode);
						}

						// Add Title attribute
						XmlAttribute newAttr = nodeParent.OwnerDocument.CreateAttribute("Title");
						newAttr.Value = node["Title"].InnerText;
						newTOCNode.Attributes.Append(newAttr);

						// Fill child items
						FillSampleListXML(node, newTOCNode);
					}
				}

				node = node.NextSibling;
			}
		}

		#endregion

		#region Helper classes

		/// <summary>
		/// Sample description data structure.
		/// </summary>
		public class SampleInfo
		{
			public	string		sampleControl = "";
			public	string		keywords = "";
			public	string		shortBlurb = "";
			public	string		thumbnail = "";
			public	string		title = "";
			public	string		path = "";
			public	ArrayList	infoPages = new ArrayList();
		}

		/// <summary>
		/// Index item data structure.
		/// </summary>
		public class IndexInfo : IComparable
		{
			public	SampleInfo	SampleInfo = new SampleInfo();
			public	string		Key = "";
			public	string		SubKey = "";
			public	string		Name = "";

			/// <summary>
			/// Converts index item to string.
			/// </summary>
			/// <returns>Name of index.</returns>
			public override string ToString()
			{
				if(this.Name.Length > 0)
				{
					return this.Name;
				}

				if(this.SubKey.Length == 0)
				{
					return this.Key;
				}

				return this.Key + " - " + this.SubKey;
			}

			/// <summary>
			/// Compares two index items. Used in sorting
			/// </summary>
			/// <param name="obj">Second class.</param>
			/// <returns>Comparing result.</returns>
			public int CompareTo(object obj)
			{
				if(obj is IndexInfo)
				{
					IndexInfo info2 = (IndexInfo)obj;
					if(this.Key != info2.Key)
					{
						return this.Key.CompareTo(info2.Key);
					}
					return this.SubKey.CompareTo(info2.SubKey);
				}
				return 0;
			}
		}

		/// <summary>
		/// Source code and other infomational page data
		/// </summary>
		public class InfoPage
		{
			public	string		title = "";
			public	string		data = "";
		}

	#endregion
	}
}
