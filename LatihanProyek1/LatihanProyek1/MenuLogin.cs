using LatihanProyek01;
using System;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LatihanProyek1
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }

        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {

                Username.ForeColor = Color.Gray;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.ForeColor = Color.Gray;
                Password.PasswordChar = ' ';
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.PasswordChar = '\0';

                Password.ForeColor = Color.Gray;
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuLogin_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                roundedButton1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void MenuLogin_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mohon isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hasil = KerjaDatabase.Login(username, password);
            if (hasil == "Gagal")
            {
                MessageBox.Show("Login gagal! Username atau Password tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (hasil == "Admin")
            {
                MenuAdmin paneladmin = new();
                paneladmin.Show();
            }
            else if (hasil == "Kasir")
            {
                MenuKasir menuKasir = new MenuKasir();
                menuKasir.Show();
            }
            else if (hasil == "Gudang")
            {
                MenuGudang menuGudang = new MenuGudang();
                menuGudang.Show();
            }
            if (hasil != "Gagal")
            {
                this.Hide();
            }
        }
    }
}