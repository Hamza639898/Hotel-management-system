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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = Connection_Class.connect())
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("please fill full number of account", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox3.Focus();
                    return;

                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("please fill account name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("please fill balance", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "acc_pr";
                cmd.Parameters.AddWithValue("@id", "");
                cmd.Parameters.AddWithValue("@inst", textBox3.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@balance", textBox1.Text);



                cmd.Parameters.AddWithValue("@taype", "insert");
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert SUCCESSFULLY");
                  displayData();
                // clear();
                 btnsa.Enabled = true;
                 btnup.Enabled = false;
                 btnd.Enabled = false;
            }
        }

        private void account_Load(object sender, EventArgs e)
        {
            displayData();
        }
        private void displayData()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from account_table", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                table_data.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             using (SqlConnection conn = Connection_Class.connect())
            {
               

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "acc_pr";
                cmd.Parameters.AddWithValue("@id", label5.Text);
                cmd.Parameters.AddWithValue("@inst", textBox3.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@balance", textBox1.Text);



                cmd.Parameters.AddWithValue("@taype", "update");
                cmd.ExecuteNonQuery();
                MessageBox.Show("update SUCCESSFULLY");
                  displayData();
                // clear();
                  btnsa.Enabled = true;
                  btnup.Enabled = false;
                  btnd.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "acc_pr";
                cmd.Parameters.AddWithValue("@id", label5.Text);
                cmd.Parameters.AddWithValue("@inst", textBox3.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@balance", textBox1.Text);



                cmd.Parameters.AddWithValue("@taype", "delete");
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete SUCCESSFULLY");
                displayData();
                // clear();
                 btnsa.Enabled = true;
                 btnup.Enabled = false;
                 btnd.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text= table_data.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = table_data.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = table_data.CurrentRow.Cells[3].Value.ToString();
           

            label5.Text = table_data.CurrentRow.Cells[0].Value.ToString();

            btnsa.Enabled = false;
            btnup.Enabled = true;
            btnd.Enabled = true;
        }
        }
    }
