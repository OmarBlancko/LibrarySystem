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
using DatabaseProject;
namespace DatabaseProject
{
    public partial class UpdateProfile : Form
    {
        string name, oldPass, newpass, email;
        private int userId;

        public UpdateProfile(int uId)
        {
            userId = uId;
            InitializeComponent();
            GetUserInfo();

        }

        private void GetUserInfo()
        {
            try
            {

                string ConnectionString = UserRole.StaticConnectionString;
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                SqlCommand cmd = new
                    SqlCommand(
                    "select name,email,password from users where id='" + userId + "'", cn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                textBox1.Text = dt.Rows[0][0].ToString();
                textBox8.Text = dt.Rows[0][1].ToString();
                oldPass = dt.Rows[0][2].ToString();
                cn.Close();
            }
            catch (InvalidCastException error)
            {

                MessageBox.Show(error.Message);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int roleid = UserRole.GetUserRole(userId);
            if (roleid == 1)
            {
                adminView adminView = new adminView(userId);
                adminView.Show(this);
                Hide();
            }
            else if (roleid == 2)
            {
                authorView authorView = new authorView(userId);
                authorView.Show(this);
                Hide();
            }
            else if (roleid == 3 || roleid == 4) { 
            studentAndReaderView studentAndReaderView = new studentAndReaderView(userId);   
                studentAndReaderView.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("error happened");
            }
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            newpass = textBox7.Text;
            email = textBox8.Text;

            if (textBox7.Text == string.Empty || textBox8.Text == string.Empty || textBox1.Text == string.Empty || textBox6.Text == string.Empty)
            {
                MessageBox.Show("Enter full information please");
                return;
            }
            if (textBox6.Text != oldPass) {
                MessageBox.Show("Old password doesn't match");
                return;
            }
            if (textBox7.Text.Length < 6) {
                MessageBox.Show("Enter strong password");
                return;
            }
            try
            {
                    string ConnectionString = UserRole.StaticConnectionString;
                    SqlConnection cn = new SqlConnection(ConnectionString);
                    cn.Open();
                    SqlCommand comm = new SqlCommand("update users set password= '" + textBox7.Text + "' , name ='"+ textBox1.Text +"' where id ='" + userId + "'", cn);

                    comm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Updated..");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
