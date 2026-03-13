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
            conn = new SqlConnection();
            "Data source=FRHANARKA\\FARHANGANTENG;Initial catalog=DBAkademiADO;Integrated Security=true"
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
            
            }
        }
    }
}
