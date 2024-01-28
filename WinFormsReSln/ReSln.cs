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
            outClientSize(sender, e);
            this.txtReSolution.Text = Utils.outResolution();

        }

        
        private void setDataGridViewHeight(DataGridView obj)
        {
            Screen screen = Utils.outScrn();

            // 해당 모니터의 작업 영역의 높이를 가져옵니다.
            int screenHeight = screen.WorkingArea.Height;

            int newHeight = (int)(screenHeight / 15);

            // 컬럼의 높이를 설정합니다.
            obj.RowTemplate.Height = newHeight;

            // 행의 높이를 새로운 높이로 설정합니다.
            obj.ColumnHeadersHeight = newHeight;

            this.txtRowHeight.Text = newHeight.ToString();
        }

        private void ReSln_Resize(object sender, EventArgs e)
        {
           outClientSize(sender, e);
            this.txtReSolution.Text = Utils.outResolution();
        }

        private void outClientSize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            this.txtFrmWidth.Text = control.Width.ToString();
            this.txtFrmHeight.Text = control.Height.ToString();
        }
    }
}
