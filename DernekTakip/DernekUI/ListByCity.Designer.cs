
namespace DernekUI
{
    partial class ListByCity
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
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.dgvListCity = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListByCity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCity)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
            "All",
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cbxCity.Location = new System.Drawing.Point(264, 98);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(121, 21);
            this.cbxCity.TabIndex = 4;
            this.cbxCity.Text = "All";
            // 
            // dgvListCity
            // 
            this.dgvListCity.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCity.Location = new System.Drawing.Point(47, 148);
            this.dgvListCity.Name = "dgvListCity";
            this.dgvListCity.Size = new System.Drawing.Size(1039, 191);
            this.dgvListCity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(278, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şehre Göre Üye Listeleme Sayfası";
            // 
            // btnListByCity
            // 
            this.btnListByCity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListByCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnListByCity.Image = global::DernekUI.Properties.Resources.listele;
            this.btnListByCity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListByCity.Location = new System.Drawing.Point(418, 79);
            this.btnListByCity.Name = "btnListByCity";
            this.btnListByCity.Size = new System.Drawing.Size(126, 55);
            this.btnListByCity.TabIndex = 5;
            this.btnListByCity.Text = "Listele";
            this.btnListByCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListByCity.UseVisualStyleBackColor = false;
            this.btnListByCity.Click += new System.EventHandler(this.btnListByCity_Click);
            // 
            // ListByCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListByCity);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.dgvListCity);
            this.Name = "ListByCity";
            this.Text = "ListByCity";
            this.Load += new System.EventHandler(this.ListByCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListByCity;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.DataGridView dgvListCity;
        private System.Windows.Forms.Label label1;
    }
}