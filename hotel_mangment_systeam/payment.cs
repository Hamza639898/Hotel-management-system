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

namespace hotel_mangment_systeam
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("please fill  bookin", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    comboBox1.Focus();
                    return;

                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("please fill amount field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (date.Text == "")
                {
                    MessageBox.Show("please fill  date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("please fill amount_method", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }





                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "paymentmay";
                cmd.Parameters.AddWithValue("@id", "");
                cmd.Parameters.AddWithValue("@bookin", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@amount", textBox2.Text);
                cmd.Parameters.AddWithValue("@paymen_date ", date.Value);
                cmd.Parameters.AddWithValue("@payment_method ", textBox1.Text);




                cmd.Parameters.AddWithValue("@oper", "INSERT");

                cmd.ExecuteNonQuery();
                MessageBox.Show("insert SUCCESSFULLY");
                displayData();
                // clear();

            }
        }

        private void payment_Load(object sender, EventArgs e)
        {
            com2();
            displayData();
            label5.Visible = false;

        }
        private void displayData()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from Payment", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                table_data.DataSource = dt;
            }
        }

        private void com2()
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void table_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = table_data.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = table_data.CurrentRow.Cells[2].Value.ToString();
            date.Text = table_data.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = table_data.CurrentRow.Cells[4].Value.ToString();

            label5.Text = table_data.CurrentRow.Cells[0].Value.ToString();

            //  btnsa.Enabled = false;
            //btnup.Enabled = true;
            //btnd.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "paymentmay";
                cmd.Parameters.AddWithValue("@id", label5.Text);
                cmd.Parameters.AddWithValue("@bookin", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@amount", textBox2.Text);
                cmd.Parameters.AddWithValue("@paymen_date ", date.Value);
                cmd.Parameters.AddWithValue("@payment_method ", textBox1.Text);




                cmd.Parameters.AddWithValue("@oper", "update");

                cmd.ExecuteNonQuery();
                MessageBox.Show("update SUCCESSFULLY");
                displayData();
                // clear();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = Connection_Class.connect())
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "paymentmay";
                cmd.Parameters.AddWithValue("@id", label5.Text);
                cmd.Parameters.AddWithValue("@bookin", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@amount", textBox2.Text);
                cmd.Parameters.AddWithValue("@paymen_date ", date.Value);
                cmd.Parameters.AddWithValue("@payment_method ", textBox1.Text);




                cmd.Parameters.AddWithValue("@oper", "delete");

                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete SUCCESSFULLY");
                displayData();
                // clear();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from   Payment where   PaymentID like '" + textBox3.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                table_data.DataSource = dt;
            }
        }


    }
}