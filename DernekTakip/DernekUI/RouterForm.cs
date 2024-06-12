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
    public partial class RouterForm : Form
    {
        public RouterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListByBloodGroup listByBloodGroup = new ListByBloodGroup();
            listByBloodGroup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListByCity listByCity = new ListByCity();
            listByCity.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListByStatus listByStatus = new ListByStatus();
            listByStatus.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DuesPlans duesPlans = new DuesPlans();
            duesPlans.Show();
        }

        private void RouterForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DuesPayments duesPayments = new DuesPayments();
            duesPayments.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Debts debts = new Debts();
            debts.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CityZedgraph cityZedgraph = new CityZedgraph();
            cityZedgraph.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DuesIncomeZedgraph duesIncomeZedgraph = new DuesIncomeZedgraph();
            duesIncomeZedgraph.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PayerAndNonPayers payerAndNonPayers = new PayerAndNonPayers();
            payerAndNonPayers.Show();
        }
    }
}
