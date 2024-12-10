using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.AntonovNS.Sprint6.Task5.V6
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxUsl_ANS = new GroupBox();
            textBoxTask_ANS = new TextBox();
            groupBoxRes_ANS = new GroupBox();
            groupBoxResV_ANS = new GroupBox();
            buttonVipol_ANS = new Button();
            buttonHelp_ANS = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSave = new Button();
            dataGridViewNums = new DataGridView();
            groupBoxRes_ANS.SuspendLayout();
            groupBoxResV_ANS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl_ANS
            // 
            groupBoxUsl_ANS.Location = new Point(35, 30);
            groupBoxUsl_ANS.Name = "groupBoxUsl_ANS";
            groupBoxUsl_ANS.Size = new Size(521, 257);
            groupBoxUsl_ANS.TabIndex = 1;
            groupBoxUsl_ANS.TabStop = false;
            groupBoxUsl_ANS.Text = "Условие";
            // 
            // textBoxTask_ANS
            // 
            textBoxTask_ANS.BackColor = SystemColors.Control;
            textBoxTask_ANS.Location = new Point(35, 67);
            textBoxTask_ANS.Multiline = true;
            textBoxTask_ANS.Name = "textBoxTask_ANS";
            textBoxTask_ANS.Size = new Size(508, 198);
            textBoxTask_ANS.TabIndex = 4;
            textBoxTask_ANS.Text = "Протабулировать функцию cos(x) + cos(x)/(x+2) - 3*x";
            // 
            // groupBoxRes_ANS
            // 
            groupBoxRes_ANS.Controls.Add(groupBoxResV_ANS);
            groupBoxRes_ANS.Location = new Point(565, 30);
            groupBoxRes_ANS.Name = "groupBoxRes_ANS";
            groupBoxRes_ANS.Size = new Size(203, 408);
            groupBoxRes_ANS.TabIndex = 6;
            groupBoxRes_ANS.TabStop = false;
            groupBoxRes_ANS.Text = "Вывод данных";
            // 
            // groupBoxResV_ANS
            // 
            groupBoxResV_ANS.Controls.Add(dataGridViewNums);
            groupBoxResV_ANS.Location = new Point(14, 22);
            groupBoxResV_ANS.Name = "groupBoxResV_ANS";
            groupBoxResV_ANS.Size = new Size(159, 374);
            groupBoxResV_ANS.TabIndex = 0;
            groupBoxResV_ANS.TabStop = false;
            groupBoxResV_ANS.Text = "Результат:";
            // 
            // buttonVipol_ANS
            // 
            buttonVipol_ANS.Location = new Point(471, 346);
            buttonVipol_ANS.Name = "buttonVipol_ANS";
            buttonVipol_ANS.Size = new Size(72, 40);
            buttonVipol_ANS.TabIndex = 7;
            buttonVipol_ANS.Text = "Выполнить";
            buttonVipol_ANS.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_ANS
            // 
            buttonHelp_ANS.FlatStyle = FlatStyle.Flat;
            buttonHelp_ANS.Location = new Point(304, 346);
            buttonHelp_ANS.Name = "buttonHelp_ANS";
            buttonHelp_ANS.Size = new Size(68, 40);
            buttonHelp_ANS.TabIndex = 8;
            buttonHelp_ANS.Text = "?";
            buttonHelp_ANS.UseVisualStyleBackColor = true;
            buttonHelp_ANS.Click += buttonHelp_Click;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(811, 68);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(658, 352);
            chartFunction.TabIndex = 9;
            chartFunction.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction.Titles.Add(title1);
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(378, 346);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(87, 40);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(8, 25);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.Size = new Size(145, 343);
            dataGridViewNums.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 450);
            Controls.Add(buttonSave);
            Controls.Add(chartFunction);
            Controls.Add(buttonHelp_ANS);
            Controls.Add(buttonVipol_ANS);
            Controls.Add(groupBoxRes_ANS);
            Controls.Add(textBoxTask_ANS);
            Controls.Add(groupBoxUsl_ANS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 |  Таск 1 |  Вариант 19 |  Антонов Н.С.";
            TopMost = true;
            groupBoxRes_ANS.ResumeLayout(false);
            groupBoxResV_ANS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBoxUsl_ANS;
        private TextBox textBoxTask_ANS;
        private GroupBox groupBoxRes_ANS;
        private GroupBox groupBoxResV_ANS;
        private Button buttonVipol_ANS;
        private Button buttonHelp_ANS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonSave;
        private DataGridView dataGridViewNums;
    }
}
