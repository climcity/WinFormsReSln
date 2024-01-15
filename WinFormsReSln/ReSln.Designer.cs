namespace WinFormsReSln
{
    partial class ReSln
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnPgDwn = new Button();
            btnPgUp = new Button();
            panel1 = new Panel();
            txtFontSize = new TextBox();
            txtRowHeight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeight = 19;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 294);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnPgDwn
            // 
            btnPgDwn.Anchor = AnchorStyles.None;
            btnPgDwn.Location = new Point(2, 159);
            btnPgDwn.Name = "btnPgDwn";
            btnPgDwn.Size = new Size(100, 50);
            btnPgDwn.TabIndex = 6;
            btnPgDwn.Text = "Down";
            btnPgDwn.UseVisualStyleBackColor = true;
            // 
            // btnPgUp
            // 
            btnPgUp.Anchor = AnchorStyles.None;
            btnPgUp.Location = new Point(2, 92);
            btnPgUp.Name = "btnPgUp";
            btnPgUp.Size = new Size(100, 50);
            btnPgUp.TabIndex = 6;
            btnPgUp.Text = "Up";
            btnPgUp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(btnPgDwn);
            panel1.Controls.Add(btnPgUp);
            panel1.Location = new Point(650, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 294);
            panel1.TabIndex = 7;
            // 
            // txtFontSize
            // 
            txtFontSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFontSize.Location = new Point(97, 18);
            txtFontSize.Name = "txtFontSize";
            txtFontSize.Size = new Size(100, 23);
            txtFontSize.TabIndex = 8;
            // 
            // txtRowHeight
            // 
            txtRowHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtRowHeight.Location = new Point(97, 47);
            txtRowHeight.Name = "txtRowHeight";
            txtRowHeight.Size = new Size(100, 23);
            txtRowHeight.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "FONT SIZE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 9;
            label2.Text = "ROW HEIGHT";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(txtFontSize);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtRowHeight);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(555, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 89);
            panel2.TabIndex = 10;
            // 
            // ReSln
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "ReSln";
            Text = "ReSln";
            Load += ReSln_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnPgDwn;
        private Button btnPgUp;
        private Panel panel1;
        private TextBox txtFontSize;
        private TextBox txtRowHeight;
        private Label label1;
        private Label label2;
        private Panel panel2;
    }
}
