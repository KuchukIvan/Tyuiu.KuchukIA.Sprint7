using System;
using System.Linq;
using System.Windows.Forms;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    public partial class FormStatistics : Form
    {
        private string transportId;
        private string transportType;
        private string routeNumber;
        private string startDate;
        private string startStop;
        private string endStop;
        private string travelTime;

        private string[,] routeData;

        public FormStatistics(string id, string type, string route,
                            string date, string start, string end,
                            string time, string[][] array)
        {
            InitializeComponent();

            transportId = id;
            transportType = type;
            routeNumber = route;
            startDate = date;
            startStop = start;
            endStop = end;
            travelTime = time;

            ConvertArrayToMatrix(array);
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            SetupForm();
            DisplayStatistics();
            DisplaySelectedRouteInfo();
        }

        private void ConvertArrayToMatrix(string[][] array)
        {
            int rows = array.Length;
            int cols = 8;
            routeData = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    routeData[i, j] = array[i][j];
                }
            }
        }

        private void SetupForm()
        {
            this.Text = $"Статистика маршрута {transportType} №{routeNumber}";
            lblTitle_KIA.Text = $"СТАТИСТИКА\n{transportType.ToUpper()} №{routeNumber}";
        }

        private void DisplayStatistics()
        {
            int totalRoutes = routeData.GetLength(0);

            txtTotalCount_KIA.Text = $"{totalRoutes} шт.";
            txtMinTime_KIA.Text = $"{CalculateMinTime()} мин";
            txtMaxTime_KIA.Text = $"{CalculateMaxTime()} мин";
            txtAvgTime_KIA.Text = $"{CalculateAverageTime()} мин";
        }

        private void DisplaySelectedRouteInfo()
        {
            txtSelectedID_KIA.Text = transportId;
            txtTravelTime_KIA.Text = $"{travelTime} мин";
            txtStartStop_KIA.Text = startStop;
            txtEndStop_KIA.Text = endStop;
            txtDate_KIA.Text = FormatDate(startDate);
        }

        private int CalculateMinTime()
        {
            if (routeData.GetLength(0) == 0) return 0;

            int minTime = int.MaxValue;

            for (int i = 0; i < routeData.GetLength(0); i++)
            {
                if (int.TryParse(routeData[i, 6], out int currentTime))
                {
                    if (currentTime < minTime)
                        minTime = currentTime;
                }
            }

            return minTime == int.MaxValue ? 0 : minTime;
        }

        private int CalculateMaxTime()
        {
            if (routeData.GetLength(0) == 0) return 0;

            int maxTime = 0;

            for (int i = 0; i < routeData.GetLength(0); i++)
            {
                if (int.TryParse(routeData[i, 6], out int currentTime))
                {
                    if (currentTime > maxTime)
                        maxTime = currentTime;
                }
            }

            return maxTime;
        }

        private string CalculateAverageTime()
        {
            int totalRoutes = routeData.GetLength(0);
            if (totalRoutes == 0) return "0.0";

            int sum = 0;
            int validCount = 0;

            for (int i = 0; i < totalRoutes; i++)
            {
                if (int.TryParse(routeData[i, 6], out int currentTime))
                {
                    sum += currentTime;
                    validCount++;
                }
            }

            if (validCount == 0) return "0.0";

            double average = (double)sum / validCount;
            return average.ToString("F1");
        }

        private string FormatDate(string dateString)
        {
            if (dateString.Contains("."))
                return dateString;

            try
            {
                DateTime date = DateTime.Parse(dateString);
                return date.ToString("dd.MM.yyyy");
            }
            catch
            {
                return dateString;
            }
        }

        private void BtnShowChart_KIA_Click(object sender, EventArgs e)
        {
            ShowChartForm();
        }

        private void ShowChartForm()
        {
            FormChart chartForm = new FormChart(
                transportId, transportType, routeNumber, startDate,
                startStop, endStop, travelTime, routeData
            );

            chartForm.ShowDialog();
        }

        private void BtnClose_KIA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}