
namespace DernekUI
{
    partial class PayerAndNonPayers
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
            this.dgvListPaidMembers = new System.Windows.Forms.DataGridView();
            this.dgvListUnpaidMembers = new System.Windows.Forms.DataGridView();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEndMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEndYear = new System.Windows.Forms.ComboBox();
            this.btnList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPaidMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUnpaidMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListPaidMembers
            // 
            this.dgvListPaidMembers.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListPaidMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPaidMembers.Location = new System.Drawing.Point(45, 56);
            this.dgvListPaidMembers.Name = "dgvListPaidMembers";
            this.dgvListPaidMembers.Size = new System.Drawing.Size(381, 150);
            this.dgvListPaidMembers.TabIndex = 0;
            // 
            // dgvListUnpaidMembers
            // 
            this.dgvListUnpaidMembers.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListUnpaidMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUnpaidMembers.Location = new System.Drawing.Point(45, 256);
            this.dgvListUnpaidMembers.Name = "dgvListUnpaidMembers";
            this.dgvListUnpaidMembers.Size = new System.Drawing.Size(381, 150);
            this.dgvListUnpaidMembers.TabIndex = 1;
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
            this.cbxMonth.Location = new System.Drawing.Point(578, 35);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(121, 21);
            this.cbxMonth.TabIndex = 3;
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
            this.cbxYear.Location = new System.Drawing.Point(578, 62);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 21);
            this.cbxYear.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Başlangıç Ay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Başlangıç Yıl";
            // 
            // cbxEndMonth
            // 
            this.cbxEndMonth.FormattingEnabled = true;
            this.cbxEndMonth.Items.AddRange(new object[] {
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
            this.cbxEndMonth.Location = new System.Drawing.Point(578, 90);
            this.cbxEndMonth.Name = "cbxEndMonth";
            this.cbxEndMonth.Size = new System.Drawing.Size(121, 21);
            this.cbxEndMonth.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitiş Ay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bitiş Yıl";
            // 
            // cbxEndYear
            // 
            this.cbxEndYear.FormattingEnabled = true;
            this.cbxEndYear.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbxEndYear.Location = new System.Drawing.Point(578, 123);
            this.cbxEndYear.Name = "cbxEndYear";
            this.cbxEndYear.Size = new System.Drawing.Size(121, 21);
            this.cbxEndYear.TabIndex = 11;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnList.Image = global::DernekUI.Properties.Resources.listele;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(588, 150);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(111, 56);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "Listele ";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(136, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ödeme Yapanlar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(136, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ödeme Yapmayanlar";
            // 
            // PayerAndNonPayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.cbxEndYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxEndMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.cbxMonth);
            this.Controls.Add(this.dgvListUnpaidMembers);
            this.Controls.Add(this.dgvListPaidMembers);
            this.Name = "PayerAndNonPayers";
            this.Text = "PayerAndNonPayers";
            this.Load += new System.EventHandler(this.PayerAndNonPayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPaidMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUnpaidMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListPaidMembers;
        private System.Windows.Forms.DataGridView dgvListUnpaidMembers;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEndMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEndYear;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}