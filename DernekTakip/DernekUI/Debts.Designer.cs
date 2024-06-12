
namespace DernekUI
{
    partial class Debts
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
            this.dgvListDebts = new System.Windows.Forms.DataGridView();
            this.rtxMailBody = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnSavePdf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDebts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListDebts
            // 
            this.dgvListDebts.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDebts.Location = new System.Drawing.Point(12, 41);
            this.dgvListDebts.Name = "dgvListDebts";
            this.dgvListDebts.Size = new System.Drawing.Size(960, 150);
            this.dgvListDebts.TabIndex = 0;
            // 
            // rtxMailBody
            // 
            this.rtxMailBody.Location = new System.Drawing.Point(87, 255);
            this.rtxMailBody.Name = "rtxMailBody";
            this.rtxMailBody.Size = new System.Drawing.Size(311, 96);
            this.rtxMailBody.TabIndex = 3;
            this.rtxMailBody.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(276, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Borcu Olan Üyeler Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(154, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mail İçeriği Giriniz";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSendMail.Image = global::DernekUI.Properties.Resources.mail;
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.Location = new System.Drawing.Point(419, 280);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(211, 58);
            this.btnSendMail.TabIndex = 2;
            this.btnSendMail.Text = "Borcu Olanlara Mail At";
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnSavePdf
            // 
            this.btnSavePdf.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSavePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSavePdf.Image = global::DernekUI.Properties.Resources.Save_icon;
            this.btnSavePdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePdf.Location = new System.Drawing.Point(735, 197);
            this.btnSavePdf.Name = "btnSavePdf";
            this.btnSavePdf.Size = new System.Drawing.Size(175, 55);
            this.btnSavePdf.TabIndex = 1;
            this.btnSavePdf.Text = "PDF Olarak Kaydet";
            this.btnSavePdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavePdf.UseVisualStyleBackColor = false;
            this.btnSavePdf.Click += new System.EventHandler(this.btnSavePdf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(416, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplu Olarak Gönderir. Biraz zaman alıyor";
            // 
            // Debts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxMailBody);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnSavePdf);
            this.Controls.Add(this.dgvListDebts);
            this.Name = "Debts";
            this.Text = "Debts";
            this.Load += new System.EventHandler(this.Debts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDebts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListDebts;
        private System.Windows.Forms.Button btnSavePdf;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.RichTextBox rtxMailBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}