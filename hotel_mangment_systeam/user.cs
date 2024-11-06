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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            displayData();
            label1.Visible = true;
        }
        // wuxuu tablka kusoo ban dhigaa xogta
        private void displayData()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from users ", conn);
                DataTable dt = new DataTable();

                da.Fill(dt);
                data_table.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                if (name.Text == "")
                {
                    MessageBox.Show("please fill  user_name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    name.Focus();
                    return;

                }
                else if (password.Text == "")
                {
                    MessageBox.Show("please fill password field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("please fill Puser_taype", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (gm.Text == "")
                {
                    MessageBox.Show("please fill Puser_taype", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (national_id.Text == "")
                {
                    MessageBox.Show("please fill national_id", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }



                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "user_pr";
                cmd.Parameters.AddWithValue("@id", "");
                cmd.Parameters.AddWithValue("@userName", name.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@email", gm.Text);
                cmd.Parameters.AddWithValue("@nationalID", national_id.Text);


                cmd.Parameters.AddWithValue("@operation ", "insert");
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert SUCCESSFULLY");
                displayData();
                //clear();



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            name.Text = data_table.CurrentRow.Cells[1].Value.ToString();
            password.Text = data_table.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = data_table.CurrentRow.Cells[3].Value.ToString();
            gm.Text = data_table.CurrentRow.Cells[3].Value.ToString();
            national_id.Text = data_table.CurrentRow.Cells[3].Value.ToString();



            label1.Text = data_table.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "user_pr";
                cmd.Parameters.AddWithValue("@id", label1.Text);
                cmd.Parameters.AddWithValue("@userName", name.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@email", gm.Text);
                cmd.Parameters.AddWithValue("@nationalID", national_id.Text);


                cmd.Parameters.AddWithValue("@operation ", "update");
                cmd.ExecuteNonQuery();
                MessageBox.Show("update SUCCESSFULLY");
                displayData();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "user_pr";
                cmd.Parameters.AddWithValue("@id", label1.Text);
                cmd.Parameters.AddWithValue("@userName", name.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@email", gm.Text);
                cmd.Parameters.AddWithValue("@nationalID", national_id.Text);


                cmd.Parameters.AddWithValue("@operation ", "delete");
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete SUCCESSFULLY");
                displayData();
            }
        }
    }
}