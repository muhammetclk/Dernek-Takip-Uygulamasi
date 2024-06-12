
namespace DernekUI
{
    partial class DuesPlans
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
            this.dgvListDuesPlans = new System.Windows.Forms.DataGridView();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.tbxDuesAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddDues = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDuesPlans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListDuesPlans
            // 
            this.dgvListDuesPlans.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListDuesPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDuesPlans.Location = new System.Drawing.Point(64, 159);
            this.dgvListDuesPlans.Name = "dgvListDuesPlans";
            this.dgvListDuesPlans.Size = new System.Drawing.Size(460, 150);
            this.dgvListDuesPlans.TabIndex = 0;
            // 
            // cbxMonth
            // 
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cbxMonth.Location = new System.Drawing.Point(122, 33);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(121, 21);
            this.cbxMonth.TabIndex = 2;
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbxYear.Location = new System.Drawing.Point(122, 75);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 21);
            this.cbxYear.TabIndex = 3;
            // 
            // tbxDuesAmount
            // 
            this.tbxDuesAmount.Location = new System.Drawing.Point(122, 114);
            this.tbxDuesAmount.Name = "tbxDuesAmount";
            this.tbxDuesAmount.Size = new System.Drawing.Size(121, 20);
            this.tbxDuesAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yıl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Miktar";
            // 
            // btnAddDues
            // 
            this.btnAddDues.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddDues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAddDues.Image = global::DernekUI.Properties.Resources.ekle;
            this.btnAddDues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDues.Location = new System.Drawing.Point(275, 57);
            this.btnAddDues.Name = "btnAddDues";
            this.btnAddDues.Size = new System.Drawing.Size(165, 52);
            this.btnAddDues.TabIndex = 1;
            this.btnAddDues.Text = "Yeni Aidat Ekle";
            this.btnAddDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDues.UseVisualStyleBackColor = false;
            this.btnAddDues.Click += new System.EventHandler(this.btnAddDues_Click);
            // 
            // DuesPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDuesAmount);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.cbxMonth);
            this.Controls.Add(this.btnAddDues);
            this.Controls.Add(this.dgvListDuesPlans);
            this.Name = "DuesPlans";
            this.Text = "DuesPlans";
            this.Load += new System.EventHandler(this.DuesPlans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDuesPlans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListDuesPlans;
        private System.Windows.Forms.Button btnAddDues;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.TextBox tbxDuesAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}