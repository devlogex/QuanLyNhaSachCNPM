using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FImportBook : Form
    {
        public FImportBook()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            txbIDImportBook.Text = ImportBookDAO.Instance.GetNewIDImportBook().ToString();
            dtpk.Value = DateTime.Now;
            LoadListBookIntoCombobox();
            txbTotalPrice.Text = "0";

            LoadSTT();
        }
        public void LoadSTT()
        {
            for (int i = 0; i < dtgvImportBook.RowCount; i++)
                dtgvImportBook.Rows[i].Cells["STT"].Value = i + 1;
        }
        public void LoadListBookIntoCombobox()
        {
            id.DataSource = BookDAO.Instance.GetListBook();
            id.DisplayMember = "id";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvImportBook_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (cbm != null)
            {
                cbm.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
            }

            if(dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value!=null && dtgvImportBook.Rows[e.RowIndex].Cells["priceIn"].Value!=null)
            {
                dtgvImportBook.Rows[e.RowIndex].Cells["totalPrice"].Value = Double.Parse(dtgvImportBook.Rows[e.RowIndex].Cells["priceIn"].Value.ToString()) * Int64.Parse(dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value.ToString());
            }

            //if(dtgvImportBook.Rows[e.RowIndex].Cells["id"].Value!=null && dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value != null && dtgvImportBook.Rows[e.RowIndex].Cells["priceIn"].Value != null && dtgvImportBook.Rows[e.RowIndex].Cells["publishing"].Value != null)
            //{
            //    DataGridViewRow data = dtgvImportBook.Rows[e.RowIndex];
            //    for(int i=0;i<dtgvImportBook.RowCount-1;i++)
            //    {
            //        if(i!=e.RowIndex)
            //        {
            //            if(dtgvImportBook.Rows[i].Cells["id"].Value.ToString()==data.Cells["id"].Value.ToString() && dtgvImportBook.Rows[i].Cells["publishing"].Value.ToString()==data.Cells["publishing"].Value.ToString())
            //            {
            //                dtgvImportBook.Rows[i].Cells["count"].Value = Int64.Parse(dtgvImportBook.Rows[i].Cells["count"].Value.ToString()) + Int64.Parse(data.Cells["count"].Value.ToString());
            //                dtgvImportBook.Rows[i].Cells["priceIn"].Value =Double.Parse(data.Cells["priceIn"].Value.ToString());
            //                dtgvImportBook.Rows.Remove(data);

            //            }
            //        }
            //    }
            //}

            double totalPrice = 0.0;
            foreach(DataGridViewRow item in dtgvImportBook.Rows)
            {
                if (item.Cells["totalPrice"].Value != null)
                    totalPrice += Double.Parse(item.Cells["totalPrice"].Value.ToString());
            }
            txbTotalPrice.Text = totalPrice.ToString();
        }
        ComboBox cbm;
        DataGridViewCell currentCell;
        private void dtgvImportBook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                cbm = (ComboBox)e.Control;
                if (cbm != null)
                {
                    cbm.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
                }
                currentCell = this.dtgvImportBook.CurrentCell;
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(EndEdit));
        }
        void EndEdit()
        {
            if (cbm != null)
            {
                Book book = cbm.SelectedItem as Book;
                if (book != null)
                {
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["name"].Value = book.Name;
                    string authors = "";
                    for(int i=0;i<book.Authors.Count-1;i++)
                    {
                        authors += book.Authors[i].Name+", ";
                    }
                    if (book.Authors.Count > 0)
                        authors += book.Authors[book.Authors.Count - 1].Name;
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["author"].Value = authors;
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["category"].Value = book.Category.Name;
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["publishing"].Value ="Nhà xuất bản "+book.PublishCompany+", năm "+book.PublishYear;


                    this.dtgvImportBook.EndEdit();
                }
            }
        }

        private void dtgvImportBook_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dtgvImportBook.Rows[dtgvImportBook.RowCount - 1].Cells["STT"].Value = dtgvImportBook.RowCount;
        }
        private void dtgvImportBook_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            LoadSTT();
        }

        private void btnSaveImport_Click(object sender, EventArgs e)
        {

        }
    }
}
