
namespace DernekUI
{
    partial class ListByBloodGroup
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
            this.dgvListBloodGroup = new System.Windows.Forms.DataGridView();
            this.cbxBloodGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListByBloodGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBloodGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListBloodGroup
            // 
            this.dgvListBloodGroup.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListBloodGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBloodGroup.Location = new System.Drawing.Point(70, 156);
            this.dgvListBloodGroup.Name = "dgvListBloodGroup";
            this.dgvListBloodGroup.Size = new System.Drawing.Size(985, 150);
            this.dgvListBloodGroup.TabIndex = 0;
            // 
            // cbxBloodGroup
            // 
            this.cbxBloodGroup.FormattingEnabled = true;
            this.cbxBloodGroup.Items.AddRange(new object[] {
            "All",
            "A Rh+",
            "0 Rh+",
            "B Rh+",
            "AB Rh+",
            "A Rh-",
            "0 Rh-",
            "B Rh-",
            "AB Rh-"});
            this.cbxBloodGroup.Location = new System.Drawing.Point(233, 110);
            this.cbxBloodGroup.Name = "cbxBloodGroup";
            this.cbxBloodGroup.Size = new System.Drawing.Size(121, 21);
            this.cbxBloodGroup.TabIndex = 1;
            this.cbxBloodGroup.Text = "All";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(230, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kan Grubuna Göre Üye Listeleme Sayfası";
            // 
            // btnListByBloodGroup
            // 
            this.btnListByBloodGroup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListByBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnListByBloodGroup.Image = global::DernekUI.Properties.Resources.listele;
            this.btnListByBloodGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListByBloodGroup.Location = new System.Drawing.Point(383, 92);
            this.btnListByBloodGroup.Name = "btnListByBloodGroup";
            this.btnListByBloodGroup.Size = new System.Drawing.Size(108, 53);
            this.btnListByBloodGroup.TabIndex = 2;
            this.btnListByBloodGroup.Text = "Listele";
            this.btnListByBloodGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListByBloodGroup.UseVisualStyleBackColor = false;
            this.btnListByBloodGroup.Click += new System.EventHandler(this.btnListByBloodGroup_Click);
            // 
            // ListByBloodGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListByBloodGroup);
            this.Controls.Add(this.cbxBloodGroup);
            this.Controls.Add(this.dgvListBloodGroup);
            this.Name = "ListByBloodGroup";
            this.Text = "ListByBloodGroup";
            this.Load += new System.EventHandler(this.ListByBloodGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBloodGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListBloodGroup;
        private System.Windows.Forms.ComboBox cbxBloodGroup;
        private System.Windows.Forms.Button btnListByBloodGroup;
        private System.Windows.Forms.Label label1;
    }
}