using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;



namespace Login_page_CSI_net
{
    public partial class Form1 : Form
    {
        private const string CmdText = "select username, password from login where username'";
        private const string V = "'";
        SqlConnection conn = new SqlConnection();
        private string password_Text;
        private string username_Text;

        public Form1()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-7S3AJRA\ramni\\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True";

            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7S3AJRA\ramni\\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");
            con.Open();
            {
            }
        }
        //below are the names for each reference
        // private System.Windows.Forms.TextBox username;
        // private System.Windows.Forms.TextBox password;
        // private System.Windows.Forms.Button button1;
        // private System.Windows.Forms.Button button2;
        // private System.Windows.Forms.Button login;
        //09-13: The username and password buttons are clickable, and the login button is not working.

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Sourse = DESKTOP-7S3AJRA\ramni\\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");
            con.Open(); //sql connection to the db that I created

            string username = Form1.username_Text; //assigning 'username' to username
            string password = Form1.password_Text; //assigning 'password' to password
            SqlCommand cmd = new SqlCommand("select username, password from login where username= "
                                            + username_Text
                                            + "and password= "
                                            + password_Text
                                            + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("login was successful!");
                System.Diagnostics.Process.Start("https://www.google.com/");
            }
            else
            {
                MessageBox.Show("Invalid login, please check the username and password provided and try again!");
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }
        //keep the below code or else it screws up the design
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void password_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


