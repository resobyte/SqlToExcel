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
        Microsoft.Office.Interop.Excel.Worksheet xlSayfa;
        Microsoft.Office.Interop.Excel.Workbook excelKitabim;
        Microsoft.Office.Interop.Excel.Range range;

        private void Database_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=RESOBIT;Database=bizcom;Integrated Security = True");
            SqlCommand command = new SqlCommand("SELECT * FROM Report", conn);
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

            int i = 0;

            SqlDataReader dr = command.ExecuteReader();


            string[] Description = new string[sayac];
            string[] Title = new string[sayac];
            string[] Status = new string[sayac];
            string[] Status_Description = new string[sayac];
            string [] date = new string[sayac];


            while (dr.Read())
            {
                Description[i] = dr["Description"].ToString();
                Title[i] = dr["Title"].ToString();
                Status[i] = dr["Status"].ToString();
                Status_Description[i] = dr["Status_Description"].ToString();
                date[i] = dr["Date"].ToString();

                i++;
            }

            excelDosyam = new Microsoft.Office.Interop.Excel.Application();
            excelDosyam.Visible = true;

            object sayfa = true;
            excelKitabim = excelDosyam.Workbooks.Add(sayfa);
            object multiSayfa = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Worksheet Tablo;
            Tablo = (Worksheet) excelDosyam.ActiveSheet;
            excelDosyam.Worksheets.Add(multiSayfa, Tablo, 1, multiSayfa);

            Microsoft.Office.Interop.Excel.Worksheet excelSayfam;

            excelSayfam = (Worksheet) excelDosyam.Application.Sheets[1];


            object hangiSayfaAktif = 1;
            excelSayfam.Select(hangiSayfaAktif);

            int k = 1;


            




            for (int j = 0; j < sayac; j++)
            {
                range = excelSayfam.get_Range("a" + k, "a" + (k + 3));
                range.Interior.Color = Microsoft.Office.Interop.Excel.XlRgbColor.rgbGrey;

                excelSayfam.Cells[k, 2] = "Servis";
                excelSayfam.Cells[k + 1, 2] = "Aktiviteler";
            

                excelSayfam.Cells[k, 3] = "Nw-Slv-" + (j + 1);
                excelSayfam.Cells[k + 1, 3] = "Konu";
                excelSayfam.Cells[k + 2, 3] = "Durum";
                excelSayfam.Cells[k + 3, 3] = "Açıklama";

                excelSayfam.Cells[k, 4] = Description[j];
                excelSayfam.Cells[k + 1, 4] = Title[j];
                excelSayfam.Cells[k + 2, 4] = Status[j];
                excelSayfam.Cells[k + 3, 4] = Status_Description[j];

                excelSayfam.Cells[k + 2, 5] = "Tarih";
                excelSayfam.Cells[k + 3, 5] = date[j];

                k += 4;
            }


//            range = excelSayfam.get_Range("a1", "a5");
//            range.Interior.Color = Microsoft.Office.Interop.Excel.XlRgbColor.rgbAqua;
//            range.Font.Size = 20;
//            range.Font.Color= Microsoft.Office.Interop.Excel.XlRgbColor.rgbPink;
//            excelSayfam.Cells[1, 2] = "BU HUCRE RENKLI";


            //            excelKitabim.SaveAs(@"c:\resobit.xls",
            //            Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, Type.Missing, Type.Missing,
            //            false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            //            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}