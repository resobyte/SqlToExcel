using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SqlToExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Database_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=RESOBIT;Database=bizcom;Integrated Security = True");
            SqlCommand command = new SqlCommand("SELECT * FROM Report",conn);
            //            SqlDataAdapter adp = new SqlDataAdapter(command);
            //
            //            DataTable dtable = new DataTable();
            //
            //            adp.Fill(dtable);
            //
            //            Data.DataSource = dtable;
            int sayac = 0;
            conn.Open();
            SqlDataReader dr_sayac = command.ExecuteReader();
            while (dr_sayac.Read())
            {
                sayac++;
            }

            conn.Close();
            conn.Open();
            
            int i= 0;

            SqlDataReader dr = command.ExecuteReader();

          
            string [] Description = new string[sayac];
            string[] Title = new string[sayac];
            string[] Status= new string[sayac];
            string[] Status_Description = new string[sayac];



            while (dr.Read())
            {
               Description[i] = dr["Description"].ToString();
               Title[i] = dr["Title"].ToString();
               Status[i] = dr["Status"].ToString();
               Status_Description[i] = dr["Status_Description"].ToString();

               i++;
            }



        }
    }
}
