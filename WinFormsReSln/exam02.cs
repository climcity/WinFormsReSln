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
            // ������ �ҽ� ����
            DataTable table = new DataTable();
            // �ڵ����� ���� �Ǵ� �÷� ����
            DataColumn col = new DataColumn("ID", typeof(int));
            col.AutoIncrement = true; // �ڵ����� �Ӽ� Ȱ��ȭ
            col.AutoIncrementSeed = 1; // �ڵ����� ���� ���� ��
            col.AutoIncrementStep = 1; // �ڵ����� ���� ������

            // DataTable�� �÷� �߰�
            table.Columns.Add(col);
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Gender", typeof(string));
            table.Rows.Add(null, "John Doe", 25, "Male");
            table.Rows.Add(null, "Jane Doe", 30, "Female");

            // DataGridView ��Ʈ�ѿ� ������ �ҽ� ���ε�
            dataGridView1.DataSource = table;

            // DataGridView ��Ʈ�ѿ� ��ư �� �߰�
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Form ���";
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
