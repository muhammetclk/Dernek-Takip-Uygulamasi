using BusinessService;
using DataAccess;
using iText.Kernel.Pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekUI
{
    public partial class Debts : Form
    {

        BusinessManager businessManager = new BusinessManager(new AccessDatabaseDal("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakip.accdb"), new MemberCheckService(), new DuesPlanCheckService(), new DuesPaymentsCheckService());

        public Debts()
        {
            InitializeComponent();
        }


       

        void debts_list()
        {
            dgvListDebts.DataSource = "";
            dgvListDebts.DataSource = businessManager.debts_list().Tables[0];

           

           
            dgvListDebts.Columns[0].HeaderText = "Ad";
            dgvListDebts.Columns[1].HeaderText = "Soyad";
            dgvListDebts.Columns[2].HeaderText = "TC";
            dgvListDebts.Columns[3].HeaderText = "Ay";
            dgvListDebts.Columns[4].HeaderText = "Yıl";
            dgvListDebts.Columns[5].HeaderText = "Aidat Miktarı";
            dgvListDebts.Columns[6].HeaderText = "Ödenen Miktar";
            dgvListDebts.Columns[7].HeaderText = "Borç Miktarı";
            dgvListDebts.Columns[8].HeaderText = "E mail";
        }
    

        private void Debts_Load(object sender, EventArgs e)
        {
            debts_list();
        }

        private void btnSavePdf_Click(object sender, EventArgs e)
        {
            DataSet dataSet = businessManager.debts_list();
            DataTable dataTable = dataSet.Tables[0];           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Dosyaları (*.pdf)|*.pdf";
            saveFileDialog.Title = "PDF Dosyasını Kaydet";
            saveFileDialog.FileName = "BorcuOlanlar.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {                
                string dosyaYolu = saveFileDialog.FileName;
                try
                {
                    // PDF dosyasını oluşturun
                    using (FileStream fs = new FileStream(dosyaYolu, FileMode.Create))
                    {
                        using (iTextSharp.text.Document document = new iTextSharp.text.Document())
                        {
                            using (iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, fs))
                            {
                                document.Open();                               
                                document.Add(new iTextSharp.text.Paragraph("Borcu Olan Üyeler Listesi"));
                                // DataTable'dan verileri okuyarak PDF'ye ekleme
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    document.Add(new iTextSharp.text.Paragraph($"Ad: {row["member_firstname"]}, Soyad: {row["member_lastname"]}, TC: {row["tc"]}, Ay: {row["dues_month"]}, Yıl: {row["dues_year"]}, Aidat Miktarı: {row["dues_amount"]}, Ödenen Miktar: {row["paid_amount"]}, Borç Miktarı: {row["debts"]}"));
                                }
                            }
                        } 
                        MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                 
                }
                catch (Exception ex)
                {}
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            DataSet dataSet = businessManager.debts_list();
            DataTable dataTable = dataSet.Tables[0];
            try
            {
                // SMTP ayarları
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("muhammetclk5656@gmail.com", "ezym ovdx tudq nzjw"),
                    EnableSsl = true,
                };
                // E-posta gönderme
                foreach (DataRow row in dataTable.Rows)
                {
                    string toAddress = row["email"].ToString();
                    string subject = "Borç Hatırlatma";
                    string body = rtxMailBody.Text;
                    SendEmail(smtpClient, toAddress, subject, body);
                }
                MessageBox.Show("E-postalar başarıyla gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-posta gönderme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SendEmail(SmtpClient smtpClient, string toAddress, string subject, string body)
        {
            try
            {
                // E-posta oluşturma
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("your@gmail.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false,
                };

                mailMessage.To.Add(toAddress);

                // E-posta gönderme
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                // E-posta gönderme hatası
                Console.WriteLine($"E-posta gönderme hatası ({toAddress}): {ex.Message}");
            }
        }


    }
}
