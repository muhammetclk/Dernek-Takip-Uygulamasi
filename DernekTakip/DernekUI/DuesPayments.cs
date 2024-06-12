using BusinessService;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekUI
{
    public partial class DuesPayments : Form
    {
        BusinessManager businessManager = new BusinessManager(new AccessDatabaseDal("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakip.accdb"), new MemberCheckService(), new DuesPlanCheckService(), new DuesPaymentsCheckService());

        public DuesPayments()
        {
            InitializeComponent();
        }

        void dues_payments_list(){
            dgvListDuesPayments.DataSource = "";
            dgvListDuesPayments.DataSource = businessManager.dues_payments_list().Tables[0];         
            dgvListDuesPayments.Columns[0].HeaderText = "dues_payment_id";
            dgvListDuesPayments.Columns[1].HeaderText = "member_firstname";
            dgvListDuesPayments.Columns[2].HeaderText = "member_lastname";
            dgvListDuesPayments.Columns[3].HeaderText = "tc";
            dgvListDuesPayments.Columns[4].HeaderText = "dues_month";
            dgvListDuesPayments.Columns[5].HeaderText = "dues_year";
            dgvListDuesPayments.Columns[6].HeaderText = "dues_amount";
            dgvListDuesPayments.Columns[7].HeaderText = "paid_amount";}
        void list_active_members(){       
            dgvListMembers.DataSource = "";
            dgvListMembers.DataSource = businessManager.list_active_members().Tables[0];
            dgvListMembers.Columns[0].HeaderText = "member_id";
            dgvListMembers.Columns[1].HeaderText = "tc";
            dgvListMembers.Columns[2].HeaderText = "member_firstname";
            dgvListMembers.Columns[3].HeaderText = "member_lastname";
            dgvListMembers.Columns[4].HeaderText = "status";}   
        void dues_plan_list(){              
            DataSet dataSet = businessManager.dues_plan_list();
            dgvListDuesPlan.DataSource = dataSet.Tables["DuesPlans"];}
        private void DuesPayments_Load(object sender, EventArgs e){
            dues_payments_list();
            list_active_members();
            dues_plan_list();}
        


        
        int money;
        private void dgvListMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            tbxMemberId.Text =Convert.ToString(dgvListMembers.CurrentRow.Cells[0].Value);               
        }
        private void dgvListDuesPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            tbxDuesPlanId.Text=Convert.ToString(dgvListDuesPlan.CurrentRow.Cells[0].Value);
            money = Convert.ToInt32(dgvListDuesPlan.CurrentRow.Cells[3].Value);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {        
                if (tbxAmount.Text != ""&&tbxDuesPlanId.Text!=""&&tbxMemberId.Text!="" &&
                Convert.ToInt32(tbxAmount.Text) > 0 && money >= Convert.ToInt32(tbxAmount.Text)) {                   
                    if (businessManager.dues_payment_add(Convert.ToInt32(tbxMemberId.Text),
                        Convert.ToInt32(tbxDuesPlanId.Text), tbxAmount.Text, DateTime.Now.ToString()))
                    {
                        MessageBox.Show("Bu bilgilere ait aidat ödemesi zaten var. Ekleme işlemi başarısız.");
                    }
                    else
                    {
                        MessageBox.Show("Ekleme işlemi başarılı.");                       
                        dues_payments_list();
                    }
                }
                else
                {
                    MessageBox.Show("Boş Yer Bırakmayınız ve Aidat Tutarına eşit veya küçük bir değer giriniz.Aynı zamanda 0 dan büyük değer giriniz");
                }
        }

        

    }
}
