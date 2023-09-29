namespace forms
{
    partial class find
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindNext = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.RadioButton();
            this.Up = new System.Windows.Forms.RadioButton();
            this.Direction = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Matchcase = new System.Windows.Forms.CheckBox();
            this.Direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // FindNext
            // 
            this.FindNext.Location = new System.Drawing.Point(197, 39);
            this.FindNext.Name = "FindNext";
            this.FindNext.Size = new System.Drawing.Size(75, 23);
            this.FindNext.TabIndex = 1;
            this.FindNext.Text = "Find Next";
            this.FindNext.UseVisualStyleBackColor = true;
            this.FindNext.Click += new System.EventHandler(this.FindNext_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(197, 86);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.Location = new System.Drawing.Point(31, 42);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(53, 17);
            this.Down.TabIndex = 3;
            this.Down.TabStop = true;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.Location = new System.Drawing.Point(31, 19);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(39, 17);
            this.Up.TabIndex = 4;
            this.Up.TabStop = true;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            // 
            // Direction
            // 
            this.Direction.Controls.Add(this.Up);
            this.Direction.Controls.Add(this.Down);
            this.Direction.Location = new System.Drawing.Point(154, 135);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(118, 69);
            this.Direction.TabIndex = 5;
            this.Direction.TabStop = false;
            this.Direction.Text = "Direction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Find what :";
            // 
            // Matchcase
            // 
            this.Matchcase.AutoSize = true;
            this.Matchcase.Location = new System.Drawing.Point(37, 135);
            this.Matchcase.Name = "Matchcase";
            this.Matchcase.Size = new System.Drawing.Size(82, 17);
            this.Matchcase.TabIndex = 8;
            this.Matchcase.Text = "Match case";
            this.Matchcase.UseVisualStyleBackColor = true;
            // 
            // find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Matchcase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.FindNext);
            this.Controls.Add(this.textBox1);
            this.Name = "find";
            this.Text = "find";
            this.Direction.ResumeLayout(false);
            this.Direction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FindNext;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RadioButton Down;
        private System.Windows.Forms.RadioButton Up;
        private System.Windows.Forms.GroupBox Direction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Matchcase;
    }
}