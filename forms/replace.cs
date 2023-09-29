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
    public partial class replace : Form
    {
        Form2 f2;
        int y = 0;
        public replace(Form2 f)
        {
            InitializeComponent();
            f2 = f;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindNext_Click(object sender, EventArgs e)
        {
            
            int x = f2.textBox1.Text.IndexOf(textBox1.Text, y);
            if (x == 0)
                MessageBox.Show("not find", "nf", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else

                f2.textBox1.Select(x , textBox1.Text.Length);

            y += textBox1.Text.Length;
            f2.textBox1.Focus();
        }

        private void Replacee_Click(object sender, EventArgs e)
        {
          FindNext_Click(sender,e);
            f2.textBox1.SelectedText = textBox2.Text;
            f2.textBox1.Focus();
        }

        private void ReplaceAll_Click(object sender, EventArgs e)
        {
            f2.textBox1.Text = f2.textBox1.Text.Replace(textBox1.Text, textBox2.Text);
            f2.textBox1.Focus();
        }
    }
}
