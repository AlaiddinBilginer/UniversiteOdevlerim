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


namespace OtomasyonProje
{
    public partial class GirisForm : Form
    {
        SqlBaglanti sqlBaglanti = new SqlBaglanti();
        public GirisForm()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Kullanicilar where kullaniciAd = @p1 and kullaniciSifre = @p2", sqlBaglanti.baglanti());
            command.Parameters.AddWithValue("@p1", textBoxKullaniciAd.Text);
            command.Parameters.AddWithValue("@p2", textBoxSifre.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                MusteriEkran musteriEkran = new MusteriEkran();
                musteriEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş hatalı");
            }
            sqlBaglanti.baglanti().Close();
        }

        private void linkLabelSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttumForm sifremiUnuttumForm = new SifremiUnuttumForm();
            sifremiUnuttumForm.Show();
        }
    }
}
