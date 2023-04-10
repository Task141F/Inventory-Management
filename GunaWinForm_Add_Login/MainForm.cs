using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunaWinForm_Add_Login
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            Fillpanel.Controls.Add(ChildForm);
            Fillpanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productsbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductsManage());
            //openChildForm(new EntredStock());
            //openChildForm(new SortedStock());
        }

        private void Usersbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new UsersManage());
        }

        private void Fillpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            LoginForm LgFrm = new LoginForm();
            LgFrm.guna2Text1BoxLgFrm.Clear();
            LgFrm.guna2Text2BoxLgFrm.Clear();
            this.Close();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openChildForm(new EntredStock());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new SortedStock());
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
