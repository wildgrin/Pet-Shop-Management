using System.Data.SqlClient;

namespace Pet_Shop_Management
{
    class DbConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm;
        private string con;


        public string Connection()
        {

            con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anshu\source\repos\Pet Shop Management\Pet Shop Management\dbPetShop.mdf"";Integrated Security=True";
            return con;
        }

        public void ExecuteQuery(string sql)
        {
            try
            {
                cn.ConnectionString = Connection();
                cn.Open();
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
