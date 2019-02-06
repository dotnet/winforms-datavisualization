using System;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities.SampleMain
{
	/// <summary>
	/// Converts samples source code to RTF format with color highlighting.
	/// </summary>
	public class SourceCodeToRtf
	{
		#region Fields and Constructor

		protected XmlDocument	langDef;

		public SourceCodeToRtf()
		{
		}

		#endregion

		#region Public methods

		public void LoadLanguageDefinition(String fileName)
		{
			StreamReader	fileIn = null;

			try
			{
				fileIn = new StreamReader(fileName);
				langDef = new XmlDocument();
				langDef.Load(fileIn);
			}			
			finally
			{
				if(fileIn != null)
					fileIn.Close();
			}
		}

		public String ConvertFile(String fileName)
		{
			StreamReader	fileIn = null;

			try
			{
				fileIn = new StreamReader(fileName);
				String srcIn = fileIn.ReadToEnd();

				String srcOut = Convert(srcIn);
				return srcOut;
			}
			finally
			{
				if(fileIn != null)
					fileIn.Close();
			}
		}

		public String Convert(String srcIn)
		{
			int srcInPos = 0;
			srcIn += "\n ";

			// Apply RTF header
			String srcOut = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033" +
			"{\\fonttbl{\\f0\\fswiss\\fcharset0 Courier New;}}" +
			"{\\colortbl ;\\red0\\green0\\blue255;\\red0\\green128\\blue0;\\red128\\green128\\blue128;}" +
			"\\viewkind4\\uc1\\pard\\f0\\fs20 ";
		
			// Convert sample code
			Convert(srcIn, ref srcInPos, langDef["block"], ref srcOut);
		
			// Apply RTF footer
			srcOut += "\\par}";

			return srcOut;
		}


		#endregion

		#region Converter methods

		protected String RTFEncode(String strIn)
		{
			String strOut = strIn.Replace("\\","\\\\");
			strOut = strOut.Replace("}","\\}");
			strOut = strOut.Replace("{","\\{");
			strOut = strOut.Replace("\r\n","\r");
			strOut = strOut.Replace("\r","\r\n\\par");
			strOut = strOut.Replace("\t","    ");
			return strOut;
		}

		protected void Convert(String srcIn, ref int srcInPos, XmlNode langDefNode, ref String srcOut)
		{		
			Match fragMatch;
			Regex reg;

			if(langDefNode["preRTF"] != null)
			{
				srcOut += langDefNode["preRTF"].InnerText;
			}

			try
			{
				while(srcInPos < srcIn.Length)
				{
					//*************************************************************
					//find the next block fragment
					reg = new Regex(langDefNode["fragDelimiter"].InnerText,RegexOptions.IgnoreCase|RegexOptions.Multiline);
					do
					{
						fragMatch = reg.Match(srcIn,srcInPos);
						if(fragMatch.Success)
						{
							if(fragMatch.Index <= (srcInPos ))
							{
								srcOut += RTFEncode(srcIn.Substring(srcInPos,1));
								srcInPos++;
								if(srcInPos >= srcIn.Length)
									return;

								if(langDefNode["endDelimiter"] != null && srcInPos > 1)
								{
									Regex tmpReg = new Regex(langDefNode["endDelimiter"].InnerText,RegexOptions.IgnoreCase|RegexOptions.Multiline);
									Match tmpMatch = tmpReg.Match(srcIn.Substring(srcInPos -1,fragMatch.Length));
									if(tmpMatch.Success && tmpMatch.Length > 0)
										return;
								}
							}
							else
							{
								break;
							}
						}
					}while(fragMatch.Success);
					if(fragMatch.Success == false)
						break;
					String frag = srcIn.Substring(srcInPos,fragMatch.Index - srcInPos);
				

					//*************************************************************
					//check to see if the fragment is in the language definition
					bool tokenMatch = false;
					foreach( XmlNode node in langDefNode.ChildNodes)
					{
						if(node.Name != "token")
							continue;

						if(node.Attributes["regExp"] != null && node.Attributes["regExp"].Value == "false")
						{
							if(node.Attributes["value"].Value == frag)
								tokenMatch = true;
						}
						else
						{
							reg = new Regex(node.Attributes["value"].Value,RegexOptions.IgnoreCase|RegexOptions.Multiline);
							Match match = reg.Match(frag);
							if(match.Success && match.Length == frag.Length)
								tokenMatch = true;
						}

						if(tokenMatch)
						{
							tokenMatch = true;

							//check to see if it has pre and post attribs, if so, then see if they match
							if(node.Attributes["pre"] != null && srcInPos > 0)
							{
								//if false, then tokenMatch = false; break;
								reg = new Regex(node.Attributes["pre"].Value,RegexOptions.IgnoreCase|RegexOptions.Multiline);
								Match match = reg.Match(srcIn.Substring(srcInPos -1,1));
								if(match.Success == false || match.Length == 0)
								{
									tokenMatch = false;
									continue;
								}
							}
							if(node.Attributes["post"] != null)
							{
								//if false, then tokenMatch = false; break;
								reg = new Regex(node.Attributes["post"].Value,RegexOptions.IgnoreCase|RegexOptions.Multiline);
								Match match = reg.Match(srcIn.Substring(fragMatch.Index,1));
								if(match.Success == false || match.Length == 0)
								{
									tokenMatch = false;
									continue;
								}
							}

							//if a specific match size is specified for the token, then use it
							int matchSize = fragMatch.Index - srcInPos;
							if(node.Attributes["matchSize"] != null)
							{
								matchSize = int.Parse(node.Attributes["matchSize"].Value);
							}

							//if the fragment is matched then write out the pre-RTF code
							if(node["tokenPreRTF"] == null)
								srcOut += langDefNode["tokenPreRTF"].InnerText;
							else
								srcOut += node["tokenPreRTF"].InnerText;
							srcOut += RTFEncode(srcIn.Substring(srcInPos,matchSize));
						
							//update the input string position
							srcInPos += matchSize;

							//check to see if this fragment has a child block
							if(node["block"] != null)
							{
								Convert(srcIn, ref srcInPos, node["block"], ref srcOut);
							}

							//if the fragment is matched then write out the post-RTF code
							if(node["tokenPostRTF"] == null)
								srcOut += langDefNode["tokenPostRTF"].InnerText;
							else
								srcOut += node["tokenPostRTF"].InnerText;

							break;
						}
					}

					if(tokenMatch == false)
					{					
						srcOut += RTFEncode(srcIn.Substring(srcInPos,fragMatch.Index - srcInPos + 1));
						srcInPos = fragMatch.Index +1;
					}

					if(langDefNode["endDelimiter"] != null && srcInPos > 1)
					{
						reg = new Regex(langDefNode["endDelimiter"].InnerText,RegexOptions.IgnoreCase|RegexOptions.Multiline);
						Match match = reg.Match(srcIn.Substring(srcInPos -1,1));
						if(match.Success && match.Length > 0)
							return;
					}
				}
			}
			finally
			{
				if(langDefNode["postRTF"] != null)
				{
					srcOut += langDefNode["postRTF"].InnerText;
				}
			}
		}
	}

	#endregion
}
