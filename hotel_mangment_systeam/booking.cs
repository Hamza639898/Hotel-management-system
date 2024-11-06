using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_mangment_systeam
{
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }


        private void booking_Load(object sender, EventArgs e)
        {
            com1();
            com2();
            today = datein.Value;
            displayData();
        }

        private void displayData()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select* from Booking_t ", conn);
                DataTable dt = new DataTable();

                da.Fill(dt);
                data_table.DataSource = dt;

            }
        }
        DateTime today;
        private void com2()
        {

            using (SqlConnection conn = Connection_Class.connect())
            {

                string query = "SELECT  RoomNumber , room_name,room_taype,status, CONCAT(RoomNumber,' - ' ,room_name, ' - ', room_taype,' - ',status) AS roomInfo FROM Room WHERE status LIKE 'free';";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboBox2.DataSource = dataTable;
                        comboBox2.DisplayMember = "roomInfo";
                        comboBox2.ValueMember = "RoomNumber";

                    }
                }
            }
        }
        private void com1()
        {

            using (SqlConnection conn = Connection_Class.connect())
            {
                string query = "select  GuestID ,FirstName,   CONCAT( GuestID,' - ' ,FirstName ) AS guestInfo from Guest;";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboBox1.DataSource = dataTable;
                        comboBox1.DisplayMember = "guestInfo".ToString();
                        comboBox1.ValueMember = "GuestID".ToString();
                    }
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btns_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("please fill  room_name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    comboBox1.Focus();
                    return;

                }
                else if (comboBox2.Text == "")
                {
                    MessageBox.Show("please fill room_taype field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (     datein.Text == "")
                
                {
                    MessageBox.Show("please fill date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (dateout.Text == "")
                {
                    MessageBox.Show("please fill Date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (total.Text == "")
                {
                    MessageBox.Show("please fill taotal price", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "booking_pr";
                cmd.Parameters.AddWithValue("@id", "");
                cmd.Parameters.AddWithValue("@guest", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@room", comboBox2.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@indate", datein.Value);
                cmd.Parameters.AddWithValue("@outdate", dateout.Value);
                cmd.Parameters.AddWithValue("@total", total.Text);


                cmd.Parameters.AddWithValue("@oper", "INSERT");


                cmd.ExecuteNonQuery();
                MessageBox.Show("insert SUCCESSFULLY");
                   displayData();
                // clear();

            }
        }

        private void datein_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(datein.Value, today);
            if (res < 0)
                MessageBox.Show("wrong data");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from   Booking_t where   BookingID like '" + textBox1.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_table.DataSource = dt;
            }
        }

        private void data_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = data_table.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = data_table.CurrentRow.Cells[2].Value.ToString();
            datein.Text = data_table.CurrentRow.Cells[3].Value.ToString();
            dateout.Text = data_table.CurrentRow.Cells[4].Value.ToString();
            total.Text = data_table.CurrentRow.Cells[5].Value.ToString();
            la1.Text = data_table.CurrentRow.Cells[0].Value.ToString();
           
        }

        private void btans_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = Connection_Class.connect())
            {




                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "booking_pr";
                cmd.Parameters.AddWithValue("@id",la1.Text);
                cmd.Parameters.AddWithValue("@guest", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@room", comboBox2.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@indate", datein.Value);
                cmd.Parameters.AddWithValue("@outdate", dateout.Value);
                cmd.Parameters.AddWithValue("@total", total.Text);


                cmd.Parameters.AddWithValue("@oper", "update");

                cmd.ExecuteNonQuery();
                MessageBox.Show("update SUCCESSFULLY");
                displayData();
                // clear();

            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = Connection_Class.connect())
            {




                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "booking_pr";
                cmd.Parameters.AddWithValue("@id", la1.Text);
                cmd.Parameters.AddWithValue("@guest", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@room", comboBox2.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@indate", datein.Value);
                cmd.Parameters.AddWithValue("@outdate", dateout.Value);
                cmd.Parameters.AddWithValue("@total", total.Text);


                cmd.Parameters.AddWithValue("@oper", "delete");

                cmd.ExecuteNonQuery();
                MessageBox.Show("delete SUCCESSFULLY");
                displayData();
                // clear();

            }
        }

        private void bid_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}