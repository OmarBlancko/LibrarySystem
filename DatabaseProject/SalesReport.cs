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
    public partial class SalesReport : Form
    {
        private int userId;
        public SalesReport(int uid)
        {
            InitializeComponent();
            userId = uid;
            GenerateSalesReport();


        }
        void GenerateSalesReport()
        {

            try
            {
                string ConnectionString = UserRole.StaticConnectionString;
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                SqlCommand cmd = new
                    SqlCommand
                    ("SELECT id as order_id ,book_id,amount,created_at from orders", cn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception error) { 
            
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
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
    }
}
