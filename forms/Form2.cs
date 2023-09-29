using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace forms
{

    public partial class Form2 : Form
    {
        string path=" ";
        public int sw;
        public int ln=0;

        public Form2()
           
        {
            InitializeComponent();
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK  )
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
            
            
            }

        }

       
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            {
                if (path.CompareTo(" ") == 0)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                    path = saveFileDialog1.FileName;
                }
            
             File.WriteAllText(path,textBox1.Text);
}


        }

       
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK )
            {

                textBox1.Font = fontDialog1.Font;
            
            
            }

        }

        private void aboutNotpadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            About_Notpad f = new About_Notpad();
            f.ShowDialog();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            findToolStripMenuItem.Enabled = false;
            findNextToolStripMenuItem.Enabled = false;
          

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                path = saveFileDialog1.FileName;
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible  = statusBarToolStripMenuItem.Checked;
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("do you want to save changes to" + "\r\n" + path, "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr==DialogResult.Yes)
                saveToolStripMenuItem_Click(sender,e);

            
                

            if (dr == DialogResult.Cancel)
                e.Cancel = true;
   
                 
        }

    

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = " ";
            
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
               
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = true;
            if (textBox1.Text != " ")
            {
                findToolStripMenuItem.Enabled = true;
                findNextToolStripMenuItem.Enabled = true;
            
            }
            if (textBox1.Text == " ")
            {

                findToolStripMenuItem.Enabled =false;
                findNextToolStripMenuItem.Enabled = false;
            
            }
            
         }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find fi = new find(this);
            fi.Show(this);
            sw = 1;
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find fi = new find(this);
            sw = 2;
            fi.Show(this);
            
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replace re = new replace(this);
            re.Show(this);
            
            
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
          @goto gt=new @goto(this);
          gt.Show(this);
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tImeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox1.Text= textBox1.Text.Insert(textBox1.SelectionStart, DateTime.Now.ToString());
        }

        private void textBox1_CursorChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int ColCount = 1;
            int RowCount = 1;
            int Pos;
            if (  textBox1.SelectionStart > -1)
            {
                Pos = textBox1.Text.LastIndexOf("\n", textBox1.SelectionStart);
                if (Pos > -1)
                {
                    if (Pos != textBox1.SelectionStart)
                        ColCount = textBox1.SelectionStart - Pos;
                    else
                    {
                        Pos = textBox1.Text.LastIndexOf("\n", textBox1.SelectionStart - 1);
                        ColCount = textBox1.SelectionStart - Pos;
                    }
                }
                else
                {
                    ColCount = textBox1.SelectionStart + 1;
                }
                while (Pos > -1)
                {
                    RowCount++;
                    Pos = textBox1.Text.LastIndexOf("\n", Pos - 1);
                }
            }
            toolStripStatusLabel1.Text = "Ln " + RowCount.ToString();
            ln = RowCount;
          toolStripStatusLabel2.Text ="Col " + ColCount.ToString();
        }

        private void pageStupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

/*
 private void PageSetup_Click(object sender, System.EventArgs e)
		{
			printDocument1.DocumentName = tfileName;
			pageSetupDialog1.Document = printDocument1;
			pageSetupDialog1.ShowDialog();
		}

		private void Print_Click(object sender, System.EventArgs e)
		{
			printDocument1.DocumentName = tfileName;
			printDialog1.Document = printDocument1;
			printDialog1.ShowDialog();
		}*/
 
     
       
       
           }
}
