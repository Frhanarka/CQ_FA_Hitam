using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;

        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data source=FRHANARKA\\FARHANGANTENG;Initial catalog=DBAkademiADO;Integrated Security=True"
            );

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Koneksi();
            try
            {
                Koneksi();
                conn.Open();

                MessageBox.Show("Koneksi ke database Berhasil");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM Mahasiswa";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMk_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM MataKuliah";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "UPDATE Mahasiswa SET Alamat= 'Copenhagen' WHERE NIM = '23110100001'";

                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("Jumlah baris terpengaruh: " + hasil);

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
