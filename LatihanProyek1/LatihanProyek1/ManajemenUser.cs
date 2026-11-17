using LatihanProyek01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LatihanProyek1
{
    public partial class ManajemenUser : Form
    {
        private string filepath = "User.txt";
        private List<UserViewModel> semuaDataUser = new List<UserViewModel>();

        public ManajemenUser()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadDataUser();
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void LoadDataUser()
        {
            semuaDataUser.Clear();

            try
            {
                string pathFileUser = KerjaDatabase.AmbilPathFile("User.txt");
                if (File.Exists(pathFileUser))
                {
                    string[] lines = File.ReadAllLines(pathFileUser);
                    foreach (String line in lines)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length >= 4)
                            {
                                string id = parts[0].Trim();
                                string username = parts[1].Trim();
                                string role = parts[2].Trim();
                                string kondisi = parts.Length > 4 ? parts[4].Trim() : "1";
                                string statusText = (kondisi == "1") ? "Aktif" : "Nonaktif";

                                semuaDataUser.Add(new UserViewModel
                                {
                                    ID = id,
                                    Username = username,
                                    Role = role,
                                    Kondisi = statusText
                                });
                            }
                        }
                    }
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = semuaDataUser;

                AturTampilanGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Membaca File/File tidak ada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AturTampilanGrid()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                if (dataGridView1.Columns["ID"] != null) dataGridView1.Columns["ID"].HeaderText = "ID User";
                if (dataGridView1.Columns["Username"] != null) dataGridView1.Columns["Username"].HeaderText = "Username";
                if (dataGridView1.Columns["Role"] != null) dataGridView1.Columns["Role"].HeaderText = "Role";
                if (dataGridView1.Columns["Kondisi"] != null) dataGridView1.Columns["Kondisi"].HeaderText = "Kondisi";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = semuaDataUser;
            }
            else
            {
                var hasilFilter = semuaDataUser.Where(x =>
                    x.ID.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    x.Username.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    x.Role.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    x.Kondisi.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = hasilFilter;
            }
            AturTampilanGrid();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string User = Microsoft.VisualBasic.Interaction.InputBox("Buat Username:", "Tambah User", "");
            if (string.IsNullOrEmpty(User)) return;

            string Password = Microsoft.VisualBasic.Interaction.InputBox("Buat Password:", "Tambah User", "");
            if (string.IsNullOrEmpty(Password)) return;

            string Role = "";
            bool roleValid = false;

            while (!roleValid)
            {
                Role = Microsoft.VisualBasic.Interaction.InputBox(
                    "Pilih Role:\n1. ADMIN\n2. PENGELOLA GUDANG\n3. KASIR\n\n(Masukkan salah satu dari 3 role di atas):",
                    "Tambah User",
                    ""
                ).Trim().ToUpper();

                if (string.IsNullOrEmpty(Role))
                {
                    return;
                }

                if (Role == "ADMIN" || Role == "PENGELOLA GUDANG" || Role == "KASIR")
                {
                    roleValid = true;
                }
                else
                {
                    MessageBox.Show("Role tidak valid! Silakan pilih antara ADMIN, PENGELOLA GUDANG, atau KASIR.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            string idbaru;
            string pesanHasil = KerjaDatabase.TambahUser(User, Password, Role, out idbaru);

            if (pesanHasil == "User berhasil ditambahkan!")
            {
                MessageBox.Show($"{pesanHasil}\nID Baru Anda: {idbaru}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataUser();
            }
            else
            {
                MessageBox.Show(pesanHasil, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idDipilih = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString().Trim();
                string usernameDipilih = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus user '{usernameDipilih}' (ID: {idDipilih})?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    string pathFileUser = KerjaDatabase.AmbilPathFile("User.txt");

                    if (File.Exists(pathFileUser))
                    {
                        var lines = File.ReadAllLines(pathFileUser);
                        using (StreamWriter writer = new StreamWriter(pathFileUser, false))
                        {
                            foreach (string line in lines)
                            {
                                if (!string.IsNullOrWhiteSpace(line))
                                {
                                    string[] parts = line.Split('|');
                                    if (parts.Length > 0 && parts[0].Trim() != idDipilih)
                                    {
                                        writer.WriteLine(line);
                                    }
                                }
                            }
                        }
                        MessageBox.Show("User berhasil dihapus dari sistem!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataUser();
                    }
                    else
                    {
                        MessageBox.Show("File User.txt tidak ditemukan di direktori project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris user pada DataGridView yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }
    }

    public class UserViewModel
    {
        public string ID { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Kondisi { get; set; } = string.Empty;
    }
}