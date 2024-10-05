using System.Data.SqlClient;

namespace Pet_Shop_Management
{
    public partial class UserForm : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DbConnect dbcon = new DbConnect();
        string title = "Pet Shop Management";

        public UserForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModule module = new UserModule(this);
            module.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        #region Method
        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("Select * from tbUser where CONCAT (name, address, phone, role, dob) LIKE '%" + txtSearch.Text + "%'",cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }
        #endregion
    }
}
