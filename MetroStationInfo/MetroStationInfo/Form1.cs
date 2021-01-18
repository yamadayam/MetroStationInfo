using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroStationInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStationInfo_Click(object sender, EventArgs e)
        {
            var consumerKey = "3b29e6f5ca7f967abe561de001b28b01d9bb0de75806eb957ae45c9d25894f27";
            var api = new TokyoMetroApi(consumerKey);

            // 遅延時間を取得する
            var trainInformation = api.GetTrainInformation();
            tbJson.Text = api.Json; //そのままテキスト出力

            // 路線情報を取得する
            var railway = api.GetRailway();
            
            // IDで連結させてみる
            var q = railway.Join(trainInformation,
                r => r.SameAs, t => t.Railway,
                (r, t) => new
                {
                    Id = r.Id,
                    RailwayName = r.Title,
                    InfomationText = t.TrainInformationText
                });

            foreach (var item in q)
            {
                //Console.WriteLine("{0}線 - {1}", item.RailwayName, item.InfomationText);
                string s = item.RailwayName + "線 " + item.InfomationText;

                listBox1.Items.Add(s);
            }

            


        }
    }
}
