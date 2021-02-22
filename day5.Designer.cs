namespace AdventOfCode2020
{
    partial class day5
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
            this.leaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leaveBtn
            // 
            this.leaveBtn.Location = new System.Drawing.Point(664, 403);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(115, 24);
            this.leaveBtn.TabIndex = 0;
            this.leaveBtn.Text = "leave";
            this.leaveBtn.UseVisualStyleBackColor = true;
            this.leaveBtn.Click += new System.EventHandler(this.leaveBtn_Click);
            // 
            // day5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leaveBtn);
            this.Name = "day5";
            this.Text = "day5";
            this.Load += new System.EventHandler(this.day5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leaveBtn;
    }
}