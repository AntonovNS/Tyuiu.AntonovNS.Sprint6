using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.AntonovNS.Sprint6.Task2.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxUsl_ANS = new GroupBox();
            textBoxTask_ANS = new TextBox();
            groupBoxPer_ANS = new GroupBox();
            textBoxStopStep_ANS = new TextBox();
            textBoxStop_ANS = new TextBox();
            textBoxStart_ANS = new TextBox();
            textBoxStartStep_ANS = new TextBox();
            groupBoxRes_ANS = new GroupBox();
            groupBoxResV_ANS = new GroupBox();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            buttonVipol_ANS = new Button();
            buttonHelp_ANS = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxPer_ANS.SuspendLayout();
            groupBoxRes_ANS.SuspendLayout();
            groupBoxResV_ANS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
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
            // groupBoxPer_ANS
            // 
            groupBoxPer_ANS.Controls.Add(textBoxStopStep_ANS);
            groupBoxPer_ANS.Controls.Add(textBoxStop_ANS);
            groupBoxPer_ANS.Controls.Add(textBoxStart_ANS);
            groupBoxPer_ANS.Controls.Add(textBoxStartStep_ANS);
            groupBoxPer_ANS.Location = new Point(35, 293);
            groupBoxPer_ANS.Name = "groupBoxPer_ANS";
            groupBoxPer_ANS.Size = new Size(247, 133);
            groupBoxPer_ANS.TabIndex = 5;
            groupBoxPer_ANS.TabStop = false;
            groupBoxPer_ANS.Text = "Ввод данных";
            // 
            // textBoxStopStep_ANS
            // 
            textBoxStopStep_ANS.Location = new Point(122, 63);
            textBoxStopStep_ANS.Name = "textBoxStopStep_ANS";
            textBoxStopStep_ANS.Size = new Size(100, 23);
            textBoxStopStep_ANS.TabIndex = 3;
            // 
            // textBoxStop_ANS
            // 
            textBoxStop_ANS.BackColor = SystemColors.Control;
            textBoxStop_ANS.Location = new Point(122, 34);
            textBoxStop_ANS.Name = "textBoxStop_ANS";
            textBoxStop_ANS.Size = new Size(100, 23);
            textBoxStop_ANS.TabIndex = 2;
            textBoxStop_ANS.Text = "Начало шага";
            // 
            // textBoxStart_ANS
            // 
            textBoxStart_ANS.BackColor = SystemColors.Control;
            textBoxStart_ANS.Location = new Point(6, 34);
            textBoxStart_ANS.Name = "textBoxStart_ANS";
            textBoxStart_ANS.Size = new Size(100, 23);
            textBoxStart_ANS.TabIndex = 1;
            textBoxStart_ANS.Text = "Начало шага";
            // 
            // textBoxStartStep_ANS
            // 
            textBoxStartStep_ANS.Location = new Point(6, 63);
            textBoxStartStep_ANS.Name = "textBoxStartStep_ANS";
            textBoxStartStep_ANS.Size = new Size(100, 23);
            textBoxStartStep_ANS.TabIndex = 0;
            textBoxStartStep_ANS.KeyPress += textBoxX_KeyPress;
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
            groupBoxResV_ANS.Controls.Add(dataGridViewFunction);
            groupBoxResV_ANS.Location = new Point(14, 22);
            groupBoxResV_ANS.Name = "groupBoxResV_ANS";
            groupBoxResV_ANS.Size = new Size(159, 374);
            groupBoxResV_ANS.TabIndex = 0;
            groupBoxResV_ANS.TabStop = false;
            groupBoxResV_ANS.Text = "Результат:";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Column1 });
            dataGridViewFunction.Location = new Point(20, 31);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.Size = new Size(133, 337);
            dataGridViewFunction.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "F(X)";
            X.Name = "X";
            X.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // buttonVipol_ANS
            // 
            buttonVipol_ANS.Location = new Point(452, 346);
            buttonVipol_ANS.Name = "buttonVipol_ANS";
            buttonVipol_ANS.Size = new Size(91, 40);
            buttonVipol_ANS.TabIndex = 7;
            buttonVipol_ANS.Text = "Выполнить";
            buttonVipol_ANS.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_ANS
            // 
            buttonHelp_ANS.FlatStyle = FlatStyle.Flat;
            buttonHelp_ANS.Location = new Point(304, 346);
            buttonHelp_ANS.Name = "buttonHelp_ANS";
            buttonHelp_ANS.Size = new Size(91, 40);
            buttonHelp_ANS.TabIndex = 8;
            buttonHelp_ANS.Text = "?";
            buttonHelp_ANS.UseVisualStyleBackColor = true;
            buttonHelp_ANS.Click += buttonHelp_Click;
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(811, 68);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(658, 352);
            chartFunction.TabIndex = 9;
            chartFunction.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 450);
            Controls.Add(chartFunction);
            Controls.Add(buttonHelp_ANS);
            Controls.Add(buttonVipol_ANS);
            Controls.Add(groupBoxRes_ANS);
            Controls.Add(groupBoxPer_ANS);
            Controls.Add(textBoxTask_ANS);
            Controls.Add(groupBoxUsl_ANS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 |  Таск 1 |  Вариант 19 |  Антонов Н.С.";
            TopMost = true;
            groupBoxPer_ANS.ResumeLayout(false);
            groupBoxPer_ANS.PerformLayout();
            groupBoxRes_ANS.ResumeLayout(false);
            groupBoxResV_ANS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBoxUsl_ANS;
        private TextBox textBoxTask_ANS;
        private GroupBox groupBoxPer_ANS;
        private TextBox textBoxStart_ANS;
        private TextBox textBoxStartStep_ANS;
        private GroupBox groupBoxRes_ANS;
        private GroupBox groupBoxResV_ANS;
        private Button buttonVipol_ANS;
        private Button buttonHelp_ANS;
        private TextBox textBoxStopStep_ANS;
        private TextBox textBoxStop_ANS;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
