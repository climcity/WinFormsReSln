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
            // DataGridView 컨트롤 초기화
            //dataGridView1.Dock = DockStyle.Fill;
            //dataGridView1.Width = 100;
            //dataGridView1.Height = 100;
            //dataGridView1.Left = 0;
            //dataGridView1.Top = 0;
            //dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.ReadOnly = true;
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.MultiSelect = false;

            // 데이터 소스 생성
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Gender", typeof(string));
            table.Rows.Add("John Doe", 25, "Male");
            table.Rows.Add("Jane Doe", 30, "Female");

            // DataGridView 컨트롤에 데이터 소스 바인딩
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
            //Size screenSize = Screen.PrimaryScreen.Bounds.Size;
            Size screenSize = Utils.outScrn().Bounds.Size;
            // Calculate the font size based on the screen width
            // You can modify this formula as you like
            float fontSize = screenSize.Width / 100f;
            // Create a new font with the calculated size
            Font font = new Font("Tahoma", fontSize);
            // Assign the font to the DataGridView
            dataGridView1.Font = font;

            this.txtFontSize.Text = fontSize.ToString();
        }

        private void ReSln_Load(object sender, EventArgs e)
        {
            this.Location = Utils.outScrn().Bounds.Location;
        }

    }
}
