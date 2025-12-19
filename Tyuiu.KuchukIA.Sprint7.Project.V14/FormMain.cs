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

        private void Filter()
        {
            List<string[]> result = new List<string[]>();
            string searchText = toolStripTextBoxSearch_KIA.Text;
            string[,] tempData = data;

            if (!string.IsNullOrEmpty(searchText))
            {
                tempData = ds.Search(data, searchText);
            }

            for (int i = 0; i < tempData.GetLength(0); i++)
            {
                bool matchesFilter = CheckFilters(tempData, i);

                if (matchesFilter)
                {
                    string[] row = new string[columns];
                    for (int j = 0; j < columns; j++)
                    {
                        row[j] = tempData[i, j];
                    }
                    result.Add(row);
                }
            }

            filtered = ConvertToArray(result);
            rows = filtered.GetLength(0);

            if (!string.IsNullOrEmpty(sortColumn))
                SortData();
            else
                ShowData();

            UpdateStats();
        }

        private bool CheckFilters(string[,] tempData, int index)
        {
            if (numericUpDownFilterID_KIA.Value != 0)
            {
                if (Convert.ToInt32(tempData[index, 0]) != (int)numericUpDownFilterID_KIA.Value)
                    return false;
            }

            if (comboBoxFilterType_KIA.SelectedIndex > 0)
            {
                if (tempData[index, 1] != comboBoxFilterType_KIA.Text)
                    return false;
            }

            if (numericUpDownFilterRoute_KIA.Value != 0)
            {
                if (tempData[index, 2] != numericUpDownFilterRoute_KIA.Value.ToString())
                    return false;
            }

            if (!string.IsNullOrEmpty(textBoxFilterStart_KIA.Text))
            {
                if (!tempData[index, 4].ToLower().Contains(textBoxFilterStart_KIA.Text.ToLower()))
                    return false;
            }

            if (!string.IsNullOrEmpty(textBoxFilterEnd_KIA.Text))
            {
                if (!tempData[index, 5].ToLower().Contains(textBoxFilterEnd_KIA.Text.ToLower()))
                    return false;
            }

            if (numericUpDownMinTime_KIA.Value != 0)
            {
                if (Convert.ToInt32(tempData[index, 6]) < (int)numericUpDownMinTime_KIA.Value)
                    return false;
            }

            if (numericUpDownMaxTime_KIA.Value != 0)
            {
                if (Convert.ToInt32(tempData[index, 6]) > (int)numericUpDownMaxTime_KIA.Value)
                    return false;
            }

            DateTime date = DateTime.Parse(tempData[index, 3]);
            if (date < dateTimePickerMinDate_KIA.Value.Date || date > dateTimePickerMaxDate_KIA.Value.Date)
                return false;

            return true;
        }


        private void UpdateStats()
        {
            if (data.GetLength(0) == 0)
            {
                ClearStats();
                return;
            }

            textBoxStatsTransportCount_KIA.Text = ds.VehicleAmount(data).ToString();
            textBoxStatsRoutesCount_KIA.Text = ds.RouteAmount(data).ToString();

            int buses = 0, trams = 0, trolleys = 0, minibuses = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                switch (data[i, 1])
                {
                    case "Автобус": buses++; break;
                    case "Трамвай": trams++; break;
                    case "Троллейбус": trolleys++; break;
                    case "Маршрутка": minibuses++; break;
                }
            }

            textBoxStatsBuses_KIA.Text = buses.ToString();
            textBoxStatsTrams_KIA.Text = trams.ToString();
            textBoxStatsTrolleys_KIA.Text = trolleys.ToString();
            textBoxStatsMinibuses_KIA.Text = minibuses.ToString();

            textBoxStatsMinTime_KIA.Text = ds.MinTime(data).ToString();
            textBoxStatsMaxTime_KIA.Text = ds.MaxTime(data).ToString();
            textBoxStatsAvgTime_KIA.Text = ds.AvgTime(data).ToString();

            int minTime = ds.MinTime(data);
            int maxTime = ds.MaxTime(data);
            string shortest = "нет";
            string longest = "нет";

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (Convert.ToInt32(data[i, 6]) == minTime)
                    shortest = $"№{data[i, 2]} ({minTime} мин)";
                if (Convert.ToInt32(data[i, 6]) == maxTime)
                    longest = $"№{data[i, 2]} ({maxTime} мин)";
            }

            textBoxStatsShortest_KIA.Text = shortest;
            textBoxStatsLongest_KIA.Text = longest;
        }

        private void ClearStats()
        {
            textBoxStatsTransportCount_KIA.Text = "0";
            textBoxStatsRoutesCount_KIA.Text = "0";
            textBoxStatsBuses_KIA.Text = "0";
            textBoxStatsTrams_KIA.Text = "0";
            textBoxStatsTrolleys_KIA.Text = "0";
            textBoxStatsMinibuses_KIA.Text = "0";
            textBoxStatsMinTime_KIA.Text = "0";
            textBoxStatsMaxTime_KIA.Text = "0";
            textBoxStatsAvgTime_KIA.Text = "0";
            textBoxStatsShortest_KIA.Text = "нет";
            textBoxStatsLongest_KIA.Text = "нет";
        }

        private void buttonResetFilter_KIA_Click(object sender, EventArgs e)
        {
            ResetFilters();
            filtered = (string[,])data.Clone();
            rows = data.GetLength(0);
            ShowData();
            UpdateStats();
        }

        private void ResetFilters()
        {
            numericUpDownFilterID_KIA.Value = 0;
            comboBoxFilterType_KIA.SelectedIndex = 0;
            numericUpDownFilterRoute_KIA.Value = 0;
            textBoxFilterStart_KIA.Text = "";
            textBoxFilterEnd_KIA.Text = "";
            numericUpDownMinTime_KIA.Value = 0;
            numericUpDownMaxTime_KIA.Value = 0;
            toolStripTextBoxSearch_KIA.Text = "";
            dateTimePickerMinDate_KIA.Value = new DateTime(2020, 1, 1);
            dateTimePickerMaxDate_KIA.Value = DateTime.Now.AddDays(1);
        }



        private void ToolStripMenuItemNewTable_KIA_Click(object sender, EventArgs e)
        {
            if (data.GetLength(0) > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Создать новую таблицу? Все несохранённые данные будут потеряны.",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;
            }

            ClearAll();
        }

        private void toolStripMenuItemOpen_KIA_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            dlg.Title = "Открыть файл";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFile = dlg.FileName;
                    data = ds.LoadFromFile(currentFile);
                    filtered = (string[,])data.Clone();
                    rows = data.GetLength(0);

                    ShowData();
                    UpdateStats();

                    MessageBox.Show($"Загружено {rows} записей", "Успешно",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripMenuItemSave_KIA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                toolStripMenuItemSaveAs_KIA_Click(sender, e);
                return;
            }

            try
            {
                ds.SaveToFile(currentFile, data);
                MessageBox.Show("Файл сохранён", "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItemSaveAs_KIA_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "CSV файлы (*.csv)|*.csv";
            dlg.Title = "Сохранить файл";
            dlg.FileName = "transport.csv";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                currentFile = dlg.FileName;
                toolStripMenuItemSave_KIA_Click(sender, e);
            }
        }

        private void ClearAll()
        {
            data = new string[0, columns];
            filtered = new string[0, columns];
            rows = 0;
            dataGridViewTransports_KIA.Rows.Clear();
            currentFile = "";
            sortColumn = "";
            sortOrder = SortOrder.None;
            ResetFilters();
            UpdateStats();
        }
    }
}