using System.Data;

namespace WinFormsChgReSln
{
    public partial class ChgReSln : Form
    { 
        // �޺� �ڽ��� ǥ���� �ػ� ���
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

        // �޺� �ڽ��� ���� ��ư�� ������ ����
        private ComboBox comboBox;
        private Button button;

        public ChgReSln()
        {
            InitializeComponent();
            // ���� �Ӽ� ����
            this.Text = "Display Settings";
            this.Size = new Size(400, 200);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // �޺� �ڽ� ���� �� �Ӽ� ����
            comboBox = new ComboBox();
            comboBox.Location = new Point(100, 50);
            comboBox.Size = new Size(200, 30);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // �޺� �ڽ��� �ػ� ��� �߰�
            foreach (string resolution in resolutions)
            {
                comboBox.Items.Add(resolution);
            }
            // �޺� �ڽ��� ���� �ػ󵵸� ����
            comboBox.SelectedItem = Screen.PrimaryScreen.Bounds.Width + " x " + Screen.PrimaryScreen.Bounds.Height;
            // �޺� �ڽ��� SelectedIndexChanged �̺�Ʈ �ڵ鷯 ���
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // ���� ��ư ���� �� �Ӽ� ����
            button = new Button();
            button.Location = new Point(150, 100);
            button.Size = new Size(100, 30);
            button.Text = "Apply";
            button.Enabled = false;
            // ���� ��ư�� Click �̺�Ʈ �ڵ鷯 ���
            button.Click += Button_Click;
            // �޺� �ڽ��� ���� ��ư�� ���� �߰�
            this.Controls.Add(comboBox);
            this.Controls.Add(button);
        }

        // �޺� �ڽ��� SelectedIndexChanged �̺�Ʈ �ڵ鷯
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �޺� �ڽ����� ������ �ػ󵵰� ���� �ػ󵵿� �ٸ��� ���� ��ư�� Ȱ��ȭ
            if (comboBox.SelectedItem.ToString() != Screen.PrimaryScreen.Bounds.Width + " x " + Screen.PrimaryScreen.Bounds.Height)
            {
                button.Enabled = true;
            }
            // �׷��� ������ ���� ��ư�� ��Ȱ��ȭ
            else
            {
                button.Enabled = false;
            }
        }

        // ���� ��ư�� Click �̺�Ʈ �ڵ鷯
        private void Button_Click(object sender, EventArgs e)
        {
            // �޺� �ڽ����� ������ �ػ󵵸� �Ľ��Ͽ� �ʺ�� ���̸� ����
            string[] parts = comboBox.SelectedItem.ToString().Split('x');
            int width = int.Parse(parts[0].Trim());
            int height = int.Parse(parts[1].Trim());
            // �ػ󵵸� �����ϴ� �޼��� ȣ��
            ChangeResolution(width, height);
            // ���� ��ư�� ��Ȱ��ȭ
            button.Enabled = false;
        }

        // �ػ󵵸� �����ϴ� �޼���
        private void ChangeResolution(int width, int height)
        {
            // ���� ���÷��� ������ ������
            DEVMODE devmode = new DEVMODE();
            devmode.dmSize = (short)System.Runtime.InteropServices.Marshal.SizeOf(devmode);
            EnumDisplaySettings(null, -1, ref devmode);
            // ���÷��� ������ �ʺ�� ���̸� ����
            devmode.dmPelsWidth = width;
            devmode.dmPelsHeight = height;
            // ����� ���÷��� ������ ����
            ChangeDisplaySettings(ref devmode, 0);
        }

        // ���÷��� ������ ��Ÿ���� ����ü
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

        // ���÷��� ������ �������� API �Լ�
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);

        // ���÷��� ������ �����ϴ� API �Լ�
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int ChangeDisplaySettings(ref DEVMODE devMode, int flags);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
