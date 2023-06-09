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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            mybox.Items.Add("Booking");
            mybox.Items.Add("Cancellation");

            mybox.SelectedIndexChanged += Mybox_SelectedIndexChanged;


            timer1.Start();
        }

        private void Mybox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mybox.Text == "Booking")
            {
                dtp1.Visible = true;
                dtp2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;

                
            }

            if(mybox.Text == "Cancellation")
            {
                this.Hide();
                var form3 = new Form3();
                form3.Closed += (s, args) => this.Close();
                form3.Show();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();

        }

        private void show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("START DATE : " + this.dtp1.Text + "\n" + "\n" + "\n" + "END DATE : " + this.dtp2.Text);

        }
        

        private void book1_Click(object sender, EventArgs e)
        {
            

            string connetionString = null;


            SqlConnection connection;
            
            
            connetionString = "Data Source=SG-SMAUG\\SQLEXPRESS;Initial Catalog=Login_conference;Integrated Security=True";
            
            connection = new SqlConnection(connetionString);
                      
            SqlDataAdapter da = new SqlDataAdapter();

            string sql= "select booking_id as 'BOOKING ID', start_date as 'START DATE', end_date as 'END DATE', booked from Login_conference.dbo.booking Where cast(booked as varchar) = 'YES' and ";
            sql += " ( '" + dtp1.Value.ToString() + "' between start_date and end_date  or '" + dtp2.Value.ToString() +"' between start_date and end_date )";
            SqlCommand cmd = new SqlCommand(sql , connection);
            try
            {
                connection.Open();
                da.SelectCommand = cmd;
                DataTable dbtable = new DataTable();
                da.Fill(dbtable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbtable;
                dataGridView1.DataSource = bSource;
                da.Update(dbtable);

                DialogResult res;
                
                if (dbtable.Rows.Count > 0)
                {
                    res = MessageBox.Show("Your time interval is clashing with other records !!", "Clashing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        this.Show();
                    }
                }
               
                
                else
                {
                    try
                    {

                        da.InsertCommand = new SqlCommand("INSERT INTO dbo.booking VALUES(@user_id ,@start_date, @end_date, @booking_date, @booked)", connection);
                        da.InsertCommand.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id.userid;
                        da.InsertCommand.Parameters.Add("@start_date", SqlDbType.DateTime).Value = dtp1.Value;
                        da.InsertCommand.Parameters.Add("@end_date", SqlDbType.DateTime).Value = dtp2.Value;
                        da.InsertCommand.Parameters.Add("@booking_date", SqlDbType.DateTime).Value = DateTime.Now;
                        da.InsertCommand.Parameters.Add("@booked", SqlDbType.Text).Value = "YES";
                        MessageBox.Show("Saved");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("problemz");
                    }

                    da.InsertCommand.ExecuteNonQuery();
                    connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("problemms");
            }


           
            

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            string connetionString = null;


            SqlConnection connection;
            SqlCommand command;

            SqlDataReader dataReader;
            connetionString = "Data Source=SG-SMAUG\\SQLEXPRESS;Initial Catalog=Login_conference;Integrated Security=True";

            connection = new SqlConnection(connetionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("select booking_id as 'BOOKING ID', start_date as 'START DATE', end_date as 'END DATE', booked as 'BOOKED' from Login_conference.dbo.booking Where cast(booked as varchar) ='YES' ", connection);
            try
            {
                da.SelectCommand = cmd;
                DataTable dbtable = new DataTable();
                da.Fill(dbtable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbtable;
                dataGridView1.DataSource = bSource;
                da.Update(dbtable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("problem");
            }
            

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            this.timer_lbl.Text = date.ToString();
        }

       
    }
}
