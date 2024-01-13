using System.Data;

namespace WinFormsChgReSln
{
    public partial class ChgReSln : Form
    { 
        // 콤보 박스에 표시할 해상도 목록
        private string[] resolutions = new string[]
        {
            "800 x 600",
            "1024 x 768",
            "1280 x 720",
            "1366 x 768",
            "1600 x 900",
            "1920 x 1080",
            "2560 x 1440",
            "3840 x 2160"
        };

        // 콤보 박스와 적용 버튼을 저장할 변수
        private ComboBox comboBox;
        private Button button;

        public ChgReSln()
        {
            InitializeComponent();
            // 폼의 속성 설정
            this.Text = "Display Settings";
            this.Size = new Size(400, 200);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // 콤보 박스 생성 및 속성 설정
            comboBox = new ComboBox();
            comboBox.Location = new Point(100, 50);
            comboBox.Size = new Size(200, 30);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 콤보 박스에 해상도 목록 추가
            foreach (string resolution in resolutions)
            {
                comboBox.Items.Add(resolution);
            }
            // 콤보 박스에 현재 해상도를 선택
            comboBox.SelectedItem = Screen.PrimaryScreen.Bounds.Width + " x " + Screen.PrimaryScreen.Bounds.Height;
            // 콤보 박스의 SelectedIndexChanged 이벤트 핸들러 등록
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 적용 버튼 생성 및 속성 설정
            button = new Button();
            button.Location = new Point(150, 100);
            button.Size = new Size(100, 30);
            button.Text = "Apply";
            button.Enabled = false;
            // 적용 버튼의 Click 이벤트 핸들러 등록
            button.Click += Button_Click;
            // 콤보 박스와 적용 버튼을 폼에 추가
            this.Controls.Add(comboBox);
            this.Controls.Add(button);
        }

        // 콤보 박스의 SelectedIndexChanged 이벤트 핸들러
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보 박스에서 선택한 해상도가 현재 해상도와 다르면 적용 버튼을 활성화
            if (comboBox.SelectedItem.ToString() != Screen.PrimaryScreen.Bounds.Width + " x " + Screen.PrimaryScreen.Bounds.Height)
            {
                button.Enabled = true;
            }
            // 그렇지 않으면 적용 버튼을 비활성화
            else
            {
                button.Enabled = false;
            }
        }

        // 적용 버튼의 Click 이벤트 핸들러
        private void Button_Click(object sender, EventArgs e)
        {
            // 콤보 박스에서 선택한 해상도를 파싱하여 너비와 높이를 구함
            string[] parts = comboBox.SelectedItem.ToString().Split('x');
            int width = int.Parse(parts[0].Trim());
            int height = int.Parse(parts[1].Trim());
            // 해상도를 변경하는 메서드 호출
            ChangeResolution(width, height);
            // 적용 버튼을 비활성화
            button.Enabled = false;
        }

        // 해상도를 변경하는 메서드
        private void ChangeResolution(int width, int height)
        {
            // 현재 디스플레이 설정을 가져옴
            DEVMODE devmode = new DEVMODE();
            devmode.dmSize = (short)System.Runtime.InteropServices.Marshal.SizeOf(devmode);
            EnumDisplaySettings(null, -1, ref devmode);
            // 디스플레이 설정의 너비와 높이를 변경
            devmode.dmPelsWidth = width;
            devmode.dmPelsHeight = height;
            // 변경된 디스플레이 설정을 적용
            ChangeDisplaySettings(ref devmode, 0);
        }

        // 디스플레이 설정을 나타내는 구조체
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DEVMODE
        {
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public int dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;

            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }

        // 디스플레이 설정을 가져오는 API 함수
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);

        // 디스플레이 설정을 변경하는 API 함수
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int ChangeDisplaySettings(ref DEVMODE devMode, int flags);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
