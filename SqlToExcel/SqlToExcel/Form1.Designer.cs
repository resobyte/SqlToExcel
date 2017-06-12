namespace SqlToExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Database = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MultiCompanyDate = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Button();
            this.Company = new System.Windows.Forms.Button();
            this.SonrakiT = new System.Windows.Forms.Label();
            this.OncekiT = new System.Windows.Forms.Label();
            this.Aralık = new System.Windows.Forms.Label();
            this.sonrakiDate = new System.Windows.Forms.DateTimePicker();
            this.oncekiDate = new System.Windows.Forms.DateTimePicker();
            this.Company_Name = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(15, 35);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(121, 33);
            this.Database.TabIndex = 0;
            this.Database.Text = "Bütün Verileri Raporla";
            this.Database.UseVisualStyleBackColor = true;
            this.Database.Click += new System.EventHandler(this.Database_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 261);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.Database);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standart Veri Analizi";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.MultiCompanyDate);
            this.tabPage2.Controls.Add(this.Date);
            this.tabPage2.Controls.Add(this.Company);
            this.tabPage2.Controls.Add(this.SonrakiT);
            this.tabPage2.Controls.Add(this.OncekiT);
            this.tabPage2.Controls.Add(this.Aralık);
            this.tabPage2.Controls.Add(this.sonrakiDate);
            this.tabPage2.Controls.Add(this.oncekiDate);
            this.tabPage2.Controls.Add(this.Company_Name);
            this.tabPage2.Controls.Add(this.CompanyName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(369, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detaylı Veri Analizi";
            // 
            // MultiCompanyDate
            // 
            this.MultiCompanyDate.Location = new System.Drawing.Point(259, 184);
            this.MultiCompanyDate.Name = "MultiCompanyDate";
            this.MultiCompanyDate.Size = new System.Drawing.Size(104, 48);
            this.MultiCompanyDate.TabIndex = 9;
            this.MultiCompanyDate.Text = "Şirket ve Tarih Aralığına Göre Raporla";
            this.MultiCompanyDate.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(270, 112);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(93, 57);
            this.Date.TabIndex = 8;
            this.Date.Text = "Sadece Tarih Aralığına Göre Raporla";
            this.Date.UseVisualStyleBackColor = true;
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // Company
            // 
            this.Company.Location = new System.Drawing.Point(215, 17);
            this.Company.Name = "Company";
            this.Company.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Company.Size = new System.Drawing.Size(75, 49);
            this.Company.TabIndex = 7;
            this.Company.Text = "Sadece Şirkete Göre Raporla";
            this.Company.UseVisualStyleBackColor = true;
            this.Company.Click += new System.EventHandler(this.Company_Click);
            // 
            // SonrakiT
            // 
            this.SonrakiT.AutoSize = true;
            this.SonrakiT.Location = new System.Drawing.Point(9, 149);
            this.SonrakiT.Name = "SonrakiT";
            this.SonrakiT.Size = new System.Drawing.Size(40, 13);
            this.SonrakiT.TabIndex = 6;
            this.SonrakiT.Text = "2.Tarih";
            // 
            // OncekiT
            // 
            this.OncekiT.AutoSize = true;
            this.OncekiT.Location = new System.Drawing.Point(6, 105);
            this.OncekiT.Name = "OncekiT";
            this.OncekiT.Size = new System.Drawing.Size(40, 13);
            this.OncekiT.TabIndex = 5;
            this.OncekiT.Text = "1.Tarih";
            // 
            // Aralık
            // 
            this.Aralık.AutoSize = true;
            this.Aralık.Location = new System.Drawing.Point(59, 89);
            this.Aralık.Name = "Aralık";
            this.Aralık.Size = new System.Drawing.Size(62, 13);
            this.Aralık.TabIndex = 4;
            this.Aralık.Text = "Tarih Aralığı";
            // 
            // sonrakiDate
            // 
            this.sonrakiDate.Location = new System.Drawing.Point(62, 149);
            this.sonrakiDate.Name = "sonrakiDate";
            this.sonrakiDate.Size = new System.Drawing.Size(191, 20);
            this.sonrakiDate.TabIndex = 3;
            // 
            // oncekiDate
            // 
            this.oncekiDate.Location = new System.Drawing.Point(62, 105);
            this.oncekiDate.Name = "oncekiDate";
            this.oncekiDate.Size = new System.Drawing.Size(191, 20);
            this.oncekiDate.TabIndex = 2;
            // 
            // Company_Name
            // 
            this.Company_Name.AutoSize = true;
            this.Company_Name.Location = new System.Drawing.Point(59, 16);
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.Size = new System.Drawing.Size(55, 13);
            this.Company_Name.TabIndex = 1;
            this.Company_Name.Text = "Şirket İsmi";
            // 
            // CompanyName
            // 
            this.CompanyName.FormattingEnabled = true;
            this.CompanyName.Location = new System.Drawing.Point(62, 32);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(121, 21);
            this.CompanyName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(496, 321);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bizcom Report System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Database;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label SonrakiT;
        private System.Windows.Forms.Label OncekiT;
        private System.Windows.Forms.Label Aralık;
        private System.Windows.Forms.DateTimePicker sonrakiDate;
        private System.Windows.Forms.DateTimePicker oncekiDate;
        private System.Windows.Forms.Label Company_Name;
        private System.Windows.Forms.ComboBox CompanyName;
        private System.Windows.Forms.Button MultiCompanyDate;
        private System.Windows.Forms.Button Date;
        private System.Windows.Forms.Button Company;
    }
}

