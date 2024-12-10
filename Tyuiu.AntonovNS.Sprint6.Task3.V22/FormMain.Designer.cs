using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.AntonovNS.Sprint6.Task3.V22
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
            groupBoxUsl_ANS = new GroupBox();
            textBoxTask_ANS = new TextBox();
            groupBoxRes_ANS = new GroupBox();
            groupBoxResV_ANS = new GroupBox();
            buttonVipol_ANS = new Button();
            buttonHelp_ANS = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            U = new DataGridViewTextBoxColumn();
            I = new DataGridViewTextBoxColumn();
            groupBoxRes_ANS.SuspendLayout();
            groupBoxResV_ANS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
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
            groupBoxRes_ANS.Size = new Size(499, 408);
            groupBoxRes_ANS.TabIndex = 6;
            groupBoxRes_ANS.TabStop = false;
            groupBoxRes_ANS.Text = "Вывод данных";
            // 
            // groupBoxResV_ANS
            // 
            groupBoxResV_ANS.Controls.Add(dataGridViewFunction);
            groupBoxResV_ANS.Location = new Point(14, 22);
            groupBoxResV_ANS.Name = "groupBoxResV_ANS";
            groupBoxResV_ANS.Size = new Size(464, 374);
            groupBoxResV_ANS.TabIndex = 0;
            groupBoxResV_ANS.TabStop = false;
            groupBoxResV_ANS.Text = "Результат:";
            // 
            // buttonVipol_ANS
            // 
            buttonVipol_ANS.Location = new Point(393, 333);
            buttonVipol_ANS.Name = "buttonVipol_ANS";
            buttonVipol_ANS.Size = new Size(91, 40);
            buttonVipol_ANS.TabIndex = 7;
            buttonVipol_ANS.Text = "Выполнить";
            buttonVipol_ANS.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_ANS
            // 
            buttonHelp_ANS.FlatStyle = FlatStyle.Flat;
            buttonHelp_ANS.Location = new Point(35, 333);
            buttonHelp_ANS.Name = "buttonHelp_ANS";
            buttonHelp_ANS.Size = new Size(91, 40);
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
            chartFunction.Location = new Point(1082, 68);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(387, 352);
            chartFunction.TabIndex = 9;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Column1, Y, U, I });
            dataGridViewFunction.Location = new Point(20, 31);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.Size = new Size(424, 337);
            dataGridViewFunction.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "R";
            X.Name = "X";
            X.Width = 75;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // Y
            // 
            Y.HeaderText = "Y";
            Y.Name = "Y";
            Y.Width = 75;
            // 
            // U
            // 
            U.HeaderText = "U";
            U.Name = "U";
            U.Width = 75;
            // 
            // I
            // 
            I.HeaderText = "I";
            I.Name = "I";
            I.Width = 75;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
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
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Y;
        private DataGridViewTextBoxColumn U;
        private DataGridViewTextBoxColumn I;
    }
}
