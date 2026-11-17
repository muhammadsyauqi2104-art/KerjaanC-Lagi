using LatihanProyek01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

    namespace LatihanProyek1
    {
    public partial class MenuKasir : Form
    {
        private List<StokViewModel> semuaDataBarang = new List<StokViewModel>();
        private string placeholdertext = "Cari Barang";
        public MenuKasir()
        {
            InitializeComponent();
        }

        private void MenuKasir_Load(object sender, EventArgs e)
        {
            MuatDataStokKasir();
        }

        private void MuatDataStokKasir()
        {
            Dictionary<string, Dictionary<string, Barang>> dataStok = KerjaDatabase.SpilStok("Kasir");

            List<StokViewModel> listTampil = new List<StokViewModel>();

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
                if (dataGridView1.Columns["Kategori"] != null) dataGridView1.Columns["Kategori"].HeaderText = "Kategori";
                if (dataGridView1.Columns["Kategori"] != null)
                {
                    dataGridView1.Columns["Kode"].HeaderText = "Kode Barang";
                    dataGridView1.Columns["Kode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dataGridView1.Columns["NamaBarang"] != null) dataGridView1.Columns["NamaBarang"].HeaderText = "Nama Barang";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuKasir_Load_1(object sender, EventArgs e)
        {
            MuatDataStokKasir();
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

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
    public class StokViewModel
        {
            public string Kategori { get; set; } = string.Empty;
            public string Kode { get; set; } = string.Empty;
            public string NamaBarang { get; set; } = string.Empty;
            public int Stok { get; set; }
            public long Harga { get; set; }
            public int StokMinimum { get; set; }
        }
    }