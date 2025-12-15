using System;
using System.Windows.Forms;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    public partial class FormChart : Form
    {
        private string transportType;
        private string routeNumber;
        private string[,] routeData;

        public FormChart(string id, string type, string route,
                        string date, string start, string end,
                        string time, string[,] array)
        {
            InitializeComponent();

            transportType = type;
            routeNumber = route;
            routeData = array;
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            SetupChartTitle();
            FillChart();
        }

        private void SetupChartTitle()
        {
            var title = chart_KIA.Titles["TitleChart_KIA"];
            title.Text = $"Время в пути каждого {transportType.ToLower()}\nМаршрут №{routeNumber}";
        }

        private void FillChart()
        {
            var series = chart_KIA.Series["SeriesTravelTime_KIA"];
            series.Points.Clear();

            for (int i = 0; i < routeData.GetLength(0); i++)
            {
                if (int.TryParse(routeData[i, 6], out int time))
                {
                    int index = series.Points.AddXY(i + 1, time);
                    series.Points[index].AxisLabel = $"ID:{routeData[i, 0]}";
                }
            }
        }

        private void BtnCloseChart_KIA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chart_KIA_Click(object sender, EventArgs e)
        {
        }
    }
}