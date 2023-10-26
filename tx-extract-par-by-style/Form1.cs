using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TXTextControl;

namespace tx_extract_par_by_style
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         private void Form1_Load(object sender, EventArgs e)
        {
    
            textControl1.Load("computers.tx", StreamType.InternalUnicodeFormat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StyleManager styleManager = new StyleManager(textControl1);
            styleManager.ApplyStyles();
        }
	}
}
