using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KuchukIA.Sprint7.Project.V14.Lib;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private string currentFile = "";
        private string sortColumn = "";
        private SortOrder sortOrder = SortOrder.None;

        private int rows = 0;
        private int columns = 8;
        private string[,] data = new string[0, 8];
        private string[,] filtered = new string[0, 8];

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void SetupForm()
        {
            comboBoxFilterType_KIA.Items.AddRange(new string[] { "Все", "Автобус", "Трамвай", "Троллейбус", "Маршрутка" });
            comboBoxFilterType_KIA.SelectedIndex = 0;

            numericUpDownMaxTime_KIA.Maximum = 1000;
            numericUpDownMinTime_KIA.Maximum = 1000;
            numericUpDownFilterRoute_KIA.Maximum = 1000;
            numericUpDownFilterID_KIA.Maximum = 1000;

            dateTimePickerMinDate_KIA.Value = new DateTime(2020, 1, 1);
            dateTimePickerMaxDate_KIA.Value = DateTime.Now.AddDays(1);

            UpdateStats();
        }

        private void ShowData()
        {
            dataGridViewTransports_KIA.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                dataGridViewTransports_KIA.Rows.Add();

                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTransports_KIA.Rows[i].Cells[j].Value = filtered[i, j];
                }
            }
        }
    }
}