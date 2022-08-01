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
    public partial class studentAndReaderView : Form
    {
        private int userId;
        public studentAndReaderView(int uId)
        {
            userId = uId;
            InitializeComponent();
            Debug.WriteLine(userId);

        }
        UpdateProfile updateProfile;
        ListOfBooksView listOfBooksView;

        private void button1_Click(object sender, EventArgs e)
        {
                updateProfile = new UpdateProfile(userId);
                updateProfile.Show(this);
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                listOfBooksView = new ListOfBooksView(userId);
                listOfBooksView.Show(this);
            Hide();

        }

        private void studentAndReaderView_Load(object sender, EventArgs e)
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

