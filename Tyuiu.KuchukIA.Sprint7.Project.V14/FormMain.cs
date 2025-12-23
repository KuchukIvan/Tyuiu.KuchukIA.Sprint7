using System;
using System.Windows.Forms;
using Tyuiu.KuchukIA.Sprint7.Project.V14.Lib;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string currentFile = "";
        string sortColumn = "";
        SortOrder sortOrder = SortOrder.None;
        int rows = 0;
        string[,] data = new string[0, 8];
        string[,] filtered = new string[0, 8];

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxFilterType_KIA.Items.Add("Все");
            comboBoxFilterType_KIA.Items.Add("Автобус");
            comboBoxFilterType_KIA.Items.Add("Трамвай");
            comboBoxFilterType_KIA.Items.Add("Троллейбус");
            comboBoxFilterType_KIA.Items.Add("Маршрутка");
            comboBoxFilterType_KIA.SelectedIndex = 0;

            numericUpDownMaxTime_KIA.Maximum = 1000;
            numericUpDownMinTime_KIA.Maximum = 1000;
            numericUpDownFilterRoute_KIA.Maximum = 1000;
            numericUpDownFilterID_KIA.Maximum = 1000;

            dateTimePickerMinDate_KIA.Value = new DateTime(2020, 1, 1);
            dateTimePickerMaxDate_KIA.Value = DateTime.Now.AddDays(1);

            dataGridViewTransports_KIA.CellEndEdit += dataGridViewTransports_KIA_CellEndEdit;

            UpdateStats();
        }

        private void ShowData()
        {
            dataGridViewTransports_KIA.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                int rowIndex = dataGridViewTransports_KIA.Rows.Add();

                for (int j = 0; j < 8; j++)
                {
                    dataGridViewTransports_KIA.Rows[rowIndex].Cells[j].Value = filtered[i, j];
                }
            }
        }

        private void dataGridViewTransports_KIA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            string id = filtered[e.RowIndex, 0];
            string newValue = dataGridViewTransports_KIA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == id)
                {
                    data[i, e.ColumnIndex] = newValue;
                }
            }

            filtered[e.RowIndex, e.ColumnIndex] = newValue;
            UpdateStats();
        }

        private void dataGridViewTransports_KIA_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
            if (e.ColumnIndex > 7) return;

            string[] names = { "ID", "TransportType", "RouteNumber", "StartDate", "StartStop", "EndStop", "TravelTime", "Note" };
            string colName = names[e.ColumnIndex];

            if (sortColumn == colName)
            {
                if (sortOrder == SortOrder.Ascending)
                    sortOrder = SortOrder.Descending;
                else
                    sortOrder = SortOrder.Ascending;
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
            if (sortColumn == "") return;
            if (rows == 0) return;

            string[,] tempArray = new string[rows, 8];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tempArray[i, j] = filtered[i, j];
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    bool swap = false;

                    if (sortColumn == "ID")
                    {
                        int a = ToInt(tempArray[i, 0]);
                        int b = ToInt(tempArray[j, 0]);
                        swap = (sortOrder == SortOrder.Ascending) ? (a > b) : (a < b);
                    }
                    else if (sortColumn == "TransportType")
                    {
                        string a = tempArray[i, 1] ?? "";
                        string b = tempArray[j, 1] ?? "";
                        swap = (sortOrder == SortOrder.Ascending) ? (string.Compare(a, b) > 0) : (string.Compare(a, b) < 0);
                    }
                    else if (sortColumn == "RouteNumber")
                    {
                        int a = ToInt(tempArray[i, 2]);
                        int b = ToInt(tempArray[j, 2]);
                        swap = (sortOrder == SortOrder.Ascending) ? (a > b) : (a < b);
                    }
                    else if (sortColumn == "StartDate")
                    {
                        DateTime a = ToDate(tempArray[i, 3]);
                        DateTime b = ToDate(tempArray[j, 3]);
                        swap = (sortOrder == SortOrder.Ascending) ? (a > b) : (a < b);
                    }
                    else if (sortColumn == "StartStop")
                    {
                        string a = tempArray[i, 4] ?? "";
                        string b = tempArray[j, 4] ?? "";
                        swap = (sortOrder == SortOrder.Ascending) ? (string.Compare(a, b) > 0) : (string.Compare(a, b) < 0);
                    }
                    else if (sortColumn == "EndStop")
                    {
                        string a = tempArray[i, 5] ?? "";
                        string b = tempArray[j, 5] ?? "";
                        swap = (sortOrder == SortOrder.Ascending) ? (string.Compare(a, b) > 0) : (string.Compare(a, b) < 0);
                    }
                    else if (sortColumn == "TravelTime")
                    {
                        int a = ToInt(tempArray[i, 6]);
                        int b = ToInt(tempArray[j, 6]);
                        swap = (sortOrder == SortOrder.Ascending) ? (a > b) : (a < b);
                    }
                    else if (sortColumn == "Note")
                    {
                        string a = tempArray[i, 7] ?? "";
                        string b = tempArray[j, 7] ?? "";
                        swap = (sortOrder == SortOrder.Ascending) ? (string.Compare(a, b) > 0) : (string.Compare(a, b) < 0);
                    }

                    if (swap)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            string temp = tempArray[i, k];
                            tempArray[i, k] = tempArray[j, k];
                            tempArray[j, k] = temp;
                        }
                    }
                }
            }

            filtered = tempArray;
            ShowData();
        }

        private int ToInt(string text)
        {
            int result = 0;
            int.TryParse(text, out result);
            return result;
        }

        private DateTime ToDate(string text)
        {
            DateTime result = DateTime.MinValue;
            DateTime.TryParse(text, out result);
            return result;
        }

        private void Filter()
        {
            string searchText = toolStripTextBoxSearch_KIA.Text;
            string[,] searchData = data;

            if (searchText != "")
            {
                searchData = ds.Search(data, searchText);
            }

            int dataRows = searchData.GetLength(0);
            string[,] tempResult = new string[dataRows, 8];
            int resultCount = 0;

            for (int i = 0; i < dataRows; i++)
            {
                bool add = true;

                if (numericUpDownFilterID_KIA.Value != 0)
                {
                    int id = ToInt(searchData[i, 0]);
                    if (id != (int)numericUpDownFilterID_KIA.Value)
                        add = false;
                }

                if (add && comboBoxFilterType_KIA.SelectedIndex > 0)
                {
                    if (searchData[i, 1] != comboBoxFilterType_KIA.Text)
                        add = false;
                }

                if (add && numericUpDownFilterRoute_KIA.Value != 0)
                {
                    int route = ToInt(searchData[i, 2]);
                    if (route != (int)numericUpDownFilterRoute_KIA.Value)
                        add = false;
                }

                if (add && textBoxFilterStart_KIA.Text != "")
                {
                    string startStop = searchData[i, 4] ?? "";
                    if (!startStop.ToLower().Contains(textBoxFilterStart_KIA.Text.ToLower()))
                        add = false;
                }

                if (add && textBoxFilterEnd_KIA.Text != "")
                {
                    string endStop = searchData[i, 5] ?? "";
                    if (!endStop.ToLower().Contains(textBoxFilterEnd_KIA.Text.ToLower()))
                        add = false;
                }

                if (add && numericUpDownMinTime_KIA.Value != 0)
                {
                    int time = ToInt(searchData[i, 6]);
                    if (time < (int)numericUpDownMinTime_KIA.Value)
                        add = false;
                }

                if (add && numericUpDownMaxTime_KIA.Value != 0)
                {
                    int time = ToInt(searchData[i, 6]);
                    if (time > (int)numericUpDownMaxTime_KIA.Value)
                        add = false;
                }

                if (add)
                {
                    DateTime date = ToDate(searchData[i, 3]);
                    if (date < dateTimePickerMinDate_KIA.Value.Date)
                        add = false;
                }

                if (add)
                {
                    DateTime date = ToDate(searchData[i, 3]);
                    if (date > dateTimePickerMaxDate_KIA.Value.Date)
                        add = false;
                }

                if (add)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        tempResult[resultCount, j] = searchData[i, j];
                    }
                    resultCount++;
                }
            }

            filtered = new string[resultCount, 8];
            for (int i = 0; i < resultCount; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    filtered[i, j] = tempResult[i, j];
                }
            }

            rows = resultCount;

            if (sortColumn != "")
                SortData();
            else
                ShowData();

            UpdateStats();
        }

        private void UpdateStats()
        {
            if (data.GetLength(0) == 0)
            {
                ClearStats();
                return;
            }

            int totalRows = data.GetLength(0);
            textBoxStatsTransportCount_KIA.Text = totalRows.ToString();

            int routeCount = 0;
            for (int i = 0; i < totalRows; i++)
            {
                bool found = false;
                for (int j = 0; j < i; j++)
                {
                    if (data[j, 2] == data[i, 2])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found) routeCount++;
            }
            textBoxStatsRoutesCount_KIA.Text = routeCount.ToString();

            int buses = 0;
            int trams = 0;
            int trolleys = 0;
            int minibuses = 0;

            for (int i = 0; i < totalRows; i++)
            {
                string type = data[i, 1];
                if (type == "Автобус") buses++;
                else if (type == "Трамвай") trams++;
                else if (type == "Троллейбус") trolleys++;
                else if (type == "Маршрутка") minibuses++;
            }

            textBoxStatsBuses_KIA.Text = buses.ToString();
            textBoxStatsTrams_KIA.Text = trams.ToString();
            textBoxStatsTrolleys_KIA.Text = trolleys.ToString();
            textBoxStatsMinibuses_KIA.Text = minibuses.ToString();

            int minTime = 1000000;
            int maxTime = 0;
            int sumTime = 0;
            int countTime = 0;

            for (int i = 0; i < totalRows; i++)
            {
                int time = ToInt(data[i, 6]);
                if (time > 0)
                {
                    if (time < minTime) minTime = time;
                    if (time > maxTime) maxTime = time;
                    sumTime += time;
                    countTime++;
                }
            }

            if (minTime == 1000000) minTime = 0;

            textBoxStatsMinTime_KIA.Text = minTime.ToString();
            textBoxStatsMaxTime_KIA.Text = maxTime.ToString();

            if (countTime > 0)
                textBoxStatsAvgTime_KIA.Text = (sumTime / countTime).ToString();
            else
                textBoxStatsAvgTime_KIA.Text = "0";

            string shortest = "нет";
            string longest = "нет";

            for (int i = 0; i < totalRows; i++)
            {
                int time = ToInt(data[i, 6]);
                if (time == minTime && minTime > 0)
                {
                    shortest = $"№{data[i, 2]} ({minTime} мин)";
                }
                if (time == maxTime && maxTime > 0)
                {
                    longest = $"№{data[i, 2]} ({maxTime} мин)";
                }
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

        private void ToolStripMenuItemNewTable_KIA_Click(object sender, EventArgs e)
        {
            if (data.GetLength(0) > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Создать новую таблицу? Все несохранённые данные будут потеряны.",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;
            }

            data = new string[0, 8];
            filtered = new string[0, 8];
            rows = 0;
            dataGridViewTransports_KIA.Rows.Clear();
            currentFile = "";
            sortColumn = "";
            sortOrder = SortOrder.None;

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

            UpdateStats();
        }

        private void toolStripMenuItemOpen_KIA_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFile = dlg.FileName;
                    data = ds.LoadFromFile(currentFile);

                    int dataRows = data.GetLength(0);
                    filtered = new string[dataRows, 8];

                    for (int i = 0; i < dataRows; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            filtered[i, j] = data[i, j];
                        }
                    }

                    rows = dataRows;
                    ShowData();
                    UpdateStats();

                    MessageBox.Show($"Загружено {rows} записей", "Успешно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
                }
            }
        }

        private void toolStripMenuItemSave_KIA_Click(object sender, EventArgs e)
        {
            if (currentFile == "")
            {
                toolStripMenuItemSaveAs_KIA_Click(sender, e);
                return;
            }

            try
            {
                ds.SaveToFile(currentFile, data);
                MessageBox.Show("Файл сохранён", "Сохранение");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void toolStripMenuItemSaveAs_KIA_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "CSV файлы (*.csv)|*.csv";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                currentFile = dlg.FileName;
                toolStripMenuItemSave_KIA_Click(sender, e);
            }
        }

        private void toolStripButtonAdd_KIA_Click(object sender, EventArgs e)
        {
            int maxID = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                int id = ToInt(data[i, 0]);
                if (id > maxID) maxID = id;
            }
            int newID = maxID + 1;

            int oldRows = data.GetLength(0);
            string[,] newData = new string[oldRows + 1, 8];

            for (int i = 0; i < oldRows; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    newData[i, j] = data[i, j];
                }
            }

            newData[oldRows, 0] = newID.ToString();

            data = newData;

            int dataRows = data.GetLength(0);
            filtered = new string[dataRows, 8];
            for (int i = 0; i < dataRows; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    filtered[i, j] = data[i, j];
                }
            }

            rows = dataRows;
            ShowData();
            UpdateStats();
        }

        private void toolStripButtonDelete_KIA_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransports_KIA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить выбранную запись?",
                "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int index = dataGridViewTransports_KIA.SelectedRows[0].Index;
                if (index < rows)
                {
                    string id = filtered[index, 0];

                    int dataRows = data.GetLength(0);
                    int newDataRows = 0;

                    for (int i = 0; i < dataRows; i++)
                    {
                        if (data[i, 0] != id) newDataRows++;
                    }

                    string[,] newData = new string[newDataRows, 8];
                    int newIndex = 0;

                    for (int i = 0; i < dataRows; i++)
                    {
                        if (data[i, 0] != id)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                newData[newIndex, j] = data[i, j];
                            }
                            newIndex++;
                        }
                    }

                    data = newData;

                    int filteredRows = filtered.GetLength(0);
                    int newFilteredRows = 0;

                    for (int i = 0; i < filteredRows; i++)
                    {
                        if (filtered[i, 0] != id) newFilteredRows++;
                    }

                    string[,] newFiltered = new string[newFilteredRows, 8];
                    newIndex = 0;

                    for (int i = 0; i < filteredRows; i++)
                    {
                        if (filtered[i, 0] != id)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                newFiltered[newIndex, j] = filtered[i, j];
                            }
                            newIndex++;
                        }
                    }

                    filtered = newFiltered;
                    rows = data.GetLength(0);
                    ShowData();
                    UpdateStats();
                }
            }
        }

        private void toolStripButtonStats_KIA_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransports_KIA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите маршрут для статистики");
                return;
            }

            int index = dataGridViewTransports_KIA.SelectedRows[0].Index;
            if (index >= rows) return;

            string route = filtered[index, 2];
            string type = filtered[index, 1];

            int count = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 2] == route && data[i, 1] == type) count++;
            }

            string[][] array = new string[count][];
            int arrayIndex = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 2] == route && data[i, 1] == type)
                {
                    array[arrayIndex] = new string[8];
                    for (int j = 0; j < 8; j++)
                    {
                        array[arrayIndex][j] = data[i, j];
                    }
                    arrayIndex++;
                }
            }

            if (count > 0)
            {
                FormStatistics stats = new FormStatistics(
                    filtered[index, 0], filtered[index, 1], filtered[index, 2],
                    filtered[index, 3], filtered[index, 4], filtered[index, 5],
                    filtered[index, 6], array
                );
                stats.ShowDialog();
            }
        }

        private void buttonResetFilter_KIA_Click(object sender, EventArgs e)
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

            int dataRows = data.GetLength(0);
            filtered = new string[dataRows, 8];

            for (int i = 0; i < dataRows; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    filtered[i, j] = data[i, j];
                }
            }

            rows = dataRows;
            ShowData();
            UpdateStats();
        }

        private void toolStripMenuItemManual_KIA_Click(object sender, EventArgs e)
        {
            string help = @"РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ

Основные функции:
• Открыть, сохранить, создать новую таблицу

Работа с данными:
• Нажмите на + чтобы добавить пустую строку
• Нажмите на ячейку, чтобы редактировать
• Нажмите на X чтобы удалить выбранную запись

Фильтрация:
• Используйте поля справа для поиска
• Фильтры работают в реальном времени

Сортировка:
• Кликните по заголовку столбца
• Повторный клик меняет порядок";

            MessageBox.Show(help, "Руководство");
        }

        private void toolStripMenuItemAbout_KIA_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void numericUpDownFilterID_KIA_ValueChanged(object sender, EventArgs e) { Filter(); }
        private void numericUpDownFilterRoute_KIA_ValueChanged(object sender, EventArgs e) { Filter(); }
        private void numericUpDownMinTime_KIA_ValueChanged(object sender, EventArgs e) { Filter(); }
        private void numericUpDownMaxTime_KIA_ValueChanged(object sender, EventArgs e) { Filter(); }
        private void comboBoxFilterType_KIA_SelectedIndexChanged(object sender, EventArgs e) { Filter(); }
        private void dateTimePickerMinDate_KIA_ValueChanged(object sender, EventArgs e) { Filter(); }
        private void dateTimePickerMaxDate_KIA_ValueChanged(object sender, EventArgs e) { Filter(); }
        private void textBoxFilterStart_KIA_TextChanged(object sender, EventArgs e) { Filter(); }
        private void textBoxFilterEnd_KIA_TextChanged(object sender, EventArgs e) { Filter(); }
        private void toolStripTextBoxSearch_KIA_TextChanged(object sender, EventArgs e) { Filter(); }

        private void dataGridViewTransports_KIA_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void labelFilterID_KIA_Click(object sender, EventArgs e) { }
    }
}