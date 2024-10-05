using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pet_Shop_Management
{
    public partial class UserModule : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        string title = "Pet Shop Management";
        UserForm userForm;

        public UserModule(UserForm _userForm)
        {
            InitializeComponent();
            cn  = new SqlConnection(dbcon.Connection());
            userForm = _userForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to register this user?", "User Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question )== DialogResult.Yes);
                cm = new SqlCommand("INSERT INTO tbUser(name, address, phone, role, dob, password) VALUES(@name, @address, @phone, @role, @dob, @password)", cn);
                cm.Parameters.AddWithValue("@name", txtName.Text);
                cm.Parameters.AddWithValue("@address", txtAddress.Text);
                cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                cm.Parameters.AddWithValue("@role", cbRole.Text);
                cm.Parameters.AddWithValue("@dob", dtDob.Value);
                cm.Parameters.AddWithValue("@password", txtPass.Text);

                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("User has been registered successfully!", title);

                userForm.LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,title);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
