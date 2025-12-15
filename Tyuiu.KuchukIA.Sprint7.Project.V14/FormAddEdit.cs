using System;
using System.Windows.Forms;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    public partial class FormAddEdit : Form
    {
        public string[] ResultRow;

        private string originalId;

        public FormAddEdit()
        {
            InitializeComponent();
            Text = "Добавить новый маршрут";
            originalId = "0";
        }

        public FormAddEdit(string[] row)
        {
            InitializeComponent();
            Text = $"Редактировать маршрут №{row[2]}";
            originalId = row[0];
            FillFields(row);
        }

        private void FillFields(string[] row)
        {
            comboBoxType_KIA.Text = row[1];
            textBoxRoute_KIA.Text = row[2];
            textBoxDate_KIA.Text = row[3];
            textBoxStart_KIA.Text = row[4];
            textBoxEnd_KIA.Text = row[5];

            if (int.TryParse(row[6], out int time))
                numTime_KIA.Value = time;

            textBoxNote_KIA.Text = row[7];
        }

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                SaveData();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private bool CheckFields()
        {
            bool routeOk = !string.IsNullOrWhiteSpace(textBoxRoute_KIA.Text);
            bool startOk = !string.IsNullOrWhiteSpace(textBoxStart_KIA.Text);
            bool endOk = !string.IsNullOrWhiteSpace(textBoxEnd_KIA.Text);

            if (!routeOk || !startOk || !endOk)
            {
                MessageBox.Show("Заполните обязательные поля!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SaveData()
        {
            ResultRow = new string[8];

            ResultRow[0] = originalId;
            ResultRow[1] = comboBoxType_KIA.Text;
            ResultRow[2] = textBoxRoute_KIA.Text;
            ResultRow[3] = textBoxDate_KIA.Text;
            ResultRow[4] = textBoxStart_KIA.Text;
            ResultRow[5] = textBoxEnd_KIA.Text;
            ResultRow[6] = ((int)numTime_KIA.Value).ToString();
            ResultRow[7] = textBoxNote_KIA.Text;
        }
    }
}