using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_mangment_systeam
{
    public partial class reciptcs : Form
    {
        public reciptcs()
        {
            InitializeComponent();
        }

        private void reciptcs_Load(object sender, EventArgs e)
        {
            bookin();
            accoun();
            displayData();
        }
         private void displayData()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select* from rec_hotel ", conn);
                DataTable dt = new DataTable();

                da.Fill(dt);
                data_table.DataSource = dt;

            }
        }
        private void bookin()
        {

            using (SqlConnection conn = Connection_Class.connect())
            {

                string query = "SELECT Booking_t.BookingID, Booking_t.GuestID, Booking_t.RoomNumber, guest.FirstName,CONCAT(Booking_t.BookingID, ' - ', Booking_t.GuestID, ' - ', guest.FirstName, ' - ', Booking_t.TotalPrice) AS BOOKINGINFO FROM Booking_t JOIN guest ON Booking_t.GuestID = guest.GuestID; ";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboBox1.DataSource = dataTable;
                        comboBox1.DisplayMember = "BOOKINGINFO";
                        comboBox1.ValueMember = "BookingID";

                    }
                }
            }
        }
              private void accoun()
        {

            using (SqlConnection conn = Connection_Class.connect())
            {

                string query = "select id,instation,name,concat(id,'-',name,'-',instation)  as accoun_info from account_table; ";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboBox2.DataSource = dataTable;
                        comboBox2.DisplayMember ="accoun_info";
                        comboBox2.ValueMember ="id";

                    }
                }
            }
        }

              private void button1_Click(object sender, EventArgs e)
              {
                  
            using (SqlConnection conn = Connection_Class.connect())
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("please fill  room_name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    comboBox1.Focus();
                    return;

                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("please fill room_taype field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if ( comboBox2.Text== "")
                
                {
                    MessageBox.Show("please fill date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("please fill Date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (date.Text == "")
                {
                    MessageBox.Show("please fill taotal price", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "rec_pr";
                cmd.Parameters.AddWithValue("@id", "");
                cmd.Parameters.AddWithValue("@bookin", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@amount", textBox1.Text);
                cmd.Parameters.AddWithValue("@acc", comboBox2.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@rec_date", date.Value);
                cmd.Parameters.AddWithValue("@rec_method", textBox2.Text);

                
               


                cmd.Parameters.AddWithValue("@oper", "INSERT");


                cmd.ExecuteNonQuery();
                MessageBox.Show("insert SUCCESSFULLY");
                  displayData();

                
                // clear();

            }
        }

              private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
              {
                  comboBox1.Text = data_table.CurrentRow.Cells[1].Value.ToString();
                  textBox1.Text= data_table.CurrentRow.Cells[2].Value.ToString();
                  comboBox2.Text = data_table.CurrentRow.Cells[3].Value.ToString();
                  date.Text = data_table.CurrentRow.Cells[4].Value.ToString();
                  textBox2.Text = data_table.CurrentRow.Cells[5].Value.ToString();
                 
                 label7.Text = data_table.CurrentRow.Cells[0].Value.ToString();
              

                  
              }

              private void btnup_Click(object sender, EventArgs e)
              {
                  using (SqlConnection conn = Connection_Class.connect())
            {
              

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "rec_pr";
                cmd.Parameters.AddWithValue("@id", label7.Text);
                cmd.Parameters.AddWithValue("@bookin", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@amount", textBox1.Text);
                cmd.Parameters.AddWithValue("@acc", comboBox2.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@rec_date", date.Value);
                cmd.Parameters.AddWithValue("@rec_method", textBox2.Text);
               


                cmd.Parameters.AddWithValue("@oper", "update");


                cmd.ExecuteNonQuery();
                MessageBox.Show("update SUCCESSFULLY");
                //   displayData();
                // clear();
                        btnsa.Enabled = true;
                 btnup.Enabled = false;
                 btnd.Enabled = false;

            }
        }

              private void btnd_Click(object sender, EventArgs e)
              {
                      using (SqlConnection conn = Connection_Class.connect())
            {
              

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "rec_pr";
                cmd.Parameters.AddWithValue("@id", label7.Text);
                cmd.Parameters.AddWithValue("@bookin", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@amount", textBox1.Text);
                cmd.Parameters.AddWithValue("@acc", comboBox2.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@rec_date", date.Value);
                cmd.Parameters.AddWithValue("@rec_method", textBox2.Text);
               


                cmd.Parameters.AddWithValue("@oper", "delete");


                cmd.ExecuteNonQuery();
                MessageBox.Show("delete SUCCESSFULLY");
                //   displayData();
                // clear();
                btnsa.Enabled = true;
                btnup.Enabled = false;
                btnd.Enabled = false;

            }
        }

              private void textBox4_TextChanged(object sender, EventArgs e)
              {
                     using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from  rec_hotel where   rec_id like '" + textBox4.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_table.DataSource = dt;
            }
        }

              private void label8_Click(object sender, EventArgs e)
              {

              }
              }
              }
              
              
        
    