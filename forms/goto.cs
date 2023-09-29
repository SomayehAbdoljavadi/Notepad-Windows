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
    public partial class @goto : Form
    {
        Form2 f2;
        public @goto(Form2 f)
        {
            InitializeComponent();
            f2 = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GOTo_Click(object sender, EventArgs e)

        {
            
            if (Convert.ToInt16(textBox1.Text) <= f2.ln)
            {
                f2.textBox1.SelectionStart = f2.textBox1.GetFirstCharIndexFromLine(int.Parse(textBox1.Text) - 1);
                f2.textBox1.Focus();
                Close();
            }
            else
                if (Convert.ToInt16(textBox1.Text) > f2.ln)
                    MessageBox.Show("invalid line", "not", MessageBoxButtons.OK);

           
                  }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
