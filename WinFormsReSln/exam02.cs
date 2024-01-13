using commnLib;
using System.Data;
using System.Windows.Forms;

namespace WinFormsReSln
{
    public partial class exam02 : Form
    {
        public exam02()
        {
            InitializeComponent();
            InitializeDataGridView();
        }


        private void InitializeDataGridView()
        {
            // 데이터 소스 생성
            DataTable table = new DataTable();
            // 자동증가 값이 되는 컬럼 생성
            DataColumn col = new DataColumn("ID", typeof(int));
            col.AutoIncrement = true; // 자동증가 속성 활성화
            col.AutoIncrementSeed = 1; // 자동증가 값의 시작 값
            col.AutoIncrementStep = 1; // 자동증가 값의 증가량

            // DataTable에 컬럼 추가
            table.Columns.Add(col);
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Gender", typeof(string));
            table.Rows.Add(null, "John Doe", 25, "Male");
            table.Rows.Add(null, "Jane Doe", 30, "Female");

            // DataGridView 컨트롤에 데이터 소스 바인딩
            dataGridView1.DataSource = table;

            // DataGridView 컨트롤에 버튼 열 추가
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Form 출력";
            btnColumn.Name = "buttonColumn";
            int btnColumnIdx = dataGridView1.Columns.Add(btnColumn);

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        private void ShwFrm_Load(object sender, EventArgs e)
        {
            this.Location = Utils.outScrn().Bounds.Location;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
