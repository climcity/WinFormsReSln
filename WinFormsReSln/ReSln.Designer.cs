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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtReSolution = new TextBox();
            txtFrmHeight = new TextBox();
            txtFrmWidth = new TextBox();
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
            txtFontSize.Location = new Point(130, 70);
            txtFontSize.Name = "txtFontSize";
            txtFontSize.Size = new Size(92, 23);
            txtFontSize.TabIndex = 8;
            txtFontSize.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRowHeight
            // 
            txtRowHeight.Location = new Point(130, 99);
            txtRowHeight.Name = "txtRowHeight";
            txtRowHeight.Size = new Size(92, 23);
            txtRowHeight.TabIndex = 8;
            txtRowHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 73);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 9;
            label1.Text = "Font Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 9;
            label2.Text = "Row Height";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(txtFontSize);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtReSolution);
            panel2.Controls.Add(txtFrmHeight);
            panel2.Controls.Add(txtFrmWidth);
            panel2.Controls.Add(txtRowHeight);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(526, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 239);
            panel2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 44);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 9;
            label5.Text = "Display Resolution";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 160);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 9;
            label4.Text = "Form Height";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 131);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 9;
            label3.Text = "Form Width";
            // 
            // txtReSolution
            // 
            txtReSolution.Location = new Point(130, 41);
            txtReSolution.Name = "txtReSolution";
            txtReSolution.Size = new Size(92, 23);
            txtReSolution.TabIndex = 8;
            txtReSolution.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFrmHeight
            // 
            txtFrmHeight.Location = new Point(130, 157);
            txtFrmHeight.Name = "txtFrmHeight";
            txtFrmHeight.Size = new Size(92, 23);
            txtFrmHeight.TabIndex = 8;
            txtFrmHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFrmWidth
            // 
            txtFrmWidth.Location = new Point(130, 128);
            txtFrmWidth.Name = "txtFrmWidth";
            txtFrmWidth.Size = new Size(92, 23);
            txtFrmWidth.TabIndex = 8;
            txtFrmWidth.TextAlign = HorizontalAlignment.Center;
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
            Resize += ReSln_Resize;
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
        private Label label3;
        private TextBox txtFrmWidth;
        private Label label4;
        private TextBox txtFrmHeight;
        private Label label5;
        private TextBox txtReSolution;
    }
}
