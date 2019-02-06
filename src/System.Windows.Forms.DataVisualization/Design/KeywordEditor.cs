// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	A keyword editor form. Allows the end user to insert
//				new and edit exsisting keywords in the string.
//


using System.Collections;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{
    /// <summary>
    /// Summary description for KeywordEditor.
    /// </summary>
    internal class KeywordEditor : System.Windows.Forms.Form
	{
		#region Fields

		/// <summary>
		/// List of keywords that are applicable to the edited property
		/// </summary>
		private ArrayList _applicableKeywords = null;

		/// <summary>
		/// Keyword beign edited or empty if inserting a new one.
		/// </summary>
		internal string Keyword = string.Empty;

		/// <summary>
		/// Maximum number of supported Y values.
		/// </summary>
		private	int		_maxYValueIndex = 9;

		// Form fields
		private System.Windows.Forms.GroupBox _groupBoxKeywords;
		private System.Windows.Forms.ListBox _listBoxKeywords;
		private System.Windows.Forms.GroupBox _groupBoxDescription;
		private System.Windows.Forms.Label _labelDescription;
		private System.Windows.Forms.Button _buttonCancel;
		private System.Windows.Forms.Button _buttonOk;
		private System.Windows.Forms.GroupBox _groupBoxFormat;
		private System.Windows.Forms.Label _labelFormat;
		private System.Windows.Forms.NumericUpDown _numericUpDownYValue;
		private System.Windows.Forms.Label _labelYValue;
		private System.Windows.Forms.ComboBox _comboBoxFormat;
		private System.Windows.Forms.Label _labelPrecision;
		private System.Windows.Forms.TextBox _textBoxCustomFormat;
		private System.Windows.Forms.Label _labelCustomFormat;
		private System.Windows.Forms.Label _labelSample;
		private System.Windows.Forms.TextBox _textBoxSample;
		private System.Windows.Forms.TextBox _textBoxPrecision;
		private System.Windows.Forms.ToolTip _toolTip;
		private System.ComponentModel.IContainer _components;

        // resolved VSTS by extending the dialog by 36x28 pixels.
        // 5767	FRA: ChartAPI: String "Format Sample:" is  truncated on the "Keywords Editor'	
        // 4383	DEU: VC/VB/VCS/VWD: ChartAPI: The string "If a chart type supports..." is truncated on the 'Keyword Editor' dialog.
        // 3524	DEU: VC/VB/VCS/VWD: ChartAPI: The string "If a chart type supports..." is truncated on the 'Keyword Editor' dialog.

		private static int widthDialogExtend = 80;
		private static int heightDialogExtend = 38;

		#endregion // Fields

		#region Constructors

		/// <summary>
		/// Default public constructor.
		/// </summary>
		public KeywordEditor()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			PrepareControlsLayout();
		}

		/// <summary>
		/// Form constructor.
		/// </summary>
		/// <param name="applicableKeywords">List of keywords that can be inserted.</param>
		/// <param name="keyword">Keyword that should be edited.</param>
		/// <param name="maxYValueIndex">Maximum number of Y Values supported.</param>
		public KeywordEditor(ArrayList applicableKeywords, string keyword, int maxYValueIndex) : this()
		{
			// Save input data
			this._applicableKeywords = applicableKeywords;
			this.Keyword = keyword;
			this._maxYValueIndex = maxYValueIndex;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(_components != null)
				{
					_components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion // Constructors

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._components = new System.ComponentModel.Container();
			this._groupBoxKeywords = new System.Windows.Forms.GroupBox();
			this._listBoxKeywords = new System.Windows.Forms.ListBox();
			this._groupBoxDescription = new System.Windows.Forms.GroupBox();
			this._labelDescription = new System.Windows.Forms.Label();
			this._buttonCancel = new System.Windows.Forms.Button();
			this._buttonOk = new System.Windows.Forms.Button();
			this._groupBoxFormat = new System.Windows.Forms.GroupBox();
			this._textBoxPrecision = new System.Windows.Forms.TextBox();
			this._labelSample = new System.Windows.Forms.Label();
			this._textBoxSample = new System.Windows.Forms.TextBox();
			this._numericUpDownYValue = new System.Windows.Forms.NumericUpDown();
			this._labelYValue = new System.Windows.Forms.Label();
			this._comboBoxFormat = new System.Windows.Forms.ComboBox();
			this._labelPrecision = new System.Windows.Forms.Label();
			this._labelFormat = new System.Windows.Forms.Label();
			this._labelCustomFormat = new System.Windows.Forms.Label();
			this._textBoxCustomFormat = new System.Windows.Forms.TextBox();
			this._toolTip = new System.Windows.Forms.ToolTip(this._components);
			this._groupBoxKeywords.SuspendLayout();
			this._groupBoxDescription.SuspendLayout();
			this._groupBoxFormat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._numericUpDownYValue)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxKeywords
			// 
			this._groupBoxKeywords.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this._listBoxKeywords});
			this._groupBoxKeywords.Location = new System.Drawing.Point(8, 16);
			this._groupBoxKeywords.Name = "groupBoxKeywords";
			this._groupBoxKeywords.Size = new System.Drawing.Size(216, 232);
			this._groupBoxKeywords.TabIndex = 0;
			this._groupBoxKeywords.TabStop = false;
            this._groupBoxKeywords.Text = SR.LabelKeyKeywords;
			// 
			// listBoxKeywords
			// 
			this._listBoxKeywords.Location = new System.Drawing.Point(8, 24);
			this._listBoxKeywords.Name = "listBoxKeywords";
			this._listBoxKeywords.Size = new System.Drawing.Size(200, 199);
			this._listBoxKeywords.TabIndex = 0;
			this._listBoxKeywords.DoubleClick += new System.EventHandler(this.listBoxKeywords_DoubleClick);
			this._listBoxKeywords.SelectedIndexChanged += new System.EventHandler(this.listBoxKeywords_SelectedIndexChanged);
			// 
			// groupBoxDescription
			// 
			this._groupBoxDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this._labelDescription});
			this._groupBoxDescription.Location = new System.Drawing.Point(240, 16);
			this._groupBoxDescription.Name = "groupBoxDescription";
			this._groupBoxDescription.Size = new System.Drawing.Size(328, 88);
			this._groupBoxDescription.TabIndex = 1;
			this._groupBoxDescription.TabStop = false;
            this._groupBoxDescription.Text = SR.LabelDescription;
			// 
			// labelDescription
			// 
			this._labelDescription.Location = new System.Drawing.Point(16, 24);
			this._labelDescription.Name = "labelDescription";
			this._labelDescription.Size = new System.Drawing.Size(304, 56);
			this._labelDescription.TabIndex = 0;
			this._labelDescription.Text = "<replaced at runtime>";
			// 
			// buttonCancel
			// 
			this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(479, 256);
			this._buttonCancel.Name = "buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(90, 27);
			this._buttonCancel.TabIndex = 4;
            this._buttonCancel.Text = SR.LabelButtonCancel;
			// 
			// buttonOk
			// 
			this._buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._buttonOk.Location = new System.Drawing.Point(367, 256);
			this._buttonOk.Name = "buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(90, 27);
			this._buttonOk.TabIndex = 3;
            this._buttonOk.Text = SR.LabelButtonOk;
			this._buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// groupBoxFormat
			// 
			this._groupBoxFormat.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this._textBoxPrecision,
																						 this._labelSample,
																						 this._textBoxSample,
																						 this._numericUpDownYValue,
																						 this._labelYValue,
																						 this._comboBoxFormat,
																						 this._labelPrecision,
																						 this._labelFormat,
																						 this._labelCustomFormat,
																						 this._textBoxCustomFormat});
			this._groupBoxFormat.Location = new System.Drawing.Point(240, 112);
			this._groupBoxFormat.Name = "groupBoxFormat";
			this._groupBoxFormat.Size = new System.Drawing.Size(328, 136);
			this._groupBoxFormat.TabIndex = 2;
			this._groupBoxFormat.TabStop = false;
            this._groupBoxFormat.Text = SR.LabelValueFormatting;
			// 
			// textBoxPrecision
			// 
			this._textBoxPrecision.Location = new System.Drawing.Point(112, 48);
			this._textBoxPrecision.Name = "textBoxPrecision";
			this._textBoxPrecision.Size = new System.Drawing.Size(64, 20);
			this._textBoxPrecision.TabIndex = 3;
			this._textBoxPrecision.Text = "";
			this._textBoxPrecision.TextChanged += new System.EventHandler(this.textBoxPrecision_TextChanged);
			// 
			// labelSample
			// 
			this._labelSample.Location = new System.Drawing.Point(8, 72);
			this._labelSample.Name = "labelSample";
			this._labelSample.Size = new System.Drawing.Size(96, 23);
			this._labelSample.TabIndex = 7;
            this._labelSample.Text = SR.LabelFormatKeySample;
			this._labelSample.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxSample
			// 
			this._textBoxSample.Location = new System.Drawing.Point(112, 72);
			this._textBoxSample.Name = "textBoxSample";
			this._textBoxSample.ReadOnly = true;
			this._textBoxSample.Size = new System.Drawing.Size(192, 20);
			this._textBoxSample.TabIndex = 8;
			this._textBoxSample.Text = "";
			// 
			// numericUpDownYValue
			// 
			this._numericUpDownYValue.CausesValidation = false;
			this._numericUpDownYValue.Location = new System.Drawing.Point(112, 104);
			this._numericUpDownYValue.Maximum = new System.Decimal(new int[] {
																				9,
																				0,
																				0,
																				0});
			this._numericUpDownYValue.Name = "numericUpDownYValue";
			this._numericUpDownYValue.Size = new System.Drawing.Size(64, 20);
			this._numericUpDownYValue.TabIndex = 10;
			this._numericUpDownYValue.ValueChanged += new System.EventHandler(this.numericUpDownYValue_ValueChanged);
			// 
			// labelYValue
			// 
			this._labelYValue.Location = new System.Drawing.Point(8, 104);
			this._labelYValue.Name = "labelYValue";
			this._labelYValue.Size = new System.Drawing.Size(96, 23);
			this._labelYValue.TabIndex = 9;
            this._labelYValue.Text = SR.LabelKeyYValueIndex;
			this._labelYValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxFormat
			// 
			this._comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._comboBoxFormat.Items.AddRange(new object[] {
																SR.DescriptionTypeNone,
																SR.DescriptionNumberFormatTypeCurrency,
																SR.DescriptionNumberFormatTypeDecimal,
																SR.DescriptionNumberFormatTypeScientific,
																SR.DescriptionNumberFormatTypeFixedPoint,
																SR.DescriptionNumberFormatTypeGeneral,
																SR.DescriptionNumberFormatTypeNumber,
																SR.DescriptionNumberFormatTypePercent,
																SR.DescriptionTypeCustom});

    		this._comboBoxFormat.Location = new System.Drawing.Point(112, 24);
			this._comboBoxFormat.MaxDropDownItems = 10;
			this._comboBoxFormat.Name = "comboBoxFormat";
			this._comboBoxFormat.Size = new System.Drawing.Size(192, 21);
			this._comboBoxFormat.TabIndex = 1;
			this._comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormat_SelectedIndexChanged);
			// 
			// labelPrecision
			// 
			this._labelPrecision.Location = new System.Drawing.Point(8, 48);
			this._labelPrecision.Name = "labelPrecision";
			this._labelPrecision.Size = new System.Drawing.Size(96, 23);
			this._labelPrecision.TabIndex = 2;
            this._labelPrecision.Text = SR.LabelKeyPrecision;
			this._labelPrecision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelFormat
			// 
			this._labelFormat.Location = new System.Drawing.Point(8, 24);
			this._labelFormat.Name = "labelFormat";
			this._labelFormat.Size = new System.Drawing.Size(96, 23);
			this._labelFormat.TabIndex = 0;
            this._labelFormat.Text = SR.LabelKeyFormat;
			this._labelFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelCustomFormat
			// 
			this._labelCustomFormat.Location = new System.Drawing.Point(8, 48);
			this._labelCustomFormat.Name = "labelCustomFormat";
			this._labelCustomFormat.Size = new System.Drawing.Size(96, 23);
			this._labelCustomFormat.TabIndex = 4;
            this._labelCustomFormat.Text = SR.LabelKeyCustomFormat;
			this._labelCustomFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._labelCustomFormat.Visible = false;
			// 
			// textBoxCustomFormat
			// 
			this._textBoxCustomFormat.Location = new System.Drawing.Point(112, 48);
			this._textBoxCustomFormat.Name = "textBoxCustomFormat";
			this._textBoxCustomFormat.Size = new System.Drawing.Size(192, 20);
			this._textBoxCustomFormat.TabIndex = 5;
			this._textBoxCustomFormat.Text = "";
			this._textBoxCustomFormat.Visible = false;
			this._textBoxCustomFormat.TextChanged += new System.EventHandler(this.textBoxCustomFormat_TextChanged);
			// 
			// KeywordEditor
			// 
			this.AcceptButton = this._buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this._buttonCancel;
			this.ClientSize = new System.Drawing.Size(578, 295);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._groupBoxFormat,
																		  this._buttonCancel,
																		  this._buttonOk,
																		  this._groupBoxDescription,
																		  this._groupBoxKeywords});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "KeywordEditor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = SR.LabelKeywordEditor;
			this.Load += new System.EventHandler(this.KeywordEditor_Load);
			this._groupBoxKeywords.ResumeLayout(false);
			this._groupBoxDescription.ResumeLayout(false);
			this._groupBoxFormat.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._numericUpDownYValue)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers

		/// <summary>
		/// Form loaded event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void KeywordEditor_Load(object sender, System.EventArgs e)
		{
			// Set restriction on the Y Value index editor
			if(this._maxYValueIndex >= 0 && this._maxYValueIndex < 10)
			{
				this._numericUpDownYValue.Maximum = this._maxYValueIndex;
			}
			this._numericUpDownYValue.Enabled = this._maxYValueIndex > 0;
			this._labelYValue.Enabled = this._maxYValueIndex > 0;

			// Set tooltip for custom format
            this._toolTip.SetToolTip(this._textBoxCustomFormat, SR.DescriptionToolTipCustomFormatCharacters);

			// Select format None
			this._comboBoxFormat.SelectedIndex = 0;

			// Fill list of applicable keywords
			if(this._applicableKeywords != null)
			{
				foreach(KeywordInfo keywordInfo in this._applicableKeywords)
				{
					this._listBoxKeywords.Items.Add(keywordInfo);
				}
			}

			// Check if keyword for editing was specified
			if(this.Keyword.Length == 0)
			{
				this._listBoxKeywords.SelectedIndex = 0;
				this._comboBoxFormat.SelectedIndex = 0;
			}
			else
			{
				// Iterate through all keywords and find a match
				bool itemFound = false;
				foreach(KeywordInfo keywordInfo in this._applicableKeywords)
				{
					// Iterate through all possible keyword names
					string[] keywordNames = keywordInfo.GetKeywords();
					foreach(string keywordName in keywordNames)
					{
						if(this.Keyword.StartsWith(keywordName, StringComparison.Ordinal))
						{
							// Select keyword in the list
							this._listBoxKeywords.SelectedItem = keywordInfo;
							int keywordLength = keywordName.Length;

							// Check if keyword support multiple Y values
							if(keywordInfo.SupportsValueIndex)
							{
								if(this.Keyword.Length > keywordLength &&
									this.Keyword[keywordLength] == 'Y')
								{
									++keywordLength;
									if(this.Keyword.Length > (keywordLength) &&
										char.IsDigit(this.Keyword[keywordLength]))
									{
										int yValueIndex = int.Parse(this.Keyword.Substring(keywordLength, 1), CultureInfo.InvariantCulture);
										if(yValueIndex < 0 || yValueIndex > this._maxYValueIndex)
										{
											yValueIndex = 0;
										}
										_numericUpDownYValue.Value = yValueIndex;
										++keywordLength;
									}
								}
							}

							// Check if keyword support format string
							if(keywordInfo.SupportsFormatting)
							{
								if(this.Keyword.Length > keywordLength &&
									this.Keyword[keywordLength] == '{' &&
									this.Keyword.EndsWith("}", StringComparison.Ordinal))
								{
									// Get format string
									string format = this.Keyword.Substring(keywordLength + 1, this.Keyword.Length - keywordLength - 2);

									if(format.Length == 0)
									{
										// Select format None
										this._comboBoxFormat.SelectedIndex = 0;
									}
									else
									{
										// Check if format string is custom
										if(format.Length == 1 ||
											(format.Length == 2 && char.IsDigit(format[1])) ||
											(format.Length == 3 && char.IsDigit(format[2])) )
										{
											if(format[0] == 'C')
											{
												this._comboBoxFormat.SelectedIndex = 1;
											}
											else if(format[0] == 'D')
											{
												this._comboBoxFormat.SelectedIndex = 2;
											}
											else if(format[0] == 'E')
											{
												this._comboBoxFormat.SelectedIndex = 3;
											}
											else if(format[0] == 'F')
											{
												this._comboBoxFormat.SelectedIndex = 4;
											}
											else if(format[0] == 'G')
											{
												this._comboBoxFormat.SelectedIndex = 5;
											}
											else if(format[0] == 'N')
											{
												this._comboBoxFormat.SelectedIndex = 6;
											}
											else if(format[0] == 'P')
											{
												this._comboBoxFormat.SelectedIndex = 7;
											}
											else
											{
												// Custom format
												this._comboBoxFormat.SelectedIndex = 8;
												this._textBoxCustomFormat.Text = format;
											}

											// Get precision
											if(this._comboBoxFormat.SelectedIndex != 8 && format.Length > 0)
											{
												this._textBoxPrecision.Text = format.Substring(1);
											}
										}
										else
										{
											// Custom format
											this._comboBoxFormat.SelectedIndex = 8;
											this._textBoxCustomFormat.Text = format;
										}
									}
								}
							}

							// Stop iteration
							itemFound = true;
							break;
						}
					}

					// Break from the keywords loop
					if(itemFound)
					{
						break;
					}
				}
			}
		}

		/// <summary>
		/// Selected format changed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void comboBoxFormat_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Format disabled
			_labelCustomFormat.Enabled = (this._comboBoxFormat.SelectedIndex > 0);
			_textBoxCustomFormat.Enabled = (this._comboBoxFormat.SelectedIndex > 0);
			_labelPrecision.Enabled = (this._comboBoxFormat.SelectedIndex > 0);
			_textBoxPrecision.Enabled = (this._comboBoxFormat.SelectedIndex > 0);
			_labelSample.Enabled = (this._comboBoxFormat.SelectedIndex > 0);
			_textBoxSample.Enabled = (this._comboBoxFormat.SelectedIndex > 0);

			// Hide show form control depending on the format selection
			bool customFormat = ((string)_comboBoxFormat.SelectedItem == "Custom");
			_labelCustomFormat.Visible = customFormat;
			_textBoxCustomFormat.Visible = customFormat;
			_labelPrecision.Visible = !customFormat;
			_textBoxPrecision.Visible = !customFormat;

			// Update format sample
			this.UpdateNumericSample();
		}


		/// <summary>
		/// Selected keyword changed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void listBoxKeywords_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Get selected keyword
			KeywordInfo keywordInfo = _listBoxKeywords.SelectedItem as KeywordInfo;
			if(keywordInfo != null)
			{
				// Show description of the selected keyword
				this._labelDescription.Text = keywordInfo.Description.Replace("\\n", "\n");

				// Check if keyword support value formatting
				_groupBoxFormat.Enabled = keywordInfo.SupportsFormatting;

				// Check if keyword support Y value index
				_labelYValue.Enabled = keywordInfo.SupportsValueIndex;
				_numericUpDownYValue.Enabled = keywordInfo.SupportsValueIndex && this._maxYValueIndex > 0;
				this._labelYValue.Enabled = keywordInfo.SupportsValueIndex && this._maxYValueIndex > 0;
			}

		}

		/// <summary>
		/// Keyword double click event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void listBoxKeywords_DoubleClick(object sender, System.EventArgs e)
		{
			// Simulate accept button click when user double clicks in the list
			this.AcceptButton.PerformClick();
		}

		/// <summary>
		/// Precision text changed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void textBoxPrecision_TextChanged(object sender, System.EventArgs e)
		{
            MessageBoxOptions messageBoxOptions = 0;
            if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                messageBoxOptions = MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading;
            }

			if(this._textBoxPrecision.Text.Length >= 1 && !char.IsDigit(this._textBoxPrecision.Text[0]))
			{
                MessageBox.Show(this, SR.MessagePrecisionInvalid, SR.MessageChartTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, messageBoxOptions);
				this._textBoxPrecision.Text = "";
			}
			else if(this._textBoxPrecision.Text.Length >= 2 && (!char.IsDigit(this._textBoxPrecision.Text[0]) || !char.IsDigit(this._textBoxPrecision.Text[1])))
			{
                MessageBox.Show(this, SR.MessagePrecisionInvalid, SR.MessageChartTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, messageBoxOptions);
				this._textBoxPrecision.Text = "";
			}

			this.UpdateNumericSample();
		}

		/// <summary>
		/// Custom format text changed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void textBoxCustomFormat_TextChanged(object sender, System.EventArgs e)
		{
			this.UpdateNumericSample();
		}

		/// <summary>
		/// Ok button click event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void buttonOk_Click(object sender, System.EventArgs e)
		{
			// Generate new keyword
			this.Keyword = string.Empty;

			// Get selected keyword
			KeywordInfo keywordInfo = this._listBoxKeywords.SelectedItem as KeywordInfo;
			if(keywordInfo != null)
			{
				this.Keyword = keywordInfo.Keyword;

				if(keywordInfo.SupportsValueIndex && 
					(int)_numericUpDownYValue.Value > 0)
				{
					this.Keyword += "Y" + ((int)_numericUpDownYValue.Value).ToString(CultureInfo.InvariantCulture);
				}
				if(keywordInfo.SupportsFormatting && 
					_comboBoxFormat.SelectedIndex > 0 &&
					this.GetFormatString().Length > 0)
				{
					this.Keyword += "{" + this.GetFormatString() + "}";
				}
			}
		}

		/// <summary>
		/// Y Value index changed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void numericUpDownYValue_ValueChanged(object sender, System.EventArgs e)
		{
			if(_numericUpDownYValue.Value > this._maxYValueIndex && _numericUpDownYValue.Value < 0)
			{
                MessageBoxOptions messageBoxOptions = 0;
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    messageBoxOptions = MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading;
                }

                MessageBox.Show(this, SR.MessageYValueIndexInvalid(this._maxYValueIndex.ToString(CultureInfo.CurrentCulture)), SR.MessageChartTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, messageBoxOptions);

				_numericUpDownYValue.Value = 0;
			}
		}

		#endregion // Event Handlers

		#region Helper Methods

		/// <summary>
		/// Gets current format string
		/// </summary>
		/// <returns></returns>
		private string GetFormatString()
		{
			string formatString = string.Empty;
			if(this._comboBoxFormat.Enabled &&
				this._comboBoxFormat.SelectedIndex == 1)
			{
				formatString = "C" + _textBoxPrecision.Text;
			}
			else if(this._comboBoxFormat.SelectedIndex == 2)
			{
				formatString = "D" + _textBoxPrecision.Text;
			}
			else if(this._comboBoxFormat.SelectedIndex == 3)
			{
				formatString = "E" + _textBoxPrecision.Text;
			}
			else if(this._comboBoxFormat.SelectedIndex == 4)
			{
				formatString = "G" + _textBoxPrecision.Text;
			}
			else if(this._comboBoxFormat.SelectedIndex == 5)
			{
				formatString = "G" + _textBoxPrecision.Text;
			}
			else if(this._comboBoxFormat.SelectedIndex == 6)
			{
				formatString = "N" + _textBoxPrecision.Text;
			}
			else if(this._comboBoxFormat.SelectedIndex == 7)
			{
				formatString = "P" + _textBoxPrecision.Text;
			}
			else if(this._comboBoxFormat.SelectedIndex == 8)
			{
				formatString = this._textBoxCustomFormat.Text;
			}

			return formatString;
		}

		/// <summary>
		/// Updates numeric sample on the form.
		/// </summary>
		private void UpdateNumericSample()
		{
			string formatString = this.GetFormatString();
			if(this._comboBoxFormat.SelectedIndex == 0)
			{
				// No format
				_textBoxSample.Text = string.Empty;
			}
			else if(this._comboBoxFormat.SelectedIndex == 1)
			{
				_textBoxSample.Text = String.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
			}
			else if(this._comboBoxFormat.SelectedIndex == 2)
			{
                _textBoxSample.Text = String.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345);
			}
			else if(this._comboBoxFormat.SelectedIndex == 3)
			{
                _textBoxSample.Text = String.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
			}
			else if(this._comboBoxFormat.SelectedIndex == 4)
			{
                _textBoxSample.Text = String.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
			}
			else if(this._comboBoxFormat.SelectedIndex == 5)
			{
                _textBoxSample.Text = String.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
			}
			else if(this._comboBoxFormat.SelectedIndex == 6)
			{
                _textBoxSample.Text = String.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
			}
			else if(this._comboBoxFormat.SelectedIndex == 7)
			{
                _textBoxSample.Text = String.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 0.126);
			}
			else if(this._comboBoxFormat.SelectedIndex == 8)
			{
				// Custom format
				bool	success = false;
				try
				{
                    this._textBoxSample.Text = String.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.67890);
					success = true;
				}
				catch(FormatException)
				{
				}

				if(!success)
				{
					try
					{
                        this._textBoxSample.Text = String.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345);
						success = true;
					}
					catch(FormatException)
					{
					}
				}
				
				if(!success)
				{
                    this._textBoxSample.Text = SR.DesciptionCustomLabelFormatInvalid;
				}
			}
		}
		/// <summary>
		/// VSTS: 787936, 787937 - Expand the dialog with widthDialogExtend, heightDialogExtend  to make room for localization.
		/// </summary>
		private void PrepareControlsLayout()
		{

			this.Width += widthDialogExtend;
			this._buttonOk.Left += widthDialogExtend;
			this._buttonCancel.Left += widthDialogExtend;
			this._groupBoxDescription.Width += widthDialogExtend;
			this._groupBoxFormat.Width += widthDialogExtend;
			this._labelDescription.Width += widthDialogExtend;
			foreach (System.Windows.Forms.Control ctrl in this._groupBoxFormat.Controls)
			{
				if (ctrl is Label)
					ctrl.Width += widthDialogExtend;
				else
					ctrl.Left += widthDialogExtend;
			}

			this.Height += heightDialogExtend;
			this._buttonOk.Top += heightDialogExtend;
			this._buttonCancel.Top += heightDialogExtend;
			this._groupBoxKeywords.Height += heightDialogExtend;
			this._listBoxKeywords.IntegralHeight = false;
			this._listBoxKeywords.Height += heightDialogExtend;
			this._groupBoxDescription.Height += heightDialogExtend;
			this._labelDescription.Height += heightDialogExtend;
			this._groupBoxFormat.Top += heightDialogExtend;
		}

		#endregion // Helper Methods
	}
}


