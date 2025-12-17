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

        private void dataGridViewTransports_KIA_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.ColumnIndex > 7) return;

            string[] columnNames = { "ID", "TransportType", "RouteNumber", "StartDate",
                                     "StartStop", "EndStop", "TravelTime", "Note" };

            string colName = columnNames[e.ColumnIndex];

            if (sortColumn == colName)
            {
                sortOrder = (sortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                sortColumn = colName;
                sortOrder = SortOrder.Ascending;
            }

            dataGridViewTransports_KIA.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = sortOrder;

            SortData();
        }

        private void SortData()
        {
            if (string.IsNullOrEmpty(sortColumn) || rows == 0) return;

            List<string[]> list = ConvertToList(filtered);

            switch (sortColumn)
            {
                case "ID":
                    list = (sortOrder == SortOrder.Ascending) ?
                        list.OrderBy(r => Convert.ToInt32(r[0])).ToList() :
                        list.OrderByDescending(r => Convert.ToInt32(r[0])).ToList();
                    break;

                case "TransportType":
                    list = (sortOrder == SortOrder.Ascending) ?
                        list.OrderBy(r => r[1]).ToList() :
                        list.OrderByDescending(r => r[1]).ToList();
                    break;

                case "RouteNumber":
                    list = (sortOrder == SortOrder.Ascending) ?
                        list.OrderBy(r => r[2]).ToList() :
                        list.OrderByDescending(r => r[2]).ToList();
                    break;

                case "StartDate":
                    list = (sortOrder == SortOrder.Ascending) ?
                        list.OrderBy(r => DateTime.Parse(r[3])).ToList() :
                        list.OrderByDescending(r => DateTime.Parse(r[3])).ToList();
                    break;

                case "StartStop":
                    list = (sortOrder == SortOrder.Ascending) ?
                        list.OrderBy(r => r[4]).ToList() :
                        list.OrderByDescending(r => r[4]).ToList();
                    break;

                case "EndStop":
                    list = (sortOrder == SortOrder.Ascending) ?
                        list.OrderBy(r => r[5]).ToList() :
                        list.OrderByDescending(r => r[5]).ToList();
                    break;

                case "TravelTime":
                    list = (sortOrder == SortOrder.Ascending) ?
                        list.OrderBy(r => Convert.ToInt32(r[6])).ToList() :
                        list.OrderByDescending(r => Convert.ToInt32(r[6])).ToList();
                    break;

                case "Note":
                    list = (sortOrder == SortOrder.Ascending) ?
                        list.OrderBy(r => r[7] ?? "").ToList() :
                        list.OrderByDescending(r => r[7] ?? "").ToList();
                    break;
            }

            filtered = ConvertToArray(list);
            ShowData();
        }

        private List<string[]> ConvertToList(string[,] array)
        {
            List<string[]> list = new List<string[]>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                string[] row = new string[columns];
                for (int j = 0; j < columns; j++)
                {
                    row[j] = array[i, j];
                }
                list.Add(row);
            }

            return list;
        }

        private string[,] ConvertToArray(List<string[]> list)
        {
            string[,] array = new string[list.Count, columns];

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = list[i][j];
                }
            }

            return array;
        }
    }
}