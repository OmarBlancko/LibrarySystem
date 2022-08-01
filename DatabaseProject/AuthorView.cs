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
    public partial class authorView : Form
    {
        private  int userId;
        public authorView(int uid)
        {
            InitializeComponent();
            userId = uid;
            Debug.WriteLine(userId);

        }
        UpdateProfile updateProfile;
        UploadBook uploadBook;
        ListOfBooksView listOfBooksView;
        private void button1_Click(object sender, EventArgs e)
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

        private void authorView_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show(this);
            Hide();
        }
    }
}
