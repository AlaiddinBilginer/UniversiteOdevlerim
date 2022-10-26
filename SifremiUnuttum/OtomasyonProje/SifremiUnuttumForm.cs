using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace OtomasyonProje
{
    public partial class SifremiUnuttumForm : Form
    {
        public SifremiUnuttumForm()
        {
            InitializeComponent();
        }

        private void SifremiUnuttumForm_Load(object sender, EventArgs e)
        {

        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();
        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("kendi email hesabınız");
            ePosta.To.Add(textBoxEmail.Text);
            ePosta.Subject = konu;
            ePosta.Body = icerik;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("kendi email hesabınız", "kendi şifreniz");
            smtp.Port = 587;
            smtp.Host = "smtp.outlook.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;

            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException e)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(e.Message, "Mail Gönderme Hatası");
            }
            return kontrol;
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            if(sqlBaglanti.baglanti().State == ConnectionState.Closed)
            {
                sqlBaglanti.baglanti().Open();
            }

            SqlCommand command = new SqlCommand("Select * From Kullanicilar where kullaniciAd = '" + textBoxKullaniciAd.Text.ToString() +
                "' and kullaniciEmail = '" + textBoxEmail.Text.ToString() + "'", sqlBaglanti.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                string kullaniciSifre = dataReader["kullaniciSifre"].ToString();
                MessageBox.Show("Şifreniz mail adresinize yollanıyor...");
                Gonder("Şifreniz ", kullaniciSifre);
                sqlBaglanti.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Uyuşmadı");
            }
            sqlBaglanti.baglanti().Close();
        }
    }
}
