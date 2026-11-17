namespace LatihanProyek1
{
    partial class LaporanPenjualan
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
            dateTimePicker1 = new DateTimePicker();
            TambahkanUser = new LatihanProjek1.RoundedButton();
            panel1.SuspendLayout();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1039, 150);
            label1.TabIndex = 2;
            label1.Text = "Laporan Penjualan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(262, 289);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(520, 31);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // TambahkanUser
            // 
            TambahkanUser.AutoSize = true;
            TambahkanUser.CornerRadius = 10;
            TambahkanUser.Location = new Point(426, 399);
            TambahkanUser.Name = "TambahkanUser";
            TambahkanUser.Size = new Size(233, 49);
            TambahkanUser.TabIndex = 5;
            TambahkanUser.Text = "Buat";
            TambahkanUser.UseVisualStyleBackColor = true;
            // 
            // LaporanPenjualan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1039, 607);
            Controls.Add(TambahkanUser);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "LaporanPenjualan";
            Text = "LaporanPenjualan";
            Load += LaporanPenjualan_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private LatihanProjek1.RoundedButton TambahkanUser;
    }
}