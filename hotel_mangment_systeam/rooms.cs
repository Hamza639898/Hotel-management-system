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
    public partial class rooms : Form
    {
        public rooms()
        {
            InitializeComponent();
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            displayData();
            id.Visible = false;

            btnsa.Enabled = true;
            btnup.Enabled = false;
            btnd.Enabled = false;
            
        }
        private void clear()
        {
            name.Text = string.Empty;
            comboBox1.Text = string.Empty;
            price.Text = string.Empty;
         


        }
        private void displayData()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from Room ", conn);
                DataTable dt = new DataTable();
              
                da.Fill(dt);
                data_table.DataSource = dt;
              
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yesradio.Checked==true)
                isfree="free";
                else
                isfree="busy";

            using (SqlConnection conn = Connection_Class.connect())
            {
                if (name.Text == "")
                {
                    MessageBox.Show("please fill  room_name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                       name.Focus();
                    return;

                }
                else if ( comboBox1.Text=="")
                {
                    MessageBox.Show("please fill room_taype field", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (price.Text == "")
                {
                    MessageBox.Show("please fill Phone Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //else if (RadioButt ")
              //  {
                //    MessageBox.Show("please fill Date", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               //     return;
              //  }
                

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "room_pr";
                cmd.Parameters.AddWithValue("@id", "");
                cmd.Parameters.AddWithValue("@room_name", name.Text);
                cmd.Parameters.AddWithValue("@room_taype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@PricePerNight", price.Text);
                cmd.Parameters.AddWithValue("@Status", isfree);


                cmd.Parameters.AddWithValue("@taype", "insert");
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert SUCCESSFULLY");
                displayData();
                clear();



            }
        }
      

        private void table_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = data_table.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = data_table.CurrentRow.Cells[2].Value.ToString();
            price.Text = data_table.CurrentRow.Cells[3].Value.ToString();
           

            id.Text = data_table.CurrentRow.Cells[0].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            using (SqlConnection conn = Connection_Class.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select*from  Room where   room_name like '" + search.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_table.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            using (SqlConnection conn = Connection_Class.connect())
            {
                //hadii  yes radio ladoorto waxay (free) hadii ladoortp no radio(no)
                string isfree;
                if (yesradio.Checked == true)
                    isfree = "free";
                else
                    isfree = "busy";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "room_pr";
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@room_name", name.Text);
                cmd.Parameters.AddWithValue("@room_taype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@PricePerNight", price.Text);
                cmd.Parameters.AddWithValue("@Status", isfree); 
               

                cmd.Parameters.AddWithValue("@taype", "update");
                cmd.ExecuteNonQuery();
                MessageBox.Show("update SUCCESSFULLY");
                displayData();
                clear();

                btnsa.Enabled = false;
                btnup.Enabled = true;
                btnd.Enabled = true;

            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = Connection_Class.connect())
            {
                string isfree;
                if (yesradio.Checked == true)
                    isfree = "free";
                else
                    isfree = "busy";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "room_pr";
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@room_name", name.Text);
                cmd.Parameters.AddWithValue("@room_taype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@PricePerNight", price.Text);
                cmd.Parameters.AddWithValue("@Status", isfree);

               


                cmd.Parameters.AddWithValue("@taype", "delete");
                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETED SUCCESSFULLY");
                displayData();
                clear();
                //btns.Enabled = true;
                //btnup.Enabled = false;
                //btnd.Enabled = false;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        
                }
            
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void table_data_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          name.Text = data_table.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = data_table.CurrentRow.Cells[2].Value.ToString();
            price.Text = data_table.CurrentRow.Cells[3].Value.ToString();
    
    
          
            id.Text = data_table.CurrentRow.Cells[0].Value.ToString();
        }
    }
}