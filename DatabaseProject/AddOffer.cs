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
    public partial class AddOffer : Form
    {
        string ID;
        float Discount;
        DateTime aDate = DateTime.Now;
        SqlDataReader dreader;

        private int userId;
        public AddOffer(int uid)
        {   
            userId = uid;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            ID = textBox1.Text;
            Discount = float.Parse(textBox4.Text);
            Random r = new Random();
            int offerid = r.Next(1, 1000);





            string ConnectionString = UserRole.StaticConnectionString;
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();


            // SqlCommand comm = new SqlCommand("update books set price=@Discount  where id=@ID", cn);
            SqlCommand comm = new SqlCommand("update books set price= price - ('" + Discount+"'*price)"+ "where id=" + ID + "  ", cn);


            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Offer Added..");

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }



            SqlCommand cmd = new SqlCommand("insert into offers (id,offer,book_id,created_at) values(@offerid,@Discount,@ID,@aDate)", cn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@offerid", offerid);
            cmd.Parameters.AddWithValue("@Discount", Discount);
            cmd.Parameters.AddWithValue("@aDate", aDate);

            cmd.ExecuteNonQuery();

            cn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void AddOffer_Load(object sender, EventArgs e)
        {

        }
    }
}
