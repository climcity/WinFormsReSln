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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            btnPgDwn.Text = "pageDown";
            btnPgDwn.UseVisualStyleBackColor = true;
            // 
            // btnPgUp
            // 
            btnPgUp.Anchor = AnchorStyles.None;
            btnPgUp.Location = new Point(2, 92);
            btnPgUp.Name = "btnPgUp";
            btnPgUp.Size = new Size(100, 50);
            btnPgUp.TabIndex = 6;
            btnPgUp.Text = "pageUp";
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
            txtFontSize.Location = new Point(652, 311);
            txtFontSize.Name = "txtFontSize";
            txtFontSize.Size = new Size(100, 23);
            txtFontSize.TabIndex = 8;
            // 
            // ReSln
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(784, 561);
            Controls.Add(txtFontSize);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "ReSln";
            Text = "ReSln";
            Load += ReSln_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnPgDwn;
        private Button btnPgUp;
        private Panel panel1;
        private TextBox txtFontSize;
    }
}
