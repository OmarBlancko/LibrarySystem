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

namespace DatabaseProject
{
    public partial class UploadBook : Form
    {
        private int userId;

        string id;
        string name;
        string details;
        double price;
        int quantity;
        int categoryId;
        public UploadBook(int uId)
        {
            userId = uId;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            categoryId = int.Parse(textBox10.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == String.Empty || textBox8.Text == String.Empty ||
                textBox9.Text == String.Empty || textBox10.Text == String.Empty || textBox11.Text == String.Empty) {
                MessageBox.Show("Please enter missing values");
                return;
            }
            try {
                string ConnectionString = UserRole.StaticConnectionString;
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into books(id,name,details,price,category_id,image,user_id,quantity,created_at) values (@id,@name,@details,@price,@categoryId,@image,@user_id,@quantity,@created_at)",cn);
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@details", details);
                cmd.Parameters.AddWithValue("@price",price);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.Parameters.AddWithValue("@image", "dummy");
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@quantity",quantity);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("MM/dd/yyyy"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book has been added");

            }
            catch (InvalidCastException error) { 
                MessageBox.Show(error.Message + "\n Please try again later");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            id = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            name = textBox8.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            price = Convert.ToDouble(textBox9.Text) ;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            details = textBox11.Text;
        }

        private void button2_Click(object sender, EventArgs e)
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
            else if (roleid == 3 || roleid == 4)
            {
                studentAndReaderView studentAndReaderView = new studentAndReaderView(userId);
                studentAndReaderView.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("error happened");
            }
        }

        private void UploadBook_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(textBox12.Text);
        }
    }
}
