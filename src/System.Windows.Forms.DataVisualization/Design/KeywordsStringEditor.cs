// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Design-time editor for the strings that may contain
//				keywords. Form automatically retrives the list of 
//				recongnizable keywords from the chart keywords 
//				registry.
//


using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{
    /// <summary>
    /// Stirng editor form that is used to edit properties that support keywords.
    /// </summary>
    internal class KeywordsStringEditorForm : System.Windows.Forms.Form
	{
		#region Fields

		// Form fields
		private System.Windows.Forms.RichTextBox _richTextBox;
		private System.Windows.Forms.GroupBox _groupBoxString;
		private System.Windows.Forms.Button _buttonOk;
		private System.Windows.Forms.Button _buttonCancel;
		private System.Windows.Forms.Button _buttonInsert;
		private System.Windows.Forms.Button _buttonEdit;
		private System.Windows.Forms.Label _labelDescription;
        private System.Windows.Forms.Panel _panelInsertEditButtons;
        private System.Windows.Forms.Panel _panelOkCancelButtons;
        private System.Windows.Forms.Panel _panelTopContent;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container _components = null;

		/// <summary>
		/// Property name that is beign edited.
		/// </summary>
		private	string	_propertyName = string.Empty;

		/// <summary>
		/// Object/class name beign edited.
		/// </summary>
		private	string	_classTypeName = string.Empty;

		/// <summary>
		/// Initial string to be edited.
		/// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private	string	_initialString = string.Empty;

		/// <summary>
		/// Result String after editing.
		/// </summary>
		public	string	ResultString = string.Empty;

		/// <summary>
		/// Maximum Y value index that can be used
		/// </summary>
		private	int		_maxYValueIndex = 9;

		/// <summary>
		/// List of applicable keywords
		/// </summary>
		internal ArrayList	applicableKeywords = null;

		/// <summary>
		/// Reference to the keywords registry
		/// </summary>
		internal KeywordsRegistry KeywordsRegistry = null;

		/// <summary>
		/// Name of the last selected keyword name
		/// </summary>
		private string _selectedKeywordName = string.Empty;

		/// <summary>
		/// Start index of selected keyword.
		/// </summary>
		private int _selectedKeywordStart = -1;

		/// <summary>
		/// Length of selected keyword.
		/// </summary>
		private int _selectedKeywordLength = -1;

		/// <summary>
		/// Indicates that RTF control control is updating its text.
		/// Used to prevent recursive calls.
		/// </summary>
		private bool _updating = false;

        // resolved VSTS by extending the dialog by 36x28 pixels.
        // 5027	 MultiLang: ChartAPI: Strings are truncated on the 'String Keywords Editor' dialog
        // 65162 Garbled characters in the String Keyword Editor on the designer
        // 16588 DEU and JPN: VCS/VB/VWD/VC: ChartAPI: Some string are truncated on the 'String Keywords Editor'
        // 3523  DEU and JPN: VCS/VB/VWD/VC: ChartAPI: Some string are truncated on the 'String Keywords Editor'

        private static int widthDialogExtend = 80;
		private static int heightDialogExtend = 38;
		
        #endregion // Fields

		#region Constructor

		/// <summary>
		/// Default public constructor
		/// </summary>
		public KeywordsStringEditorForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			PrepareControlsLayout();
		}

		/// <summary>
		/// Object constructor.
		/// </summary>
		/// <param name="initialString">String to edit.</param>
		/// <param name="classTypeName">Class name that beign edited.</param>
		/// <param name="propertyName">Property name that is beign edited.</param>
		/// <param name="maxYValueIndex">Maximum number of supported Y values.</param>
		public KeywordsStringEditorForm(string initialString, string classTypeName, string propertyName, int maxYValueIndex) : this()
		{

			// Save input parameters
			this._classTypeName = classTypeName;
			this._propertyName = propertyName;
			this._maxYValueIndex = maxYValueIndex;
			this._initialString = initialString;
			this.ResultString = initialString;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">True if disposing.</param>
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

		#endregion // Constructor

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._groupBoxString = new System.Windows.Forms.GroupBox();
            this._buttonEdit = new System.Windows.Forms.Button();
            this._buttonInsert = new System.Windows.Forms.Button();
            this._buttonOk = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._labelDescription = new System.Windows.Forms.Label();
            this._panelOkCancelButtons = new System.Windows.Forms.Panel();
            this._panelTopContent = new System.Windows.Forms.Panel();
            this._panelInsertEditButtons = new System.Windows.Forms.Panel();
            this._groupBoxString.SuspendLayout();
            this._panelOkCancelButtons.SuspendLayout();
            this._panelTopContent.SuspendLayout();
            this._panelInsertEditButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this._richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._richTextBox.Location = new System.Drawing.Point(6, 19);
            this._richTextBox.Margin = new System.Windows.Forms.Padding(7);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(488, 106);
            this._richTextBox.TabIndex = 0;
            this._richTextBox.WordWrap = false;
            this._richTextBox.SelectionChanged += new System.EventHandler(this.richTextBox_SelectionChanged);
            this._richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyDown);
            this._richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_KeyPress);
            this._richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // groupBoxString
            // 
            this._groupBoxString.Controls.Add(this._panelInsertEditButtons);
            this._groupBoxString.Controls.Add(this._richTextBox);
            this._groupBoxString.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupBoxString.Location = new System.Drawing.Point(0, 56);
            this._groupBoxString.Name = "_groupBoxString";
            this._groupBoxString.Padding = new System.Windows.Forms.Padding(6);
            this._groupBoxString.Size = new System.Drawing.Size(500, 131);
            this._groupBoxString.TabIndex = 1;
            this._groupBoxString.TabStop = false;
            this._groupBoxString.Text = SR.LabelStringWithKeywords;
            // 
            // buttonEdit
            // 
            this._buttonEdit.Enabled = false;
            this._buttonEdit.Location = new System.Drawing.Point(30, 34);
            this._buttonEdit.Name = "_buttonEdit";
            this._buttonEdit.Size = new System.Drawing.Size(156, 27);
            this._buttonEdit.TabIndex = 2;
            this._buttonEdit.Text = SR.LabelEditKeyword;
            this._buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonInsert
            // 
            this._buttonInsert.Location = new System.Drawing.Point(30, 2);
            this._buttonInsert.Name = "_buttonInsert";
            this._buttonInsert.Size = new System.Drawing.Size(156, 27);
            this._buttonInsert.TabIndex = 1;
            this._buttonInsert.Text = SR.LabelInsertNewKeyword;
            this._buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonOk
            // 
            this._buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._buttonOk.Location = new System.Drawing.Point(305, 9);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(90, 27);
            this._buttonOk.TabIndex = 2;
            this._buttonOk.Text = SR.LabelButtonOk;
            this._buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(401, 9);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(90, 27);
            this._buttonCancel.TabIndex = 3;
            this._buttonCancel.Text = SR.LabelButtonCancel;
            // 
            // labelDescription
            // 
            this._labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelDescription.Location = new System.Drawing.Point(0, 0);
            this._labelDescription.Name = "_labelDescription";
            this._labelDescription.Size = new System.Drawing.Size(500, 56);
            this._labelDescription.TabIndex = 0;
            this._labelDescription.Text = SR.DesciptionCustomLabelEditorTitle;
            // 
            // _panelOkCancelButtons
            // 
            this._panelOkCancelButtons.Controls.Add(this._buttonOk);
            this._panelOkCancelButtons.Controls.Add(this._buttonCancel);
            this._panelOkCancelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelOkCancelButtons.Location = new System.Drawing.Point(4, 191);
            this._panelOkCancelButtons.Name = "_panelOkCancelButtons";
            this._panelOkCancelButtons.Padding = new System.Windows.Forms.Padding(6);
            this._panelOkCancelButtons.Size = new System.Drawing.Size(500, 44);
            this._panelOkCancelButtons.TabIndex = 4;
            // 
            // _panelTopContent
            // 
            this._panelTopContent.Controls.Add(this._groupBoxString);
            this._panelTopContent.Controls.Add(this._labelDescription);
            this._panelTopContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelTopContent.Location = new System.Drawing.Point(4, 4);
            this._panelTopContent.Name = "_panelTopContent";
            this._panelTopContent.Size = new System.Drawing.Size(500, 187);
            this._panelTopContent.TabIndex = 5;
            // 
            // _panelInsertEditButtons
            // 
            this._panelInsertEditButtons.Controls.Add(this._buttonInsert);
            this._panelInsertEditButtons.Controls.Add(this._buttonEdit);
            this._panelInsertEditButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this._panelInsertEditButtons.Location = new System.Drawing.Point(305, 19);
            this._panelInsertEditButtons.Name = "_panelInsertEditButtons";
            this._panelInsertEditButtons.Size = new System.Drawing.Size(189, 106);
            this._panelInsertEditButtons.TabIndex = 3;            
            // 
            // KeywordsStringEditorForm
            // 
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(524, 275);
            this.Controls.Add(this._panelTopContent);
            this.Controls.Add(this._panelOkCancelButtons);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(524, 275);
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "KeywordsStringEditorForm";
            this.Text = SR.LabelStringKeywordsEditor;
            this.Load += new System.EventHandler(this.KeywordsStringEditorForm_Load);
            this._groupBoxString.ResumeLayout(false);
            this._panelOkCancelButtons.ResumeLayout(false);
            this._panelTopContent.ResumeLayout(false);
            this._panelInsertEditButtons.ResumeLayout(false); 
            this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers

		/// <summary>
		/// Form loaded event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void KeywordsStringEditorForm_Load(object sender, System.EventArgs e)
		{
            // Insert new line characters in the text
			this._labelDescription.Text = this._labelDescription.Text.Replace("\\n", "\n");

			// Load list of keywords applicable for the specified object and property.
			this.applicableKeywords = this.GetApplicableKeywords();
			if(this.applicableKeywords.Count == 0)
			{
				this._buttonInsert.Enabled = false;
				this._buttonEdit.Enabled = false;
			}

            if (!String.IsNullOrEmpty(this._initialString))
            {
                // Set text to edit
                this._richTextBox.Rtf = this.GetRtfText(this._initialString);
            }
		}

		/// <summary>
		/// Insert keyword button clicked event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void buttonInsert_Click(object sender, System.EventArgs e)
		{
			// Show keyword editor form
			KeywordEditor keywordEditor = new KeywordEditor(
				this.applicableKeywords, 
				string.Empty, 
				this._maxYValueIndex);
			if(keywordEditor.ShowDialog() == DialogResult.OK)
			{
				if(_selectedKeywordLength > 0)
				{
					// Insert keyword at the end of curently selected keyword 
					// and separate them with space
					this._richTextBox.SelectionStart = this._richTextBox.SelectionStart + this._richTextBox.SelectionLength;
					this._richTextBox.SelectionLength = 0;
					this._richTextBox.SelectedText = " " + keywordEditor.Keyword;
				}
				else
				{
					// Insert new keyword at current location
					this._richTextBox.SelectionLength = Math.Max(0, this._selectedKeywordLength);
					this._richTextBox.SelectedText = keywordEditor.Keyword;
				}
			}

			// Set focus back to the editor
			this._richTextBox.Focus();
		}

		/// <summary>
		/// Edit keyword button clicked event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			// Get seloected keyword
			string keyword = this._richTextBox.Text.Substring(this._selectedKeywordStart, this._selectedKeywordLength);

			// Show keyword editor form
			KeywordEditor keywordEditor = new KeywordEditor(
				this.applicableKeywords, 
				keyword, 
				this._maxYValueIndex);
			if(keywordEditor.ShowDialog() == DialogResult.OK)
			{
				int start = this._selectedKeywordStart;
				int length = this._selectedKeywordLength;

				// Update currently selected kyword
				this._richTextBox.Text = this._richTextBox.Text.Substring(0, start) + 
					keywordEditor.Keyword + 
					this._richTextBox.Text.Substring(start + length);
				this._richTextBox.SelectionStart = start + keywordEditor.Keyword.Length;
			}

			// Set focus back to the editor
			this._richTextBox.Focus();
		}

		/// <summary>
		/// Rich text box text changed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void richTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if(!_updating)
			{
				_updating = true;

				// Save current selection
				int selectionStart = this._richTextBox.SelectionStart;
				int selectionLength = this._richTextBox.SelectionLength;

				// Update RTF tex
				_richTextBox.Rtf = this.GetRtfText(_richTextBox.Text);
				
				// Restore selection
				this._richTextBox.SelectionStart = selectionStart;
				this._richTextBox.SelectionLength = selectionLength;
				
				_updating = false;
			}
		}

		/// <summary>
		/// Rich text box selection changed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void richTextBox_SelectionChanged(object sender, System.EventArgs e)
		{
			// No any processing in selection mode with the Shift key down
			if((System.Windows.Forms.Control.ModifierKeys & Keys.Shift) != Keys.Shift)
			{
				if(!_updating)
				{
					_updating = true;

					// Update RTF text only when selected (bolded) keyword is changed
					string selectedKeywordTemp = this._selectedKeywordName;
					string newRtf = this.GetRtfText(_richTextBox.Text);
					if(selectedKeywordTemp != this._selectedKeywordName)
					{
						// Save current selection
						int selectionStart = this._richTextBox.SelectionStart;

						// Update RTF text
						_richTextBox.Rtf = newRtf;

						// Restore selection
						this._richTextBox.SelectionStart = selectionStart;
						this._richTextBox.SelectionLength = 0;
					}
			
					_updating = false;
				}
			}
		}

		/// <summary>
		/// Rich text box key pressed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void richTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			// Make sure we enter a closing bracket when user starts 
			// entering the format string
			if(e.KeyChar == '{')
			{
				if(_richTextBox.SelectionColor == Color.Blue)
				{
					e.Handled = true;
					_richTextBox.SelectedText = "{}";
					_richTextBox.SelectionStart = _richTextBox.SelectionStart - 1;
				}
			}
		}

		/// <summary>
		/// Rich text box key down event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void richTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// Delete keyword when user press 'Delete' key
			if(e.KeyCode == Keys.Delete &&
				this._selectedKeywordStart >= 0 &&
				this._selectedKeywordLength > 0)
			{
				// Remember selection start because it will be changed as soon
				// as we update editor text
				int newSelectionPosition = this._selectedKeywordStart;

				// Remove keyword
				string newText = _richTextBox.Text.Substring(0, this._selectedKeywordStart);
				newText += _richTextBox.Text.Substring(this._selectedKeywordStart + this._selectedKeywordLength);
				_richTextBox.Text = newText;

				// Restore cursor (selection) position
				_richTextBox.SelectionStart = newSelectionPosition;
				e.Handled = true;
			}
		}


		/// <summary>
		/// Ok button pressed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void buttonOk_Click(object sender, System.EventArgs e)
		{
			// Get text from the editor
			this.ResultString = this._richTextBox.Text;

			// New line character should be presented as 2 characters "\n"
			this.ResultString = this.ResultString.Replace("\r\n", "\\n");
			this.ResultString = this.ResultString.Replace("\n", "\\n");
		}

		#endregion // Event Handlers

		#region Helper Methods

		/// <summary>
		/// Helper method that generates the RTF text based on the string.
		/// </summary>
		/// <param name="originalText">Input text.</param>
		/// <returns>Input text formatted as RTF.</returns>
		private string GetRtfText(string originalText)
		{
			// Initialize empty string
			string resultRtf = string.Empty;

			// Start with RTF header and font table
			resultRtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}\r\n";

			// Add color table
			resultRtf += @"{\colortbl ;\red0\green0\blue255;}\r\n";

			// Add text starting tags
			resultRtf += @"\viewkind4\uc1\pard\f0\fs17 ";

			// Add text
            resultRtf += GetUnicodeRtf(this.GetColorHilightedRtfText(originalText));

			// Finish RTF format
			resultRtf += @"\par\r\n}";

			return resultRtf;
		}
        
        // VSTS: 65162: The non ansi 1252 characters will be lost, we need conversion in \uXXXX? format.
        private string GetUnicodeRtf(string orginalText)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            foreach (char c in orginalText.ToCharArray())
            {
                int charInt = Convert.ToInt32(c);
                if (charInt < 0x00 || charInt > 0x7f)
                    result.Append(@"\u" + charInt.ToString() + "?");
                else
                    result.Append(Convert.ToString(c));
            }
            return result.ToString();
        }

		/// <summary>
		/// Gets specified text in RTF format where keyword are color highlighted.
		/// </summary>
		/// <param name="originalText">Original text.</param>
		/// <returns>Color higlighted RTF text.</returns>
		private string GetColorHilightedRtfText(string originalText)
		{
			string resultText = originalText;
			string selectedKeyword = string.Empty;

			// Reset selected keyword position
			this._selectedKeywordStart = -1;
			this._selectedKeywordLength = 0;

			// Current selection position that will be adjusted when formatting 
			// characters are added infron of it.
			int selectionStart = this._richTextBox.SelectionStart;

			// Replace special new line character sequence "\n"
			resultText = resultText.Replace("\\n", "\r\n");

			// Replace special RTF Character '\'
			int slashCountre = 0;
			for(int index = 0; index < resultText.Length && index < selectionStart; index ++)
			{
				if(resultText[index] == '\\')
				{
					++slashCountre;
				}
			}
			selectionStart += slashCountre;
			resultText = resultText.Replace(@"\", @"\\");

			// Iterate through all keywords 
			foreach(KeywordInfo keywordInfo in this.applicableKeywords)
			{
				// Fill array of possible names for that keyword
				string[] keywordNames = keywordInfo.GetKeywords();

				// Iterate through all possible names
				foreach(string keywordNameWithSpaces in keywordNames)
				{
					int startIndex = 0;

					// Trim spaces
					string keywordName = keywordNameWithSpaces.Trim();

					// Skip empty strings
					if(keywordName.Length > 0)
					{
						// Try finding the keyword in the string
						while( (startIndex = resultText.IndexOf(keywordName, startIndex, StringComparison.Ordinal)) >= 0)
						{
							int keywordLength = keywordName.Length;

							// Check if Y value index can be part of the keyword
							if(keywordInfo.SupportsValueIndex)
							{
								if(resultText.Length > (startIndex + keywordLength) &&
									resultText[startIndex + keywordLength] == 'Y')
								{
									++keywordLength;
									if(resultText.Length > (startIndex + keywordLength) && 
										char.IsDigit(resultText[startIndex + keywordLength]))
									{
										++keywordLength;
									}
								}
							}

							// Check if format string can be part of the keyword
							if(keywordInfo.SupportsFormatting)
							{
								if(resultText.Length > (startIndex + keywordLength) &&
									resultText[startIndex + keywordLength] == '{')
								{
									++keywordLength;
									int formatEndBracket = resultText.IndexOf("}", startIndex + keywordLength, StringComparison.Ordinal);
									if(formatEndBracket >= 0)
									{
										keywordLength += formatEndBracket - startIndex - keywordLength + 1;
									}
								}
							}

							// Check if cursor currently located inside the keyword
							bool isKeywordSelected = (selectionStart > (startIndex) && 
								selectionStart <= (startIndex + keywordLength) );

							// Show Keyword with different color
							string tempText = resultText.Substring(0, startIndex);
							string formattedKeyword = string.Empty;
							formattedKeyword += @"\cf1";
							if(isKeywordSelected)
							{
								// Remember selected keyword by name and position
								selectedKeyword = keywordInfo.Name;
								selectedKeyword += "__" + startIndex.ToString(CultureInfo.InvariantCulture);
								this._selectedKeywordStart = startIndex;
								this._selectedKeywordStart -= selectionStart - this._richTextBox.SelectionStart;
 								this._selectedKeywordLength = keywordLength;

								formattedKeyword += @"\b";
							}
							formattedKeyword += @"\ul";
							// Replace keyword start symbol '#' with "#_" to avoid duplicate processing
							formattedKeyword += "#_";		
                            formattedKeyword += resultText.Substring(startIndex + 1, keywordLength - 1);
							formattedKeyword += @"\cf0";
							if(isKeywordSelected)
							{
								formattedKeyword += @"\b0";
							}
							formattedKeyword += @"\ul0 ";
							tempText += formattedKeyword;
							tempText += resultText.Substring(startIndex + keywordLength);
							resultText = tempText;

							// Adjust selection position
							if(startIndex < selectionStart)
							{
								selectionStart += formattedKeyword.Length - keywordLength;
							}

							// Increase search start index by the length of the keyword
							startIndex += formattedKeyword.Length;
						}
					}
				}
			}
		
			// Set currenly selected keyword name
			this._selectedKeywordName = selectedKeyword;

			// Update Edit button
			if(this._selectedKeywordName.Length > 0)
			{
				// Enable Edit button and set it text
				this._buttonEdit.Enabled = true;
			}
			else
			{
				this._buttonEdit.Enabled = false;
			}

			// Replace all the "\n" strings with new line objectTag "\par"
			resultText = resultText.Replace("\r\n", @"\par ");
			resultText = resultText.Replace("\n", @"\par ");
			resultText = resultText.Replace("\\n", @"\par ");

			// Replace special RTF Characters '{' and '}'
			// Has to be done after all processing because this character is 
			// used in keywords formatting.
			resultText = resultText.Replace(@"{", @"\{");
			resultText = resultText.Replace(@"}", @"\}");

			// Replace the "#_" string with keyword start symbol.
			// This  was previously chnaged to avoid duplicate processing.
			return resultText.Replace("#_", "#");
		}

		/// <summary>
		/// Get list of keywords applicable to current object and property.
		/// </summary>
		/// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        private ArrayList GetApplicableKeywords()
		{
			// Create new array
			ArrayList keywordList = new ArrayList();

			// Get acess to the chart keywords registry
			if(KeywordsRegistry != null &&
				this._propertyName.Length > 0 &&
				this._classTypeName.Length > 0)
			{
				// Iterate through all keywords in the registry
				foreach(KeywordInfo keywordInfo in KeywordsRegistry.registeredKeywords)
				{
					// Check if keyword is supported by specified type
					bool typeSupported = false;
					string[] typeNames = keywordInfo.AppliesToTypes.Split(',');
					foreach(string typeName in typeNames)
					{
						if(this._classTypeName == typeName.Trim())
						{
							typeSupported = true;
							break;
						}
					}
					
					// If type supported check property name
					if(typeSupported)
					{
						string[] propertyNames = keywordInfo.AppliesToProperties.Split(',');
						foreach(string propertyName in propertyNames)
						{
							if(this._propertyName == propertyName.Trim())
							{
								// Add KeywordInfo into the list
								keywordList.Add(keywordInfo);
								break;
							}
						}
					}
				}
			}

			return keywordList;
		}

		/// <summary>
		/// VSTS: 787930 - Expand the dialog with widthDialogExtend, heightDialogExtend  to make room for localization.
		/// </summary>
		private void PrepareControlsLayout()
		{
			int buttonWidthAdd = 18;
			this.Width += widthDialogExtend;
			this._panelOkCancelButtons.Width += widthDialogExtend;
			this._panelInsertEditButtons.Width += widthDialogExtend;
			this._buttonInsert.Width += widthDialogExtend + buttonWidthAdd;
			this._buttonInsert.Left -= buttonWidthAdd;
			this._buttonEdit.Width += widthDialogExtend + buttonWidthAdd;
			this._buttonEdit.Left -= buttonWidthAdd;
			this._labelDescription.Width += widthDialogExtend;

			this.Height += heightDialogExtend;
			this._panelOkCancelButtons.Top += heightDialogExtend;
			this._labelDescription.Height += heightDialogExtend;
		}
        
		#endregion // Helper Methods
	}

	/// <summary>
	/// Editor for the string properties that may contain keyords.
	/// </summary>
	internal class KeywordsStringEditor : System.Drawing.Design.UITypeEditor 
	{
		#region Editor methods and properties

		// Editor services
		private IWindowsFormsEditorService	_edSvc = null;

		/// <summary>
		/// Edit label format by showing the form
		/// </summary>
		/// <param name="context">Editing context.</param>
		/// <param name="provider">Provider.</param>
		/// <param name="value">Value to edit.</param>
		/// <returns>Result</returns>
        [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily",
            Justification = "Too large of a code change to justify making this change")]
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) 
		{
			if (context != null && 
				context.Instance != null && 
				provider != null && 
				context.PropertyDescriptor != null) 
			{
				_edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				if (_edSvc != null) 
				{
					// Try getting access to the associated series
					Series series = null;
					Chart chart = null;
                    object instance = context.Instance;

#if CHART_ACTLIST
                    // Special processing if editor is called from the smart tag
                    if (instance is ChartActionList)
                    {
                        chart = ((ChartActionList)instance).Chart;
                        ChartActionList.SelectedItemInfo selectedItemInfo = ((ChartActionList)instance).GetSelectedItemInfo();
                        if(selectedItemInfo != null)
                        {
                            instance = selectedItemInfo.SelectedObject;
                        }
                    }

#endif //CHART_ACTLIST
                    // Check object instance edited
					if(instance is Series)
					{
						series = (Series)instance;
					}
					else if(instance is DataPoint)
					{
						series = ((DataPoint)instance).series;
					}
					else if(instance is LegendItem)
					{
                        if (((LegendItem)instance).Common != null)
						{
                            chart = ((LegendItem)instance).Common.Chart;
                            if (((LegendItem)instance).Common.DataManager.Series.IndexOf(((LegendItem)instance).SeriesName) >= 0)
							{
                                series = ((LegendItem)instance).Common.DataManager.Series[((LegendItem)instance).SeriesName];
							}
						}
					}
                    else if (instance is LegendCellColumn)
					{
                        if (((LegendCellColumn)instance).Legend != null)
						{
                            chart = ((LegendCellColumn)instance).Legend.Common.Chart;
						}
					}

                    else if (instance is Annotation)
					{
                        chart = ((Annotation)instance).Chart;
                        if (((Annotation)instance).AnchorDataPoint != null)
						{
                            series = ((Annotation)instance).AnchorDataPoint.series;
						}
						else if(chart != null && chart.Series.Count > 0)
						{
							series = chart.Series[0];
						}
					}



                    // Make sure chart reference was found
					if(chart == null && series != null)
					{
						chart = series.Chart;
					}

					// Get maximum number of Y values
					int maxYValueNumber = 9;
					if(series != null)
					{
						maxYValueNumber = series.YValuesPerPoint - 1;
					}
					else if(chart != null)
					{
						// Find MAX number of Y values use in all series
						maxYValueNumber = 0;
						foreach(Series ser in chart.Series)
						{
							maxYValueNumber = Math.Max(maxYValueNumber, ser.YValuesPerPoint - 1);
						}
					}

					// Show editor form
					KeywordsStringEditorForm form = new KeywordsStringEditorForm(
						(string)value,
                        instance.GetType().Name,
						context.PropertyDescriptor.Name,
						maxYValueNumber);
					if(chart != null)
					{
						form.KeywordsRegistry = (KeywordsRegistry)chart.GetService(typeof(KeywordsRegistry));
					}
					_edSvc.ShowDialog(form);
					value = form.ResultString;
				}
			}

			return value;
		}

		/// <summary>
		/// Show modal form.
		/// </summary>
		/// <param name="context">Editing context.</param>
		/// <returns>Editor style.</returns>
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) 
		{
			if (context != null && context.Instance != null) 
			{
				return UITypeEditorEditStyle.Modal;
			}
			return base.GetEditStyle(context);
		}
	
		#endregion
	}

}


