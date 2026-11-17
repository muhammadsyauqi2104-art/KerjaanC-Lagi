namespace LatihanProyek1
{
    partial class MenuKasir
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
            roundedButton1 = new LatihanProjek1.RoundedButton();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 37);
            label1.Name = "label1";
            label1.Size = new Size(247, 70);
            label1.TabIndex = 3;
            label1.Text = "Menu Kasir";
            // 
            // roundedButton1
            // 
            roundedButton1.CornerRadius = 15;
            roundedButton1.Location = new Point(704, 211);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(300, 71);
            roundedButton1.TabIndex = 1;
            roundedButton1.Text = "Keranjang Jual";
            roundedButton1.UseVisualStyleBackColor = true;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 174);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Cari Barang...";
            textBox1.Size = new Size(632, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(632, 384);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // roundedButton2
            // 
            roundedButton2.CornerRadius = 15;
            roundedButton2.Location = new Point(704, 398);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(300, 73);
            roundedButton2.TabIndex = 4;
            roundedButton2.Text = "Cek Keranjang";
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
            // MenuKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1039, 607);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(roundedButton1);
            Controls.Add(panel1);
            Name = "MenuKasir";
            Text = "MenuKasir";
            WindowState = FormWindowState.Maximized;
            MaximizedBoundsChanged += MenuKasir_Load;
            Load += MenuKasir_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private LatihanProjek1.RoundedButton roundedButton1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private LatihanProjek1.RoundedButton roundedButton2;
        private LatihanProjek1.RoundedButton roundedButton3;
    }
}