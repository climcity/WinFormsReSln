using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  commnLib;

namespace WinFormsReSln
{
    public partial class ShwFrm : Form
    {
        public ShwFrm()
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
            table.Columns.Add("Service Name", typeof(string));
            table.Columns.Add("Form Name", typeof(string));

            table.Rows.Add(null, "AAA", "exam01");
            table.Rows.Add(null, "BBB", "exam02");
            table.Rows.Add(null, "CCC", "ReSln");

            // DataGridView 컨트롤에 데이터 소스 바인딩
            dataGridView1.DataSource = table;

            // DataGridView 컨트롤에 버튼 열 추가
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Form 출력";
            btnColumn.Name = "buttonColumn";
            int btnColumnIdx = dataGridView1.Columns.Add(btnColumn);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 클릭한 셀의 열의 인덱스를 얻음
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            // 클릭한 열이 버튼 열인지 확인
            if (dataGridView1.Columns[columnIndex] is DataGridViewButtonColumn)
            {
                // 원하는 코드를 실행
                //MessageBox.Show("버튼 클릭 이벤트가 발생했습니다.");


                // 셀에 접근
                DataGridViewCell cell = dataGridView1.Rows[rowIndex].Cells[columnIndex + 3];

                // 셀의 텍스트를 얻음

                try
                {
                    Form newFrm = null;
                    string cellText = cell.Value.ToString();
                    if (cellText.Equals("ReSln"))
                    {
                        newFrm = new ReSln();
                    }
                    else if (cellText.Equals("exam01"))
                    {
                        newFrm = new exam01();
                    }
                    else if (cellText.Equals("exam02"))
                    {
                        newFrm = new exam02();
                    }

                    if (newFrm != null)
                    {
                        newFrm.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private void ShwFrm_Load(object sender, EventArgs e)
        {
            this.Location = Utils.outScrn().Bounds.Location;
        }
    }
}
