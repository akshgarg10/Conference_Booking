using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            string connetionString = null;


            SqlConnection connection;
            SqlCommand command;

            SqlDataReader dataReader;
            connetionString = "Data Source=SG-SMAUG\\SQLEXPRESS;Initial Catalog=Login_conference;Integrated Security=True";

            connection = new SqlConnection(connetionString);
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                connection.Open();
                command = new SqlCommand("update Login_conference.dbo.booking set booked='NO' where booking_id = '" + this.textBox1.Text + "'", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                }
                DialogResult res;
                res = MessageBox.Show("Do You Want To Cancel your Booking ?", "Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    
                    MessageBox.Show("Your booking has been cancelled");
             
                }
                else
                {
                    this.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("problem");
            }

            
            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
