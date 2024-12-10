using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.AntonovNS.Sprint6.Task5.V6.Lib;
namespace Tyuiu.AntonovNS.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = "InPutDataFileTask5V6.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл не найден: " + path, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridViewNums.ColumnCount = 2;
                dataGridViewNums.Columns[0].Width = 20;
                dataGridViewNums.Columns[1].Width = 50;

                double[] numsMass = new double[ds.len];
                numsMass = ds.LoadFromDataFile(path);
                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));

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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
