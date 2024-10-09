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

namespace Pet_Shop_Management
{
    public partial class ProductForm : Form
    {
        SqlConnection cn;
        SqlCommand? cm;
        SqlDataReader? dr;
        DbConnect dbcon = new DbConnect();
        string title = "Pet Shop Management";

        public ProductForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            LoadProduct();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule module = new ProductModule(this);
            module.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModule productModule = new ProductModule(this);
                productModule.lblPcode.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.txtName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.txtType.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.cbCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.txtQty.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModule.btnSave.Enabled = false;
                productModule.btnUpdate.Enabled = true;
                productModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    dbcon.ExecuteQuery("Delete from tbProduct where pcode LIKE @productId");
                    cm.Parameters.AddWithValue("@productId", dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                    MessageBox.Show("Product data has been successfully erased.", title, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            LoadProduct();
        }

        #region Methods
        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname, ptype, pcategory) LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(
                    i,
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString()
                );
            }
            dr.Close();
            cn.Close();
        }
        #endregion

    }
}
