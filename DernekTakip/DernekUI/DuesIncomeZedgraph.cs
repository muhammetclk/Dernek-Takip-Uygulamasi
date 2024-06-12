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
using ZedGraph;

namespace DernekUI
{
    public partial class DuesIncomeZedgraph : Form
    {
        BusinessManager businessManager = new BusinessManager(new AccessDatabaseDal("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakip.accdb"), new MemberCheckService(), new DuesPlanCheckService(), new DuesPaymentsCheckService());

        public DuesIncomeZedgraph()
        {
            InitializeComponent();
        }
        DataTable get_monthly_and_yearly_income_data()
        {
            DataSet dataSet;
            DataTable monthlyandYearlyIncomeData = businessManager.get_monthly_and_yearly_income_data().Tables[0];


            monthlyandYearlyIncomeData.Columns[0].ColumnName = "PaidAmount";
            monthlyandYearlyIncomeData.Columns[1].ColumnName = "dues_month";

            return monthlyandYearlyIncomeData;

        }

       


        private void DuesIncomeZedgraph_Load(object sender, EventArgs e)
        {
            
            CreateBarGraph(get_monthly_and_yearly_income_data());

        }


        private void CreateBarGraph(DataTable monthlyandYearlyIncomeData)
        {            
            zedGraphControl1.GraphPane.CurveList.Clear();
            // Grafik için yeni bir pane oluştur
            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.Title.Text = "Aylık ve Yıllık Aidat Gelirleri";
            graphPane.XAxis.Title.Text = "Ay / Yıl";
            graphPane.YAxis.Title.Text = "Toplam Gelir";
            // Verileri grafik pane'ine ekle
            PointPairList monthlyPointPairs = new PointPairList();
            int index1 = 0;
            foreach (DataRow row in monthlyandYearlyIncomeData.Rows)
            {
                string month = row["dues_month"].ToString();
                int paidAmount = Convert.ToInt32(row["PaidAmount"]);
                monthlyPointPairs.Add(index1++, paidAmount, month);
            }
            // Bar tipinde grafik oluştur
            BarItem monthlyBar = graphPane.AddBar("Aylık Aidat Geliri", monthlyPointPairs, Color.Blue);
            monthlyBar.Bar.Fill = new Fill(Color.Blue);
            // Sütunların genişliğini ayarla
            graphPane.BarSettings.MinClusterGap = 0.5f; // Ay aralıkları
            graphPane.BarSettings.MinBarGap = 0.5f; // Sütun aralıkları
            // X ekseni etiketleri
            graphPane.XAxis.Type = AxisType.Text;
            graphPane.XAxis.Scale.TextLabels = monthlyandYearlyIncomeData.AsEnumerable().Select(row => row["dues_month"].ToString()).ToArray();
            graphPane.XAxis.Scale.MajorStep = 1;
            graphPane.XAxis.Scale.Min = 0;
            graphPane.XAxis.Scale.Max = monthlyandYearlyIncomeData.Rows.Count;
            // Y ekseni ayarları
            graphPane.YAxis.Scale.Min = 0;
            // Grafik kontrolünü yeniden çiz
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }




    }
}
