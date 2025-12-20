using System;
using System.Windows.Forms;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    public partial class FormStatistics : Form
    {
        string id, type, route, date, start, end, time;
        string[,] data;

        public FormStatistics(string id, string type, string route,
                            string date, string start, string end,
                            string time, string[][] array)
        {
            InitializeComponent();

            this.id = id;
            this.type = type;
            this.route = route;
            this.date = date;
            this.start = start;
            this.end = end;
            this.time = time;

            data = new string[array.Length, 8];
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < 8; j++)
                    data[i, j] = array[i][j];
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            Text = $"Статистика маршрута {type} №{route}";
            lblTitle_KIA.Text = $"СТАТИСТИКА\n{type.ToUpper()} №{route}";

            ShowStats();
            ShowInfo();
        }

        private void ShowStats()
        {
            int count = data.GetLength(0);
            txtTotalCount_KIA.Text = $"{count} шт.";

            int minTime = 1000000;
            int maxTime = 0;
            int sumTime = 0;

            for (int i = 0; i < count; i++)
            {
                if (int.TryParse(data[i, 6], out int current))
                {
                    if (current < minTime) minTime = current;
                    if (current > maxTime) maxTime = current;
                    sumTime += current;
                }
            }

            if (minTime == 1000000) minTime = 0;

            txtMinTime_KIA.Text = $"{minTime} мин";
            txtMaxTime_KIA.Text = $"{maxTime} мин";

            if (count > 0)
                txtAvgTime_KIA.Text = $"{(double)sumTime / count:F1} мин";
            else
                txtAvgTime_KIA.Text = "0.0 мин";
        }

        private void ShowInfo()
        {
            txtSelectedID_KIA.Text = id;
            txtTravelTime_KIA.Text = $"{time} мин";
            txtStartStop_KIA.Text = start;
            txtEndStop_KIA.Text = end;

            try
            {
                DateTime d = DateTime.Parse(date);
                txtDate_KIA.Text = d.ToString("dd.MM.yyyy");
            }
            catch
            {
                txtDate_KIA.Text = date;
            }
        }

        private void BtnShowChart_KIA_Click(object sender, EventArgs e)
        {
            FormChart chart = new FormChart(id, type, route, date, start, end, time, data);
            chart.ShowDialog();
        }

        private void BtnClose_KIA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}