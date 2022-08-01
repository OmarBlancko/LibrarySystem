namespace DatabaseProject
{
    partial class SqlQueriesReport
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(63, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 32);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Most interesting book title";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(106, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(106, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 27);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(63, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(466, 32);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Book title that hasn\'t order last month";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox5.Enabled = false;
            this.textBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Location = new System.Drawing.Point(106, 244);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 27);
            this.textBox5.TabIndex = 17;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(63, 208);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(827, 32);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "Number of authors that their books hadn\'t any buyers during last month";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(63, 277);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(319, 32);
            this.textBox8.TabIndex = 18;
            this.textBox8.Text = "Authors that hadn\'t upload any books yet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(444, 82);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(63, 419);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(827, 32);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "Category with minimum number of books";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox9.Enabled = false;
            this.textBox9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox9.Location = new System.Drawing.Point(106, 469);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(250, 27);
            this.textBox9.TabIndex = 21;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(106, 561);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(585, 115);
            this.dataGridView2.TabIndex = 22;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(63, 502);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(827, 32);
            this.textBox10.TabIndex = 23;
            this.textBox10.Text = "Readers information";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SqlQueriesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1093, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "SqlQueriesReport";
            this.Text = "SqlQueriesReport";
            this.Load += new System.EventHandler(this.SqlQueriesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private DataGridView dataGridView1;
        private TextBox textBox7;
        private TextBox textBox9;
        private DataGridView dataGridView2;
        private TextBox textBox10;
        private Button button1;
    }
}