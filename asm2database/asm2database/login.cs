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

namespace asm2database
{
    public partial class login : Form
    {
        SqlConnection conn;
        public login()
        {

            InitializeComponent();

            conn = new SqlConnection("server = DESKTOP-HPP1IIU\\MSSQLSERVER01; database = LibraryManagement1; integrated security = true");
        }

        
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
         }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            string querry = "select * from Accounts where username = @username and user_password = @password";
            conn.Open();
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@Username"].Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["user_role"].ToString();
                if (role.Equals("admin"))
                {
                    MessageBox.Show(this, "Login success", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    manager admin = new manager(username);
                    admin.ShowDialog();
                    this.Dispose();
                }
                if (role.Equals("borrower"))
                {
                    MessageBox.Show(this, "Login success", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    user borrower = new user(username);
                    borrower.ShowDialog();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            conn.Close();



        }
    }
}
