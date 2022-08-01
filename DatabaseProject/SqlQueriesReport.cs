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
    public partial class SqlQueriesReport : Form
    {
        private int userId;
        public SqlQueriesReport(int uid)
        {
            userId = uid;
            InitializeComponent();
            GenerateReports();
        }
        private void GenerateReports()
        {
            string ConnectionString = UserRole.StaticConnectionString;
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new
                SqlCommand(
                "select Top 1 books.name as title ,Count(orders.book_id) as most_buying  from books , orders  where books.id = orders.book_id group by books.name order by most_buying DESC"
                , cn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();


            cmd = new SqlCommand("select  name from books where not exists (select * from orders where [books].id = [orders].book_id and[orders].created_at > DATEADD(MONTH, -1, GETDATE()))",
                cn);
            dt= new DataTable();
            sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            sda.Fill(dt);
            textBox3.Text= dt.Rows[0][0].ToString();

            cmd = new SqlCommand("select distinct count([users].id) as Author_Numbers from users where [users].role_id = 2 and not exists( select[books].user_id from books , orders where[books].user_id = [users].id and[orders].book_id = [books].id and[orders].created_at > DATEADD(MONTH, -1, GETDATE()) )",
                cn);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            sda.Fill(dt);
            textBox5.Text = dt.Rows[0][0].ToString();

            cmd = new SqlCommand("select [users].name as Author_Name from users where  [users].role_id = 2 and not exists( select[books].user_id from books where [books].user_id = [users].id)",
               cn);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            cmd = new SqlCommand("select top 1  [category].name as Category_Name , count([books].category_id) as Number_OF_Books from category , books where[category].id = [books].category_id group by[category].name order by Number_OF_Books asc",
                cn);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            sda.Fill(dt);
            textBox9.Text = dt.Rows[0][0].ToString();


            cmd = new SqlCommand("select [users].name, [users].email, count([orders].user_id) as num_of_books_buy ,[roles].name as Role_Name from users, orders, roles where [users].role_id = 4 and [users].id = [orders].user_id and [roles].id = [users].role_id group by [users].name , [users].email , [roles].name",
               cn);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            cn.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
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

        private void SqlQueriesReport_Load(object sender, EventArgs e)
        {

        }
    }
}
