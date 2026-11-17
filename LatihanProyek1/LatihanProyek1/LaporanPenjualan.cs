using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LatihanProyek1
{
    public partial class LaporanPenjualan : Form
    {
        public LaporanPenjualan()
        {
            InitializeComponent();
        }


        private void LaporanPenjualan_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime tanggaldipilih = dateTimePicker1.Value;
            string tanggalcari = tanggaldipilih.ToString("yyyy-mm-dd");
        }
    }
}
