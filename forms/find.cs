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
    public partial class find : Form
     
    {
        Form2 f2;

        int y = 0;

        public find(Form2 f)
        {
            InitializeComponent();
            f2 = f;
        }

             private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindNext_Click(object sender, EventArgs e)
        {
           
            if (f2.sw == 1)
            {
                int x = f2.textBox1.Text.IndexOf(textBox1.Text);
                if (x == -1)
                    MessageBox.Show("not find", "nf", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else

                    f2.textBox1.Select(x, textBox1.Text.Length);

            }
           
                if (f2.sw == 2)
                {
                    int x = f2.textBox1.Text.IndexOf(textBox1.Text, y);
                    if (x == -1)
                        MessageBox.Show("not find", "nf", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else

                        f2.textBox1.Select(x, textBox1.Text.Length);

                    y += textBox1.Text.Length;
                }
   

            f2.textBox1.Focus();
        }
    }
}
