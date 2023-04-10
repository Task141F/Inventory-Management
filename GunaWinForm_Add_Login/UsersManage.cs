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
    public partial class UsersManage : Form
    {
        public UsersManage()
        {
            InitializeComponent();
        }

        //Data Base Connection.
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HASSOUB\Documents\GunaWinFormDb.mdf;Integrated Security=True;Connect Timeout=30");

        void ShowList()
        {
            try
            {
                con.Open();
                String MyQuery = "select * from UsersTableDb";
                SqlDataAdapter sqladptr = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder sqlbldr = new SqlCommandBuilder(sqladptr);
                var dtset = new DataSet();
                sqladptr.Fill(dtset);
                UsersTabList_guna2DataGridView.DataSource = dtset.Tables[0];
                con.Close();
                
            }
            catch
            {
            }

        }

        private void UsersManage_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (UsrNmGna2TxtBx_db.Text == "")
            {
                MessageBox.Show("Enter The User Name");  
            }
            
        
            else
            {
                if (UsrPswrdGna2TxtBx_db.Text == "")
                {
                    MessageBox.Show("Enter The User Password");
                }
                else
                { 
                try
                {
                    con.Open();
                    SqlCommand sqlcmnd = new SqlCommand("insert into UsersTableDb values('" + UsrNmGna2TxtBx_db.Text + "','" + UsrPswrdGna2TxtBx_db.Text + "')", con);
                    sqlcmnd.ExecuteNonQuery();
                    MessageBox.Show("User Succesfully Added");
                    UsrNmGna2TxtBx_db.Clear();
                    UsrPswrdGna2TxtBx_db.Clear();
                    con.Close();
                    ShowList();
                 }
                catch
                {
                        //MainForm MainFrm = new MainForm();
                       // MainFrm.Show();
                        //openChildForm(new ProductsManage());
                    }
                }

            }


                /*if (UsrNmGna2TxtBx_db.Text == "")
                {
                    MessageBox.Show("Enter The User Name");

                    if (UsrPswrdGna2TxtBx_db.Text == "")
                    {
                        MessageBox.Show("Enter The User Password");
                    }
                }*/
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            /*UsrNmGna2TxtBx_db.Clear();
            UsrPswrdGna2TxtBx_db.Clear();
            ShowList();*/
            //InitializeComponent();

        }

        private void UsrNmGna2TxtBx_db_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(UsrPswrdGna2TxtBx_db.Text == "")
            {
                MessageBox.Show("Select User From The List");
               
            }
            else
            {
                try
                {
                    con.Open();
                String MyQuery = "delete from UsersTableDb where Userpassword='" + UsrPswrdGna2TxtBx_db.Text + "';";
                SqlCommand sqlcmnd = new SqlCommand(MyQuery, con);
                sqlcmnd.ExecuteNonQuery();
                MessageBox.Show("User Succesfully Deleted");
                UsrNmGna2TxtBx_db.Clear();
                UsrPswrdGna2TxtBx_db.Clear();
                con.Close();
                ShowList();
                }
                catch
                {

                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (UsrNmGna2TxtBx_db.Text == "")
            {
                //if (UsrNmGna2TxtBx_db.Text != "")
                MessageBox.Show("Select User From The List");

            }
            else
            {
                if (UsrPswrdGna2TxtBx_db.Text == "")
                {
                    MessageBox.Show("Select User From The List");
                }
                else
                {

                    try
                    {
                        con.Open();
                        //SqlCommand sqlcmnd = new SqlCommand("update UsersTableDb set Username='" + UsrNmGna2TxtBx_db.Text + "', Userpassword='" + UsrPswrdGna2TxtBx_db.Text + "'", con);
                        SqlCommand sqlcmnd = new SqlCommand("update UsersTableDb set Username='" + UsrNmGna2TxtBx_db.Text + "' where Userpassword='" + UsrPswrdGna2TxtBx_db.Text + "'", con);

                        sqlcmnd.ExecuteNonQuery();
                        MessageBox.Show("User Informations Succesfully Updated");
                        UsrNmGna2TxtBx_db.Clear();
                        UsrPswrdGna2TxtBx_db.Clear();
                        con.Close();
                        ShowList();
                    }
                    catch
                    {

                    }
                }
            }

        }

        private void UsrPswrdGna2TxtBx_db_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsersTabList_guna2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsrNmGna2TxtBx_db.Text = UsersTabList_guna2DataGridView.SelectedRows[0].Cells[0].Value.ToString();
            UsrPswrdGna2TxtBx_db.Text = UsersTabList_guna2DataGridView.SelectedRows[0].Cells[1].Value.ToString();


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            UsrNmGna2TxtBx_db.Clear();
            UsrPswrdGna2TxtBx_db.Clear();
        }
    }
}
