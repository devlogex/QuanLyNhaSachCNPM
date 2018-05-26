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
            LoadBookTitleIntoCombobox();
            txbTotalPrice.Text = "0";

            LoadSTT();
        }
        public void LoadSTT()
        {
            for (int i = 0; i < dtgvImportBook.RowCount; i++)
                dtgvImportBook.Rows[i].Cells["STT"].Value = i + 1;
        }
        public void LoadBookTitleIntoCombobox()
        {
            id.DataSource = BookTitleDAO.Instance.LoadListBookTitle();
            id.DisplayMember = "id";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void F_LoadAfterChosePublish(object sender, EventArgs e)
        {
            dtgvImportBook.CurrentCell.OwningRow.Cells["publishing"].Value = sender as string;
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
                DataRowView data = cbm.SelectedItem as DataRowView;
                if (data != null)
                {
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["name"].Value = data["name"].ToString();
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["author"].Value = data["author"].ToString();
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["category"].Value = data["category"].ToString();

                    FPublishing f = new FPublishing(Int32.Parse(data["id"].ToString()));
                    f.UpdateForm += F_LoadAfterChosePublish;
                    f.ShowDialog();

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

        private void btnAddImport_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}
