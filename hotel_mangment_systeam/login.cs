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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = Connection_Class.connect())




                if (usert.Text.Trim().Equals("") || password.Text == "")
                {
                    MessageBox.Show("Enter your username and password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string selectquery = "SELECT * FROM users WHERE user_Name =   @userName AND user_password =    @password";
                    SqlCommand command = new SqlCommand(selectquery, conn);
                    command.Parameters.Add("@userName", SqlDbType.VarChar).Value = usert.Text;
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = password.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    SqlDataReader read = command.ExecuteReader();

                    // If the username and password exist
                    if (table.Rows.Count > 0)
                    {
                        // Show the main form
                        this.Hide();
                        Form1 F1 = new Form1();
                        F1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Your username and password do not exist", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void usert_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
                if (usert.Text.Trim().Equals("") || password.Text == "")
                {
                    MessageBox.Show("Enter your username and password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string selectquery = "SELECT * FROM users WHERE user_Name = @userName AND user_password = @password";
                    SqlCommand command = new SqlCommand(selectquery, conn);
                    command.Parameters.Add("@userName", SqlDbType.VarChar).Value = usert.Text;
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = password.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    
                    if (table.Rows.Count > 0)
                    {
           
                        this.Hide();

                        Form1 d = new  Form1 ();

                    
                        d.Setusername( table.Rows[0]["user_name"].ToString());
                        d.SetUserType(table.Rows[0]["user_taype"].ToString());

                        
                      if (d.GetUserType().Equals("admin"))
                        {
                          
                           

                          
                        }
                        else if   (d.GetUserType().Equals("finance"))
                          
                        {
                           
                        
                        }
                      
                        d.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your username and password do not exist", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}