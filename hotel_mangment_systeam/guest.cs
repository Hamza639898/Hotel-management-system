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
    public partial class guest : Form
    {
        public guest()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                if (name1.Text == "")
                {
                    MessageBox.Show("please fill full name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    name1.Focus();
                    return;

                }
                else if (name2.Text == "")
                {
                    MessageBox.Show("please fill Address field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (dd1.Text == "")
                {
                    MessageBox.Show("please fill Phone Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (address.Text == "")
                {
                    MessageBox.Show("please fill Date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (p.Text == "")
                {
                    MessageBox.Show("please fill Date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (emil.Text == "")
                {
                    MessageBox.Show("please fill Date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // SqlCommand cmd = new SqlCommand("insert into employee(First_name,last_name,number) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')",conn);

                // store procdure
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "guest_pr";
                cmd.Parameters.AddWithValue("@id", "   ");
                cmd.Parameters.AddWithValue("@firs_name", name1.Text);
                cmd.Parameters.AddWithValue("@list_name", name2.Text);
                cmd.Parameters.AddWithValue("@date_birth", dd1.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@phone", p.Text);
                cmd.Parameters.AddWithValue("@emial", emil.Text);
                cmd.Parameters.AddWithValue("@taype", "insert");


                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully", "saving data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                displayData();
                clear();

            }
        }

        private void name1_TextChanged(object sender, EventArgs e)
        {




        }
      

        private void guest_Load(object sender, EventArgs e)
        {
            displayData();
            label3.Visible = false;
        }
        private void displayData()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from guest", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                table_data.DataSource = dt;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from guest where  FirstName like '" + textBox2.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                table_data.DataSource = dt;
            }
        }

        private void table_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            name1.Text = table_data.CurrentRow.Cells[1].Value.ToString();
            name2.Text = table_data.CurrentRow.Cells[2].Value.ToString();
            dd1.Text = table_data.CurrentRow.Cells[3].Value.ToString();
            address.Text = table_data.CurrentRow.Cells[4].Value.ToString();
            p.Text = table_data.CurrentRow.Cells[4].Value.ToString();
            label3.Text = table_data.CurrentRow.Cells[0].Value.ToString();
            emil.Text = table_data.CurrentRow.Cells[6].Value.ToString();
                btnsa.Enabled = false;
             btnup.Enabled = true;
             btnd.Enabled = true;
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "guest_pr";
                cmd.Parameters.AddWithValue("@id", label3.Text);
                cmd.Parameters.AddWithValue("@firs_name", name1.Text);
                cmd.Parameters.AddWithValue("@list_name", name2.Text);
                cmd.Parameters.AddWithValue("@date_birth", dd1.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@phone", p.Text);
                cmd.Parameters.AddWithValue("@emial", emil.Text);

                cmd.Parameters.AddWithValue("@taype", "delete");
                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETED SUCCESSFULLY");
                displayData();
                clear();
                btnsa.Enabled = true;
                btnup.Enabled = false;
                 btnd.Enabled = false;
            }
        }

        private void clear()
        {
            name1.Text = string.Empty;
            name2.Text = string.Empty;
            dd1.Text = string.Empty;
            address.Text = string.Empty;
            p.Text = string.Empty;
            emil.Text = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            using (SqlConnection conn = Connection_Class.connect())
            {
                if (name1.Text == "")
                {
                    MessageBox.Show("please fill full name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    name1.Focus();
                    return;

                }
                else if (name2.Text == "")
                {
                    MessageBox.Show("please fill Address field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (dd1.Text == "")
                {
                    MessageBox.Show("please fill Phone Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (address.Text == "")
                {
                    MessageBox.Show("please fill Date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (p.Text == "")
                {
                    MessageBox.Show("please fill Date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (emil.Text == "")
                {
                    MessageBox.Show("please fill Date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "guest_pr";
                cmd.Parameters.AddWithValue("@id", label3.Text);
                cmd.Parameters.AddWithValue("@firs_name", name1.Text);
                cmd.Parameters.AddWithValue("@list_name", name2.Text);
                cmd.Parameters.AddWithValue("@date_birth", dd1.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@phone", p.Text);
                cmd.Parameters.AddWithValue("@emial", emil.Text);

                cmd.Parameters.AddWithValue("@taype", "update");
                cmd.ExecuteNonQuery();
                MessageBox.Show("update SUCCESSFULLY");
                displayData();
                clear();
                btnsa.Enabled = true;
                btnup.Enabled = false;
                 btnd.Enabled = false;

            
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}