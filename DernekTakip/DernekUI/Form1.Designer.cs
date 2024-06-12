
namespace DernekUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListMember = new System.Windows.Forms.DataGridView();
            this.gbxAddMember = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxTcId = new System.Windows.Forms.TextBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxBloodGroup = new System.Windows.Forms.ComboBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.rtbxAddress = new System.Windows.Forms.RichTextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lblTcId = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUpdateEmail = new System.Windows.Forms.TextBox();
            this.tbxUpdateTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxUpdateCity = new System.Windows.Forms.ComboBox();
            this.cbxUpdateBloodGroup = new System.Windows.Forms.ComboBox();
            this.cbxUpdateGender = new System.Windows.Forms.ComboBox();
            this.tbxUpdateFirstname = new System.Windows.Forms.TextBox();
            this.rtbxUpdateAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxUpdateLastname = new System.Windows.Forms.TextBox();
            this.tbxUpdatePhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxUpdateStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMember)).BeginInit();
            this.gbxAddMember.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListMember
            // 
            this.dgvListMember.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMember.Location = new System.Drawing.Point(3, 12);
            this.dgvListMember.Name = "dgvListMember";
            this.dgvListMember.Size = new System.Drawing.Size(1225, 235);
            this.dgvListMember.TabIndex = 29;
            this.dgvListMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListMember_CellClick);
            // 
            // gbxAddMember
            // 
            this.gbxAddMember.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxAddMember.Controls.Add(this.lblEmail);
            this.gbxAddMember.Controls.Add(this.tbxEmail);
            this.gbxAddMember.Controls.Add(this.tbxTcId);
            this.gbxAddMember.Controls.Add(this.lblBloodGroup);
            this.gbxAddMember.Controls.Add(this.btnAddMember);
            this.gbxAddMember.Controls.Add(this.cbxCity);
            this.gbxAddMember.Controls.Add(this.cbxBloodGroup);
            this.gbxAddMember.Controls.Add(this.cbxGender);
            this.gbxAddMember.Controls.Add(this.tbxFirstName);
            this.gbxAddMember.Controls.Add(this.rtbxAddress);
            this.gbxAddMember.Controls.Add(this.lblFirstName);
            this.gbxAddMember.Controls.Add(this.lblCity);
            this.gbxAddMember.Controls.Add(this.lblLastName);
            this.gbxAddMember.Controls.Add(this.lblAddress);
            this.gbxAddMember.Controls.Add(this.tbxLastName);
            this.gbxAddMember.Controls.Add(this.tbxPhone);
            this.gbxAddMember.Controls.Add(this.lblTcId);
            this.gbxAddMember.Controls.Add(this.lblPhone);
            this.gbxAddMember.Controls.Add(this.lblGender);
            this.gbxAddMember.Location = new System.Drawing.Point(22, 263);
            this.gbxAddMember.Name = "gbxAddMember";
            this.gbxAddMember.Size = new System.Drawing.Size(528, 280);
            this.gbxAddMember.TabIndex = 28;
            this.gbxAddMember.TabStop = false;
            this.gbxAddMember.Text = "Üye Ekleme";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(78, 173);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(160, 20);
            this.tbxEmail.TabIndex = 23;
            // 
            // tbxTcId
            // 
            this.tbxTcId.Location = new System.Drawing.Point(78, 30);
            this.tbxTcId.Name = "tbxTcId";
            this.tbxTcId.Size = new System.Drawing.Size(160, 20);
            this.tbxTcId.TabIndex = 7;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(266, 33);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(58, 13);
            this.lblBloodGroup.TabIndex = 11;
            this.lblBloodGroup.Text = "Kan Grubu";
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAddMember.Image = global::DernekUI.Properties.Resources.kayit;
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.Location = new System.Drawing.Point(216, 204);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(84, 57);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Ekle";
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
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
            this.cbxCity.Location = new System.Drawing.Point(342, 98);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(160, 21);
            this.cbxCity.TabIndex = 21;
            // 
            // cbxBloodGroup
            // 
            this.cbxBloodGroup.FormattingEnabled = true;
            this.cbxBloodGroup.Items.AddRange(new object[] {
            "A Rh+",
            "0 Rh+",
            "B Rh+",
            "AB Rh+",
            "A Rh-",
            "0 Rh-",
            "B Rh-",
            "AB Rh-"});
            this.cbxBloodGroup.Location = new System.Drawing.Point(342, 30);
            this.cbxBloodGroup.Name = "cbxBloodGroup";
            this.cbxBloodGroup.Size = new System.Drawing.Size(160, 21);
            this.cbxBloodGroup.TabIndex = 20;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(78, 135);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(160, 21);
            this.cbxGender.TabIndex = 19;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(78, 63);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(160, 20);
            this.tbxFirstName.TabIndex = 2;
            // 
            // rtbxAddress
            // 
            this.rtbxAddress.Location = new System.Drawing.Point(342, 135);
            this.rtbxAddress.Name = "rtbxAddress";
            this.rtbxAddress.Size = new System.Drawing.Size(160, 47);
            this.rtbxAddress.TabIndex = 18;
            this.rtbxAddress.Text = "";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(20, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Ad";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(266, 101);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 13);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "Şehir";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 101);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(37, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Soyad";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(266, 138);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(34, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Adres";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(78, 98);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(160, 20);
            this.tbxLastName.TabIndex = 5;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(342, 63);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(160, 20);
            this.tbxPhone.TabIndex = 13;
            // 
            // lblTcId
            // 
            this.lblTcId.AutoSize = true;
            this.lblTcId.Location = new System.Drawing.Point(6, 30);
            this.lblTcId.Name = "lblTcId";
            this.lblTcId.Size = new System.Drawing.Size(20, 13);
            this.lblTcId.TabIndex = 6;
            this.lblTcId.Text = "Tc";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(266, 66);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Telefon";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 138);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(43, 13);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Cinsiyet";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxUpdateStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxUpdateEmail);
            this.groupBox1.Controls.Add(this.tbxUpdateTc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.cbxUpdateCity);
            this.groupBox1.Controls.Add(this.cbxUpdateBloodGroup);
            this.groupBox1.Controls.Add(this.cbxUpdateGender);
            this.groupBox1.Controls.Add(this.tbxUpdateFirstname);
            this.groupBox1.Controls.Add(this.rtbxUpdateAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxUpdateLastname);
            this.groupBox1.Controls.Add(this.tbxUpdatePhone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(586, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 280);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Güncelleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email";
            // 
            // tbxUpdateEmail
            // 
            this.tbxUpdateEmail.Location = new System.Drawing.Point(78, 176);
            this.tbxUpdateEmail.Name = "tbxUpdateEmail";
            this.tbxUpdateEmail.Size = new System.Drawing.Size(160, 20);
            this.tbxUpdateEmail.TabIndex = 23;
            // 
            // tbxUpdateTc
            // 
            this.tbxUpdateTc.Location = new System.Drawing.Point(78, 30);
            this.tbxUpdateTc.Name = "tbxUpdateTc";
            this.tbxUpdateTc.Size = new System.Drawing.Size(160, 20);
            this.tbxUpdateTc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kan Grubu";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUpdate.Image = global::DernekUI.Properties.Resources.guncelle;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(87, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 55);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxUpdateCity
            // 
            this.cbxUpdateCity.FormattingEnabled = true;
            this.cbxUpdateCity.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.cbxUpdateCity.Location = new System.Drawing.Point(326, 98);
            this.cbxUpdateCity.Name = "cbxUpdateCity";
            this.cbxUpdateCity.Size = new System.Drawing.Size(160, 21);
            this.cbxUpdateCity.TabIndex = 21;
            // 
            // cbxUpdateBloodGroup
            // 
            this.cbxUpdateBloodGroup.FormattingEnabled = true;
            this.cbxUpdateBloodGroup.Items.AddRange(new object[] {
            "A Rh+",
            "0 Rh+",
            "B Rh+",
            "AB Rh+",
            "A Rh-",
            "0 Rh-",
            "B Rh-",
            "AB Rh-"});
            this.cbxUpdateBloodGroup.Location = new System.Drawing.Point(326, 27);
            this.cbxUpdateBloodGroup.Name = "cbxUpdateBloodGroup";
            this.cbxUpdateBloodGroup.Size = new System.Drawing.Size(160, 21);
            this.cbxUpdateBloodGroup.TabIndex = 20;
            // 
            // cbxUpdateGender
            // 
            this.cbxUpdateGender.FormattingEnabled = true;
            this.cbxUpdateGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxUpdateGender.Location = new System.Drawing.Point(78, 135);
            this.cbxUpdateGender.Name = "cbxUpdateGender";
            this.cbxUpdateGender.Size = new System.Drawing.Size(160, 21);
            this.cbxUpdateGender.TabIndex = 19;
            // 
            // tbxUpdateFirstname
            // 
            this.tbxUpdateFirstname.Location = new System.Drawing.Point(78, 63);
            this.tbxUpdateFirstname.Name = "tbxUpdateFirstname";
            this.tbxUpdateFirstname.Size = new System.Drawing.Size(160, 20);
            this.tbxUpdateFirstname.TabIndex = 2;
            // 
            // rtbxUpdateAddress
            // 
            this.rtbxUpdateAddress.Location = new System.Drawing.Point(326, 135);
            this.rtbxUpdateAddress.Name = "rtbxUpdateAddress";
            this.rtbxUpdateAddress.Size = new System.Drawing.Size(160, 47);
            this.rtbxUpdateAddress.TabIndex = 18;
            this.rtbxUpdateAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Şehir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adres";
            // 
            // tbxUpdateLastname
            // 
            this.tbxUpdateLastname.Location = new System.Drawing.Point(78, 98);
            this.tbxUpdateLastname.Name = "tbxUpdateLastname";
            this.tbxUpdateLastname.Size = new System.Drawing.Size(160, 20);
            this.tbxUpdateLastname.TabIndex = 5;
            // 
            // tbxUpdatePhone
            // 
            this.tbxUpdatePhone.Location = new System.Drawing.Point(326, 63);
            this.tbxUpdatePhone.Name = "tbxUpdatePhone";
            this.tbxUpdatePhone.Size = new System.Drawing.Size(160, 20);
            this.tbxUpdatePhone.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cinsiyet";
            // 
            // cbxUpdateStatus
            // 
            this.cbxUpdateStatus.FormattingEnabled = true;
            this.cbxUpdateStatus.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cbxUpdateStatus.Location = new System.Drawing.Point(326, 204);
            this.cbxUpdateStatus.Name = "cbxUpdateStatus";
            this.cbxUpdateStatus.Size = new System.Drawing.Size(160, 21);
            this.cbxUpdateStatus.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Durumu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1240, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListMember);
            this.Controls.Add(this.gbxAddMember);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMember)).EndInit();
            this.gbxAddMember.ResumeLayout(false);
            this.gbxAddMember.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListMember;
        private System.Windows.Forms.GroupBox gbxAddMember;
        private System.Windows.Forms.TextBox tbxTcId;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxBloodGroup;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.RichTextBox rtbxAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lblTcId;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUpdateEmail;
        private System.Windows.Forms.TextBox tbxUpdateTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUpdateCity;
        private System.Windows.Forms.ComboBox cbxUpdateBloodGroup;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateGender;
        private System.Windows.Forms.TextBox tbxUpdateFirstname;
        private System.Windows.Forms.RichTextBox rtbxUpdateAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxUpdateLastname;
        private System.Windows.Forms.TextBox tbxUpdatePhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUpdateStatus;
    }
}

