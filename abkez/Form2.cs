using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace abkez
{
    public partial class Form2 : Form
    {
        string con = @"Server=(localdb)\MSSQLLocalDB; Database=autokak";
        SqlConnection kapcsolat;
        string utasitas;
        SqlCommand parancs;
        SqlDataReader lekerdezes;

        private void betolt()
        {
            DGV.Rows.Clear();
            kapcsolat = new SqlConnection(con);
            kapcsolat.Open();
            utasitas = "SELECT * FROM auto";
            parancs = new SqlCommand(utasitas, kapcsolat);
            lekerdezes = parancs.ExecuteReader();
            while (lekerdezes.Read())
            {
                DGV.Rows.Add(lekerdezes[0], lekerdezes[1], lekerdezes[2], lekerdezes[3], lekerdezes[4]);
            }
            kapcsolat.Close();
        }

        public Form2()
        {
            InitializeComponent();
            betolt();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tb_tulkeres_TextChanged(object sender, EventArgs e)
        {
            if (tb_tulkeres.TextLength > 0)
            {
                utasitas = $"SELECT * FROM auto where tulajdonos LIKE '%" + tb_tulkeres.Text + "%'";
                DGV.Rows.Clear();
                kapcsolat.Open();
                parancs = new SqlCommand(utasitas, kapcsolat);
                lekerdezes = parancs.ExecuteReader();
                while (lekerdezes.Read())
                {
                    DGV.Rows.Add(lekerdezes[0], lekerdezes[1], lekerdezes[2], lekerdezes[3], lekerdezes[4]);
                }
                kapcsolat.Close();
            }
            else
            {
                DGV.Rows.Clear();
                kapcsolat = new SqlConnection(con);
                kapcsolat.Open();
                utasitas = "SELECT * FROM auto";
                parancs = new SqlCommand(utasitas, kapcsolat);
                lekerdezes = parancs.ExecuteReader();
                while (lekerdezes.Read())
                {
                    DGV.Rows.Add(lekerdezes[0], lekerdezes[1], lekerdezes[2], lekerdezes[3], lekerdezes[4]);
                }
                kapcsolat.Close();
            }
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            if (tb_rszam.TextLength>0&&tb_tipus.TextLength>0&&tb_tulaj.TextLength>0&&tb_ar.TextLength>0) 
            {
                kapcsolat.Open();
                utasitas = $"INSERT INTO auto(rendszam,tipus,tulajdonos,ar) values('{tb_rszam.Text}','{tb_tipus.Text}','{tb_tulaj.Text}','{tb_ar.Text}')";
                parancs = new SqlCommand (utasitas, kapcsolat);
                parancs.ExecuteReader();
                kapcsolat.Close() ;
            }
        }
    }
}
