namespace Tyuiu.AntonovNS.Sprint6.Task0.V27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxUsl_ANS = new GroupBox();
            pictureBoxFormula_ANS = new PictureBox();
            textBoxTask_ANS = new TextBox();
            groupBoxPer_ANS = new GroupBox();
            textBoxX_ANS = new TextBox();
            textBox1 = new TextBox();
            groupBoxRes_ANS = new GroupBox();
            groupBoxResV_ANS = new GroupBox();
            textBoxRes_ANS = new TextBox();
            buttonVipol_ANS = new Button();
            buttonHelp_ANS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ANS).BeginInit();
            groupBoxPer_ANS.SuspendLayout();
            groupBoxRes_ANS.SuspendLayout();
            groupBoxResV_ANS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl_ANS
            // 
            groupBoxUsl_ANS.Location = new Point(35, 30);
            groupBoxUsl_ANS.Name = "groupBoxUsl_ANS";
            groupBoxUsl_ANS.Size = new Size(753, 257);
            groupBoxUsl_ANS.TabIndex = 1;
            groupBoxUsl_ANS.TabStop = false;
            groupBoxUsl_ANS.Text = "Условие";
            // 
            // pictureBoxFormula_ANS
            // 
            pictureBoxFormula_ANS.Image = (Image)resources.GetObject("pictureBoxFormula_ANS.Image");
            pictureBoxFormula_ANS.InitialImage = (Image)resources.GetObject("pictureBoxFormula_ANS.InitialImage");
            pictureBoxFormula_ANS.Location = new Point(579, 66);
            pictureBoxFormula_ANS.Name = "pictureBoxFormula_ANS";
            pictureBoxFormula_ANS.Size = new Size(203, 39);
            pictureBoxFormula_ANS.TabIndex = 2;
            pictureBoxFormula_ANS.TabStop = false;
            // 
            // textBoxTask_ANS
            // 
            textBoxTask_ANS.BackColor = SystemColors.Control;
            textBoxTask_ANS.Location = new Point(35, 67);
            textBoxTask_ANS.Multiline = true;
            textBoxTask_ANS.Name = "textBoxTask_ANS";
            textBoxTask_ANS.Size = new Size(538, 198);
            textBoxTask_ANS.TabIndex = 4;
            textBoxTask_ANS.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxPer_ANS
            // 
            groupBoxPer_ANS.Controls.Add(textBoxX_ANS);
            groupBoxPer_ANS.Controls.Add(textBox1);
            groupBoxPer_ANS.Location = new Point(35, 293);
            groupBoxPer_ANS.Name = "groupBoxPer_ANS";
            groupBoxPer_ANS.Size = new Size(508, 133);
            groupBoxPer_ANS.TabIndex = 5;
            groupBoxPer_ANS.TabStop = false;
            groupBoxPer_ANS.Text = "Ввод данных";
            // 
            // textBoxX_ANS
            // 
            textBoxX_ANS.BackColor = SystemColors.Control;
            textBoxX_ANS.Location = new Point(56, 38);
            textBoxX_ANS.Name = "textBoxX_ANS";
            textBoxX_ANS.Size = new Size(100, 23);
            textBoxX_ANS.TabIndex = 1;
            textBoxX_ANS.Text = "Переменная X:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBoxX_KeyPress;
            // 
            // groupBoxRes_ANS
            // 
            groupBoxRes_ANS.Controls.Add(groupBoxResV_ANS);
            groupBoxRes_ANS.Location = new Point(565, 293);
            groupBoxRes_ANS.Name = "groupBoxRes_ANS";
            groupBoxRes_ANS.Size = new Size(203, 99);
            groupBoxRes_ANS.TabIndex = 6;
            groupBoxRes_ANS.TabStop = false;
            groupBoxRes_ANS.Text = "Вывод данных";
            // 
            // groupBoxResV_ANS
            // 
            groupBoxResV_ANS.Controls.Add(textBoxRes_ANS);
            groupBoxResV_ANS.Location = new Point(14, 22);
            groupBoxResV_ANS.Name = "groupBoxResV_ANS";
            groupBoxResV_ANS.Size = new Size(159, 64);
            groupBoxResV_ANS.TabIndex = 0;
            groupBoxResV_ANS.TabStop = false;
            groupBoxResV_ANS.Text = "Результат:";
            // 
            // textBoxRes_ANS
            // 
            textBoxRes_ANS.Location = new Point(6, 22);
            textBoxRes_ANS.Name = "textBoxRes_ANS";
            textBoxRes_ANS.ReadOnly = true;
            textBoxRes_ANS.Size = new Size(147, 23);
            textBoxRes_ANS.TabIndex = 0;
            // 
            // buttonVipol_ANS
            // 
            buttonVipol_ANS.Location = new Point(677, 398);
            buttonVipol_ANS.Name = "buttonVipol_ANS";
            buttonVipol_ANS.Size = new Size(91, 40);
            buttonVipol_ANS.TabIndex = 7;
            buttonVipol_ANS.Text = "Выполнить";
            buttonVipol_ANS.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_ANS
            // 
            buttonHelp_ANS.FlatStyle = FlatStyle.Flat;
            buttonHelp_ANS.Location = new Point(565, 398);
            buttonHelp_ANS.Name = "buttonHelp_ANS";
            buttonHelp_ANS.Size = new Size(91, 40);
            buttonHelp_ANS.TabIndex = 8;
            buttonHelp_ANS.Text = "?";
            buttonHelp_ANS.UseVisualStyleBackColor = true;
            buttonHelp_ANS.Click += buttonHelp_Click;
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
            Controls.Add(pictureBoxFormula_ANS);
            Controls.Add(groupBoxUsl_ANS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 |  Таск 0 |  Вариант 27 |  Антонов Н.С.";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ANS).EndInit();
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
        private PictureBox pictureBoxFormula_ANS;
        private TextBox textBoxTask_ANS;
        private GroupBox groupBoxPer_ANS;
        private TextBox textBoxX_ANS;
        private TextBox textBox1;
        private GroupBox groupBoxRes_ANS;
        private GroupBox groupBoxResV_ANS;
        private TextBox textBoxRes_ANS;
        private Button buttonVipol_ANS;
        private Button buttonHelp_ANS;
    }
}
