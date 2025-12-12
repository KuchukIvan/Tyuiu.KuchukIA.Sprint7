namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    partial class FormAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEdit));
            labelType_KIA = new Label();
            comboBoxType_KIA = new ComboBox();
            labelRoute_KIA = new Label();
            textBoxRoute_KIA = new TextBox();
            labelDate_KIA = new Label();
            textBoxDate_KIA = new TextBox();
            labelStart_KIA = new Label();
            textBoxStart_KIA = new TextBox();
            labelEnd_KIA = new Label();
            textBoxEnd_KIA = new TextBox();
            labelTime_KIA = new Label();
            numTime_KIA = new NumericUpDown();
            labelNote_KIA = new Label();
            textBoxNote_KIA = new TextBox();
            btnOK_KIA = new Button();
            btnCancel_KIA = new Button();
            ((System.ComponentModel.ISupportInitialize)numTime_KIA).BeginInit();
            SuspendLayout();
            // 
            // labelType_KIA
            // 
            labelType_KIA.AutoSize = true;
            labelType_KIA.Location = new Point(20, 15);
            labelType_KIA.Name = "labelType_KIA";
            labelType_KIA.Size = new Size(96, 15);
            labelType_KIA.TabIndex = 0;
            labelType_KIA.Text = "Вид транспорта:";
            // 
            // comboBoxType_KIA
            // 
            comboBoxType_KIA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType_KIA.FormattingEnabled = true;
            comboBoxType_KIA.Items.AddRange(new object[] { "Автобус", "Трамвай", "Троллейбус", "Маршрутка" });
            comboBoxType_KIA.Location = new Point(180, 12);
            comboBoxType_KIA.Name = "comboBoxType_KIA";
            comboBoxType_KIA.Size = new Size(180, 23);
            comboBoxType_KIA.TabIndex = 1;
            // 
            // labelRoute_KIA
            // 
            labelRoute_KIA.AutoSize = true;
            labelRoute_KIA.Location = new Point(20, 45);
            labelRoute_KIA.Name = "labelRoute_KIA";
            labelRoute_KIA.Size = new Size(94, 15);
            labelRoute_KIA.TabIndex = 2;
            labelRoute_KIA.Text = "Номер маршрута:";
            // 
            // textBoxRoute_KIA
            // 
            textBoxRoute_KIA.Location = new Point(180, 42);
            textBoxRoute_KIA.Name = "textBoxRoute_KIA";
            textBoxRoute_KIA.Size = new Size(180, 23);
            textBoxRoute_KIA.TabIndex = 3;
            // 
            // labelDate_KIA
            // 
            labelDate_KIA.AutoSize = true;
            labelDate_KIA.Location = new Point(20, 75);
            labelDate_KIA.Name = "labelDate_KIA";
            labelDate_KIA.Size = new Size(106, 15);
            labelDate_KIA.TabIndex = 4;
            labelDate_KIA.Text = "Дата (ДД.ММ.ГГГГ):";
            // 
            // textBoxDate_KIA
            // 
            textBoxDate_KIA.Location = new Point(180, 72);
            textBoxDate_KIA.Name = "textBoxDate_KIA";
            textBoxDate_KIA.Size = new Size(180, 23);
            textBoxDate_KIA.TabIndex = 5;
            // 
            // labelStart_KIA
            // 
            labelStart_KIA.AutoSize = true;
            labelStart_KIA.Location = new Point(20, 105);
            labelStart_KIA.Name = "labelStart_KIA";
            labelStart_KIA.Size = new Size(120, 15);
            labelStart_KIA.TabIndex = 6;
            labelStart_KIA.Text = "Начальная остановка:";
            // 
            // textBoxStart_KIA
            // 
            textBoxStart_KIA.Location = new Point(180, 102);
            textBoxStart_KIA.Name = "textBoxStart_KIA";
            textBoxStart_KIA.Size = new Size(180, 23);
            textBoxStart_KIA.TabIndex = 7;
            // 
            // labelEnd_KIA
            // 
            labelEnd_KIA.AutoSize = true;
            labelEnd_KIA.Location = new Point(20, 135);
            labelEnd_KIA.Name = "labelEnd_KIA";
            labelEnd_KIA.Size = new Size(112, 15);
            labelEnd_KIA.TabIndex = 8;
            labelEnd_KIA.Text = "Конечная остановка:";
            // 
            // textBoxEnd_KIA
            // 
            textBoxEnd_KIA.Location = new Point(180, 132);
            textBoxEnd_KIA.Name = "textBoxEnd_KIA";
            textBoxEnd_KIA.Size = new Size(180, 23);
            textBoxEnd_KIA.TabIndex = 9;
            // 
            // labelTime_KIA
            // 
            labelTime_KIA.AutoSize = true;
            labelTime_KIA.Location = new Point(20, 165);
            labelTime_KIA.Name = "labelTime_KIA";
            labelTime_KIA.Size = new Size(99, 15);
            labelTime_KIA.TabIndex = 10;
            labelTime_KIA.Text = "Время в пути (мин):";
            // 
            // numTime_KIA
            // 
            numTime_KIA.Location = new Point(180, 162);
            numTime_KIA.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numTime_KIA.Name = "numTime_KIA";
            numTime_KIA.Size = new Size(180, 23);
            numTime_KIA.TabIndex = 11;
            // 
            // labelNote_KIA
            // 
            labelNote_KIA.AutoSize = true;
            labelNote_KIA.Location = new Point(20, 195);
            labelNote_KIA.Name = "labelNote_KIA";
            labelNote_KIA.Size = new Size(73, 15);
            labelNote_KIA.TabIndex = 12;
            labelNote_KIA.Text = "Примечание:";
            // 
            // textBoxNote_KIA
            // 
            textBoxNote_KIA.Location = new Point(180, 192);
            textBoxNote_KIA.Name = "textBoxNote_KIA";
            textBoxNote_KIA.Size = new Size(180, 23);
            textBoxNote_KIA.TabIndex = 13;
            // 
            // btnOK_KIA
            // 
            btnOK_KIA.DialogResult = DialogResult.OK;
            btnOK_KIA.Location = new Point(120, 232);
            btnOK_KIA.Name = "btnOK_KIA";
            btnOK_KIA.Size = new Size(80, 30);
            btnOK_KIA.TabIndex = 14;
            btnOK_KIA.Text = "OK";
            btnOK_KIA.UseVisualStyleBackColor = true;
            btnOK_KIA.Click += BtnOK_Click;
            // 
            // btnCancel_KIA
            // 
            btnCancel_KIA.DialogResult = DialogResult.Cancel;
            btnCancel_KIA.Location = new Point(220, 232);
            btnCancel_KIA.Name = "btnCancel_KIA";
            btnCancel_KIA.Size = new Size(80, 30);
            btnCancel_KIA.TabIndex = 15;
            btnCancel_KIA.Text = "Отмена";
            btnCancel_KIA.UseVisualStyleBackColor = true;
            // 
            // FormAddEdit
            // 
            AcceptButton = btnOK_KIA;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel_KIA;
            ClientSize = new Size(384, 279);
            Controls.Add(btnCancel_KIA);
            Controls.Add(btnOK_KIA);
            Controls.Add(textBoxNote_KIA);
            Controls.Add(labelNote_KIA);
            Controls.Add(numTime_KIA);
            Controls.Add(labelTime_KIA);
            Controls.Add(textBoxEnd_KIA);
            Controls.Add(labelEnd_KIA);
            Controls.Add(textBoxStart_KIA);
            Controls.Add(labelStart_KIA);
            Controls.Add(textBoxDate_KIA);
            Controls.Add(labelDate_KIA);
            Controls.Add(textBoxRoute_KIA);
            Controls.Add(labelRoute_KIA);
            Controls.Add(comboBoxType_KIA);
            Controls.Add(labelType_KIA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить новый маршрут";
            Load += FormAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)numTime_KIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelType_KIA;
        private ComboBox comboBoxType_KIA;
        private Label labelRoute_KIA;
        private TextBox textBoxRoute_KIA;
        private Label labelDate_KIA;
        private TextBox textBoxDate_KIA;
        private Label labelStart_KIA;
        private TextBox textBoxStart_KIA;
        private Label labelEnd_KIA;
        private TextBox textBoxEnd_KIA;
        private Label labelTime_KIA;
        private NumericUpDown numTime_KIA;
        private Label labelNote_KIA;
        private TextBox textBoxNote_KIA;
        private Button btnOK_KIA;
        private Button btnCancel_KIA;
    }
}