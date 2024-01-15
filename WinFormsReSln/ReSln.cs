using commnLib;
using System.Data;
using System.Windows.Forms;

namespace WinFormsReSln
{
    public partial class ReSln : Form
    {
        public ReSln()
        {
            InitializeComponent();
            InitializeDataGridView();
            AdjustFontSize();
        }


        private void InitializeDataGridView()
        {
            setDataGridViewHeight(this.dataGridView1);

            // ������ �ҽ� ����
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Gender", typeof(string));
            table.Rows.Add("John Doe", 25, "Male");
            table.Rows.Add("Jane Doe", 30, "Female");

            // DataGridView ��Ʈ�ѿ� ������ �ҽ� ���ε�
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdjustFontSize()
        {
            // Get the current screen size
            Size screenSize = Utils.outScrn().Bounds.Size;
            // Calculate the font size based on the screen width
            // You can modify this formula as you like
            float fontSize = float.Round(screenSize.Width / 70f);
            // Create a new font with the calculated size
            Font font = new Font("Tahoma", fontSize);
            // Assign the font to the DataGridView
            this.dataGridView1.Font = font;
            this.btnPgDwn.Font = font;
            this.btnPgUp.Font = font;   

            this.txtFontSize.Text = fontSize.ToString();
        }

        private void ReSln_Load(object sender, EventArgs e)
        {
            this.Location = Utils.outScrn().Bounds.Location;
            
        }

        private void setDataGridViewHeight(DataGridView obj)
        {
            Screen screen = Utils.outScrn();

            // �ش� ������� �۾� ������ ���̸� �����ɴϴ�.
            int screenHeight = screen.WorkingArea.Height;

            int newHeight = (int)(screenHeight / 15);

            // �÷��� ���̸� �����մϴ�.
            obj.RowTemplate.Height = newHeight;

            // ���� ���̸� ���ο� ���̷� �����մϴ�.
            obj.ColumnHeadersHeight = newHeight;

            this.txtRowHeight.Text = newHeight.ToString();
        }
    }
}
