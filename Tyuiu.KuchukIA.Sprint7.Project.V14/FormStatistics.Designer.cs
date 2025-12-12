namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    partial class FormStatistics
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle_KIA = new Label();
            panelMain_KIA = new Panel();
            btnClose_KIA = new Button();
            btnShowChart_KIA = new Button();
            txtDate_KIA = new TextBox();
            lblDate_KIA = new Label();
            txtEndStop_KIA = new TextBox();
            lblEndStop_KIA = new Label();
            txtStartStop_KIA = new TextBox();
            lblStartStop_KIA = new Label();
            txtTravelTime_KIA = new TextBox();
            lblTravelTime_KIA = new Label();
            txtSelectedID_KIA = new TextBox();
            lblSelectedID_KIA = new Label();
            txtAvgTime_KIA = new TextBox();
            lblAvgTime_KIA = new Label();
            txtMaxTime_KIA = new TextBox();
            lblMaxTime_KIA = new Label();
            txtMinTime_KIA = new TextBox();
            lblMinTime_KIA = new Label();
            txtTotalCount_KIA = new TextBox();
            lblTotalCount_KIA = new Label();
            lblSelectedTitle_KIA = new Label();
            panelMain_KIA.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle_KIA
            // 
            lblTitle_KIA.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle_KIA.ForeColor = Color.DarkBlue;
            lblTitle_KIA.Location = new Point(10, 10);
            lblTitle_KIA.Name = "lblTitle_KIA";
            lblTitle_KIA.Size = new Size(460, 50);
            lblTitle_KIA.TabIndex = 21;
            lblTitle_KIA.Text = "СТАТИСТИКА";
            lblTitle_KIA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain_KIA
            // 
            panelMain_KIA.AutoScroll = true;
            panelMain_KIA.BackColor = Color.WhiteSmoke;
            panelMain_KIA.Controls.Add(btnClose_KIA);
            panelMain_KIA.Controls.Add(btnShowChart_KIA);
            panelMain_KIA.Controls.Add(txtDate_KIA);
            panelMain_KIA.Controls.Add(lblDate_KIA);
            panelMain_KIA.Controls.Add(txtEndStop_KIA);
            panelMain_KIA.Controls.Add(lblEndStop_KIA);
            panelMain_KIA.Controls.Add(txtStartStop_KIA);
            panelMain_KIA.Controls.Add(lblStartStop_KIA);
            panelMain_KIA.Controls.Add(txtTravelTime_KIA);
            panelMain_KIA.Controls.Add(lblTravelTime_KIA);
            panelMain_KIA.Controls.Add(txtSelectedID_KIA);
            panelMain_KIA.Controls.Add(lblSelectedID_KIA);
            panelMain_KIA.Controls.Add(txtAvgTime_KIA);
            panelMain_KIA.Controls.Add(lblAvgTime_KIA);
            panelMain_KIA.Controls.Add(txtMaxTime_KIA);
            panelMain_KIA.Controls.Add(lblMaxTime_KIA);
            panelMain_KIA.Controls.Add(txtMinTime_KIA);
            panelMain_KIA.Controls.Add(lblMinTime_KIA);
            panelMain_KIA.Controls.Add(txtTotalCount_KIA);
            panelMain_KIA.Controls.Add(lblTotalCount_KIA);
            panelMain_KIA.Controls.Add(lblSelectedTitle_KIA);
            panelMain_KIA.Controls.Add(lblTitle_KIA);
            panelMain_KIA.Dock = DockStyle.Fill;
            panelMain_KIA.Location = new Point(0, 0);
            panelMain_KIA.Name = "panelMain_KIA";
            panelMain_KIA.Padding = new Padding(15);
            panelMain_KIA.Size = new Size(500, 650);
            panelMain_KIA.TabIndex = 0;
            panelMain_KIA.Paint += panelMain_KIA_Paint;
            // 
            // btnClose_KIA
            // 
            btnClose_KIA.BackColor = Color.Gray;
            btnClose_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnClose_KIA.ForeColor = Color.White;
            btnClose_KIA.Location = new Point(260, 570);
            btnClose_KIA.Name = "btnClose_KIA";
            btnClose_KIA.Size = new Size(200, 40);
            btnClose_KIA.TabIndex = 0;
            btnClose_KIA.Text = "ЗАКРЫТЬ";
            btnClose_KIA.UseVisualStyleBackColor = false;
            btnClose_KIA.Click += BtnClose_KIA_Click;
            // 
            // btnShowChart_KIA
            // 
            btnShowChart_KIA.BackColor = Color.SteelBlue;
            btnShowChart_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnShowChart_KIA.ForeColor = Color.White;
            btnShowChart_KIA.Location = new Point(50, 570);
            btnShowChart_KIA.Name = "btnShowChart_KIA";
            btnShowChart_KIA.Size = new Size(200, 40);
            btnShowChart_KIA.TabIndex = 1;
            btnShowChart_KIA.Text = "ПОКАЗАТЬ ДИАГРАММУ";
            btnShowChart_KIA.UseVisualStyleBackColor = false;
            btnShowChart_KIA.Click += BtnShowChart_KIA_Click;
            // 
            // txtDate_KIA
            // 
            txtDate_KIA.BackColor = Color.White;
            txtDate_KIA.BorderStyle = BorderStyle.FixedSingle;
            txtDate_KIA.Font = new Font("Arial", 11F);
            txtDate_KIA.Location = new Point(195, 510);
            txtDate_KIA.Name = "txtDate_KIA";
            txtDate_KIA.ReadOnly = true;
            txtDate_KIA.Size = new Size(275, 24);
            txtDate_KIA.TabIndex = 2;
            // 
            // lblDate_KIA
            // 
            lblDate_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblDate_KIA.ForeColor = Color.DarkSlateGray;
            lblDate_KIA.Location = new Point(10, 513);
            lblDate_KIA.Name = "lblDate_KIA";
            lblDate_KIA.Size = new Size(180, 20);
            lblDate_KIA.TabIndex = 3;
            lblDate_KIA.Text = "Дата введения:";
            // 
            // txtEndStop_KIA
            // 
            txtEndStop_KIA.BackColor = Color.White;
            txtEndStop_KIA.BorderStyle = BorderStyle.FixedSingle;
            txtEndStop_KIA.Font = new Font("Arial", 11F);
            txtEndStop_KIA.Location = new Point(195, 430);
            txtEndStop_KIA.Multiline = true;
            txtEndStop_KIA.Name = "txtEndStop_KIA";
            txtEndStop_KIA.ReadOnly = true;
            txtEndStop_KIA.ScrollBars = ScrollBars.Vertical;
            txtEndStop_KIA.Size = new Size(275, 60);
            txtEndStop_KIA.TabIndex = 4;
            // 
            // lblEndStop_KIA
            // 
            lblEndStop_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblEndStop_KIA.ForeColor = Color.DarkSlateGray;
            lblEndStop_KIA.Location = new Point(10, 433);
            lblEndStop_KIA.Name = "lblEndStop_KIA";
            lblEndStop_KIA.Size = new Size(180, 20);
            lblEndStop_KIA.TabIndex = 5;
            lblEndStop_KIA.Text = "Конечная остановка:";
            // 
            // txtStartStop_KIA
            // 
            txtStartStop_KIA.BackColor = Color.White;
            txtStartStop_KIA.BorderStyle = BorderStyle.FixedSingle;
            txtStartStop_KIA.Font = new Font("Arial", 11F);
            txtStartStop_KIA.Location = new Point(195, 350);
            txtStartStop_KIA.Multiline = true;
            txtStartStop_KIA.Name = "txtStartStop_KIA";
            txtStartStop_KIA.ReadOnly = true;
            txtStartStop_KIA.ScrollBars = ScrollBars.Vertical;
            txtStartStop_KIA.Size = new Size(275, 60);
            txtStartStop_KIA.TabIndex = 6;
            // 
            // lblStartStop_KIA
            // 
            lblStartStop_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblStartStop_KIA.ForeColor = Color.DarkSlateGray;
            lblStartStop_KIA.Location = new Point(10, 353);
            lblStartStop_KIA.Name = "lblStartStop_KIA";
            lblStartStop_KIA.Size = new Size(180, 20);
            lblStartStop_KIA.TabIndex = 7;
            lblStartStop_KIA.Text = "Начальная остановка:";
            // 
            // txtTravelTime_KIA
            // 
            txtTravelTime_KIA.BackColor = Color.White;
            txtTravelTime_KIA.BorderStyle = BorderStyle.FixedSingle;
            txtTravelTime_KIA.Font = new Font("Arial", 11F);
            txtTravelTime_KIA.Location = new Point(195, 310);
            txtTravelTime_KIA.Name = "txtTravelTime_KIA";
            txtTravelTime_KIA.ReadOnly = true;
            txtTravelTime_KIA.Size = new Size(275, 24);
            txtTravelTime_KIA.TabIndex = 8;
            // 
            // lblTravelTime_KIA
            // 
            lblTravelTime_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblTravelTime_KIA.ForeColor = Color.DarkSlateGray;
            lblTravelTime_KIA.Location = new Point(10, 313);
            lblTravelTime_KIA.Name = "lblTravelTime_KIA";
            lblTravelTime_KIA.Size = new Size(180, 20);
            lblTravelTime_KIA.TabIndex = 9;
            lblTravelTime_KIA.Text = "Время в пути:";
            // 
            // txtSelectedID_KIA
            // 
            txtSelectedID_KIA.BackColor = Color.White;
            txtSelectedID_KIA.BorderStyle = BorderStyle.FixedSingle;
            txtSelectedID_KIA.Font = new Font("Arial", 11F);
            txtSelectedID_KIA.Location = new Point(195, 270);
            txtSelectedID_KIA.Name = "txtSelectedID_KIA";
            txtSelectedID_KIA.ReadOnly = true;
            txtSelectedID_KIA.Size = new Size(275, 24);
            txtSelectedID_KIA.TabIndex = 10;
            // 
            // lblSelectedID_KIA
            // 
            lblSelectedID_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblSelectedID_KIA.ForeColor = Color.DarkSlateGray;
            lblSelectedID_KIA.Location = new Point(10, 273);
            lblSelectedID_KIA.Name = "lblSelectedID_KIA";
            lblSelectedID_KIA.Size = new Size(180, 20);
            lblSelectedID_KIA.TabIndex = 11;
            lblSelectedID_KIA.Text = "ID записи:";
            // 
            // txtAvgTime_KIA
            // 
            txtAvgTime_KIA.BackColor = Color.White;
            txtAvgTime_KIA.BorderStyle = BorderStyle.FixedSingle;
            txtAvgTime_KIA.Font = new Font("Arial", 11F);
            txtAvgTime_KIA.Location = new Point(195, 190);
            txtAvgTime_KIA.Name = "txtAvgTime_KIA";
            txtAvgTime_KIA.ReadOnly = true;
            txtAvgTime_KIA.Size = new Size(275, 24);
            txtAvgTime_KIA.TabIndex = 12;
            // 
            // lblAvgTime_KIA
            // 
            lblAvgTime_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblAvgTime_KIA.ForeColor = Color.DarkSlateGray;
            lblAvgTime_KIA.Location = new Point(10, 193);
            lblAvgTime_KIA.Name = "lblAvgTime_KIA";
            lblAvgTime_KIA.Size = new Size(180, 20);
            lblAvgTime_KIA.TabIndex = 13;
            lblAvgTime_KIA.Text = "Среднее время:";
            // 
            // txtMaxTime_KIA
            // 
            txtMaxTime_KIA.BackColor = Color.White;
            txtMaxTime_KIA.BorderStyle = BorderStyle.FixedSingle;
            txtMaxTime_KIA.Font = new Font("Arial", 11F);
            txtMaxTime_KIA.Location = new Point(195, 150);
            txtMaxTime_KIA.Name = "txtMaxTime_KIA";
            txtMaxTime_KIA.ReadOnly = true;
            txtMaxTime_KIA.Size = new Size(275, 24);
            txtMaxTime_KIA.TabIndex = 14;
            // 
            // lblMaxTime_KIA
            // 
            lblMaxTime_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblMaxTime_KIA.ForeColor = Color.DarkSlateGray;
            lblMaxTime_KIA.Location = new Point(10, 153);
            lblMaxTime_KIA.Name = "lblMaxTime_KIA";
            lblMaxTime_KIA.Size = new Size(180, 20);
            lblMaxTime_KIA.TabIndex = 15;
            lblMaxTime_KIA.Text = "Максимальное время:";
            // 
            // txtMinTime_KIA
            // 
            txtMinTime_KIA.BackColor = Color.White;
            txtMinTime_KIA.BorderStyle = BorderStyle.FixedSingle;
            txtMinTime_KIA.Font = new Font("Arial", 11F);
            txtMinTime_KIA.Location = new Point(195, 110);
            txtMinTime_KIA.Name = "txtMinTime_KIA";
            txtMinTime_KIA.ReadOnly = true;
            txtMinTime_KIA.Size = new Size(275, 24);
            txtMinTime_KIA.TabIndex = 16;
            // 
            // lblMinTime_KIA
            // 
            lblMinTime_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblMinTime_KIA.ForeColor = Color.DarkSlateGray;
            lblMinTime_KIA.Location = new Point(10, 113);
            lblMinTime_KIA.Name = "lblMinTime_KIA";
            lblMinTime_KIA.Size = new Size(180, 20);
            lblMinTime_KIA.TabIndex = 17;
            lblMinTime_KIA.Text = "Минимальное время:";
            // 
            // txtTotalCount_KIA
            // 
            txtTotalCount_KIA.BackColor = Color.White;
            txtTotalCount_KIA.BorderStyle = BorderStyle.FixedSingle;
            txtTotalCount_KIA.Font = new Font("Arial", 11F);
            txtTotalCount_KIA.Location = new Point(195, 70);
            txtTotalCount_KIA.Name = "txtTotalCount_KIA";
            txtTotalCount_KIA.ReadOnly = true;
            txtTotalCount_KIA.Size = new Size(275, 24);
            txtTotalCount_KIA.TabIndex = 18;
            // 
            // lblTotalCount_KIA
            // 
            lblTotalCount_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblTotalCount_KIA.ForeColor = Color.DarkSlateGray;
            lblTotalCount_KIA.Location = new Point(10, 73);
            lblTotalCount_KIA.Name = "lblTotalCount_KIA";
            lblTotalCount_KIA.Size = new Size(180, 20);
            lblTotalCount_KIA.TabIndex = 19;
            lblTotalCount_KIA.Text = "Количество записей:";
            // 
            // lblSelectedTitle_KIA
            // 
            lblSelectedTitle_KIA.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblSelectedTitle_KIA.ForeColor = Color.DarkGreen;
            lblSelectedTitle_KIA.Location = new Point(10, 230);
            lblSelectedTitle_KIA.Name = "lblSelectedTitle_KIA";
            lblSelectedTitle_KIA.Size = new Size(200, 20);
            lblSelectedTitle_KIA.TabIndex = 20;
            lblSelectedTitle_KIA.Text = "ВЫБРАННАЯ ЗАПИСЬ:";
            // 
            // FormStatistics
            // 
            ClientSize = new Size(500, 650);
            Controls.Add(panelMain_KIA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Статистика";
            Load += FormStatistics_Load;
            panelMain_KIA.ResumeLayout(false);
            panelMain_KIA.PerformLayout();
            ResumeLayout(false);
        }

        // Объявления полей
        private Label lblTitle_KIA;
        private Panel panelMain_KIA;
        private Button btnClose_KIA;
        private Button btnShowChart_KIA;
        private TextBox txtDate_KIA;
        private Label lblDate_KIA;
        private TextBox txtEndStop_KIA;
        private Label lblEndStop_KIA;
        private TextBox txtStartStop_KIA;
        private Label lblStartStop_KIA;
        private TextBox txtTravelTime_KIA;
        private Label lblTravelTime_KIA;
        private TextBox txtSelectedID_KIA;
        private Label lblSelectedID_KIA;
        private TextBox txtAvgTime_KIA;
        private Label lblAvgTime_KIA;
        private TextBox txtMaxTime_KIA;
        private Label lblMaxTime_KIA;
        private TextBox txtMinTime_KIA;
        private Label lblMinTime_KIA;
        private TextBox txtTotalCount_KIA;
        private Label lblTotalCount_KIA;
        private Label lblSelectedTitle_KIA;
    }
}