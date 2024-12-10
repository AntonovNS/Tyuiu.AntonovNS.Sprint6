using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.AntonovNS.Sprint6.Task3.V22.Lib;
namespace Tyuiu.AntonovNS.Sprint6.Task3.V22
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
                int[,] s = { { 17, 0, 19, -9, -1 }, { 9, 4, -5, 7, 15 }, { 11, 13, 4, -4, -14 }, { 11, 14, 5, -15, 16 }, { 2, -14, -2, 11, 11 } };
                string strLine;
                int len = ds.Calculate(s).Length;
                int[,] valueArray;
                valueArray = ds.Calculate(s);
                for (int i = 0; i < 5; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(valueArray[i, 0]), Convert.ToString(valueArray[i, 1]), Convert.ToString(valueArray[i, 2]), Convert.ToString(valueArray[i, 3]), Convert.ToString(valueArray[i, 4]));
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

        private void dataGridViewFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
