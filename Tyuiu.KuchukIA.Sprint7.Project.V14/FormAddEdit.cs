using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    public partial class FormAddEdit : Form
    {
        public string[] ResultRow { get; private set; }
        private bool editMode = false;
        private string[] oldRow;

        public FormAddEdit()
        {
            InitializeComponent();
            editMode = false;
            this.Text = "Добавить новый маршрут";
        }

        public FormAddEdit(string[] row)
        {
            InitializeComponent();
            editMode = true;
            oldRow = row;
            this.Text = "Редактировать маршрут №" + row[2];

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
            this.ActiveControl = null;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (textBoxRoute_KIA.Text == "" ||
                textBoxStart_KIA.Text == "" ||
                textBoxEnd_KIA.Text == "")
            {
                MessageBox.Show("Заполните обязательные поля!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            ResultRow = new string[8];

            if (editMode)
                ResultRow[0] = oldRow[0];
            else
                ResultRow[0] = "0";

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