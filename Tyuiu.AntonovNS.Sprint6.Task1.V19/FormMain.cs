using Tyuiu.AntonovNS.Sprint6.Task1.V19.Lib;
namespace Tyuiu.AntonovNS.Sprint6.Task1.V19
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
                int startStep = Convert.ToInt32(textBoxStartStep_ANS);
                int stopStep = Convert.ToInt32(textBoxStopStep_ANS);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes_ANS.Text = "";
                textBoxRes_ANS.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxRes_ANS.AppendText("|     X      |    F(x)    |" + Environment.NewLine);
                textBoxRes_ANS.AppendText("+------------+------------+" + Environment.NewLine);
                for (int i = 0;i<=len-1;i++) 
                {
                    strLine = String.Format("|{0,5:d}    |  {1, 5:f2}  | ", startStep, valueArray[i]);
                    textBoxRes_ANS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes_ANS.AppendText("+------------+------------+" + Environment.NewLine);
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
    }
}
