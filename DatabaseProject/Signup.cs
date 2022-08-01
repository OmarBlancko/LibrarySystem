namespace DatabaseProject
{
    using System.Data.SqlClient;
    using ConnectionClass;
    public partial class Signup : Form
    {
        studentAndReaderView studentAndReaderView;
        adminView adminView;
        authorView authorView;
        string name;
        string email;
        string password;
        int roleId;
  
        public Signup()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int userId = r.Next(1, 1000);
            if (textBox1.Text == String.Empty || textBox4.Text == String.Empty  || textBox6.Text == String.Empty)
            {
                MessageBox.Show("Please fill data");
                return;
            }
            if (password.Length < 5)
            {
                MessageBox.Show("Enter strong password");
                return;
            }
            try
            {
                string ConnectionString = UserRole.StaticConnectionString;
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();
                SqlCommand cmd = new
                    SqlCommand("insert into users(id,name,email,password,role_id,created_at)  values (@userId,@name,@email,@password,@roleId,@created_at)", cn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@roleId", roleId);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("MM/dd/yyyy"));
                cmd.ExecuteNonQuery();
                if (roleId == 1)

                {
                    adminView = new adminView(userId);
                    adminView.Show(this);
                    Hide();
                }
                else if (roleId == 2)

                {
                    authorView = new authorView(userId);
                    authorView.Show(this);
                    Hide();
                }
                else { 
                studentAndReaderView = new studentAndReaderView(userId);
                    studentAndReaderView.Show(this);
                    Hide();
                }

            }
            catch (InvalidCastException error)
            {
                MessageBox.Show("Some error happened try again");

            }
            MessageBox.Show("signed up succesfully");

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            email= textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                roleId = 3;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                roleId = 4;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                roleId =2;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            password = textBox6.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show(this);
            Hide();
        }
    }
}