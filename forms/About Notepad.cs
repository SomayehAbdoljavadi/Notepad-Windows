using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms
{
    public partial class About_Notpad : Form
    {
        public About_Notpad()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Notpad_Load(object sender, EventArgs e)
        {
            label1.Text = "سلام" + "\n"+"چطوری";
        }
    }
}
