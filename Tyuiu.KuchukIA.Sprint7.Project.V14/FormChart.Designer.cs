namespace Tyuiu.KuchukIA.Sprint7.Project.V14
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea_KIA = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series_KIA = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title_KIA = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_KIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCloseChart_KIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.chart_KIA).BeginInit();
            this.SuspendLayout();
            // 
            // chart_KIA
            // 
            chartArea_KIA.AxisX.Interval = 1;
            chartArea_KIA.AxisX.Title = "ID транспорта";
            chartArea_KIA.AxisX.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            chartArea_KIA.AxisY.Interval = 10;
            chartArea_KIA.AxisY.Title = "Время в пути (мин)";
            chartArea_KIA.AxisY.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            chartArea_KIA.Name = "MainArea_KIA";
            this.chart_KIA.ChartAreas.Add(chartArea_KIA);
            this.chart_KIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_KIA.Location = new System.Drawing.Point(0, 0);
            this.chart_KIA.Name = "chart_KIA";
            series_KIA.BorderColor = System.Drawing.Color.DarkBlue;
            series_KIA.BorderWidth = 2;
            series_KIA.ChartArea = "MainArea_KIA";
            series_KIA.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series_KIA.Color = System.Drawing.Color.DodgerBlue;
            series_KIA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            series_KIA.IsValueShownAsLabel = true;
            series_KIA.IsVisibleInLegend = false;
            series_KIA.Label = "#VAL мин";
            series_KIA.Name = "SeriesTravelTime_KIA";
            this.chart_KIA.Series.Add(series_KIA);
            this.chart_KIA.Size = new System.Drawing.Size(900, 700);
            this.chart_KIA.TabIndex = 0;
            this.chart_KIA.Text = "chart1";
            title_KIA.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            title_KIA.ForeColor = System.Drawing.Color.DarkBlue;
            title_KIA.Name = "TitleChart_KIA";
            title_KIA.Text = "Время в пути каждого транспорта\nМаршрут №";
            this.chart_KIA.Titles.Add(title_KIA);
            this.chart_KIA.Click += new System.EventHandler(this.chart_KIA_Click);
            // 
            // btnCloseChart_KIA
            // 
            this.btnCloseChart_KIA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCloseChart_KIA.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.btnCloseChart_KIA.ForeColor = System.Drawing.Color.White;
            this.btnCloseChart_KIA.Location = new System.Drawing.Point(760, 640);
            this.btnCloseChart_KIA.Name = "btnCloseChart_KIA";
            this.btnCloseChart_KIA.Size = new System.Drawing.Size(120, 40);
            this.btnCloseChart_KIA.TabIndex = 1;
            this.btnCloseChart_KIA.Text = "ЗАКРЫТЬ";
            this.btnCloseChart_KIA.UseVisualStyleBackColor = false;
            this.btnCloseChart_KIA.Click += new System.EventHandler(this.BtnCloseChart_KIA_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnCloseChart_KIA);
            this.Controls.Add(this.chart_KIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Диаграмма";
            this.Load += new System.EventHandler(this.FormChart_Load);
            ((System.ComponentModel.ISupportInitialize)this.chart_KIA).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KIA;
        private System.Windows.Forms.Button btnCloseChart_KIA;
    }
}