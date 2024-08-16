using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UrunGuncelleme : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-FHMTT9B\\SQLEXPRESS;Initial Catalog=practiceDb;Integrated Security = True; Encrypt = True; Trust Server Certificate = True.connectionString";

        private List<info> Data { get; set; }
        public UrunGuncelleme()
        {
            InitializeComponent();
            Data = new List<info>();
        }
        private void kreditutarbilgi()
        {
            FillComboBasvurulanUrun();
        }
        private void FillComboBasvurulanUrun()      //comboboxtaki kredileri çekiyor
        {
            SqlConnection baglanti = new SqlConnection("Data Source=desktop-fhmtt9b\\sqlexpress;Initial Catalog=practiceDb;Integrated Security=True");
            cmbkrediTuru.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = baglanti.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT BasvurulanUrun FROM BasvurulanUrunKayit");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {
                cmbkrediTuru.Items.Add(dr["BasvurulanUrun"].ToString());
            }

            baglanti.Close();

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UrunGuncelleme_Load(object sender, EventArgs e)
        {
            FillComboBasvurulanUrun();
            kreditutarbilgi();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtlimit1_TextChanged(object sender, EventArgs e)
        {
            kreditutarbilgi();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
