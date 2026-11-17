namespace LatihanProyek1
{
    partial class MenuGudang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            TambahkanUser = new LatihanProjek1.RoundedButton();
            roundedButton1 = new LatihanProjek1.RoundedButton();
            roundedButton2 = new LatihanProjek1.RoundedButton();
            roundedButton3 = new LatihanProjek1.RoundedButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 150);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1039, 150);
            label1.TabIndex = 2;
            label1.Text = "Menu Gudang";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(632, 384);
            dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 174);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Cari Barang...";
            textBox1.Size = new Size(632, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // TambahkanUser
            // 
            TambahkanUser.CornerRadius = 10;
            TambahkanUser.Location = new Point(738, 211);
            TambahkanUser.Name = "TambahkanUser";
            TambahkanUser.Size = new Size(233, 49);
            TambahkanUser.TabIndex = 6;
            TambahkanUser.Text = "Tambah Barang";
            TambahkanUser.UseVisualStyleBackColor = true;
            TambahkanUser.Click += TambahkanUser_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.CornerRadius = 10;
            roundedButton1.Location = new Point(738, 307);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(233, 49);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "Restock";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // roundedButton2
            // 
            roundedButton2.CornerRadius = 10;
            roundedButton2.Location = new Point(738, 415);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(233, 49);
            roundedButton2.TabIndex = 8;
            roundedButton2.Text = "Hapus Barang";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // roundedButton3
            // 
            roundedButton3.CornerRadius = 10;
            roundedButton3.ForeColor = Color.Red;
            roundedButton3.Location = new Point(902, 561);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(125, 34);
            roundedButton3.TabIndex = 31;
            roundedButton3.Text = "Keluar";
            roundedButton3.UseVisualStyleBackColor = true;
            roundedButton3.Click += roundedButton3_Click;
            // 
            // MenuGudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1039, 607);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            Controls.Add(TambahkanUser);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "MenuGudang";
            Text = "MenuGudang";
            WindowState = FormWindowState.Maximized;
            MaximizedBoundsChanged += MenuGudang_Load;
            Load += MenuGudang_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private LatihanProjek1.RoundedButton TambahkanUser;
        private LatihanProjek1.RoundedButton roundedButton1;
        private LatihanProjek1.RoundedButton roundedButton2;
        private LatihanProjek1.RoundedButton roundedButton3;
    }
}