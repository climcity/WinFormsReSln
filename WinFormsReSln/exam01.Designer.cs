using System.Windows.Forms;

namespace WinFormsReSln
{
    partial class exam01
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(660, 183);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnPgDwn
            // 
            btnPgDwn.Location = new Point(667, 117);
            btnPgDwn.Name = "btnPgDwn";
            btnPgDwn.Size = new Size(100, 50);
            btnPgDwn.TabIndex = 6;
            btnPgDwn.Text = "pageDown";
            btnPgDwn.UseVisualStyleBackColor = true;
            // 
            // btnPgUp
            // 
            btnPgUp.Location = new Point(667, 40);
            btnPgUp.Name = "btnPgUp";
            btnPgUp.Size = new Size(100, 50);
            btnPgUp.TabIndex = 6;
            btnPgUp.Text = "pageUp";
            btnPgUp.UseVisualStyleBackColor = true;
            // 
            // exam01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnPgDwn);
            Controls.Add(btnPgUp);
            Name = "exam01";
            Text = "exam01";
            Load += ShwFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnPgDwn;
        private Button btnPgUp;
    }
}
