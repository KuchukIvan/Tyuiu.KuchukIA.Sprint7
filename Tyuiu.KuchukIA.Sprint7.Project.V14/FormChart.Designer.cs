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
            chart_KIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnCloseChart_KIA = new Button();
            ((System.ComponentModel.ISupportInitialize)chart_KIA).BeginInit();
            SuspendLayout();
            // 
            // chart_KIA
            // 
            chart_KIA.Dock = DockStyle.Fill;
            chart_KIA.Location = new Point(0, 0);
            chart_KIA.Name = "chart_KIA";
            chart_KIA.Size = new Size(900, 700);
            chart_KIA.TabIndex = 0;
            chart_KIA.Text = "chart1";
            chart_KIA.Click += chart_KIA_Click;
            // 
            // btnCloseChart_KIA
            // 
            btnCloseChart_KIA.BackColor = Color.SteelBlue;
            btnCloseChart_KIA.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCloseChart_KIA.ForeColor = Color.White;
            btnCloseChart_KIA.Location = new Point(760, 640);
            btnCloseChart_KIA.Name = "btnCloseChart_KIA";
            btnCloseChart_KIA.Size = new Size(120, 40);
            btnCloseChart_KIA.TabIndex = 1;
            btnCloseChart_KIA.Text = "ЗАКРЫТЬ";
            btnCloseChart_KIA.UseVisualStyleBackColor = false;
            btnCloseChart_KIA.Click += BtnCloseChart_KIA_Click;
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            Controls.Add(btnCloseChart_KIA);
            Controls.Add(chart_KIA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormChart";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Диаграмма";
            Load += FormChart_Load;
            ((System.ComponentModel.ISupportInitialize)chart_KIA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KIA;
        private Button btnCloseChart_KIA;
    }
}