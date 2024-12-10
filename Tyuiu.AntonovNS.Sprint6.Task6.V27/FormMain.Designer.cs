namespace Tyuiu.AntonovNS.Sprint6.Task6.V27
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonRes = new Button();
            buttonHelp = new Button();
            groupBoxUsl = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxVVod = new TextBox();
            groupBox3 = new GroupBox();
            textBoxRes = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBoxUsl.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRes
            // 
            buttonRes.Location = new Point(194, 26);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(154, 120);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "button2";
            buttonRes.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(1457, 26);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(133, 120);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "button3";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(textBox1);
            groupBoxUsl.Location = new Point(13, 163);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(1577, 152);
            groupBoxUsl.TabIndex = 3;
            groupBoxUsl.TabStop = false;
            groupBoxUsl.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(7, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1551, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxVVod);
            groupBox2.Location = new Point(15, 331);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(805, 617);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBoxVVod
            // 
            textBoxVVod.Location = new Point(14, 30);
            textBoxVVod.Multiline = true;
            textBoxVVod.Name = "textBoxVVod";
            textBoxVVod.Size = new Size(773, 568);
            textBoxVVod.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxRes);
            groupBox3.Location = new Point(842, 331);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(748, 617);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(0, 30);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(729, 556);
            textBoxRes.TabIndex = 1;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 960);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxUsl);
            Controls.Add(buttonHelp);
            Controls.Add(buttonRes);
            Name = "FormMain";
            Text = "Form1";
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonRes;
        private Button buttonHelp;
        private GroupBox groupBoxUsl;
        private GroupBox groupBox2;
        private TextBox textBoxVVod;
        private GroupBox groupBox3;
        private TextBox textBoxRes;
        private TextBox textBox1;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip1;
    }
}
