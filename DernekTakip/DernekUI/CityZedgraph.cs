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
    public partial class CityZedgraph : Form
    {
        BusinessManager businessManager = new BusinessManager(new AccessDatabaseDal("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DernekTakip.accdb"), new MemberCheckService(), new DuesPlanCheckService(), new DuesPaymentsCheckService());

        public CityZedgraph()
        {
            InitializeComponent();
        }

        void get_member_city()
        {
            DataSet dataSet;
            DataTable cityData= businessManager.get_member_city().Tables[0];
            cityData.Columns[0].ColumnName="MemberCount";
            cityData.Columns[1].ColumnName= "city_id";          
            CreateBarGraph(cityData);
        }
        private void CityZedgraph_Load(object sender, EventArgs e)
        {  
            get_member_city();
        }
        private void CreateBarGraph(DataTable cityData)
        {
            // ZedGraph grafik kontrolünü temizle
            zedGraphControl1.GraphPane.CurveList.Clear();
            // Grafik için yeni bir pane oluştur
            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.Title.Text = "Üye Dağılımı";
            graphPane.XAxis.Title.Text = "Şehir";
            graphPane.YAxis.Title.Text = "Üye Sayısı";
            // Verileri grafik pane'ine ekle
            PointPairList pointPairs = new PointPairList();
            int index = 0;
            foreach (DataRow row in cityData.Rows)
            {
                string city = row["city_id"].ToString();
                int memberCount =Convert.ToInt32( row["MemberCount"]);
                pointPairs.Add(index++, memberCount, city);
            }
            // Bar tipinde grafik oluştur
            BarItem myBar = graphPane.AddBar("Üye Sayısı", pointPairs, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue);
            // X ekseni etiketleri
            graphPane.XAxis.Type = AxisType.Text;
            graphPane.XAxis.Scale.TextLabels = cityData.AsEnumerable().Select(row => row["city_id"].ToString()).ToArray();
            graphPane.XAxis.Scale.MajorStep = 1;
            graphPane.XAxis.Scale.Min = 0;
            graphPane.XAxis.Scale.Max = cityData.Rows.Count;
            // Y ekseni ayarları
            graphPane.YAxis.Scale.Min = 0;
            // Grafik kontrolünü yeniden çiz
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        } 
    


    }
}
