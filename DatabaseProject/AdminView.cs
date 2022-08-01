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
namespace DatabaseProject
{
    public partial class adminView : Form
    {
        UpdateProfile updateProfile;
        UploadBook uploadBook;
        ListOfBooksView listOfBooksView;
        SalesReport salesReport;
        AddOffer addOffer;
        private int userId;
        public adminView(int   uid)
        {
            userId = uid;
            Debug.WriteLine(userId);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // update profile
        {
             
            updateProfile = new UpdateProfile(userId);
          
                updateProfile.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                uploadBook = new UploadBook(userId);
            
                uploadBook.Show(this);
            Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
                listOfBooksView = new ListOfBooksView(userId);
               listOfBooksView.Show(this);
            Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            salesReport = new SalesReport(userId);
            salesReport.Show(this);
            Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addOffer = new AddOffer(userId);
                addOffer.Show(this);
            Hide();
        }

        private void adminView_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show(this);
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlQueriesReport sqlQueriesReport = new SqlQueriesReport(userId);
            sqlQueriesReport.Show(this);
            Hide();
        }
    }
}
