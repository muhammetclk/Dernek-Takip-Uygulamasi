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
    public partial class PayerAndNonPayers : Form
    {
        BusinessManager businessManager = new BusinessManager(new AccessDatabaseDal("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakip.accdb"), new MemberCheckService(), new DuesPlanCheckService(), new DuesPaymentsCheckService());

        public PayerAndNonPayers()
        {
            InitializeComponent();
        }
        void list_paid_members()
        {
           /* dgvListPaidMembers.DataSource = "";
            dgvListPaidMembers.DataSource = businessManager.list_paid_members().Tables[0];

            //DataSet dataSet = businessManager.dues_payments_list();
            //dgvListDuesPayments.DataSource = dataSet.Tables["DuesPayments"];

            dgvListPaidMembers.Columns[0].HeaderText = "member_id";
            dgvListPaidMembers.Columns[1].HeaderText = "member_firstname";
            dgvListPaidMembers.Columns[2].HeaderText = "member_lastname";
            dgvListPaidMembers.Columns[3].HeaderText = "payment_date";*/
           
        }

        void list_unpaid_members()
        {

        }

        private void PayerAndNonPayers_Load(object sender, EventArgs e)
        {
            list_paid_members();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (cbxMonth.Text != "" && cbxYear.Text != "" && cbxEndMonth.Text != "" && cbxEndYear.Text !="")
            {


               // businessManager.list_paid_members(cbxMonth.Text, cbxYear.Text, cbxEndMonth.Text, cbxEndYear.Text);

                 dgvListPaidMembers.DataSource = "";
             dgvListPaidMembers.DataSource = businessManager.list_paid_members(cbxMonth.Text,Convert.ToInt32(cbxYear.Text), cbxEndMonth.Text, Convert.ToInt32(cbxEndYear.Text)).Tables[0];

             //DataSet dataSet = businessManager.dues_payments_list();
             //dgvListDuesPayments.DataSource = dataSet.Tables["DuesPayments"];

             dgvListPaidMembers.Columns[0].HeaderText = "member_id";
             dgvListPaidMembers.Columns[1].HeaderText = "member_firstname";
             dgvListPaidMembers.Columns[2].HeaderText = "member_lastname";
             dgvListPaidMembers.Columns[3].HeaderText = "payment_date";


                MessageBox.Show("Listeleme işlemi başarılı.");

                    list_paid_members();
                
            }
            else
            {
                MessageBox.Show("Boş alan geçmeyiniz!");
            }
        
        
        }
    }
}
