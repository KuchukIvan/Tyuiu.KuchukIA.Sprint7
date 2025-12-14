using System;
using System.Linq;
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
            {
                for (int j = 0; j < 8; j++)
                {
                    data[i, j] = array[i][j];
                }
            }
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            this.Text = "Статистика маршрута " + type + " №" + route;
            lblTitle_KIA.Text = "СТАТИСТИКА\n" + type.ToUpper() + " №" + route;

            txtTotalCount_KIA.Text = data.GetLength(0) + " шт.";
            txtMinTime_KIA.Text = MinTime() + " мин";
            txtMaxTime_KIA.Text = MaxTime() + " мин";
            txtAvgTime_KIA.Text = AvgTime() + " мин";

            txtSelectedID_KIA.Text = id;
            txtTravelTime_KIA.Text = time + " мин";
            txtStartStop_KIA.Text = start;
            txtEndStop_KIA.Text = end;
            txtDate_KIA.Text = FormatDate(date);
        }

        int MinTime()
        {
            if (data.GetLength(0) == 0) return 0;

            int min = int.MaxValue;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (int.TryParse(data[i, 6], out int t))
                {
                    if (t < min)
                        min = t;
                }
            }

            return (min == int.MaxValue) ? 0 : min;
        }

        int MaxTime()
        {
            if (data.GetLength(0) == 0) return 0;

            int max = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (int.TryParse(data[i, 6], out int t))
                {
                    if (t > max)
                        max = t;
                }
            }

            return max;
        }

        string AvgTime()
        {
            if (data.GetLength(0) == 0) return "0.0";

            int sum = 0;
            int count = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (int.TryParse(data[i, 6], out int t))
                {
                    sum += t;
                    count++;
                }
            }

            if (count == 0) return "0.0";

            double avg = (double)sum / count;
            return avg.ToString("F1");
        }

        string FormatDate(string d)
        {
            if (d.Contains("."))
                return d;

            try
            {
                DateTime dt = DateTime.Parse(d);
                return dt.ToString("dd.MM.yyyy");
            }
            catch
            {
                return d;
            }
        }

        private void BtnShowChart_KIA_Click(object sender, EventArgs e)
        {
            FormChart chart = new FormChart(id, type, route, date,
                                          start, end, time, data);
            chart.ShowDialog();
        }

        private void BtnClose_KIA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}