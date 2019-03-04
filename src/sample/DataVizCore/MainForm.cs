using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#if DATAVIZCORE
using System.Windows.Forms.DataVisualization.Charting;
#endif

namespace DataVizCore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
#if DATAVIZCORE
            var chartControl = new Chart
            {
                Location = new Point(10, 10),
                Size = new Size(ClientSize.Width - 10, ClientSize.Height - 10),
                Anchor = AnchorStyles.Bottom |
                                  AnchorStyles.Top |
                                  AnchorStyles.Left |
                                  AnchorStyles.Right
            };

            this.Controls.Add(chartControl);
#endif
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
