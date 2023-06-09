using System.Data.SqlClient;
using System;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            string connetionString = null;


            SqlConnection connection;
            SqlCommand command;

            SqlDataReader dataReader;
            connetionString = "Data Source=SG-SMAUG\\SQLEXPRESS;Initial Catalog=Login_conference;Integrated Security=True";

            connection = new SqlConnection(connetionString);
            try
            {

                connection.Open();
                command = new SqlCommand("select * from dbo.login where username ='" + textBox1.Text + "' and password ='" + textBox2.Text + "'", connection);
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    user_id.userid = int.Parse(dataReader["user_id"].ToString());

                    MessageBox.Show("Welcome To Our App !");
                    this.Hide();
                    var form2 = new Form2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();


                }
                else
                {
                    MessageBox.Show("Please enter the correct details");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.Show();

        }
    }
}