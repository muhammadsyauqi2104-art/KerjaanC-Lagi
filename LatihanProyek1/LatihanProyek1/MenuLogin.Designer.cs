namespace LatihanProyek1
{
    partial class MenuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLogin));
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            roundedButton1 = new LatihanProjek1.RoundedButton();
            pictureBox1 = new PictureBox();
            Password = new TextBox();
            Username = new TextBox();
            sisiLengkungPanel1 = new LatihanProjek1.SisiLengkungPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 607);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 159);
            label2.TabIndex = 0;
            label2.Text = "SMK MART";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(424, 188);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(520, 290);
            tableLayoutPanel1.TabIndex = 6;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1039, 150);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(525, 9);
            label1.Name = "label1";
            label1.Size = new Size(300, 81);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(roundedButton1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(Password);
            panel3.Controls.Add(Username);
            panel3.Controls.Add(sisiLengkungPanel1);
            panel3.Location = new Point(293, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(746, 464);
            panel3.TabIndex = 5;
            // 
            // roundedButton1
            // 
            roundedButton1.CornerRadius = 15;
            roundedButton1.Location = new Point(294, 310);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(193, 56);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "Masuk";
            roundedButton1.UseVisualStyleBackColor = true;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(339, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Password.Location = new Point(60, 238);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(648, 31);
            Password.TabIndex = 1;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            Password.Enter += Password_Enter;
            Password.KeyDown += Password_KeyDown;
            Password.Leave += Password_Leave;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Username.Location = new Point(60, 180);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(648, 31);
            Username.TabIndex = 0;
            Username.TextChanged += Username_TextChanged;
            Username.KeyDown += Username_KeyDown;
            Username.Leave += Username_Leave;
            // 
            // sisiLengkungPanel1
            // 
            sisiLengkungPanel1.BackColor = Color.LightGray;
            sisiLengkungPanel1.CornerRadius = 15;
            sisiLengkungPanel1.Location = new Point(13, 23);
            sisiLengkungPanel1.Name = "sisiLengkungPanel1";
            sisiLengkungPanel1.Size = new Size(730, 418);
            sisiLengkungPanel1.TabIndex = 6;
            // 
            // MenuLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1039, 607);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "MenuLogin";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += MenuLogin_Load;
            KeyDown += MenuLogin_KeyDown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private TextBox Password;
        private TextBox Username;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private LatihanProjek1.SisiLengkungPanel sisiLengkungPanel1;
        private LatihanProjek1.RoundedButton roundedButton1;
    }
}
