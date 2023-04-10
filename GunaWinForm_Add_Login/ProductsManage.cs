﻿using System;
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
    public partial class ProductsManage : Form
    {
        public ProductsManage()
        {
            InitializeComponent();
        }

        //Child Form Load Code......................
        private Form activeForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PrdctMngPanel.Controls.Add(ChildForm);
            PrdctMngPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        //Data Base Connection.
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HASSOUB\Documents\GunaWinFormDb.mdf;Integrated Security=True;Connect Timeout=30");

        void ShowList()
        {
            try
            {
                con.Open();
                String MyQuery = "select * from ProductsTableDb";
                SqlDataAdapter sqladptr = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder sqlbldr = new SqlCommandBuilder(sqladptr);
                var dtset = new DataSet();
                sqladptr.Fill(dtset);
                PrdctsTabList_guna2DataGridView.DataSource = dtset.Tables[0];
                con.Close();
            }
            catch
            {
            }

        }
        void ChoseCategory()
        {
            String MyQuery = "select * from CategoryTableDb";
            SqlCommand sqlcmnd = new SqlCommand(MyQuery, con);
            SqlDataReader DtRdr;
             
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Category_name", typeof(string));
                DtRdr = sqlcmnd.ExecuteReader();
                dt.Load(DtRdr);
                PrdctSlctCtgrComboBox.ValueMember = "Category_name";
                PrdctSlctCtgrComboBox.DataSource = dt;
                con.Close();
            }
            catch
            {
            }
        }
        private void PrdctMngPanel_Paint(object sender, PaintEventArgs e)
        {
            ChoseCategory();
            ShowList();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            PrdctExpdtrTxtBx_db.Clear();
            PrdctFctrNmbrTxtBx_db.Clear();
            PrdctMrqTxtBx_db.Clear();
            PrdctRéfMoyenTxtBx_db.Clear();
            PrdctRéfPiéceTxtBx_db.Clear();
            PrdctDésignationTxtBx_db.Clear();
            PrdctQteTxtBx_db.Clear();
            PrdctEmplcmntMgsnTxtBx_db.Clear();
            PrdctDateFactrTxtBx_db.Clear();
        }

        private void ToCtgrMngButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryManage());
        }

        private void PrdctsTabList_guna2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrdctExpdtrTxtBx_db.Text = PrdctsTabList_guna2DataGridView.SelectedRows[0].Cells[0].Value.ToString();
            PrdctFctrNmbrTxtBx_db.Text = PrdctsTabList_guna2DataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PrdctMrqTxtBx_db.Text = PrdctsTabList_guna2DataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PrdctRéfMoyenTxtBx_db.Text = PrdctsTabList_guna2DataGridView.SelectedRows[0].Cells[3].Value.ToString();
            PrdctRéfPiéceTxtBx_db.Text = PrdctsTabList_guna2DataGridView.SelectedRows[0].Cells[4].Value.ToString();
            PrdctDésignationTxtBx_db.Text = PrdctsTabList_guna2DataGridView.SelectedRows[0].Cells[5].Value.ToString();
            PrdctQteTxtBx_db.Text = PrdctsTabList_guna2DataGridView.SelectedRows[0].Cells[6].Value.ToString();
            PrdctEmplcmntMgsnTxtBx_db.Text = PrdctsTabList_guna2DataGridView.SelectedRows[0].Cells[7].Value.ToString();
            PrdctDateFactrTxtBx_db.Text = PrdctsTabList_guna2DataGridView.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void PrdctEmplcmntMgsnTxtBx_db_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (PrdctExpdtrTxtBx_db.Text == "" && PrdctFctrNmbrTxtBx_db.Text == "" && PrdctMrqTxtBx_db.Text == "" && PrdctRéfMoyenTxtBx_db.Text == "" && PrdctRéfPiéceTxtBx_db.Text == "" && PrdctDésignationTxtBx_db.Text == "" && PrdctQteTxtBx_db.Text == "" && PrdctEmplcmntMgsnTxtBx_db.Text == "" && PrdctDateFactrTxtBx_db.Text == "")
            {
                MessageBox.Show("Complete The Product Informations");
            }
            else
            {
                if (PrdctRéfPiéceTxtBx_db.Text == "")
                {
                    MessageBox.Show("Enter The Product Référence");
                }
                else
                {
                    try
                    {
                        con.Open();
                        SqlCommand sqlcmnd = new SqlCommand("insert into ProductsTableDb values('" + PrdctExpdtrTxtBx_db.Text + "','" + PrdctFctrNmbrTxtBx_db.Text + "','" + PrdctMrqTxtBx_db.Text + "','" + PrdctRéfMoyenTxtBx_db.Text + "','" + PrdctRéfPiéceTxtBx_db.Text + "','" + PrdctDésignationTxtBx_db.Text + "','" + PrdctQteTxtBx_db.Text + "','" + PrdctEmplcmntMgsnTxtBx_db.Text + "','" + PrdctDateFactrTxtBx_db.Text + "')", con);
                        sqlcmnd.ExecuteNonQuery();
                        MessageBox.Show("Product Informations Succesfully Added");
                        PrdctExpdtrTxtBx_db.Clear();
                        PrdctFctrNmbrTxtBx_db.Clear();
                        PrdctMrqTxtBx_db.Clear();
                        PrdctRéfMoyenTxtBx_db.Clear();
                        PrdctRéfPiéceTxtBx_db.Clear();
                        PrdctDésignationTxtBx_db.Clear();
                        PrdctQteTxtBx_db.Clear();
                        PrdctEmplcmntMgsnTxtBx_db.Clear();
                        PrdctDateFactrTxtBx_db.Clear();
                        con.Close();
                        ShowList();
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (PrdctRéfPiéceTxtBx_db.Text == "")
            {
                MessageBox.Show("Select Product From The List");

            }
            else
            {


                try
                {
                    //SqlCommand sqlcmnd = new SqlCommand("update ProductsTableDb set Expéditeur='" + PrdctExpdtrTxtBx_db.Text + "', N°Facture='" + PrdctFctrNmbrTxtBx_db.Text + "', Marque='" + PrdctMrqTxtBx_db.Text + "', Références_Moyen='" + PrdctRéfMoyenTxtBx_db.Text + "', Désignation='" + PrdctDésignationTxtBx_db.Text + "', Qte='" + PrdctQteTxtBx_db.Text + "', Emplacement_Magasin='" + PrdctEmplcmntMgsnTxtBx_db.Text + "', Date_Facture='" + PrdctDateFactrTxtBx_db.Text + "' where Référence_Piéce='" + PrdctRéfPiéceTxtBx_db.Text + "'", con);
                    //SqlCommand sqlcmnd = new SqlCommand("update ProductsTableDb set Expéditeur='" + PrdctExpdtrTxtBx_db.Text + "',N°Facture='" + PrdctFctrNmbrTxtBx_db.Text + "' where Référence_Piéce='" + PrdctRéfPiéceTxtBx_db.Text + "'", con);
                    //sqlcmnd.ExecuteNonQuery();
                    //String Query = "update ProductsTableDb set (Expéditeur,N°Facture,Marque,Références_Moyen,Désignation,Qte,Emplacement_Magasin,Date_Facture) values('"+ this.PrdctExpdtrTxtBx_db.Text + "','" + this.PrdctFctrNmbrTxtBx_db.Text + "','" + this.PrdctMrqTxtBx_db.Text + "','" + this.PrdctRéfMoyenTxtBx_db.Text + "','" + this.PrdctDésignationTxtBx_db.Text + "','" + this.PrdctQteTxtBx_db.Text + "','" + this.PrdctEmplcmntMgsnTxtBx_db.Text + "','" + this.PrdctDateFactrTxtBx_db.Text +"') ;";
                    String Query = "update ProductsTableDb set (Expéditeur='" + this.PrdctExpdtrTxtBx_db.Text + "',N°Facture='" + this.PrdctFctrNmbrTxtBx_db.Text + "',Marque='" + this.PrdctMrqTxtBx_db.Text + "',Références_Moyen='" + this.PrdctRéfMoyenTxtBx_db.Text + "',Référence_Piéce='" + this.PrdctRéfPiéceTxtBx_db.Text + "',Désignation='" + this.PrdctDésignationTxtBx_db.Text + "',Qte='" + this.PrdctQteTxtBx_db.Text + "',Emplacement_Magasin='" + this.PrdctEmplcmntMgsnTxtBx_db.Text + "',Date_Facture='" + this.PrdctDateFactrTxtBx_db.Text + "' where Référence_Piéce='" + this.PrdctRéfPiéceTxtBx_db.Text + "') ;";
                    SqlCommand sqlcmnd = new SqlCommand(Query, con);
                    SqlDataReader DtRdr;

                    con.Open();
                    DtRdr = sqlcmnd.ExecuteReader();
                    /*while (DtRdr.Read())
                    {
                    }*/
                    MessageBox.Show("Product Informations Succesfully Updated");                   
                    con.Close();
                    ShowList();
                }
                catch
                {

                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (PrdctRéfPiéceTxtBx_db.Text == "")
            {
                MessageBox.Show("Select Product From The List");

            }
            else
            {
                try
                {
                    con.Open();
                    String MyQuery = "delete from ProductsTableDb where Référence_Piéce='" + PrdctRéfPiéceTxtBx_db.Text + "';";
                    SqlCommand sqlcmnd = new SqlCommand(MyQuery, con);
                    sqlcmnd.ExecuteNonQuery();
                    MessageBox.Show("Product Succesfully Deleted");
                    PrdctExpdtrTxtBx_db.Clear();
                    PrdctFctrNmbrTxtBx_db.Clear();
                    PrdctMrqTxtBx_db.Clear();
                    PrdctRéfMoyenTxtBx_db.Clear();
                    PrdctRéfPiéceTxtBx_db.Clear();
                    PrdctDésignationTxtBx_db.Clear();
                    PrdctQteTxtBx_db.Clear();
                    PrdctEmplcmntMgsnTxtBx_db.Clear();
                    PrdctDateFactrTxtBx_db.Clear();
                    con.Close();
                    ShowList();
                }
                catch
                {

                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ActiveForm.Refresh();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void SearchFillPanelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrdctSlctCtgrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrdctRéfPiéceTxtBx_db_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonsPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void InsertInfopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PrdctQteTxtBx_db_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

