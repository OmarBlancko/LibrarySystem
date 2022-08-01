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
    public partial class ListOfBooksView : Form
    {
        int userId;
        public ListOfBooksView(int uId)
        {
              userId = uId;
            InitializeComponent();
            GenerateBooksList();
        }
        int bookId;
        double amount;
        private void GenerateBooksList() {
            string ConnectionString = UserRole.StaticConnectionString;
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new
                SqlCommand
                ("SELECT [books].id,[books].name , [books].details ,[books].price, [books].quantity , [users].name as Auhtor_name , [category].name as Category_Name FROM books , users , category where [books].quantity > 0 AND [users].id = [books].user_id AND [category].id =[books].category_id", cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            this.dataGridView1.Show();
            dataGridView1.DataSource = dt;


        }

        private void ListOfBooksView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bookId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            amount =Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[3].Value);
            BookInfo bookInfo = new BookInfo(bookId,userId,amount);
            bookInfo.ShowDialog();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
/*
 * ListView listView = new ListView();
            listView.Bounds = new Rectangle(new Point(10,10),new Size(300,200));*/