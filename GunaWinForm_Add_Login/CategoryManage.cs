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
    public partial class CategoryManage : Form
    {
        public CategoryManage()
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
                String MyQuery = "select * from CategoryTableDb";
                SqlDataAdapter sqladptr = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder sqlbldr = new SqlCommandBuilder(sqladptr);
                var dtset = new DataSet();
                sqladptr.Fill(dtset);
                CategoryTabList_guna2DataGridView.DataSource = dtset.Tables[0];
                con.Close();

            }
            catch
            {
            }

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryIDlabel_Click(object sender, EventArgs e)
        {

        }

        private void CategoryNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void CtgrIdGna2TxtBx_db_TextChanged(object sender, EventArgs e)
        {

        }

        private void CtgrNmGna2TxtBx_db_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryManageMsgLabel_Click(object sender, EventArgs e)
        {

        }

        private void CategoryTabList_guna2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CtgrIdGna2TxtBx_db.Text = CategoryTabList_guna2DataGridView.SelectedRows[0].Cells[0].Value.ToString();
            CtgrNmGna2TxtBx_db.Text = CategoryTabList_guna2DataGridView.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            CtgrIdGna2TxtBx_db.Clear();
            CtgrNmGna2TxtBx_db.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CtgrIdGna2TxtBx_db.Text == "")
            {
                MessageBox.Show("Enter The Category ID");
            }


            else
            {
                if (CtgrNmGna2TxtBx_db.Text == "")
                {
                    MessageBox.Show("Enter The Category name");
                }
                else
                {
                    try
                    {
                        con.Open();
                        SqlCommand sqlcmnd = new SqlCommand("insert into CategoryTableDB values('" + CtgrIdGna2TxtBx_db.Text + "','" + CtgrNmGna2TxtBx_db.Text + "')", con);
                        sqlcmnd.ExecuteNonQuery();
                        MessageBox.Show("Category Succesfully Added");
                        CtgrIdGna2TxtBx_db.Clear();
                        CtgrNmGna2TxtBx_db.Clear();
                        con.Close();
                        ShowList();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
        }

        private void CategoryManage_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CtgrIdGna2TxtBx_db.Text == "")
            {
                MessageBox.Show("Select Category From The List");

            }
            else
            {
                try
                {
                    con.Open();
                    String MyQuery = "delete from CategoryTableDb where Category_Id='" + CtgrIdGna2TxtBx_db.Text + "';";
                    SqlCommand sqlcmnd = new SqlCommand(MyQuery, con);
                    sqlcmnd.ExecuteNonQuery();
                    MessageBox.Show("User Succesfully Deleted");
                    CtgrIdGna2TxtBx_db.Clear();
                    CtgrNmGna2TxtBx_db.Clear();
                    con.Close();
                    ShowList();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (CtgrNmGna2TxtBx_db.Text == "")
            {
                //if (CtgrNmGna2TxtBx_db != "")
                MessageBox.Show("Select Category From The List");

            }
            else
            {
                if (CtgrIdGna2TxtBx_db.Text == "")
                {
                    MessageBox.Show("Select Category From The List");
                }
                else
                {

                    try
                    {
                        con.Open();
                        SqlCommand sqlcmnd = new SqlCommand("update CategoryTableDb set Category_name='" + CtgrNmGna2TxtBx_db.Text + "' where Category_Id ='" + CtgrIdGna2TxtBx_db.Text + "'", con);
                        sqlcmnd.ExecuteNonQuery();
                        MessageBox.Show("Category Informations Succesfully Updated");
                        CtgrNmGna2TxtBx_db.Clear();
                        CtgrIdGna2TxtBx_db.Clear();
                        con.Close();
                        ShowList();
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
