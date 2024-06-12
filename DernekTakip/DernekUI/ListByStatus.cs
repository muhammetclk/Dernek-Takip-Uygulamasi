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
    public partial class ListByStatus : Form
    {

        BusinessManager businessManager = new BusinessManager(new AccessDatabaseDal("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakip.accdb"), new MemberCheckService(), new DuesPlanCheckService(),new DuesPaymentsCheckService());



        public ListByStatus()
        {
            InitializeComponent();
        }

        void member_list()
        {

            DataSet dataSet;

            if (cbxStatus.Text == "All")
            {
                dataSet = businessManager.member_list();

            }
            else
            {
                dataSet = businessManager.member_list("status", cbxStatus.Text);
            }

            dgvListStatus.DataSource = dataSet.Tables["Members"];
        }


        private void ListByStatus_Load(object sender, EventArgs e)
        {
            member_list();
        }

        private void btnListByStatus_Click(object sender, EventArgs e)
        {
            member_list();
        }
    }
}
