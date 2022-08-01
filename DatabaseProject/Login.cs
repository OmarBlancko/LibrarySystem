using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Login : Form
    {
        string email;
        string password;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            password = textBox6.Text;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            email = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty  || textBox6.Text == String.Empty)
            {
                MessageBox.Show("Please fill data");
                return;
            }
            try
            {

                string ConnectionString = UserRole.StaticConnectionString;
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                SqlCommand cmd = new
                    SqlCommand("select count(*) , role_id ,id, password FROM users where email ='" +textBox1.Text+"' AND password ='" +textBox6.Text+ "'Group by id,password,role_id", cn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0) {
                    if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                    {
                        adminView adminView = new adminView(Convert.ToInt32(dt.Rows[0][2]));
                        adminView.Show(this);
                        Hide();
                    }
                    else if (Convert.ToInt32(dt.Rows[0][1]) == 2)
                    {
                        authorView authorView = new authorView(Convert.ToInt32(dt.Rows[0][2]));
                        authorView.Show(this);
                        Hide();
                    }
              
                    else if (Convert.ToInt32(dt.Rows[0][1]) == 3 || Convert.ToInt32(dt.Rows[0][1]) == 4)
                    {
                        studentAndReaderView studentAndReaderView = new studentAndReaderView(Convert.ToInt32(dt.Rows[0][2]));
                        studentAndReaderView.Show(this);
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("invalid email or password");
                }
                cn.Close();
            }
            catch (InvalidCastException error) {
                Debug.WriteLine(error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show(this);
            Hide();
        }
    }
}
