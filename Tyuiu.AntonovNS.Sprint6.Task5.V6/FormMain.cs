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
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V6.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNums.ColumnCount = 2;
                dataGridViewNums.ColumnCount[0].Width = 20;
                dataGridViewNums.ColumnCount[1].Width = 50;
                this.chartDiag.ChartAreas[0].AxisX.Title = "��� X";
                this.chartDiag.ChartAreas[0].AxisY.Title = "��� Y";
                chartDiag.Series[0].Points.Clear();
                double[] numsMass = new double[ds.len];
                numsMass = ds.LoadFromDataFile(path);
                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartDiag.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show("Task 0 �������� ������� ������ �����-24-1 ������� ������ ���������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
