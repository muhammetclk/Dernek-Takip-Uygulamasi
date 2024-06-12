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
    public partial class ListByBloodGroup : Form
    {

        BusinessManager businessManager = new BusinessManager(new AccessDatabaseDal("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakip.accdb"), new MemberCheckService(), new DuesPlanCheckService(), new DuesPaymentsCheckService());


        public ListByBloodGroup()
        {
            InitializeComponent();
        }

        void member_list()
        {
            
            DataSet dataSet;

            if (cbxBloodGroup.Text=="All")
            { 
                 dataSet = businessManager.member_list();

            }
            else
            {
                 dataSet = businessManager.member_list("blood_group",cbxBloodGroup.Text);
            }
           
            dgvListBloodGroup.DataSource = dataSet.Tables["Members"];
        }

        private void ListByBloodGroup_Load(object sender, EventArgs e)
        {
            member_list();
        }

        private void btnListByBloodGroup_Click(object sender, EventArgs e)
        {
            member_list();
        }
    }
}
