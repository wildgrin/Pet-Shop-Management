using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pet_Shop_Management
{
    public partial class UserModule : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        UserForm userForm;

        string title = "Pet Shop Management";
        bool check;

        public UserModule(UserForm _userForm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            userForm = _userForm;
            cbRole.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to register this user?", "User Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
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
                    if (MessageBox.Show("Are you sure you want to update this user?", "Update User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                    cm = new SqlCommand("UPDATE tbUser SET name=@name, address=@address, phone=@phone, role=@role, dob=@dob, password=@password WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@id", lbluid.Text);
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@role", cbRole.Text);
                    cm.Parameters.AddWithValue("@dob", dtDob.Value);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("User's data has been successfully updated!", title);

                    userForm.LoadUser();
                    this.Dispose();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.Text == "Employee")
            {
                this.Height = 514 - 30;
                lblPass.Visible = false;
                txtPass.Visible = false;
            }
            else
            {
                lblPass.Visible = true;
                txtPass.Visible = true;
                this.Height = 514;
            }
        }

        #region Methods

        /// <summary>
        /// Clearing all fields Method
        /// </summary>
        public void Clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPass.Clear();
            txtPhone.Clear();
            cbRole.SelectedIndex = 0;
            dtDob.Value = DateTime.Now;

            btnUpdate.Enabled = false;
        }

        /// <summary>
        /// Required fields check in User Module
        /// </summary>
        public void CheckField()
        {
            if (txtName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }
            if (CheckAge(dtDob.Value) < 18)
            {
                MessageBox.Show("User is a child worker! Age under 18.", "Warning");
                return;
            }
            check = true;
        }

        /// <summary>
        /// Calculate Age of the user
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <returns></returns>
        public static int CheckAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                age -= 1;
            }
            return age;
        }

        #endregion
    }
}
