namespace GunaWinForm_Add_Login
{
    partial class UsersManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.UsersManageMsgLabel = new System.Windows.Forms.Label();
            this.UsersTabList_guna2DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.InsertInfopanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.UsrPswrdGna2TxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserPswrdlabel = new System.Windows.Forms.Label();
            this.UsrNmGna2TxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.Toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTabList_guna2DataGridView)).BeginInit();
            this.InsertInfopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Toppanel.Controls.Add(this.UsersManageMsgLabel);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(1280, 34);
            this.Toppanel.TabIndex = 0;
            // 
            // UsersManageMsgLabel
            // 
            this.UsersManageMsgLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsersManageMsgLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsersManageMsgLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.UsersManageMsgLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.UsersManageMsgLabel.Location = new System.Drawing.Point(490, 5);
            this.UsersManageMsgLabel.Name = "UsersManageMsgLabel";
            this.UsersManageMsgLabel.Size = new System.Drawing.Size(220, 25);
            this.UsersManageMsgLabel.TabIndex = 0;
            this.UsersManageMsgLabel.Text = "Users Management";
            this.UsersManageMsgLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsersTabList_guna2DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.UsersTabList_guna2DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersTabList_guna2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersTabList_guna2DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UsersTabList_guna2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersTabList_guna2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersTabList_guna2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersTabList_guna2DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersTabList_guna2DataGridView.ColumnHeadersHeight = 40;
            this.UsersTabList_guna2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersTabList_guna2DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersTabList_guna2DataGridView.EnableHeadersVisualStyles = false;
            this.UsersTabList_guna2DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.UsersTabList_guna2DataGridView.Location = new System.Drawing.Point(325, 183);
            this.UsersTabList_guna2DataGridView.Name = "UsersTabList_guna2DataGridView";
            this.UsersTabList_guna2DataGridView.ReadOnly = true;
            this.UsersTabList_guna2DataGridView.RowHeadersVisible = false;
            this.UsersTabList_guna2DataGridView.RowTemplate.Height = 30;
            this.UsersTabList_guna2DataGridView.RowTemplate.ReadOnly = true;
            this.UsersTabList_guna2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersTabList_guna2DataGridView.Size = new System.Drawing.Size(720, 478);
            this.UsersTabList_guna2DataGridView.TabIndex = 1;
            this.UsersTabList_guna2DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.UsersTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.UsersTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersTabList_guna2DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersTabList_guna2DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.UsersTabList_guna2DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.UsersTabList_guna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.UsersTabList_guna2DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersTabList_guna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersTabList_guna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UsersTabList_guna2DataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.UsersTabList_guna2DataGridView.ThemeStyle.ReadOnly = true;
            this.UsersTabList_guna2DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.UsersTabList_guna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersTabList_guna2DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UsersTabList_guna2DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.UsersTabList_guna2DataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.UsersTabList_guna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.UsersTabList_guna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UsersTabList_guna2DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersTabList_guna2DataGridView_CellContentClick);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.Exitbutton.FlatAppearance.BorderSize = 2;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Exitbutton.ForeColor = System.Drawing.Color.Chocolate;
            this.Exitbutton.Location = new System.Drawing.Point(27, 628);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(100, 33);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.Location = new System.Drawing.Point(27, 223);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 33);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonEdit.Location = new System.Drawing.Point(27, 303);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 33);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.Location = new System.Drawing.Point(27, 373);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 33);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // InsertInfopanel
            // 
            this.InsertInfopanel.BackColor = System.Drawing.SystemColors.Window;
            this.InsertInfopanel.Controls.Add(this.buttonClear);
            this.InsertInfopanel.Controls.Add(this.UsrPswrdGna2TxtBx_db);
            this.InsertInfopanel.Controls.Add(this.UserPswrdlabel);
            this.InsertInfopanel.Controls.Add(this.UsrNmGna2TxtBx_db);
            this.InsertInfopanel.Controls.Add(this.UserNamelabel);
            this.InsertInfopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertInfopanel.Location = new System.Drawing.Point(0, 34);
            this.InsertInfopanel.Name = "InsertInfopanel";
            this.InsertInfopanel.Size = new System.Drawing.Size(1280, 90);
            this.InsertInfopanel.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonClear.Location = new System.Drawing.Point(1038, 31);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 33);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // UsrPswrdGna2TxtBx_db
            // 
            this.UsrPswrdGna2TxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsrPswrdGna2TxtBx_db.DefaultText = "";
            this.UsrPswrdGna2TxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsrPswrdGna2TxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsrPswrdGna2TxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsrPswrdGna2TxtBx_db.DisabledState.Parent = this.UsrPswrdGna2TxtBx_db;
            this.UsrPswrdGna2TxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsrPswrdGna2TxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsrPswrdGna2TxtBx_db.FocusedState.Parent = this.UsrPswrdGna2TxtBx_db;
            this.UsrPswrdGna2TxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsrPswrdGna2TxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsrPswrdGna2TxtBx_db.HoverState.Parent = this.UsrPswrdGna2TxtBx_db;
            this.UsrPswrdGna2TxtBx_db.Location = new System.Drawing.Point(741, 39);
            this.UsrPswrdGna2TxtBx_db.Name = "UsrPswrdGna2TxtBx_db";
            this.UsrPswrdGna2TxtBx_db.PasswordChar = '\0';
            this.UsrPswrdGna2TxtBx_db.PlaceholderText = "";
            this.UsrPswrdGna2TxtBx_db.SelectedText = "";
            this.UsrPswrdGna2TxtBx_db.ShadowDecoration.Parent = this.UsrPswrdGna2TxtBx_db;
            this.UsrPswrdGna2TxtBx_db.Size = new System.Drawing.Size(200, 25);
            this.UsrPswrdGna2TxtBx_db.TabIndex = 3;
            this.UsrPswrdGna2TxtBx_db.TextChanged += new System.EventHandler(this.UsrPswrdGna2TxtBx_db_TextChanged);
            // 
            // UserPswrdlabel
            // 
            this.UserPswrdlabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPswrdlabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPswrdlabel.ForeColor = System.Drawing.Color.Chocolate;
            this.UserPswrdlabel.Location = new System.Drawing.Point(547, 39);
            this.UserPswrdlabel.Name = "UserPswrdlabel";
            this.UserPswrdlabel.Size = new System.Drawing.Size(151, 25);
            this.UserPswrdlabel.TabIndex = 2;
            this.UserPswrdlabel.Text = "User Password";
            this.UserPswrdlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsrNmGna2TxtBx_db
            // 
            this.UsrNmGna2TxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsrNmGna2TxtBx_db.DefaultText = "";
            this.UsrNmGna2TxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsrNmGna2TxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsrNmGna2TxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsrNmGna2TxtBx_db.DisabledState.Parent = this.UsrNmGna2TxtBx_db;
            this.UsrNmGna2TxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsrNmGna2TxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsrNmGna2TxtBx_db.FocusedState.Parent = this.UsrNmGna2TxtBx_db;
            this.UsrNmGna2TxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsrNmGna2TxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsrNmGna2TxtBx_db.HoverState.Parent = this.UsrNmGna2TxtBx_db;
            this.UsrNmGna2TxtBx_db.Location = new System.Drawing.Point(271, 39);
            this.UsrNmGna2TxtBx_db.Name = "UsrNmGna2TxtBx_db";
            this.UsrNmGna2TxtBx_db.PasswordChar = '\0';
            this.UsrNmGna2TxtBx_db.PlaceholderText = "";
            this.UsrNmGna2TxtBx_db.SelectedText = "";
            this.UsrNmGna2TxtBx_db.ShadowDecoration.Parent = this.UsrNmGna2TxtBx_db;
            this.UsrNmGna2TxtBx_db.Size = new System.Drawing.Size(200, 25);
            this.UsrNmGna2TxtBx_db.TabIndex = 1;
            this.UsrNmGna2TxtBx_db.TextChanged += new System.EventHandler(this.UsrNmGna2TxtBx_db_TextChanged);
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNamelabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelabel.ForeColor = System.Drawing.Color.Chocolate;
            this.UserNamelabel.Location = new System.Drawing.Point(131, 39);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(95, 25);
            this.UserNamelabel.TabIndex = 0;
            this.UserNamelabel.Text = "User Name";
            this.UserNamelabel.Click += new System.EventHandler(this.UserNamelabel_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonRefresh.FlatAppearance.BorderSize = 2;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonRefresh.Location = new System.Drawing.Point(27, 447);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 33);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "REFRESH";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // UsersManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.InsertInfopanel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.UsersTabList_guna2DataGridView);
            this.Controls.Add(this.Toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersManage";
            this.Load += new System.EventHandler(this.UsersManage_Load);
            this.Toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTabList_guna2DataGridView)).EndInit();
            this.InsertInfopanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private Guna.UI2.WinForms.Guna2DataGridView UsersTabList_guna2DataGridView;
        private System.Windows.Forms.Label UsersManageMsgLabel;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel InsertInfopanel;
        private Guna.UI2.WinForms.Guna2TextBox UsrPswrdGna2TxtBx_db;
        private System.Windows.Forms.Label UserPswrdlabel;
        private Guna.UI2.WinForms.Guna2TextBox UsrNmGna2TxtBx_db;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClear;
    }
}