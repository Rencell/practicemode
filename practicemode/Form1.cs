using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace practicemode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connectionString = "Server=.\\SQLEXPRESS;Database=mynigga;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=mynigga;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                string query = "SELECT username FROM users WHERE id = 1";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    string userName = (string)cmd.ExecuteScalar();

                    textBox1.Text = userName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing SQL query: {ex.Message}");
            }
        }
    }
}
