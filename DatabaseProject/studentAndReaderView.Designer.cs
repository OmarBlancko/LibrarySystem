namespace DatabaseProject
{
    partial class studentAndReaderView
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Show available books";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(291, 318);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 50);
            this.button6.TabIndex = 9;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // studentAndReaderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "studentAndReaderView";
            this.Text = "studentAndReaderView";
            this.Load += new System.EventHandler(this.studentAndReaderView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button6;
    }
}