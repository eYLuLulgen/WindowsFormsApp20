using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BaşvuruSayfası : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-FHMTT9B\\SQLEXPRESS;Initial Catalog=practiceDb;Integrated Security = True; Encrypt = True; Trust Server Certificate = True.connectionString";

        private List<info> Data { get; set; }


        public BaşvuruSayfası()
        {
            InitializeComponent();
            Data = new List<info>();

        }

        public void TabloyuDoldur()
        {
            string connectionString = "Data Source=DESKTOP-FHMTT9B\\SQLEXPRESS;Initial Catalog=practiceDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string sqlGetData = "SELECT MusteriNO, MusteriAd, MusteriSoyad, BasvurulanUrun, KrediTutarı, KrediVadesi, TaksitTutarı, ReferansNo, BasvuruTarihi, BasvuruDurumu FROM Basvurular ORDER BY ReferansNo ASC";


            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sqlGetData, cnn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //panel2.Enabled = false;
            //button1.Enabled = false;
            //panel4.Enabled = false;
            //btnIO.Enabled = false;
            //btnD.Enabled = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnIO.Enabled = true;
            btnD.Enabled = true;


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtMNo.Text))
            {
                MessageBox.Show("Lütfen MÜŞTERİ NO giriniz");
            }
            else
            {
                SqlConnection baglanti = new SqlConnection("Data Source=desktop-fhmtt9b\\sqlexpress;Initial Catalog=practiceDb;Integrated Security=True");
                baglanti.Open();
                string sqlGetMusteriAdSoyad = "SELECT MusteriAd , MusteriSoyad FROM MusteriBilgiler WHERE MusteriNo=@mNo";
                SqlCommand cmdAdd = new SqlCommand(sqlGetMusteriAdSoyad, baglanti);
                cmdAdd.Parameters.Add("@mNo", txtMNo.Text);
                SqlDataReader reader = cmdAdd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["MusteriAd"].ToString();
                    textSurname.Text = reader["MusteriSoyad"].ToString();
                    panel2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Aradığınız Müşteri No için kayıtlı müşteri bulunamamıştır");


                }

                reader.Close();
                FillComboBasvurulanUrun();
                //TabloyuDoldur();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();


        }

        private void txtKT_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtKT.Text) || !decimal.TryParse(txtKT.Text, out decimal kreditutarı))
            {
                
                MessageBox.Show("Lütfen geçerli bir kredi tutarı giriniz.");
                return;
            }

            if (krediLimitleri.TryGetValue(comboBox1.Text.Trim(), out decimal maxLimit))
            {
                if (kreditutarı > maxLimit)
                {
                    MessageBox.Show($" Maksimum {maxLimit:C} TL'lik kredi alabilirsiniz.");
                }
            }
            else
            {

                MessageBox.Show("Lütfen geçerli bir kredi türü seçiniz.");
            }

            FillCmbKredi();
            UpdateResult();


        }


        public void FillCmbKredi()
        {

            cmbvade.Items.Clear();


            if (!string.IsNullOrEmpty(txtKT.Text) && decimal.TryParse(txtKT.Text, out decimal krrdvkıyas))
            {
                if (krrdvkıyas <= 50000)
                {
                    cmbvade.Items.AddRange(new object[] { "36", "30", "24", "12", "9", "6", "3" });
                }
                else if (krrdvkıyas <= 100000)
                {
                    cmbvade.Items.AddRange(new object[] { "24", "12", "9", "6", "3" });
                }
                else
                {
                    cmbvade.Items.AddRange(new object[] { "12", "9", "6", "3" });

                }

            }
        }

        public void UpdateResult()
        {
            if (!string.IsNullOrEmpty(txtKT.Text) && decimal.TryParse(txtKT.Text, out decimal sayi2) && sayi2 != 0)
            {
                if (cmbvade.SelectedItem != null && decimal.TryParse(cmbvade.SelectedItem.ToString(), out decimal sayi1))  
                {                  
                    if (sayi1 < sayi2)
                    {
                        decimal result = sayi2 / sayi1; //sıfır girmeme için yaz aklında bulunsun
                        result = Math.Round(result, 6);
                        txtTT.Text = result.ToString();
                        button1.Enabled = true;
                    }
                    else
                    {
                        button1.Enabled = false;
                        txtTT.Text = "Geçersiz Giriş";
                    }
                }
            }
        }

        public string randomGenerator()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=desktop-fhmtt9b\\sqlexpress;Initial Catalog=practiceDb;Integrated Security=True");
            baglanti.Open();
            int oncreferansNo = 10000;
            string query = "SELECT TOP 1 ReferansNo FROM Basvurular ORDER BY ReferansNo DESC";
            SqlCommand command = new SqlCommand(query, baglanti);

            object result = command.ExecuteScalar();

            if (result != null)
            {
                oncreferansNo = Convert.ToInt32(result);
                oncreferansNo++;
            }

            return oncreferansNo.ToString();

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Text = string.Empty;
            txtMNo.Text = string.Empty;
            txtTT.Text = string.Empty;          
            txtKT.Text = string.Empty;
            txtName.Text = string.Empty;
            textSurname.Text = string.Empty;                      
            comboBox1.SelectedIndex = -1;
            cmbvade.SelectedIndex = -1;


        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            string connectionString = "Data Source=desktop-fhmtt9b\\sqlexpress;Initial Catalog=practiceDb;Integrated Security=True";
            string sqlInsertBasvuru = "insert into BASVURULAR (MusteriNO, MusteriAd, MusteriSoyad, BasvurulanUrun, KrediTutarı, KrediVadesi, TaksitTutarı, ReferansNo, BasvuruTarihi, BasvuruDurumu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@10  ) ";



            DateTime dateTime = DateTime.Now;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();


                    SqlCommand ekle = new SqlCommand(sqlInsertBasvuru, cnn);
                    ekle.Parameters.AddWithValue("@p1", txtMNo.Text);
                    ekle.Parameters.AddWithValue("@p2", txtName.Text);
                    ekle.Parameters.AddWithValue("@p3", textSurname.Text);
                    ekle.Parameters.AddWithValue("@p4", comboBox1.Text);
                    ekle.Parameters.AddWithValue("@p5", txtKT.Text);
                    ekle.Parameters.AddWithValue("@p6", cmbvade.Text);
                    ekle.Parameters.AddWithValue("@p7", txtTT.Text);
                    ekle.Parameters.AddWithValue("@p8", randomGenerator());
                    ekle.Parameters.AddWithValue("@p9", dateTime);
                    ekle.Parameters.AddWithValue("@10", "Birinci Onay");





                    int rowsInserted = ekle.ExecuteNonQuery();
                    if (rowsInserted > 0)
                    {

                        MessageBox.Show("Kayıt veritabanına açıldı.");
                        TabloyuDoldur();

                    }
                    else
                    {
                        MessageBox.Show("Başvuru eklenemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit(); //bağlantıyı kapatmadan uygulamadan çıkmayı sağlıyor
                                // Environment.Exit(0); bağlantıyı da kapatıyor
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel4.Enabled = true;

        }

        private void FillComboBasvurulanUrun()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=desktop-fhmtt9b\\sqlexpress;Initial Catalog=practiceDb;Integrated Security=True");
            comboBox1.Items.Clear();
            baglanti.Open(); //genel bağlanamadı uyarı yapmak istiyorsak buraya yazıyoruz
            SqlCommand cmd = new SqlCommand();
            cmd = baglanti.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT BasvurulanUrun FROM BasvurulanUrunKayit"); //bayram kredisini getir demek istersek koşul için WHERE kullanırız
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable(); //bilgilerimiz için
            SqlDataAdapter da = new SqlDataAdapter(cmd); //enerjisi buradan geliyormuş gibi düşün
            da.Fill(dt);//dt yi da ile doldur demek




            foreach (DataRow dr in dt.Rows)// if ,try lara göre yavaş bir yöntem çünkü hepsini çağırıyor
            {
                comboBox1.Items.Add(dr["BasvurulanUrun"].ToString());
            }

            baglanti.Close();

        }


    



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMNo_TextChanged(object sender, EventArgs e)
        {

        }


        private void BasvuruDurumu()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string referansNo = row.Cells["ReferansNo"].Value.ToString();

            string connectionString = "Data Source=desktop-fhmtt9b\\sqlexpress;Initial Catalog=practiceDb;Integrated Security=True";
            string query = "UPDATE Basvurular SET BasvuruDurumu = @Durum WHERE ReferansNo = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Durum", "ONAY");
                    cmd.Parameters.AddWithValue("@Id", referansNo);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            TabloyuDoldur();

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnIO_Click_1(object sender, EventArgs e)
        {
            BasvuruDurumu();
        }
        private void txtMNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            Detay_Ekranı detaysyf = new Detay_Ekranı();


            detaysyf.referansno2 = dataGridView1.CurrentRow.Cells["ReferansNo"].Value.ToString();

            detaysyf.Show();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void txtTT_TextChanged(object sender, EventArgs e)
        {

        }


        private readonly Dictionary<string, decimal> krediLimitleri = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase)
         {
          { "İhtiyaç Kredisi", 200000m },
          { "Konut Kredisi", 1000000m },
          { "Taşıt Kredisi", 500000m },
          { "Bayram Kredisi", 100000m },
          { "Evlilik Kredisi", 600000m },
          { "Öğrenci Kredisi", 50000m }
         };

        private void cmbvade_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }
    }
}
/*  Select ile çekiyor
 *  read ile seçtiğini okuyor bu olmazsa execute edilen bilgi sql den bize gelmiyor
 *  74 üncü satırdakiler temel kalıp diğer yerleri de onlarla yapıyoruz*/



