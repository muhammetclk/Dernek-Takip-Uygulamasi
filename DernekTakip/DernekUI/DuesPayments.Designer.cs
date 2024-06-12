
namespace DernekUI
{
    partial class DuesPayments
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
            this.dgvListDuesPayments = new System.Windows.Forms.DataGridView();
            this.dgvListMembers = new System.Windows.Forms.DataGridView();
            this.dgvListDuesPlan = new System.Windows.Forms.DataGridView();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMemberId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDuesPlanId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDuesPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDuesPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListDuesPayments
            // 
            this.dgvListDuesPayments.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListDuesPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDuesPayments.Location = new System.Drawing.Point(12, 288);
            this.dgvListDuesPayments.Name = "dgvListDuesPayments";
            this.dgvListDuesPayments.Size = new System.Drawing.Size(865, 150);
            this.dgvListDuesPayments.TabIndex = 0;
            // 
            // dgvListMembers
            // 
            this.dgvListMembers.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMembers.Location = new System.Drawing.Point(12, 47);
            this.dgvListMembers.Name = "dgvListMembers";
            this.dgvListMembers.Size = new System.Drawing.Size(563, 85);
            this.dgvListMembers.TabIndex = 1;
            this.dgvListMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListMembers_CellClick);
            // 
            // dgvListDuesPlan
            // 
            this.dgvListDuesPlan.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListDuesPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDuesPlan.Location = new System.Drawing.Point(12, 166);
            this.dgvListDuesPlan.Name = "dgvListDuesPlan";
            this.dgvListDuesPlan.Size = new System.Drawing.Size(471, 85);
            this.dgvListDuesPlan.TabIndex = 2;
            this.dgvListDuesPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDuesPlan_CellClick);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(692, 166);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(583, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seçili Üyenin Yatırdığı Tutarı Giriniz";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAdd.Image = global::DernekUI.Properties.Resources.ekle;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(683, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 41);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Öde";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(106, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aidatını Yatıracağınız Üyeyi Seçin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(106, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aidatını Yatıracağınız Tarih Bilgisini Seçin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(206, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Üyelere Göre Yatırılan Aidat Bilgileri Listesi";
            // 
            // tbxMemberId
            // 
            this.tbxMemberId.Location = new System.Drawing.Point(692, 80);
            this.tbxMemberId.Name = "tbxMemberId";
            this.tbxMemberId.Size = new System.Drawing.Size(100, 20);
            this.tbxMemberId.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Üye İd";
            // 
            // tbxDuesPlanId
            // 
            this.tbxDuesPlanId.Location = new System.Drawing.Point(692, 112);
            this.tbxDuesPlanId.Name = "tbxDuesPlanId";
            this.tbxDuesPlanId.Size = new System.Drawing.Size(100, 20);
            this.tbxDuesPlanId.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aidat İd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(609, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Üye ve Aidat Bilgisini Tablolardan Seçiniz";
            // 
            // DuesPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxDuesPlanId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxMemberId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvListDuesPlan);
            this.Controls.Add(this.dgvListMembers);
            this.Controls.Add(this.dgvListDuesPayments);
            this.Name = "DuesPayments";
            this.Text = "DuesPayments";
            this.Load += new System.EventHandler(this.DuesPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDuesPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDuesPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListDuesPayments;
        private System.Windows.Forms.DataGridView dgvListMembers;
        private System.Windows.Forms.DataGridView dgvListDuesPlan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMemberId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDuesPlanId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}