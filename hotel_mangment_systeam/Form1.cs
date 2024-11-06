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
      
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        public void SetUserType(string userType)
        {
            l2.Text = userType;
        }
        public void Setusername(string username)
        {
            l1.Text = username;
        }

        // wuxuu dhashbordka kusoo akhrinyaa tirda inta user ee joogta
        private void displusercount()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {
           
                   using (SqlCommand cmd = new SqlCommand("select count(user_id)from users", conn))

                
    {
        label2.Text = cmd.ExecuteScalar().ToString();
        

        
    }
}
            }

        // wuxuu dhashbordka kusoo akhrinyaa tirda inta room ee diwaangishan
        private void displyroomcount()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {

                using (SqlCommand cmd = new SqlCommand("select count(RoomNumber)from Room", conn))
                {
                   room.Text = cmd.ExecuteScalar().ToString();



                }
            }
        }
           // wuxuu dhashbordka kusoo akhrinyaa tirda inta bookin ee diwaangishan
        private void displaybookin()
        {
            using (SqlConnection conn = Connection_Class.connect())
            {

                using (SqlCommand cmd = new SqlCommand("select count(BookingID)from Booking_t", conn))
                {
                Bookin.Text = cmd.ExecuteScalar().ToString();
               
               


                }
            }
        }
    
        
        public string GetUserType()
        {
            return l2.Text;
        }



        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            guest g = new guest();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guest g = new guest();
            g.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            guest g = new guest();
            g.Show();

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            guest g = new guest();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public Button MyButton
        {
            get { return this.button1; } // Assuming 'button1' is the name of your button
        }
        public   TabControl maytab
        {
            get { return this.Home; } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displusercount();
            displyroomcount();
            displaybookin();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            guest g = new guest();
            g.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Home.SelectedTab = tabPage3;

        }

 

  

        private void button_delete_Click(object sender, EventArgs e)
        {
            Home.SelectedTab=tabPage1;
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            Home.SelectedTab = tabPage4;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
         
        }

   
        private void text_display()
        {

       
        }

  

        
        private void tabPage3_Click(object sender, EventArgs e)
        {


        }
     

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rooms r = new rooms();
            r.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            guest g = new guest();
            g.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rooms r = new rooms();
            r.Show();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            guest g = new guest();
            g.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            booking b = new booking();
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home.SelectedTab = tabPage2;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Home.SelectedTab = tabPage3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Hide();
            l.Show();
       
        }

      

        private void label7_Click(object sender, EventArgs e)
        {
        
         

               
            }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            payment p = new payment();
            p.Show();
        }

          public  static void  user_Click(object sender, EventArgs e)
        {

        }

        public static void taype_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            user u = new user();
            u.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            account a = new account();
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reciptcs r = new reciptcs();
            r.Show();
        }
        }
    
}
