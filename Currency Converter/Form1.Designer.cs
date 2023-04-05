namespace Currency_Converter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nominal_inp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dari_cmb = new System.Windows.Forms.ComboBox();
            this.hasil_txt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ke_cmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(140, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            // 
            // nominal_inp
            // 
            this.nominal_inp.Location = new System.Drawing.Point(56, 144);
            this.nominal_inp.Margin = new System.Windows.Forms.Padding(6);
            this.nominal_inp.Name = "nominal_inp";
            this.nominal_inp.Size = new System.Drawing.Size(236, 31);
            this.nominal_inp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nominal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dari";
            // 
            // dari_cmb
            // 
            this.dari_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dari_cmb.FormattingEnabled = true;
            this.dari_cmb.Items.AddRange(new object[] {
            "USD",
            "MYR",
            "CNY",
            "SGD",
            "JPY"});
            this.dari_cmb.Location = new System.Drawing.Point(354, 142);
            this.dari_cmb.Margin = new System.Windows.Forms.Padding(6);
            this.dari_cmb.Name = "dari_cmb";
            this.dari_cmb.Size = new System.Drawing.Size(232, 33);
            this.dari_cmb.TabIndex = 4;
            // 
            // hasil_txt
            // 
            this.hasil_txt.AutoSize = true;
            this.hasil_txt.BackColor = System.Drawing.SystemColors.Menu;
            this.hasil_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hasil_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil_txt.ForeColor = System.Drawing.Color.Goldenrod;
            this.hasil_txt.Location = new System.Drawing.Point(38, 210);
            this.hasil_txt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hasil_txt.Name = "hasil_txt";
            this.hasil_txt.Size = new System.Drawing.Size(153, 67);
            this.hasil_txt.TabIndex = 5;
            this.hasil_txt.Text = "hasil";
            this.hasil_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(620, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 83);
            this.button1.TabIndex = 6;
            this.button1.Text = "Konversi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ke_cmb
            // 
            this.ke_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ke_cmb.FormattingEnabled = true;
            this.ke_cmb.Items.AddRange(new object[] {
            "USD",
            "MYR",
            "CNY",
            "SGD",
            "JPY"});
            this.ke_cmb.Location = new System.Drawing.Point(646, 144);
            this.ke_cmb.Margin = new System.Windows.Forms.Padding(6);
            this.ke_cmb.Name = "ke_cmb";
            this.ke_cmb.Size = new System.Drawing.Size(232, 33);
            this.ke_cmb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ke";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(48, 290);
            this.date_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(54, 26);
            this.date_label.TabIndex = 9;
            this.date_label.Text = "date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(459, 64);
            this.button2.TabIndex = 10;
            this.button2.Text = "Open Google Currency Converter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 425);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(902, 321);
            this.webBrowser1.TabIndex = 11;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(926, 758);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.ke_cmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hasil_txt);
            this.Controls.Add(this.dari_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nominal_inp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nominal_inp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dari_cmb;
        private System.Windows.Forms.Label hasil_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ke_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

