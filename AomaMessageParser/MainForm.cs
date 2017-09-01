using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AomaMessageParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInput.Clear();
            tbOutput.Clear();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            MessageTool.Parse(null);
            MessageTool.Construct(new AnalysisAlert());
        }
    }
}
