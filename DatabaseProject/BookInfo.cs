using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace DatabaseProject
{
    public partial class BookInfo : Form
    {
        private int bookId;
        private int userId;
        private double amount;
        public BookInfo(int bID, int uId, double am)
        {
            bookId = bID;
            userId = uId;
            amount = am;
            Debug.WriteLine(bookId);
            InitializeComponent();
            setBookDetails();
        }
        private void setBookDetails() {
            textBox13.Text = bookId.ToString();
            try {
                string ConnectionString = "Data Source=DESKTOP-BQ2IPJO;Initial Catalog=temp;Integrated Security=True";
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                SqlCommand cmd = new
                    SqlCommand(
                    "select [books].name,[books].details , [books].price ,[books].category_id , [books].quantity ,[category].name FROM category, books where books.[id]=" + bookId + " AND [books].category_id =[category].id",cn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                textBox7.Text = dt.Rows[0][0].ToString();
                textBox1.Text=dt.Rows[0][5].ToString();
                textBox11.Text = dt.Rows[0][1].ToString();
                textBox4.Text = dt.Rows[0][2].ToString();
                textBox9.Text =dt.Rows[0][4].ToString();
                cn.Close();
            }
            catch(InvalidCastException error)
            {

                MessageBox.Show(error.Message);
            }


        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox13_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int commentId = rnd.Next(1, 10000);
            try
            {
                string ConnectionString = UserRole.StaticConnectionString;
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                SqlCommand cmd = new
                    SqlCommand("insert into comments (id,body,book_id,user_id,created_at) values(@id,@body,@book_id,@user_id,@created_at)", cn);
                cmd.Parameters.AddWithValue("@id", commentId);
                cmd.Parameters.AddWithValue("@body", textBox12.Text);
                cmd.Parameters.AddWithValue("@book_id", bookId);
                cmd.Parameters.AddWithValue("@user_id", 2);
                cmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString("MM/dd/yyyy"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Comment send successfully");
                cn.Close();
            }
            catch (InvalidCastException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int orderId = rnd.Next(1, 10000);
            try
            {
                string ConnectionString = UserRole.StaticConnectionString;
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(" insert into orders(id,user_id,book_id,amount,created_at) values(@id,@user_id,@book_id,@amount,@created_at) ",cn);
                cmd.Parameters.AddWithValue("@id",orderId);
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@book_id", bookId);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("MM/dd/yyyy"));
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update books set quantity=quantity-1 where id='"+bookId+"'",cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("order has been initialized");
                cn.Close();
            }
            catch (InvalidCastException error) {
                MessageBox.Show(error.Message);
            }
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
