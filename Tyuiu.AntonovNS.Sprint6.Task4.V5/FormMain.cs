using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.AntonovNS.Sprint6.Task4.V5.Lib;
namespace Tyuiu.AntonovNS.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_ANS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_ANS.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                chartFunction.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(stopStep, valueArray[i]);
                    textBoxRes.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 0 выполнил студент группы ИСТНб-24-1 Антонов Никита Сергеевич", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSave_Click(object sender,EventArgs e) 
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V5.txt";
                File.WriteAllText(path, textBoxRes.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch 
            {
                MessageBox.Show("Сбой при сохранении файла","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
