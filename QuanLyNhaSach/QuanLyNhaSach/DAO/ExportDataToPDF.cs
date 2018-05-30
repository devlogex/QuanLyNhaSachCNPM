using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLyNhaSach.DAO
{
    public class ExportDataToPDF
    {
        private static ExportDataToPDF instance;

        public static ExportDataToPDF Instance
        {
            get { if (instance == null) instance = new ExportDataToPDF(); return instance; }
            set => instance = value;
        }
        private ExportDataToPDF() { }

        //public bool EDTGVToPdf(DataGridView dtgv, string name)
        //{

        //        BaseFont font = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
        //        PdfPTable table = new PdfPTable(dtgv.ColumnCount);
        //        table.DefaultCell.Padding = 3;
        //        table.WidthPercentage = 100;
        //        table.HorizontalAlignment = Element.ALIGN_LEFT;
        //        table.DefaultCell.BorderWidth = 1;

        //        Font text = new Font(font, 10, Font.NORMAL);
        //        foreach (DataGridViewColumn item in dtgv.Columns)
        //        {
        //            PdfPCell cell = new PdfPCell(new Phrase(item.Name, text));
        //            cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
        //            table.AddCell(cell);
        //        }

        //        foreach (DataGridViewRow row in dtgv.Rows)
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //            {
        //                if(cell.Value!=null)
        //                    table.AddCell(new Phrase(cell.Value.ToString(), text));
        //                else
        //                table.AddCell(new Phrase("", text));
        //        }
        //    }

        //        using (FileStream stream = new FileStream(name, FileMode.Create))
        //        {
        //            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
        //            PdfWriter.GetInstance(pdfDoc, stream);
        //            pdfDoc.Open();
        //            pdfDoc.Add(table);
        //            pdfDoc.Close();
        //            stream.Close();
        //        }
        //        return true;
        //}
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public PdfPTable GetTable(DataGridView dtgv )
        {

            BaseFont font = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable table = new PdfPTable(dtgv.ColumnCount);
            table.DefaultCell.Padding = 3;
            table.WidthPercentage = 100;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.DefaultCell.BorderWidth = 1;

            Font text = new Font(font, 10, Font.NORMAL);
            foreach (DataGridViewColumn item in dtgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(convertToUnSign3(item.HeaderText), text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                table.AddCell(cell);
            }

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                        table.AddCell(new Phrase(convertToUnSign3(cell.Value.ToString()), text));
                    else
                        table.AddCell(new Phrase("", text));
                }
            }
            return table;
        }
        public Phrase GetPhrase(string data)
        {
            Font text = FontFactory.GetFont(BaseFont.HELVETICA, "Cp1254", BaseFont.NOT_EMBEDDED, 12, Font.NORMAL, BaseColor.BLACK);

            Phrase phrase = new Phrase(convertToUnSign3(data), text);
            return phrase;
        }
        public Phrase GetPhraseHeader(string data)
        {
            Font text = FontFactory.GetFont(BaseFont.HELVETICA, "Cp1254", BaseFont.EMBEDDED, 24, Font.BOLD, BaseColor.GRAY);

            Phrase phrase = new Phrase(convertToUnSign3(data), text);
            return phrase;
        }
        public bool ExportDataToPdf(string name,List<Phrase> datas, PdfPTable table=null)
        {
            using (FileStream stream = new FileStream(name, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 30f, 30f, 30f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                foreach (Phrase item in datas)
                    pdfDoc.Add(item);
                if(table!=null)
                    pdfDoc.Add(table);
                pdfDoc.Close();
                stream.Close();
            }
            return true;
        }
    }
}