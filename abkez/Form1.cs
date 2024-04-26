using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace abkez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Server=(localdb)\MSSQLLocalDB; Database=autokak";
            SqlConnection kapcs = new SqlConnection(con);
            kapcs.Open();
            string querry = "SELECT * FROM auto";
            SqlCommand parancs = new SqlCommand(querry, kapcs);
            SqlDataReader lekerdezes = parancs.ExecuteReader();
            while (lekerdezes.Read())
            {
                DGV.Rows.Add(lekerdezes[0], lekerdezes[1], lekerdezes[2], lekerdezes[3], lekerdezes[4]);
            }
            kapcs.Close();
            kapcs.Open();
            querry = "SELECT AVG(ar) FROM auto;";
            parancs = new SqlCommand(querry, kapcs);
            lekerdezes = parancs.ExecuteReader();
            lekerdezes.Read();
            atlag.Text = lekerdezes[0].ToString();
            kapcs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
