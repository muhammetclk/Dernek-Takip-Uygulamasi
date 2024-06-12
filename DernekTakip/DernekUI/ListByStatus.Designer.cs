
namespace DernekUI
{
    partial class ListByStatus
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
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.dgvListStatus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListByStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "All",
            "Aktif",
            "Pasif"});
            this.cbxStatus.Location = new System.Drawing.Point(257, 87);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(120, 21);
            this.cbxStatus.TabIndex = 7;
            this.cbxStatus.Text = "All";
            // 
            // dgvListStatus
            // 
            this.dgvListStatus.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStatus.Location = new System.Drawing.Point(59, 132);
            this.dgvListStatus.Name = "dgvListStatus";
            this.dgvListStatus.Size = new System.Drawing.Size(994, 193);
            this.dgvListStatus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(229, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Durumuna (Aktif/Pasif) Göre Üye Listeleme ";
            // 
            // btnListByStatus
            // 
            this.btnListByStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListByStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnListByStatus.Image = global::DernekUI.Properties.Resources.listele;
            this.btnListByStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListByStatus.Location = new System.Drawing.Point(395, 64);
            this.btnListByStatus.Name = "btnListByStatus";
            this.btnListByStatus.Size = new System.Drawing.Size(117, 62);
            this.btnListByStatus.TabIndex = 8;
            this.btnListByStatus.Text = "Listele";
            this.btnListByStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListByStatus.UseVisualStyleBackColor = false;
            this.btnListByStatus.Click += new System.EventHandler(this.btnListByStatus_Click);
            // 
            // ListByStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1189, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListByStatus);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.dgvListStatus);
            this.Name = "ListByStatus";
            this.Text = "ListByStatus";
            this.Load += new System.EventHandler(this.ListByStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListByStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.DataGridView dgvListStatus;
        private System.Windows.Forms.Label label1;
    }
}