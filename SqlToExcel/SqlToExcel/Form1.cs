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
using Microsoft.Office.Interop.Excel;

namespace SqlToExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Microsoft.Office.Interop.Excel.Application excelDosyam;
        Microsoft.Office.Interop.Excel.Workbook excelKitabim;
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

            excelDosyam = new Microsoft.Office.Interop.Excel.Application();
            excelDosyam.Visible = true;

            object sayfa = true;
            excelKitabim = excelDosyam.Workbooks.Add(sayfa);
            object multiSayfa = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Worksheet Tablo;
            Tablo = (Worksheet)excelDosyam.ActiveSheet;
            excelDosyam.Worksheets.Add(multiSayfa, Tablo, 1, multiSayfa);

            Microsoft.Office.Interop.Excel.Worksheet excelSayfam;

            excelSayfam = (Worksheet)excelDosyam.Application.Sheets[1];

           
            object hangiSayfaAktif = 1;
            excelSayfam.Select(hangiSayfaAktif);

            

            for (int j = 0; j < sayac; j++)
            {
                excelSayfam.Cells[j + 1 ,4] = Description[j];
                excelSayfam.Cells[j+2, 4] = Title[j];
                excelSayfam.Cells[j+3, 4] = Status[j];
                excelSayfam.Cells[j+4, 4] = Status_Description[j];


            }


//            excelKitabim.SaveAs(@"c:\SahinExcel.xls",
//            Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, Type.Missing, Type.Missing,
//            false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
//            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);



        }
    }
}
