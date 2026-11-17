using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LatihanProyek01; 

namespace LatihanProyek1
{
    public partial class MenuGudang : Form
    {
        private List<StokViewModel> semuaDataBarang = new List<StokViewModel>();
        private string placeholdertext = "Cari Barang";

        public MenuGudang()
        {
            InitializeComponent();
        }

        private void MenuGudang_Load(object sender, EventArgs e)
        {
            MuatDataStokGudang();
        }

        private void MuatDataStokGudang()
        {
            Dictionary<string, Dictionary<string, Barang>> dataStok = KerjaDatabase.SpilStok("Gudang");

            semuaDataBarang.Clear();

            foreach (var kategoriPair in dataStok)
            {
                string kategori = kategoriPair.Key;
                foreach (var barangPair in kategoriPair.Value)
                {
                    string kodeBarang = barangPair.Key;
                    Barang b = barangPair.Value;

                    semuaDataBarang.Add(new StokViewModel
                    {
                        Kategori = kategori,
                        Kode = kodeBarang,
                        NamaBarang = b.NamaBarang,
                        Stok = b.Stok,
                        Harga = b.Harga,
                        StokMinimum = b.StokMinimum
                    });
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = semuaDataBarang;

            AturTampilanGrid();
        }

        private void AturTampilanGrid()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                if (dataGridView1.Columns["Kategori"] != null)
                    dataGridView1.Columns["Kategori"].HeaderText = "Kategori";

                if (dataGridView1.Columns["Kode"] != null)
                {
                    dataGridView1.Columns["Kode"].HeaderText = "Kode Barang";
                    dataGridView1.Columns["Kode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridView1.Columns["NamaBarang"] != null)
                    dataGridView1.Columns["NamaBarang"].HeaderText = "Nama Barang";

                if (dataGridView1.Columns["Stok"] != null)
                {
                    dataGridView1.Columns["Stok"].HeaderText = "Stok";
                    dataGridView1.Columns["Stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridView1.Columns["Harga"] != null)
                {
                    dataGridView1.Columns["Harga"].HeaderText = "Harga (Rp)";
                    dataGridView1.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["Harga"].DefaultCellStyle.Format = "N0";
                }

                if (dataGridView1.Columns["StokMinimum"] != null)
                {
                    dataGridView1.Columns["StokMinimum"].HeaderText = "Min. Stok";
                    dataGridView1.Columns["StokMinimum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholdertext || textBox1.ForeColor == Color.Gray)
            {
                return;
            }
            string keyword = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = semuaDataBarang;
            }
            else
            {
                var hasilFilter = semuaDataBarang.Where(x =>
                    x.Kode.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    x.NamaBarang.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    x.Kategori.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = hasilFilter;

                AturTampilanGrid();
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TambahkanUser_Click(object sender, EventArgs e)
        {
            DialogResult kategoribaru = MessageBox.Show("Apakah anda ingin membuat kategori baru?\n(YES untuk tambah kategori baru NO untuk katgori yang sudah ada", "Kategori Barag",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            bool BuatKategori = (kategoribaru == DialogResult.Yes);
            string namakategori = "";
            string inisialbaru = "";

            if (BuatKategori)
            {
                namakategori = Microsoft.VisualBasic.Interaction.InputBox("Masukan nama kategori baru:", "Tambah Barang");
                if (string.IsNullOrWhiteSpace(namakategori)) return;

                inisialbaru = Microsoft.VisualBasic.Interaction.InputBox("Masukkan inisial baru:", "Tambah User");
                if (string.IsNullOrWhiteSpace(inisialbaru)) return;
            }
            else
            {
                Dictionary<string, string> daftarkategori = KerjaDatabase.SpilKategori();
                string pesanPilihan = "Daftar Kategori yang Tersedia:\n";
                foreach (var kat in daftarkategori)
                {
                    pesanPilihan += $"- {kat.Key} ({kat.Value})\n";
                }
                pesanPilihan += "\nMasukkan Nama Kategori yang ingin dipilih:";

                namakategori = Microsoft.VisualBasic.Interaction.InputBox(pesanPilihan, "Tambah Barang - Pilih Kategori", "".ToLower());
                if (string.IsNullOrWhiteSpace(namakategori)) return;
            }
            string namaBarang = Microsoft.VisualBasic.Interaction.InputBox("Masukkan Nama Barang:", "Tambah Barang", "");
            if (string.IsNullOrWhiteSpace(namaBarang)) return;

            string strStok = Microsoft.VisualBasic.Interaction.InputBox("Masukkan Jumlah Stok Awal:", "Tambah Barang", "0");
            if (!int.TryParse(strStok, out int stokAwal))
            {
                MessageBox.Show("Stok awal harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strHarga = Microsoft.VisualBasic.Interaction.InputBox("Masukkan Harga Satuan (Rp):", "Tambah Barang", "0");
            if (!long.TryParse(strHarga, out long harga))
            {
                MessageBox.Show("Harga harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strStokMin = Microsoft.VisualBasic.Interaction.InputBox("Masukkan Batas Stok Minimum:", "Tambah Barang", "10");
            if (!int.TryParse(strStokMin, out int stokMinimum))
            {
                MessageBox.Show("Stok minimum harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hasilPesan = KerjaDatabase.TambahBarang(BuatKategori, namakategori, inisialbaru, namaBarang, stokAwal, harga, stokMinimum);

            MessageBox.Show(hasilPesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MuatDataStokGudang();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholdertext)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = placeholdertext;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void MenuKasir_Load(object sender, EventArgs e)
        {

        }
    }
}