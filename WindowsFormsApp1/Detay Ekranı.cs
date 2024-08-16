using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Detay_Ekranı : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-FHMTT9B\\SQLEXPRESS;Initial Catalog=practiceDb;Integrated Security = True; Encrypt = True; Trust Server Certificate = True.connectionString";

        private List<info> Data { get; set; }

        public void detaydoldur()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=desktop-fhmtt9b\\sqlexpress;Initial Catalog=practiceDb;Integrated Security=True");
            baglanti.Open();
            string sqlGetDetay = "SELECT  MusteriNO, MusteriAd, MusteriSoyad, BasvurulanUrun, KrediTutarı, KrediVadesi, TaksitTutarı, ReferansNo, BasvuruTarihi, BasvuruDurumu FROM Basvurular WHERE ReferansNo=@txtRN2 ";
            SqlCommand cmdAdd = new SqlCommand(sqlGetDetay, baglanti);
            //cmdAdd.Parameters.Add("@txtRN2", txtRN2.Text);
            cmdAdd.Parameters.Add("@txtRN2", SqlDbType.NVarChar).Value = @txtRN2.Text;

            SqlDataReader reader = cmdAdd.ExecuteReader();



            if (reader.Read())
            {
                txtMN2.Text = reader["MusteriNO"].ToString();
                txtA2.Text = reader["MusteriAd"].ToString();
                txtSA2.Text = reader["MusteriSoyad"].ToString();
                txtBU2.Text = reader["BasvurulanUrun"].ToString();
                txtKT2.Text = reader["KrediTutarı"].ToString();
                txtKV2.Text = reader["KrediVadesi"].ToString();
                txtTT2.Text = reader["TaksitTutarı"].ToString();
                txtRN2.Text = reader["ReferansNo"].ToString();
                txtBT2.Text = reader["BasvuruTarihi"].ToString();
                txtOD2.Text = reader["BasvuruDurumu"].ToString();

            }
            else
            {
                MessageBox.Show("Hata");


            }

            reader.Close();
        }


        public Detay_Ekranı()
        {
            InitializeComponent();
            Data = new List<info>();
        }


        private void txtAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        public string referansno2;
        private void Detay_Ekranı_Load(object sender, EventArgs e)
        {
            txtRN2.Text = referansno2;
            detaydoldur();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtOD2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSA2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblbb_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
            try //burada tam çalşmıyor

            {
                DateTimePicker d = new DateTimePicker();
                d.MaxDate = new DateTime(2024, 8, 16);
                d.MinDate = new DateTime(1900, 1, 1);

                TimeSpan fark;
                int yas; DateTime dogumtarihi;
                dogumtarihi = Convert.ToDateTime(datadg.Text);
                fark = DateTime.Now.Date.Subtract(dogumtarihi);
                yas = Convert.ToInt32(fark.TotalDays);



            }
            catch
            {
                MessageBox.Show("Doğum tarihi hesabında sıkıntı var");
            }




        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
        }
        public bool TcDogruMu()
        {
            string kimlikno = txtTC.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numaranızı eksik girdiniz!\nLütfen tekrar deneyin.");
                txtTC.Clear();
                txtTC.Focus();
                return false;
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < kimlikno.Length; i++)
            {
                sayilar[i] = Int32.Parse(kimlikno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < kimlikno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Girilen Tc Kimlik No yanlıştır!\nLütfen kontrol ediniz.");
                txtTC.Focus();
                return false;
            }
        }
        private void txtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //TcDogruMu();

            }

        }

        private void txtcep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }
        private void txtag_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TcDogruMu();

            //KosullarKredi();
            //    if (String.IsNullOrEmpty(txtTC.Text)) /*düzeltince tekrar gelmemesi lazım ama o ilerlemiyor*/
            //    {
            //        MessageBox.Show("T.C. Kimlik NO'yu boş bırakamazsınız.");
            //        return;
            //    }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtag.Text = "17002".ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTC.Text = string.Empty;
            txtcep.Text = string.Empty;
            txtep.Text = string.Empty;
            txtag.Text = string.Empty;
            datadg.Text = string.Empty;
            checkBox1.Checked = false;
            datadg.Text = string.Empty;

        }

        private void txtag_TextChanged(object sender, EventArgs e)
        {

        }

        public void KosullarKredi()
        {

            //if (txtBU2.Text == "İhtiyaç Kredisi") //işe yaramadı niye bilmiyorum

            //{
            //    if (decimal.TryParse(txtag.Text, out decimal gelir) && decimal.TryParse(txtKT2.Text, out decimal kredi) && kredi != 0)
            //    {
            //        gelir = gelir * 5;
            //        if (gelir >= kredi)
            //        {
            //            MessageBox.Show("Kredi talebiniz oluşturulmuştur.");
            //            return;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Kredi talebiniz reddedilmiştir.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Geçersiz gelir veya kredi miktarı.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Yanlış kredi türü.");
            //}

            if (txtBU2.Text.Trim().Equals("İhtiyaç Kredisi", StringComparison.OrdinalIgnoreCase))
            {

                if (decimal.TryParse(txtag.Text, out decimal gelir) && decimal.TryParse(txtKT2.Text, out decimal kredi) && kredi != 0)
                {

                    gelir = gelir * 5;
                    if (gelir >= kredi)
                    {
                        MessageBox.Show("Kredi talebiniz oluşturulmuştur.");
                    }
                    else
                    {
                        MessageBox.Show("Kredi talebiniz reddedilmiştir.Gelirinizin beş katını geçemezsiniz");
                    }

                }
                else
                {
                    MessageBox.Show("Geçersiz gelir veya kredi miktarı.");
                }
            }

            if (txtBU2.Text.Trim().Equals("Konut Kredisi", StringComparison.OrdinalIgnoreCase))
            {
                if (decimal.TryParse(txtag.Text, out decimal gelir) && decimal.TryParse(txtKT2.Text, out decimal kredi) && kredi != 0 && kredi <= 1000000)
                {
                    gelir = gelir * 20;
                    if (gelir >= kredi)
                    {
                        MessageBox.Show("Kredi talebiniz oluşturulmuştur.");
                    }
                    else
                    {
                        MessageBox.Show("Kredi talebiniz reddedilmiştir.Gelirinizin yirmi katını geçemezsiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz gelir veya kredi miktarı.");
                }
            }

            if (txtBU2.Text.Trim().Equals("Taşıt kredisi", StringComparison.OrdinalIgnoreCase))
            {
                if (decimal.TryParse(txtag.Text, out decimal gelir) && decimal.TryParse(txtKT2.Text, out decimal kredi) && kredi != 0 && kredi <= 500000)
                {
                    gelir = gelir * 10;
                    if (gelir >= kredi)
                    {
                        MessageBox.Show("Kredi talebiniz oluşturulmuştur.");
                    }
                    else
                    {
                        MessageBox.Show("Kredi talebiniz reddedilmiştir.Gelirinizin on katını geçemezsiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz gelir veya kredi miktarı.");
                }
            }

            if (txtBU2.Text.Trim().Equals("Bayram Kredisi", StringComparison.OrdinalIgnoreCase))
            {
                if (decimal.TryParse(txtag.Text, out decimal gelir) && decimal.TryParse(txtKT2.Text, out decimal kredi) && kredi != 0 && kredi <= 100000)
                {
                    gelir = gelir * 4;
                    if (gelir >= kredi)
                    {
                        MessageBox.Show("Kredi talebiniz oluşturulmuştur.");
                    }
                    else
                    {
                        MessageBox.Show("Kredi talebiniz reddedilmiştir.Gelirinizin dört katını geçemezsiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz gelir veya kredi miktarı.");
                }
            }

            if (txtBU2.Text.Trim().Equals("Evlilik kredisi", StringComparison.OrdinalIgnoreCase))
            {
                if (decimal.TryParse(txtag.Text, out decimal gelir) && decimal.TryParse(txtKT2.Text, out decimal kredi) && kredi != 0 && kredi <= 600000)
                {
                    gelir = gelir * 8;
                    if (gelir >= kredi)
                    {
                        MessageBox.Show("Kredi talebiniz oluşturulmuştur.");
                    }
                    else
                    {
                        MessageBox.Show("Kredi talebiniz reddedilmiştir.Gelirinizin sekiz katını geçemezsiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz gelir veya kredi miktarı.");
                }
            }

            if (txtBU2.Text.Trim().Equals("Öğrenci kredisi", StringComparison.OrdinalIgnoreCase))
            {

                if (decimal.TryParse(txtag.Text, out decimal gelir) && decimal.TryParse(txtKT2.Text, out decimal kredi) && kredi != 0 && kredi <= 50000)
                {
                    gelir = gelir * 2;
                    if (gelir >= kredi)
                    {
                        MessageBox.Show("Kredi talebiniz oluşturulmuştur.");
                    }
                    else
                    {
                        MessageBox.Show("Kredi talebiniz reddedilmiştir.Gelirinizin iki katını geçemezsiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz gelir veya kredi miktarı.");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunGuncelleme urungnc = new UrunGuncelleme();

            urungnc.Show();
        }

        private void txtBU2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BaşvuruSayfası geri = new BaşvuruSayfası(); //form1 i yeniden başlatıyor öyle olmaması lazım
            this.Close();
            geri.Show();
        }
    }
}
