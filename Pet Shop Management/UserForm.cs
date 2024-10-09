using System.Data.SqlClient;

namespace Pet_Shop_Management
{
    public partial class UserForm : Form
    {
        SqlConnection cn;
        SqlCommand? cm;
        SqlDataReader? dr;
        DbConnect dbcon = new DbConnect();
        string title = "Pet Shop Management";

        public UserForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            LoadUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModule module = new UserModule(this);
            module.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                UserModule userModule = new UserModule(this);
                userModule.lbluid.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtName.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtAddress.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPhone.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.cbRole.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                userModule.dtDob.Text = dgvUser.Rows[e.RowIndex].Cells[6].Value.ToString();
                userModule.txtPass.Text = dgvUser.Rows[e.RowIndex].Cells[7].Value.ToString();

                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete from tbUser where id LIKE @userId", cn);
                    cm.Parameters.AddWithValue("@userId", dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("User data has been successfully erased.", title, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            LoadUser();
        }

        #region Method
        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser WHERE CONCAT(name, address, phone, role, dob) LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(
                    i,
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    DateTime.TryParse(dr[5].ToString(), out DateTime parsedDate) ? parsedDate.ToShortDateString() : null,
                    dr[6].ToString()
                );
            }
            dr.Close();
            cn.Close();
        }
        #endregion        
    }
}
