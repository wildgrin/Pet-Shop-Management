using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Pet_Shop_Management
{
    public partial class ProductModule : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        ProductForm productForm;

        string title = "Pet Shop Management";
        bool check;

        public ProductModule(ProductForm _productForm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            productForm = _productForm;
            cbCategory.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to register this product?", "Product Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("INSERT INTO tbProduct(pname, ptype, pcategory, pqty, pprice) VALUES(@pname, @ptype, @pcategory, @pqty, @pprice)", cn);
                        cm.Parameters.AddWithValue("@pname", txtName.Text);
                        cm.Parameters.AddWithValue("@ptype", txtType.Text);
                        cm.Parameters.AddWithValue("@pcategory", cbCategory.Text);
                        cm.Parameters.AddWithValue("@pqty", int.Parse(txtQty.Text));
                        cm.Parameters.AddWithValue("@pprice", double.Parse(txtPrice.Text));
                        MessageBox.Show("Product has been registered successfully!", title);

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Product has been registered successfully!", title);
                        
                        productForm.LoadProduct();
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to update this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("UPDATE tbProduct SET pname=@pname, ptype=@ptype, pcategory=@pcategory, pqty=@pqty, pprice=@pprice WHERE pcode=@pcode", cn);
                        cm.Parameters.AddWithValue("@pcode", lblPcode.Text);
                        cm.Parameters.AddWithValue("@pname", txtName.Text);
                        cm.Parameters.AddWithValue("@ptype", txtType.Text);
                        cm.Parameters.AddWithValue("@pcategory", cbCategory.Text);
                        cm.Parameters.AddWithValue("@pqty", txtQty.Text);
                        cm.Parameters.AddWithValue("@pprice", txtPrice.Text);

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Product's data has been successfully updated!", title);

                        productForm.LoadProduct();
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow int character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow int character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > .1))
            {
                e.Handled = true;
            }
        }

        #region Methods

        /// <summary>
        /// Required fields check
        /// </summary>
        public void CheckField()
        {
            if (txtName.Text == "" || txtPrice.Text == "" || txtQty.Text == "" || txtType.Text == "")
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }
            check = true;
        }

        /// <summary>
        /// Clearing all fields Method
        /// </summary>
        public void Clear()
        {
            txtName.Clear();
            txtType.Clear();
            cbCategory.SelectedIndex = 0;
            txtQty.Clear();
            txtPrice.Clear();

            btnUpdate.Enabled = false;
        }


        #endregion
    }
}
