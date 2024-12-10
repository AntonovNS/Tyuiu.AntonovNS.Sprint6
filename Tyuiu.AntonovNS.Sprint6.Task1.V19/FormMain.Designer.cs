using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.AntonovNS.Sprint6.Task1.V19
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
            groupBoxUsl_ANS = new GroupBox();
            textBoxTask_ANS = new TextBox();
            groupBoxPer_ANS = new GroupBox();
            textBoxStart_ANS = new TextBox();
            textBoxStartStep_ANS = new TextBox();
            groupBoxRes_ANS = new GroupBox();
            groupBoxResV_ANS = new GroupBox();
            textBoxRes_ANS = new TextBox();
            buttonVipol_ANS = new Button();
            buttonHelp_ANS = new Button();
            textBoxStop_ANS = new TextBox();
            textBoxStopStep_ANS = new TextBox();
            groupBoxPer_ANS.SuspendLayout();
            groupBoxRes_ANS.SuspendLayout();
            groupBoxResV_ANS.SuspendLayout();
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
            groupBoxResV_ANS.Controls.Add(textBoxRes_ANS);
            groupBoxResV_ANS.Location = new Point(14, 22);
            groupBoxResV_ANS.Name = "groupBoxResV_ANS";
            groupBoxResV_ANS.Size = new Size(159, 374);
            groupBoxResV_ANS.TabIndex = 0;
            groupBoxResV_ANS.TabStop = false;
            groupBoxResV_ANS.Text = "Результат:";
            // 
            // textBoxRes_ANS
            // 
            textBoxRes_ANS.Location = new Point(6, 22);
            textBoxRes_ANS.Multiline = true;
            textBoxRes_ANS.Name = "textBoxRes_ANS";
            textBoxRes_ANS.ReadOnly = true;
            textBoxRes_ANS.Size = new Size(147, 346);
            textBoxRes_ANS.TabIndex = 0;
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
            // textBoxStop_ANS
            // 
            textBoxStop_ANS.BackColor = SystemColors.Control;
            textBoxStop_ANS.Location = new Point(122, 34);
            textBoxStop_ANS.Name = "textBoxStop_ANS";
            textBoxStop_ANS.Size = new Size(100, 23);
            textBoxStop_ANS.TabIndex = 2;
            textBoxStop_ANS.Text = "Начало шага";
            // 
            // textBoxStopStep_ANS
            // 
            textBoxStopStep_ANS.Location = new Point(122, 63);
            textBoxStopStep_ANS.Name = "textBoxStopStep_ANS";
            textBoxStopStep_ANS.Size = new Size(100, 23);
            textBoxStopStep_ANS.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            groupBoxResV_ANS.PerformLayout();
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
        private TextBox textBoxRes_ANS;
        private Button buttonVipol_ANS;
        private Button buttonHelp_ANS;
        private TextBox textBoxStopStep_ANS;
        private TextBox textBoxStop_ANS;
    }
}
