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

namespace GunaWinForm_Add_Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Data Base Connection.
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HASSOUB\Documents\GunaWinFormDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void guna2Text1BoxLgFrm_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void guna2Text2BoxLgFrm_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                guna2Text2BoxLgFrm.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
            }
            else
            {
                guna2Text2BoxLgFrm.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
            }
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2Text1BoxLgFrm.Clear();
            guna2Text2BoxLgFrm.Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        /*private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqladptr = new SqlDataAdapter("Select Count(*) from UsersTableDb where Username = '" + guna2Text1BoxLgFrm.Text + "' and Userpassword = '" + guna2Text2BoxLgFrm.Text + "'", con);
            DataTable DT = new DataTable();
            sqladptr.Fill(DT);
            if(DT.Rows[0][0].ToString() == "1")
            {
                
                MainForm MainFrm = new MainForm();
                MainFrm.Show();
                //guna2TextBox1.Clear();
                //guna2TextBox2.Clear();

                //FirstForm FrstFrm = new FirstForm();
                //FrstFrm.Hide();
                //this.Close();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong name or password");
            }
            con.Close();

            /*SqlCommand sqlcmnd = con.CreateCommand();
            sqlcmnd.CommandText = "SELECT Username FROM UsersTableDb ";
            String guna2TextBox1*/

            /*MainForm toLogin = new MainForm();
            toLogin.ShowDialog();*/
        }
    
    }

