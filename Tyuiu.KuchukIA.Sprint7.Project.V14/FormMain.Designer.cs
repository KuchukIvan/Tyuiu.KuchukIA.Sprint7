namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuStrip_KIA = new MenuStrip();
            toolStripMenuItemFile_KIA = new ToolStripMenuItem();
            ToolStripMenuItemNewTable_KIA = new ToolStripMenuItem();
            toolStripMenuItemOpen_KIA = new ToolStripMenuItem();
            toolStripMenuItemSave_KIA = new ToolStripMenuItem();
            toolStripMenuItemSaveAs_KIA = new ToolStripMenuItem();
            toolStripMenuItemHelp_KIA = new ToolStripMenuItem();
            toolStripMenuItemManual_KIA = new ToolStripMenuItem();
            toolStripMenuItemAbout_KIA = new ToolStripMenuItem();
            groupBoxStats_KIA = new GroupBox();
            textBoxStatsLongest_KIA = new TextBox();
            textBoxStatsShortest_KIA = new TextBox();
            textBoxStatsAvgTime_KIA = new TextBox();
            textBoxStatsMaxTime_KIA = new TextBox();
            textBoxStatsMinTime_KIA = new TextBox();
            textBoxStatsMinibuses_KIA = new TextBox();
            textBoxStatsTrolleys_KIA = new TextBox();
            textBoxStatsTrams_KIA = new TextBox();
            textBoxStatsBuses_KIA = new TextBox();
            textBoxStatsRoutesCount_KIA = new TextBox();
            textBoxStatsTransportCount_KIA = new TextBox();
            labelStatsLongestTitle_KIA = new Label();
            labelStatsShortestTitle_KIA = new Label();
            labelStatsAvgTimeTitle_KIA = new Label();
            labelStatsMaxTimeTitle_KIA = new Label();
            labelStatsMinTimeTitle_KIA = new Label();
            labelStatsMinibusesTitle_KIA = new Label();
            labelStatsTrolleysTitle_KIA = new Label();
            labelStatsTramsTitle_KIA = new Label();
            labelStatsBusesTitle_KIA = new Label();
            labelStatsRoutesCountTitle_KIA = new Label();
            labelStatsTransportCountTitle_KIA = new Label();
            groupBoxFilter_KIA = new GroupBox();
            buttonResetFilter_KIA = new Button();
            numericUpDownMaxTime_KIA = new NumericUpDown();
            labelFilterTimeTo_KIA = new Label();
            labelFilterTimeFrom_KIA = new Label();
            numericUpDownMinTime_KIA = new NumericUpDown();
            textBoxFilterEnd_KIA = new TextBox();
            textBoxFilterStart_KIA = new TextBox();
            labelFilterTime_KIA = new Label();
            labelFilterEnd_KIA = new Label();
            labelFilterStart_KIA = new Label();
            dateTimePickerMaxDate_KIA = new DateTimePicker();
            labelFilterDateTo_KIA = new Label();
            dateTimePickerMinDate_KIA = new DateTimePicker();
            labelFilterDateFrom_KIA = new Label();
            labelFilterDate_KIA = new Label();
            numericUpDownFilterRoute_KIA = new NumericUpDown();
            labelFilterRoute_KIA = new Label();
            comboBoxFilterType_KIA = new ComboBox();
            numericUpDownFilterID_KIA = new NumericUpDown();
            labelFilterType_KIA = new Label();
            labelFilterID_KIA = new Label();
            toolStripTools_KIA = new ToolStrip();
            toolStripButtonEdit_KIA = new ToolStripButton();
            toolStripSeparatorEditAdd_KIA = new ToolStripSeparator();
            toolStripButtonAdd_KIA = new ToolStripButton();
            toolStripSeparatorAddDelete_KIA = new ToolStripSeparator();
            toolStripButtonDelete_KIA = new ToolStripButton();
            toolStripSeparatorDeleteStats_KIA = new ToolStripSeparator();
            toolStripButtonStats_KIA = new ToolStripButton();
            toolStripSeparatorStatsSearch_KIA = new ToolStripSeparator();
            toolStripLabelSearchIcon_KIA = new ToolStripLabel();
            toolStripLabelSearch_KIA = new ToolStripLabel();
            toolStripTextBoxSearch_KIA = new ToolStripTextBox();
            toolTip_KIA = new ToolTip(components);
            dataGridViewTransports_KIA = new DataGridView();
            colID_KIA = new DataGridViewTextBoxColumn();
            colTransportType_KIA = new DataGridViewTextBoxColumn();
            colRouteNumber_KIA = new DataGridViewTextBoxColumn();
            colStartDate_KIA = new DataGridViewTextBoxColumn();
            colStartStop_KIA = new DataGridViewTextBoxColumn();
            colEndStop_KIA = new DataGridViewTextBoxColumn();
            colTravelTime_KIA = new DataGridViewTextBoxColumn();
            colNote_KIA = new DataGridViewTextBoxColumn();
            menuStrip_KIA.SuspendLayout();
            groupBoxStats_KIA.SuspendLayout();
            groupBoxFilter_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxTime_KIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinTime_KIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFilterRoute_KIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFilterID_KIA).BeginInit();
            toolStripTools_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransports_KIA).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_KIA
            // 
            menuStrip_KIA.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile_KIA, toolStripMenuItemHelp_KIA });
            menuStrip_KIA.Location = new Point(0, 0);
            menuStrip_KIA.Name = "menuStrip_KIA";
            menuStrip_KIA.Size = new Size(1433, 24);
            menuStrip_KIA.TabIndex = 0;
            menuStrip_KIA.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile_KIA
            // 
            toolStripMenuItemFile_KIA.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemNewTable_KIA, toolStripMenuItemOpen_KIA, toolStripMenuItemSave_KIA, toolStripMenuItemSaveAs_KIA });
            toolStripMenuItemFile_KIA.Name = "toolStripMenuItemFile_KIA";
            toolStripMenuItemFile_KIA.Size = new Size(48, 20);
            toolStripMenuItemFile_KIA.Text = "Файл";
            // 
            // ToolStripMenuItemNewTable_KIA
            // 
            ToolStripMenuItemNewTable_KIA.Image = (Image)resources.GetObject("ToolStripMenuItemNewTable_KIA.Image");
            ToolStripMenuItemNewTable_KIA.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripMenuItemNewTable_KIA.Name = "ToolStripMenuItemNewTable_KIA";
            ToolStripMenuItemNewTable_KIA.Size = new Size(179, 38);
            ToolStripMenuItemNewTable_KIA.Text = "Новая таблица";
            ToolStripMenuItemNewTable_KIA.TextDirection = ToolStripTextDirection.Horizontal;
            ToolStripMenuItemNewTable_KIA.ToolTipText = "Создать новую таблицу";
            ToolStripMenuItemNewTable_KIA.Click += ToolStripMenuItemNewTable_KIA_Click;
            // 
            // toolStripMenuItemOpen_KIA
            // 
            toolStripMenuItemOpen_KIA.Image = (Image)resources.GetObject("toolStripMenuItemOpen_KIA.Image");
            toolStripMenuItemOpen_KIA.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemOpen_KIA.Name = "toolStripMenuItemOpen_KIA";
            toolStripMenuItemOpen_KIA.Size = new Size(179, 38);
            toolStripMenuItemOpen_KIA.Text = "Открыть...";
            toolStripMenuItemOpen_KIA.ToolTipText = "Открыть файл с данными";
            toolStripMenuItemOpen_KIA.Click += toolStripMenuItemOpen_KIA_Click;
            // 
            // toolStripMenuItemSave_KIA
            // 
            toolStripMenuItemSave_KIA.Image = (Image)resources.GetObject("toolStripMenuItemSave_KIA.Image");
            toolStripMenuItemSave_KIA.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemSave_KIA.Name = "toolStripMenuItemSave_KIA";
            toolStripMenuItemSave_KIA.Size = new Size(179, 38);
            toolStripMenuItemSave_KIA.Text = "Сохранить";
            toolStripMenuItemSave_KIA.ToolTipText = "Сохранить текущие данные";
            toolStripMenuItemSave_KIA.Click += toolStripMenuItemSave_KIA_Click;
            // 
            // toolStripMenuItemSaveAs_KIA
            // 
            toolStripMenuItemSaveAs_KIA.Image = (Image)resources.GetObject("toolStripMenuItemSaveAs_KIA.Image");
            toolStripMenuItemSaveAs_KIA.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemSaveAs_KIA.Name = "toolStripMenuItemSaveAs_KIA";
            toolStripMenuItemSaveAs_KIA.Size = new Size(179, 38);
            toolStripMenuItemSaveAs_KIA.Text = "Сохранить как...";
            toolStripMenuItemSaveAs_KIA.ToolTipText = "Сохранить данные в новый файл";
            toolStripMenuItemSaveAs_KIA.Click += toolStripMenuItemSaveAs_KIA_Click;
            // 
            // toolStripMenuItemHelp_KIA
            // 
            toolStripMenuItemHelp_KIA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemManual_KIA, toolStripMenuItemAbout_KIA });
            toolStripMenuItemHelp_KIA.Name = "toolStripMenuItemHelp_KIA";
            toolStripMenuItemHelp_KIA.Size = new Size(68, 20);
            toolStripMenuItemHelp_KIA.Text = "Помощь";
            // 
            // toolStripMenuItemManual_KIA
            // 
            toolStripMenuItemManual_KIA.Image = (Image)resources.GetObject("toolStripMenuItemManual_KIA.Image");
            toolStripMenuItemManual_KIA.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemManual_KIA.Name = "toolStripMenuItemManual_KIA";
            toolStripMenuItemManual_KIA.Size = new Size(165, 38);
            toolStripMenuItemManual_KIA.Text = "Руководство";
            toolStripMenuItemManual_KIA.ToolTipText = "Открыть руководство пользователя";
            toolStripMenuItemManual_KIA.Click += toolStripMenuItemManual_KIA_Click;
            // 
            // toolStripMenuItemAbout_KIA
            // 
            toolStripMenuItemAbout_KIA.Image = (Image)resources.GetObject("toolStripMenuItemAbout_KIA.Image");
            toolStripMenuItemAbout_KIA.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemAbout_KIA.Name = "toolStripMenuItemAbout_KIA";
            toolStripMenuItemAbout_KIA.Size = new Size(165, 38);
            toolStripMenuItemAbout_KIA.Text = "О программе";
            toolStripMenuItemAbout_KIA.ToolTipText = "Информация о программе";
            toolStripMenuItemAbout_KIA.Click += toolStripMenuItemAbout_KIA_Click;
            // 
            // groupBoxStats_KIA
            // 
            groupBoxStats_KIA.Controls.Add(textBoxStatsLongest_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsShortest_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsAvgTime_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsMaxTime_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsMinTime_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsMinibuses_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsTrolleys_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsTrams_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsBuses_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsRoutesCount_KIA);
            groupBoxStats_KIA.Controls.Add(textBoxStatsTransportCount_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsLongestTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsShortestTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsAvgTimeTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsMaxTimeTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsMinTimeTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsMinibusesTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsTrolleysTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsTramsTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsBusesTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsRoutesCountTitle_KIA);
            groupBoxStats_KIA.Controls.Add(labelStatsTransportCountTitle_KIA);
            groupBoxStats_KIA.Dock = DockStyle.Bottom;
            groupBoxStats_KIA.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxStats_KIA.Location = new Point(0, 600);
            groupBoxStats_KIA.Name = "groupBoxStats_KIA";
            groupBoxStats_KIA.Size = new Size(1433, 161);
            groupBoxStats_KIA.TabIndex = 3;
            groupBoxStats_KIA.TabStop = false;
            groupBoxStats_KIA.Text = "Статистика";
            // 
            // textBoxStatsLongest_KIA
            // 
            textBoxStatsLongest_KIA.Location = new Point(596, 125);
            textBoxStatsLongest_KIA.Name = "textBoxStatsLongest_KIA";
            textBoxStatsLongest_KIA.ReadOnly = true;
            textBoxStatsLongest_KIA.Size = new Size(168, 25);
            textBoxStatsLongest_KIA.TabIndex = 21;
            textBoxStatsLongest_KIA.TabStop = false;
            // 
            // textBoxStatsShortest_KIA
            // 
            textBoxStatsShortest_KIA.Location = new Point(200, 125);
            textBoxStatsShortest_KIA.Name = "textBoxStatsShortest_KIA";
            textBoxStatsShortest_KIA.ReadOnly = true;
            textBoxStatsShortest_KIA.Size = new Size(155, 25);
            textBoxStatsShortest_KIA.TabIndex = 20;
            textBoxStatsShortest_KIA.TabStop = false;
            // 
            // textBoxStatsAvgTime_KIA
            // 
            textBoxStatsAvgTime_KIA.Location = new Point(1200, 19);
            textBoxStatsAvgTime_KIA.Name = "textBoxStatsAvgTime_KIA";
            textBoxStatsAvgTime_KIA.ReadOnly = true;
            textBoxStatsAvgTime_KIA.Size = new Size(70, 25);
            textBoxStatsAvgTime_KIA.TabIndex = 19;
            textBoxStatsAvgTime_KIA.TabStop = false;
            // 
            // textBoxStatsMaxTime_KIA
            // 
            textBoxStatsMaxTime_KIA.Location = new Point(967, 21);
            textBoxStatsMaxTime_KIA.Name = "textBoxStatsMaxTime_KIA";
            textBoxStatsMaxTime_KIA.ReadOnly = true;
            textBoxStatsMaxTime_KIA.Size = new Size(70, 25);
            textBoxStatsMaxTime_KIA.TabIndex = 18;
            textBoxStatsMaxTime_KIA.TabStop = false;
            // 
            // textBoxStatsMinTime_KIA
            // 
            textBoxStatsMinTime_KIA.Location = new Point(694, 21);
            textBoxStatsMinTime_KIA.Name = "textBoxStatsMinTime_KIA";
            textBoxStatsMinTime_KIA.ReadOnly = true;
            textBoxStatsMinTime_KIA.Size = new Size(70, 25);
            textBoxStatsMinTime_KIA.TabIndex = 17;
            textBoxStatsMinTime_KIA.TabStop = false;
            // 
            // textBoxStatsMinibuses_KIA
            // 
            textBoxStatsMinibuses_KIA.Location = new Point(694, 71);
            textBoxStatsMinibuses_KIA.Name = "textBoxStatsMinibuses_KIA";
            textBoxStatsMinibuses_KIA.ReadOnly = true;
            textBoxStatsMinibuses_KIA.Size = new Size(70, 25);
            textBoxStatsMinibuses_KIA.TabIndex = 16;
            textBoxStatsMinibuses_KIA.TabStop = false;
            // 
            // textBoxStatsTrolleys_KIA
            // 
            textBoxStatsTrolleys_KIA.Location = new Point(489, 71);
            textBoxStatsTrolleys_KIA.Name = "textBoxStatsTrolleys_KIA";
            textBoxStatsTrolleys_KIA.ReadOnly = true;
            textBoxStatsTrolleys_KIA.Size = new Size(70, 25);
            textBoxStatsTrolleys_KIA.TabIndex = 15;
            textBoxStatsTrolleys_KIA.TabStop = false;
            // 
            // textBoxStatsTrams_KIA
            // 
            textBoxStatsTrams_KIA.Location = new Point(274, 71);
            textBoxStatsTrams_KIA.Name = "textBoxStatsTrams_KIA";
            textBoxStatsTrams_KIA.ReadOnly = true;
            textBoxStatsTrams_KIA.Size = new Size(70, 25);
            textBoxStatsTrams_KIA.TabIndex = 14;
            textBoxStatsTrams_KIA.TabStop = false;
            // 
            // textBoxStatsBuses_KIA
            // 
            textBoxStatsBuses_KIA.Location = new Point(95, 71);
            textBoxStatsBuses_KIA.Name = "textBoxStatsBuses_KIA";
            textBoxStatsBuses_KIA.ReadOnly = true;
            textBoxStatsBuses_KIA.Size = new Size(70, 25);
            textBoxStatsBuses_KIA.TabIndex = 13;
            textBoxStatsBuses_KIA.TabStop = false;
            // 
            // textBoxStatsRoutesCount_KIA
            // 
            textBoxStatsRoutesCount_KIA.Location = new Point(410, 21);
            textBoxStatsRoutesCount_KIA.Name = "textBoxStatsRoutesCount_KIA";
            textBoxStatsRoutesCount_KIA.ReadOnly = true;
            textBoxStatsRoutesCount_KIA.Size = new Size(100, 25);
            textBoxStatsRoutesCount_KIA.TabIndex = 12;
            textBoxStatsRoutesCount_KIA.TabStop = false;
            // 
            // textBoxStatsTransportCount_KIA
            // 
            textBoxStatsTransportCount_KIA.Location = new Point(146, 21);
            textBoxStatsTransportCount_KIA.Name = "textBoxStatsTransportCount_KIA";
            textBoxStatsTransportCount_KIA.ReadOnly = true;
            textBoxStatsTransportCount_KIA.Size = new Size(100, 25);
            textBoxStatsTransportCount_KIA.TabIndex = 11;
            textBoxStatsTransportCount_KIA.TabStop = false;
            // 
            // labelStatsLongestTitle_KIA
            // 
            labelStatsLongestTitle_KIA.AutoSize = true;
            labelStatsLongestTitle_KIA.Location = new Point(403, 128);
            labelStatsLongestTitle_KIA.Name = "labelStatsLongestTitle_KIA";
            labelStatsLongestTitle_KIA.Size = new Size(187, 17);
            labelStatsLongestTitle_KIA.TabIndex = 10;
            labelStatsLongestTitle_KIA.Text = "Самый длинный маршрут:";
            // 
            // labelStatsShortestTitle_KIA
            // 
            labelStatsShortestTitle_KIA.AutoSize = true;
            labelStatsShortestTitle_KIA.Location = new Point(6, 128);
            labelStatsShortestTitle_KIA.Name = "labelStatsShortestTitle_KIA";
            labelStatsShortestTitle_KIA.Size = new Size(188, 17);
            labelStatsShortestTitle_KIA.TabIndex = 9;
            labelStatsShortestTitle_KIA.Text = "Самый короткий маршрут:";
            // 
            // labelStatsAvgTimeTitle_KIA
            // 
            labelStatsAvgTimeTitle_KIA.AutoSize = true;
            labelStatsAvgTimeTitle_KIA.Location = new Point(1076, 24);
            labelStatsAvgTimeTitle_KIA.Name = "labelStatsAvgTimeTitle_KIA";
            labelStatsAvgTimeTitle_KIA.Size = new Size(118, 17);
            labelStatsAvgTimeTitle_KIA.TabIndex = 8;
            labelStatsAvgTimeTitle_KIA.Text = "Среднее время:";
            // 
            // labelStatsMaxTimeTitle_KIA
            // 
            labelStatsMaxTimeTitle_KIA.AutoSize = true;
            labelStatsMaxTimeTitle_KIA.Location = new Point(803, 24);
            labelStatsMaxTimeTitle_KIA.Name = "labelStatsMaxTimeTitle_KIA";
            labelStatsMaxTimeTitle_KIA.Size = new Size(158, 17);
            labelStatsMaxTimeTitle_KIA.TabIndex = 7;
            labelStatsMaxTimeTitle_KIA.Text = "Максимальное время:";
            // 
            // labelStatsMinTimeTitle_KIA
            // 
            labelStatsMinTimeTitle_KIA.AutoSize = true;
            labelStatsMinTimeTitle_KIA.Location = new Point(537, 24);
            labelStatsMinTimeTitle_KIA.Name = "labelStatsMinTimeTitle_KIA";
            labelStatsMinTimeTitle_KIA.Size = new Size(151, 17);
            labelStatsMinTimeTitle_KIA.TabIndex = 6;
            labelStatsMinTimeTitle_KIA.Text = "Минимальное время:";
            // 
            // labelStatsMinibusesTitle_KIA
            // 
            labelStatsMinibusesTitle_KIA.AutoSize = true;
            labelStatsMinibusesTitle_KIA.Location = new Point(597, 74);
            labelStatsMinibusesTitle_KIA.Name = "labelStatsMinibusesTitle_KIA";
            labelStatsMinibusesTitle_KIA.Size = new Size(91, 17);
            labelStatsMinibusesTitle_KIA.TabIndex = 5;
            labelStatsMinibusesTitle_KIA.Text = "Маршрутки: ";
            // 
            // labelStatsTrolleysTitle_KIA
            // 
            labelStatsTrolleysTitle_KIA.AutoSize = true;
            labelStatsTrolleysTitle_KIA.Location = new Point(376, 74);
            labelStatsTrolleysTitle_KIA.Name = "labelStatsTrolleysTitle_KIA";
            labelStatsTrolleysTitle_KIA.Size = new Size(107, 17);
            labelStatsTrolleysTitle_KIA.TabIndex = 4;
            labelStatsTrolleysTitle_KIA.Text = "Троллейбусы: ";
            // 
            // labelStatsTramsTitle_KIA
            // 
            labelStatsTramsTitle_KIA.AutoSize = true;
            labelStatsTramsTitle_KIA.Location = new Point(203, 74);
            labelStatsTramsTitle_KIA.Name = "labelStatsTramsTitle_KIA";
            labelStatsTramsTitle_KIA.Size = new Size(74, 17);
            labelStatsTramsTitle_KIA.TabIndex = 3;
            labelStatsTramsTitle_KIA.Text = "Трамваи: ";
            // 
            // labelStatsBusesTitle_KIA
            // 
            labelStatsBusesTitle_KIA.AutoSize = true;
            labelStatsBusesTitle_KIA.Location = new Point(6, 74);
            labelStatsBusesTitle_KIA.Name = "labelStatsBusesTitle_KIA";
            labelStatsBusesTitle_KIA.Size = new Size(83, 17);
            labelStatsBusesTitle_KIA.TabIndex = 2;
            labelStatsBusesTitle_KIA.Text = "Автобусы: ";
            // 
            // labelStatsRoutesCountTitle_KIA
            // 
            labelStatsRoutesCountTitle_KIA.AutoSize = true;
            labelStatsRoutesCountTitle_KIA.Location = new Point(274, 24);
            labelStatsRoutesCountTitle_KIA.Name = "labelStatsRoutesCountTitle_KIA";
            labelStatsRoutesCountTitle_KIA.Size = new Size(145, 17);
            labelStatsRoutesCountTitle_KIA.TabIndex = 1;
            labelStatsRoutesCountTitle_KIA.Text = "Кол-во маршрутов:  ";
            // 
            // labelStatsTransportCountTitle_KIA
            // 
            labelStatsTransportCountTitle_KIA.AutoSize = true;
            labelStatsTransportCountTitle_KIA.Location = new Point(6, 24);
            labelStatsTransportCountTitle_KIA.Name = "labelStatsTransportCountTitle_KIA";
            labelStatsTransportCountTitle_KIA.Size = new Size(144, 17);
            labelStatsTransportCountTitle_KIA.TabIndex = 0;
            labelStatsTransportCountTitle_KIA.Text = "Кол-во транспорта: ";
            // 
            // groupBoxFilter_KIA
            // 
            groupBoxFilter_KIA.Controls.Add(buttonResetFilter_KIA);
            groupBoxFilter_KIA.Controls.Add(numericUpDownMaxTime_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterTimeTo_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterTimeFrom_KIA);
            groupBoxFilter_KIA.Controls.Add(numericUpDownMinTime_KIA);
            groupBoxFilter_KIA.Controls.Add(textBoxFilterEnd_KIA);
            groupBoxFilter_KIA.Controls.Add(textBoxFilterStart_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterTime_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterEnd_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterStart_KIA);
            groupBoxFilter_KIA.Controls.Add(dateTimePickerMaxDate_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterDateTo_KIA);
            groupBoxFilter_KIA.Controls.Add(dateTimePickerMinDate_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterDateFrom_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterDate_KIA);
            groupBoxFilter_KIA.Controls.Add(numericUpDownFilterRoute_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterRoute_KIA);
            groupBoxFilter_KIA.Controls.Add(comboBoxFilterType_KIA);
            groupBoxFilter_KIA.Controls.Add(numericUpDownFilterID_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterType_KIA);
            groupBoxFilter_KIA.Controls.Add(labelFilterID_KIA);
            groupBoxFilter_KIA.Dock = DockStyle.Right;
            groupBoxFilter_KIA.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxFilter_KIA.Location = new Point(1169, 24);
            groupBoxFilter_KIA.Name = "groupBoxFilter_KIA";
            groupBoxFilter_KIA.Size = new Size(264, 576);
            groupBoxFilter_KIA.TabIndex = 4;
            groupBoxFilter_KIA.TabStop = false;
            groupBoxFilter_KIA.Text = "Фильтрация";
            // 
            // buttonResetFilter_KIA
            // 
            buttonResetFilter_KIA.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonResetFilter_KIA.Location = new Point(14, 520);
            buttonResetFilter_KIA.Name = "buttonResetFilter_KIA";
            buttonResetFilter_KIA.Size = new Size(159, 41);
            buttonResetFilter_KIA.TabIndex = 21;
            buttonResetFilter_KIA.Text = "Сбросить фильтры";
            toolTip_KIA.SetToolTip(buttonResetFilter_KIA, "Сбросить все фильтры");
            buttonResetFilter_KIA.UseVisualStyleBackColor = true;
            buttonResetFilter_KIA.Click += buttonResetFilter_KIA_Click;
            // 
            // numericUpDownMaxTime_KIA
            // 
            numericUpDownMaxTime_KIA.Location = new Point(151, 460);
            numericUpDownMaxTime_KIA.Name = "numericUpDownMaxTime_KIA";
            numericUpDownMaxTime_KIA.Size = new Size(75, 25);
            numericUpDownMaxTime_KIA.TabIndex = 20;
            toolTip_KIA.SetToolTip(numericUpDownMaxTime_KIA, "Максимальное время в пути (0 - без ограничения)");
            numericUpDownMaxTime_KIA.ValueChanged += numericUpDownMaxTime_KIA_ValueChanged;
            // 
            // labelFilterTimeTo_KIA
            // 
            labelFilterTimeTo_KIA.AutoSize = true;
            labelFilterTimeTo_KIA.Location = new Point(120, 462);
            labelFilterTimeTo_KIA.Name = "labelFilterTimeTo_KIA";
            labelFilterTimeTo_KIA.Size = new Size(25, 17);
            labelFilterTimeTo_KIA.TabIndex = 19;
            labelFilterTimeTo_KIA.Text = "до";
            // 
            // labelFilterTimeFrom_KIA
            // 
            labelFilterTimeFrom_KIA.AutoSize = true;
            labelFilterTimeFrom_KIA.Location = new Point(14, 462);
            labelFilterTimeFrom_KIA.Name = "labelFilterTimeFrom_KIA";
            labelFilterTimeFrom_KIA.Size = new Size(23, 17);
            labelFilterTimeFrom_KIA.TabIndex = 18;
            labelFilterTimeFrom_KIA.Text = "от";
            // 
            // numericUpDownMinTime_KIA
            // 
            numericUpDownMinTime_KIA.Location = new Point(39, 460);
            numericUpDownMinTime_KIA.Name = "numericUpDownMinTime_KIA";
            numericUpDownMinTime_KIA.Size = new Size(75, 25);
            numericUpDownMinTime_KIA.TabIndex = 17;
            toolTip_KIA.SetToolTip(numericUpDownMinTime_KIA, "Минимальное время в пути (0 - без ограничения)");
            numericUpDownMinTime_KIA.ValueChanged += numericUpDownMinTime_KIA_ValueChanged;
            // 
            // textBoxFilterEnd_KIA
            // 
            textBoxFilterEnd_KIA.Location = new Point(14, 383);
            textBoxFilterEnd_KIA.Name = "textBoxFilterEnd_KIA";
            textBoxFilterEnd_KIA.Size = new Size(212, 25);
            textBoxFilterEnd_KIA.TabIndex = 16;
            toolTip_KIA.SetToolTip(textBoxFilterEnd_KIA, "Поиск по конечной остановке");
            textBoxFilterEnd_KIA.TextChanged += textBoxFilterEnd_KIA_TextChanged;
            // 
            // textBoxFilterStart_KIA
            // 
            textBoxFilterStart_KIA.Location = new Point(14, 317);
            textBoxFilterStart_KIA.Name = "textBoxFilterStart_KIA";
            textBoxFilterStart_KIA.Size = new Size(212, 25);
            textBoxFilterStart_KIA.TabIndex = 15;
            toolTip_KIA.SetToolTip(textBoxFilterStart_KIA, "Поиск по начальной остановке");
            textBoxFilterStart_KIA.TextChanged += textBoxFilterStart_KIA_TextChanged;
            // 
            // labelFilterTime_KIA
            // 
            labelFilterTime_KIA.AutoSize = true;
            labelFilterTime_KIA.Location = new Point(10, 434);
            labelFilterTime_KIA.Name = "labelFilterTime_KIA";
            labelFilterTime_KIA.Size = new Size(152, 17);
            labelFilterTime_KIA.TabIndex = 14;
            labelFilterTime_KIA.Text = "Время в пути (минут)";
            // 
            // labelFilterEnd_KIA
            // 
            labelFilterEnd_KIA.AutoSize = true;
            labelFilterEnd_KIA.Location = new Point(11, 363);
            labelFilterEnd_KIA.Name = "labelFilterEnd_KIA";
            labelFilterEnd_KIA.Size = new Size(147, 17);
            labelFilterEnd_KIA.TabIndex = 13;
            labelFilterEnd_KIA.Text = "Конечная остановка";
            // 
            // labelFilterStart_KIA
            // 
            labelFilterStart_KIA.AutoSize = true;
            labelFilterStart_KIA.Location = new Point(11, 297);
            labelFilterStart_KIA.Name = "labelFilterStart_KIA";
            labelFilterStart_KIA.Size = new Size(156, 17);
            labelFilterStart_KIA.TabIndex = 12;
            labelFilterStart_KIA.Text = "Начальная остановка";
            // 
            // dateTimePickerMaxDate_KIA
            // 
            dateTimePickerMaxDate_KIA.Format = DateTimePickerFormat.Short;
            dateTimePickerMaxDate_KIA.Location = new Point(154, 245);
            dateTimePickerMaxDate_KIA.Name = "dateTimePickerMaxDate_KIA";
            dateTimePickerMaxDate_KIA.Size = new Size(98, 25);
            dateTimePickerMaxDate_KIA.TabIndex = 11;
            toolTip_KIA.SetToolTip(dateTimePickerMaxDate_KIA, "Конечная дата для фильтрации");
            dateTimePickerMaxDate_KIA.ValueChanged += dateTimePickerMaxDate_KIA_ValueChanged;
            // 
            // labelFilterDateTo_KIA
            // 
            labelFilterDateTo_KIA.AutoSize = true;
            labelFilterDateTo_KIA.Location = new Point(129, 251);
            labelFilterDateTo_KIA.Name = "labelFilterDateTo_KIA";
            labelFilterDateTo_KIA.Size = new Size(25, 17);
            labelFilterDateTo_KIA.TabIndex = 10;
            labelFilterDateTo_KIA.Text = "до";
            // 
            // dateTimePickerMinDate_KIA
            // 
            dateTimePickerMinDate_KIA.Format = DateTimePickerFormat.Short;
            dateTimePickerMinDate_KIA.Location = new Point(32, 245);
            dateTimePickerMinDate_KIA.Name = "dateTimePickerMinDate_KIA";
            dateTimePickerMinDate_KIA.Size = new Size(95, 25);
            dateTimePickerMinDate_KIA.TabIndex = 9;
            toolTip_KIA.SetToolTip(dateTimePickerMinDate_KIA, "Начальная дата для фильтрации");
            dateTimePickerMinDate_KIA.ValueChanged += dateTimePickerMinDate_KIA_ValueChanged;
            // 
            // labelFilterDateFrom_KIA
            // 
            labelFilterDateFrom_KIA.AutoSize = true;
            labelFilterDateFrom_KIA.Location = new Point(10, 251);
            labelFilterDateFrom_KIA.Name = "labelFilterDateFrom_KIA";
            labelFilterDateFrom_KIA.Size = new Size(23, 17);
            labelFilterDateFrom_KIA.TabIndex = 8;
            labelFilterDateFrom_KIA.Text = "от";
            // 
            // labelFilterDate_KIA
            // 
            labelFilterDate_KIA.AutoSize = true;
            labelFilterDate_KIA.Location = new Point(11, 220);
            labelFilterDate_KIA.Name = "labelFilterDate_KIA";
            labelFilterDate_KIA.Size = new Size(181, 17);
            labelFilterDate_KIA.TabIndex = 7;
            labelFilterDate_KIA.Text = "Дата введения маршрута";
            // 
            // numericUpDownFilterRoute_KIA
            // 
            numericUpDownFilterRoute_KIA.Location = new Point(14, 176);
            numericUpDownFilterRoute_KIA.Name = "numericUpDownFilterRoute_KIA";
            numericUpDownFilterRoute_KIA.Size = new Size(120, 25);
            numericUpDownFilterRoute_KIA.TabIndex = 6;
            toolTip_KIA.SetToolTip(numericUpDownFilterRoute_KIA, "Фильтр по номеру маршрута (0 - все маршруты)");
            numericUpDownFilterRoute_KIA.ValueChanged += numericUpDownFilterRoute_KIA_ValueChanged;
            // 
            // labelFilterRoute_KIA
            // 
            labelFilterRoute_KIA.AutoSize = true;
            labelFilterRoute_KIA.Location = new Point(10, 156);
            labelFilterRoute_KIA.Name = "labelFilterRoute_KIA";
            labelFilterRoute_KIA.Size = new Size(123, 17);
            labelFilterRoute_KIA.TabIndex = 5;
            labelFilterRoute_KIA.Text = "Номер маршрута";
            // 
            // comboBoxFilterType_KIA
            // 
            comboBoxFilterType_KIA.FormattingEnabled = true;
            comboBoxFilterType_KIA.Location = new Point(13, 111);
            comboBoxFilterType_KIA.Name = "comboBoxFilterType_KIA";
            comboBoxFilterType_KIA.Size = new Size(121, 25);
            comboBoxFilterType_KIA.TabIndex = 4;
            toolTip_KIA.SetToolTip(comboBoxFilterType_KIA, "Фильтр по виду транспорта");
            comboBoxFilterType_KIA.SelectedIndexChanged += comboBoxFilterType_KIA_SelectedIndexChanged;
            // 
            // numericUpDownFilterID_KIA
            // 
            numericUpDownFilterID_KIA.Location = new Point(14, 45);
            numericUpDownFilterID_KIA.Name = "numericUpDownFilterID_KIA";
            numericUpDownFilterID_KIA.Size = new Size(120, 25);
            numericUpDownFilterID_KIA.TabIndex = 3;
            toolTip_KIA.SetToolTip(numericUpDownFilterID_KIA, "Фильтр по ID транспорта (0 - показать все)");
            numericUpDownFilterID_KIA.ValueChanged += numericUpDownFilterID_KIA_ValueChanged;
            // 
            // labelFilterType_KIA
            // 
            labelFilterType_KIA.AutoSize = true;
            labelFilterType_KIA.Location = new Point(10, 91);
            labelFilterType_KIA.Name = "labelFilterType_KIA";
            labelFilterType_KIA.Size = new Size(117, 17);
            labelFilterType_KIA.TabIndex = 2;
            labelFilterType_KIA.Text = "Вид транспорта";
            // 
            // labelFilterID_KIA
            // 
            labelFilterID_KIA.AutoSize = true;
            labelFilterID_KIA.Location = new Point(10, 25);
            labelFilterID_KIA.Name = "labelFilterID_KIA";
            labelFilterID_KIA.Size = new Size(104, 17);
            labelFilterID_KIA.TabIndex = 0;
            labelFilterID_KIA.Text = "ID транспорта";
            labelFilterID_KIA.Click += labelFilterID_KIA_Click;
            // 
            // toolStripTools_KIA
            // 
            toolStripTools_KIA.Items.AddRange(new ToolStripItem[] { toolStripButtonEdit_KIA, toolStripSeparatorEditAdd_KIA, toolStripButtonAdd_KIA, toolStripSeparatorAddDelete_KIA, toolStripButtonDelete_KIA, toolStripSeparatorDeleteStats_KIA, toolStripButtonStats_KIA, toolStripSeparatorStatsSearch_KIA, toolStripLabelSearchIcon_KIA, toolStripLabelSearch_KIA, toolStripTextBoxSearch_KIA });
            toolStripTools_KIA.Location = new Point(0, 24);
            toolStripTools_KIA.Name = "toolStripTools_KIA";
            toolStripTools_KIA.RenderMode = ToolStripRenderMode.System;
            toolStripTools_KIA.Size = new Size(1169, 25);
            toolStripTools_KIA.TabIndex = 7;
            toolStripTools_KIA.Text = "toolStrip1";
            // 
            // toolStripButtonEdit_KIA
            // 
            toolStripButtonEdit_KIA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEdit_KIA.Image = (Image)resources.GetObject("toolStripButtonEdit_KIA.Image");
            toolStripButtonEdit_KIA.ImageTransparentColor = Color.Magenta;
            toolStripButtonEdit_KIA.Name = "toolStripButtonEdit_KIA";
            toolStripButtonEdit_KIA.Size = new Size(23, 22);
            toolStripButtonEdit_KIA.Text = "toolStripButton2";
            toolStripButtonEdit_KIA.ToolTipText = "Редактировать выбранную запись";
            toolStripButtonEdit_KIA.Click += toolStripButtonEdit_KIA_Click;
            // 
            // toolStripSeparatorEditAdd_KIA
            // 
            toolStripSeparatorEditAdd_KIA.Name = "toolStripSeparatorEditAdd_KIA";
            toolStripSeparatorEditAdd_KIA.Size = new Size(6, 25);
            // 
            // toolStripButtonAdd_KIA
            // 
            toolStripButtonAdd_KIA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAdd_KIA.Image = (Image)resources.GetObject("toolStripButtonAdd_KIA.Image");
            toolStripButtonAdd_KIA.ImageTransparentColor = Color.Magenta;
            toolStripButtonAdd_KIA.Name = "toolStripButtonAdd_KIA";
            toolStripButtonAdd_KIA.Size = new Size(23, 22);
            toolStripButtonAdd_KIA.Text = "toolStripButton3";
            toolStripButtonAdd_KIA.ToolTipText = "Добавить новую запись";
            toolStripButtonAdd_KIA.Click += toolStripButtonAdd_KIA_Click;
            // 
            // toolStripSeparatorAddDelete_KIA
            // 
            toolStripSeparatorAddDelete_KIA.Name = "toolStripSeparatorAddDelete_KIA";
            toolStripSeparatorAddDelete_KIA.Size = new Size(6, 25);
            // 
            // toolStripButtonDelete_KIA
            // 
            toolStripButtonDelete_KIA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDelete_KIA.Image = (Image)resources.GetObject("toolStripButtonDelete_KIA.Image");
            toolStripButtonDelete_KIA.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelete_KIA.Name = "toolStripButtonDelete_KIA";
            toolStripButtonDelete_KIA.Size = new Size(23, 22);
            toolStripButtonDelete_KIA.Text = "toolStripButton4";
            toolStripButtonDelete_KIA.ToolTipText = "Удалить выбранную запись";
            toolStripButtonDelete_KIA.Click += toolStripButtonDelete_KIA_Click;
            // 
            // toolStripSeparatorDeleteStats_KIA
            // 
            toolStripSeparatorDeleteStats_KIA.Name = "toolStripSeparatorDeleteStats_KIA";
            toolStripSeparatorDeleteStats_KIA.Size = new Size(6, 25);
            // 
            // toolStripButtonStats_KIA
            // 
            toolStripButtonStats_KIA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStats_KIA.Image = (Image)resources.GetObject("toolStripButtonStats_KIA.Image");
            toolStripButtonStats_KIA.ImageTransparentColor = Color.Magenta;
            toolStripButtonStats_KIA.Name = "toolStripButtonStats_KIA";
            toolStripButtonStats_KIA.Size = new Size(23, 22);
            toolStripButtonStats_KIA.Text = "toolStripButton1";
            toolStripButtonStats_KIA.ToolTipText = "Статистика выбранного маршрута";
            toolStripButtonStats_KIA.Click += toolStripButtonStats_KIA_Click;
            // 
            // toolStripSeparatorStatsSearch_KIA
            // 
            toolStripSeparatorStatsSearch_KIA.Name = "toolStripSeparatorStatsSearch_KIA";
            toolStripSeparatorStatsSearch_KIA.Size = new Size(6, 25);
            // 
            // toolStripLabelSearchIcon_KIA
            // 
            toolStripLabelSearchIcon_KIA.Image = (Image)resources.GetObject("toolStripLabelSearchIcon_KIA.Image");
            toolStripLabelSearchIcon_KIA.Name = "toolStripLabelSearchIcon_KIA";
            toolStripLabelSearchIcon_KIA.Size = new Size(16, 22);
            // 
            // toolStripLabelSearch_KIA
            // 
            toolStripLabelSearch_KIA.Name = "toolStripLabelSearch_KIA";
            toolStripLabelSearch_KIA.Size = new Size(45, 22);
            toolStripLabelSearch_KIA.Text = "Поиск:";
            // 
            // toolStripTextBoxSearch_KIA
            // 
            toolStripTextBoxSearch_KIA.Name = "toolStripTextBoxSearch_KIA";
            toolStripTextBoxSearch_KIA.Size = new Size(200, 25);
            toolStripTextBoxSearch_KIA.ToolTipText = "Быстрый поиск по всем полям";
            toolStripTextBoxSearch_KIA.TextChanged += toolStripTextBoxSearch_KIA_TextChanged;
            // 
            // dataGridViewTransports_KIA
            // 
            dataGridViewTransports_KIA.AllowUserToAddRows = false;
            dataGridViewTransports_KIA.AllowUserToResizeColumns = false;
            dataGridViewTransports_KIA.AllowUserToResizeRows = false;
            dataGridViewTransports_KIA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTransports_KIA.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewTransports_KIA.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTransports_KIA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTransports_KIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransports_KIA.Columns.AddRange(new DataGridViewColumn[] { colID_KIA, colTransportType_KIA, colRouteNumber_KIA, colStartDate_KIA, colStartStop_KIA, colEndStop_KIA, colTravelTime_KIA, colNote_KIA });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTransports_KIA.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTransports_KIA.Dock = DockStyle.Fill;
            dataGridViewTransports_KIA.GridColor = SystemColors.ControlDark;
            dataGridViewTransports_KIA.Location = new Point(0, 49);
            dataGridViewTransports_KIA.Name = "dataGridViewTransports_KIA";
            dataGridViewTransports_KIA.ReadOnly = true;
            dataGridViewTransports_KIA.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewTransports_KIA.RowHeadersVisible = false;
            dataGridViewTransports_KIA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTransports_KIA.RowTemplate.Height = 30;
            dataGridViewTransports_KIA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTransports_KIA.Size = new Size(1169, 551);
            dataGridViewTransports_KIA.TabIndex = 8;
            toolTip_KIA.SetToolTip(dataGridViewTransports_KIA, "Основная таблица данных. Кликните по заголовку для сортировки.");
            dataGridViewTransports_KIA.CellContentClick += dataGridViewTransports_KIA_CellContentClick;
            dataGridViewTransports_KIA.ColumnHeaderMouseClick += dataGridViewTransports_KIA_ColumnHeaderMouseClick;
            // 
            // colID_KIA
            // 
            colID_KIA.HeaderText = "ID";
            colID_KIA.Name = "colID_KIA";
            colID_KIA.ReadOnly = true;
            colID_KIA.Width = 50;
            // 
            // colTransportType_KIA
            // 
            colTransportType_KIA.HeaderText = "Вид транспорта";
            colTransportType_KIA.Name = "colTransportType_KIA";
            colTransportType_KIA.ReadOnly = true;
            colTransportType_KIA.Width = 130;
            // 
            // colRouteNumber_KIA
            // 
            colRouteNumber_KIA.HeaderText = "Номер маршрута";
            colRouteNumber_KIA.Name = "colRouteNumber_KIA";
            colRouteNumber_KIA.ReadOnly = true;
            // 
            // colStartDate_KIA
            // 
            colStartDate_KIA.HeaderText = "Дата введения";
            colStartDate_KIA.Name = "colStartDate_KIA";
            colStartDate_KIA.ReadOnly = true;
            colStartDate_KIA.Width = 120;
            // 
            // colStartStop_KIA
            // 
            colStartStop_KIA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStartStop_KIA.HeaderText = "Начальная остановка";
            colStartStop_KIA.Name = "colStartStop_KIA";
            colStartStop_KIA.ReadOnly = true;
            // 
            // colEndStop_KIA
            // 
            colEndStop_KIA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEndStop_KIA.HeaderText = "Конечная остановка";
            colEndStop_KIA.Name = "colEndStop_KIA";
            colEndStop_KIA.ReadOnly = true;
            // 
            // colTravelTime_KIA
            // 
            colTravelTime_KIA.HeaderText = "Время в пути (мин)";
            colTravelTime_KIA.Name = "colTravelTime_KIA";
            colTravelTime_KIA.ReadOnly = true;
            colTravelTime_KIA.Width = 110;
            // 
            // colNote_KIA
            // 
            colNote_KIA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNote_KIA.HeaderText = "Примечание";
            colNote_KIA.Name = "colNote_KIA";
            colNote_KIA.ReadOnly = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 761);
            Controls.Add(dataGridViewTransports_KIA);
            Controls.Add(toolStripTools_KIA);
            Controls.Add(groupBoxFilter_KIA);
            Controls.Add(groupBoxStats_KIA);
            Controls.Add(menuStrip_KIA);
            MainMenuStrip = menuStrip_KIA;
            MinimumSize = new Size(1449, 800);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Городской транспорт";
            Load += FormMain_Load;
            menuStrip_KIA.ResumeLayout(false);
            menuStrip_KIA.PerformLayout();
            groupBoxStats_KIA.ResumeLayout(false);
            groupBoxStats_KIA.PerformLayout();
            groupBoxFilter_KIA.ResumeLayout(false);
            groupBoxFilter_KIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxTime_KIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinTime_KIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFilterRoute_KIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFilterID_KIA).EndInit();
            toolStripTools_KIA.ResumeLayout(false);
            toolStripTools_KIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransports_KIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_KIA;
        private ToolStripMenuItem toolStripMenuItemFile_KIA;
        private ToolStripMenuItem ToolStripMenuItemNewTable_KIA;
        private ToolStripMenuItem toolStripMenuItemOpen_KIA;
        private ToolStripMenuItem toolStripMenuItemSave_KIA;
        private ToolStripMenuItem toolStripMenuItemSaveAs_KIA;
        private ToolStripMenuItem toolStripMenuItemHelp_KIA;
        private ToolStripMenuItem toolStripMenuItemManual_KIA;
        private ToolStripMenuItem toolStripMenuItemAbout_KIA;
        private GroupBox groupBoxStats_KIA;
        private TextBox textBoxStatsLongest_KIA;
        private TextBox textBoxStatsShortest_KIA;
        private TextBox textBoxStatsAvgTime_KIA;
        private TextBox textBoxStatsMaxTime_KIA;
        private TextBox textBoxStatsMinTime_KIA;
        private TextBox textBoxStatsMinibuses_KIA;
        private TextBox textBoxStatsTrolleys_KIA;
        private TextBox textBoxStatsTrams_KIA;
        private TextBox textBoxStatsBuses_KIA;
        private TextBox textBoxStatsRoutesCount_KIA;
        private TextBox textBoxStatsTransportCount_KIA;
        private Label labelStatsLongestTitle_KIA;
        private Label labelStatsShortestTitle_KIA;
        private Label labelStatsAvgTimeTitle_KIA;
        private Label labelStatsMaxTimeTitle_KIA;
        private Label labelStatsMinTimeTitle_KIA;
        private Label labelStatsMinibusesTitle_KIA;
        private Label labelStatsTrolleysTitle_KIA;
        private Label labelStatsTramsTitle_KIA;
        private Label labelStatsBusesTitle_KIA;
        private Label labelStatsRoutesCountTitle_KIA;
        private Label labelStatsTransportCountTitle_KIA;
        private GroupBox groupBoxFilter_KIA;
        private Button buttonResetFilter_KIA;
        private NumericUpDown numericUpDownMaxTime_KIA;
        private Label labelFilterTimeTo_KIA;
        private Label labelFilterTimeFrom_KIA;
        private NumericUpDown numericUpDownMinTime_KIA;
        private TextBox textBoxFilterEnd_KIA;
        private TextBox textBoxFilterStart_KIA;
        private Label labelFilterTime_KIA;
        private Label labelFilterEnd_KIA;
        private Label labelFilterStart_KIA;
        private DateTimePicker dateTimePickerMaxDate_KIA;
        private Label labelFilterDateTo_KIA;
        private DateTimePicker dateTimePickerMinDate_KIA;
        private Label labelFilterDateFrom_KIA;
        private Label labelFilterDate_KIA;
        private NumericUpDown numericUpDownFilterRoute_KIA;
        private Label labelFilterRoute_KIA;
        private ComboBox comboBoxFilterType_KIA;
        private NumericUpDown numericUpDownFilterID_KIA;
        private Label labelFilterType_KIA;
        private Label labelFilterID_KIA;
        private ToolStrip toolStripTools_KIA;
        private ToolStripButton toolStripButtonEdit_KIA;
        private ToolStripSeparator toolStripSeparatorEditAdd_KIA;
        private ToolStripButton toolStripButtonAdd_KIA;
        private ToolStripSeparator toolStripSeparatorAddDelete_KIA;
        private ToolStripButton toolStripButtonDelete_KIA;
        private ToolStripSeparator toolStripSeparatorDeleteStats_KIA;
        private ToolStripButton toolStripButtonStats_KIA;
        private ToolStripSeparator toolStripSeparatorStatsSearch_KIA;
        private ToolStripLabel toolStripLabelSearchIcon_KIA;
        private ToolStripLabel toolStripLabelSearch_KIA;
        private ToolStripTextBox toolStripTextBoxSearch_KIA;
        private ToolTip toolTip_KIA;
        private DataGridView dataGridViewTransports_KIA;
        private DataGridViewTextBoxColumn colID_KIA;
        private DataGridViewTextBoxColumn colTransportType_KIA;
        private DataGridViewTextBoxColumn colRouteNumber_KIA;
        private DataGridViewTextBoxColumn colStartDate_KIA;
        private DataGridViewTextBoxColumn colStartStop_KIA;
        private DataGridViewTextBoxColumn colEndStop_KIA;
        private DataGridViewTextBoxColumn colTravelTime_KIA;
        private DataGridViewTextBoxColumn colNote_KIA;
    }
}