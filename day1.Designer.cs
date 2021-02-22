namespace AdventOfCode2020
{
    partial class day1
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
            this.leave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.output = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leave
            // 
            this.leave.Location = new System.Drawing.Point(654, 372);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(78, 43);
            this.leave.TabIndex = 0;
            this.leave.Text = "Return";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Location = new System.Drawing.Point(44, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 300);
            this.panel1.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(667, 300);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.output);
            this.panel2.Location = new System.Drawing.Point(251, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 38);
            this.panel2.TabIndex = 2;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(3, 6);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 20);
            this.output.TabIndex = 0;
            // 
            // day1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leave);
            this.Name = "day1";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.day1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label output;
    }
}