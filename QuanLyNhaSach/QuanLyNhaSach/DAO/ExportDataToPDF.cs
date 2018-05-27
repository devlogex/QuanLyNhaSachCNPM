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

        //public bool ExportDTGVToPdf(DataGridView ExDataTable,string name) 
        //{
        //    //Here set page size as A4

        //    Document pdfDoc = new Document(PageSize.A4,10,10,10,10);
        //    FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write, FileShare.None);
        //    try
        //    {
        //        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
        //        pdfDoc.Open();

        //        //Set Font Properties for PDF File
        //        Font fnt = FontFactory.GetFont("Times New Roman", 10);
        //        DataGridView dt = ExDataTable;

        //        if (dt != null)
        //        {

        //            PdfPTable PdfTable = new PdfPTable(dt.Columns.Count);
        //            PdfPCell PdfPCell = null;

        //            //Here we create PDF file tables

        //            for (int rows = 0; rows < dt.Rows.Count; rows++)
        //            {
        //                if (rows == 0)
        //                {
        //                    for (int column = 0; column < dt.Columns.Count; column++)
        //                    {
        //                        PdfPCell = new PdfPCell(new Phrase(new Chunk(dt.Columns[column].HeaderText, fnt)));
        //                        PdfTable.AddCell(PdfPCell);
        //                    }
        //                }
        //                for (int column = 0; column < dt.Columns.Count; column++)
        //                {
        //                    if (dt.Rows[rows].Cells[column] != null)
        //                        PdfPCell = new PdfPCell(new Phrase(new Chunk(dt.Rows[rows].Cells[column].Value.ToString(), fnt)));
        //                    else
        //                        PdfPCell = new PdfPCell(new Phrase(""));
        //                    PdfTable.AddCell(PdfPCell);
        //                }
        //            }

        //            // Finally Add pdf table to the document 
        //            pdfDoc.Add(PdfTable);
        //        }

        //        pdfDoc.Close();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
    
        }
    }
}
