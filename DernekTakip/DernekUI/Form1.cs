using BusinessService;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekUI
{
    public partial class Form1 : Form
    {

        

        BusinessManager businessManager = new BusinessManager(
            new AccessDatabaseDal("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakip.accdb"),
            new MemberCheckService(),
            new DuesPlanCheckService(),
            new DuesPaymentsCheckService());

        public Form1()
        {
            InitializeComponent();
        }


        void member_list()
        {
            

           DataSet dataSet= businessManager.member_list();
            dgvListMember.DataSource = dataSet.Tables["Members"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            member_list();
        }

        public Boolean textler_bosMu()
        {
            if (tbxTcId.Text != "" &&
                tbxFirstName.Text != "" &&
                tbxLastName.Text != "" &&
                cbxGender.Text != "" &&
                cbxBloodGroup.Text != "" &&
                tbxPhone.Text != "" &&
                cbxCity.Text != "" &&
                rtbxAddress.Text != "" &&
                tbxEmail.Text != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
       
            public Boolean textler_bosMu2()
        {
            if (tbxUpdateTc.Text != "" && tbxUpdateFirstname.Text != "" && tbxUpdateLastname.Text != "" && cbxUpdateGender.Text != "" && cbxUpdateBloodGroup.Text != "" && tbxUpdatePhone.Text != "" && cbxUpdateCity.Text != "" && rtbxUpdateAddress.Text != "" && tbxUpdateEmail.Text != ""
)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        bool IsValidEmail(string email)
        {
            // E-posta adresinin genel formatta olup olmadığını kontrol etmek için regex
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            if (!regex.IsMatch(email))
            {
                return true;
            }
         
            return false;
        }




         bool IsValidPhoneNumber(string number)
        {
            // Telefon numarasının sadece sayılardan oluşup oluşmadığını kontrol etmek
            if (!number.All(char.IsDigit))
            {
                return true;
            }
            else if(number.Length != 10)
            {
                return true;
            }
            return false;                 
         }


        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (textler_bosMu()){
                MessageBox.Show("Boşta alan kalmasın. Ekleme işlemi başarısız.");}
            else{
                if (tbxTcId.Text.Length != 11 || !tbxTcId.Text.All(char.IsDigit)){
                    MessageBox.Show("Tc Numarası 11 haneli ve sadece sayılardan oluşmalıdır. Ekleme işlemi başarısız.");}
                else if (!tbxFirstName.Text.All(char.IsLetter)){
                    MessageBox.Show("isim karakterlerden oluşmalı");}
                else if (!tbxLastName.Text.All(char.IsLetter)){
                    MessageBox.Show("soyad karakterlerden oluşmalı");}
                else if (IsValidEmail(tbxEmail.Text)){
                    MessageBox.Show("email doğru formatta girilmedi");}
                else if (IsValidPhoneNumber(tbxPhone.Text)){
                    MessageBox.Show("telefon sayılardan oluşmalı ve 10 adet uzunluğunda olmalı ");}
                else{
                    if (businessManager.member_add(tbxFirstName.Text,
                        tbxLastName.Text,
                        tbxTcId.Text,
                        cbxBloodGroup.Text,
                        cbxGender.Text,
                        tbxPhone.Text,
                        tbxEmail.Text,
                        rtbxAddress.Text,
                        cbxCity.Text,
                        DateTime.Now.ToString())){
                    MessageBox.Show("Bu bilgilere ait üye zaten var. Ekleme işlemi başarısız.");}
                    else{                 
                    MessageBox.Show("Ekleme işlemi başarılı.");     
                    member_list();}
                }
            }                               
        }

        private void dgvListMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateTc.Text = dgvListMember.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateFirstname.Text = dgvListMember.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateLastname.Text = dgvListMember.CurrentRow.Cells[3].Value.ToString();
            cbxUpdateBloodGroup.Text = dgvListMember.CurrentRow.Cells[4].Value.ToString();
            cbxUpdateGender.Text = dgvListMember.CurrentRow.Cells[5].Value.ToString();
            tbxUpdatePhone.Text = dgvListMember.CurrentRow.Cells[6].Value.ToString();
            tbxUpdateEmail.Text = dgvListMember.CurrentRow.Cells[7].Value.ToString();
            rtbxUpdateAddress.Text = dgvListMember.CurrentRow.Cells[8].Value.ToString();
            cbxUpdateCity.Text = dgvListMember.CurrentRow.Cells[9].Value.ToString();
            cbxUpdateStatus.Text= dgvListMember.CurrentRow.Cells[10].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int member_id = Convert.ToInt32(dgvListMember.CurrentRow.Cells[0].Value);
            if (textler_bosMu2()){
            
                MessageBox.Show("Boşta alan kalmasın. Güncelleme işlemi başarısız.");}
            else{            
                if (tbxUpdateTc.Text.Length != 11 || !tbxUpdateTc.Text.All(char.IsDigit)){
                MessageBox.Show("Tc Numarası 11 haneli ve sadece sayılardan oluşmalıdır. Güncelleme işlemi başarısız.");
                }
                else if (!tbxUpdateFirstname.Text.All(char.IsLetter)){               
                    MessageBox.Show("isim karakterlerden oluşmalı");}               
                else if (!tbxUpdateLastname.Text.All(char.IsLetter)){             
                    MessageBox.Show("soyad karakterlerden oluşmalı");}               
                else if (IsValidEmail(tbxUpdateEmail.Text)){               
                    MessageBox.Show("email doğru formatta girilmedi");}              
                else if (IsValidPhoneNumber(tbxUpdatePhone.Text)){               
                    MessageBox.Show("telefon sayılardan oluşmalı ve 10 adet uzunluğunda olmalı ");}               
                else{               
                    if (businessManager.member_update(member_id,
                        tbxUpdateFirstname.Text,
                        tbxUpdateLastname.Text, tbxUpdateTc.Text, cbxUpdateBloodGroup.Text,
                        cbxUpdateGender.Text, tbxUpdatePhone.Text, tbxUpdateEmail.Text, rtbxUpdateAddress.Text,
                        cbxUpdateCity.Text,cbxUpdateStatus.Text)){                   
                        MessageBox.Show("Bu bilgilere ait üye zaten var. Güncelleme işlemi başarısız.");}                    
                    else{                   
                        MessageBox.Show("Güncelleme işlemi başarılı.");
                        member_list();}                   
                }
            }
        }        
    }
}
