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
    public partial class DuesPlans : Form
    {

        BusinessManager businessManager = new BusinessManager(new AccessDatabaseDal("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakip.accdb"), new MemberCheckService(),new DuesPlanCheckService(), new DuesPaymentsCheckService());

        public DuesPlans()
        {
            InitializeComponent();
        }

        void dues_plan_list()
        {           
            DataSet dataSet = businessManager.dues_plan_list();
            dgvListDuesPlans.DataSource = dataSet.Tables["DuesPlans"];
        }
        private void DuesPlans_Load(object sender, EventArgs e)
        {
            dues_plan_list();
        }
        private void btnAddDues_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxMonth.Text != "" && cbxYear.Text != "" && tbxDuesAmount.Text != "" &&
                    Convert.ToInt32(tbxDuesAmount.Text)>0)
                {
                if (businessManager.dues_plan_add(cbxMonth.Text, cbxYear.Text, tbxDuesAmount.Text ))
                {
                    MessageBox.Show("Bu tarihe ait Aidat zaten var. Ekleme işlemi başarısız.");
                }
                else{              
                    MessageBox.Show("Ekleme işlemi başarılı.");                 
                    dues_plan_list();}              
            }
            else{            
                MessageBox.Show("Boş alan geçmeyiniz! ve Miktar olarak 0 dan büyük bir değer giriniz");}            
            }
            catch
            {}           
        }
    }
}
