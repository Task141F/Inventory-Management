namespace GunaWinForm_Add_Login
{
    partial class CategoryManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.CategoryManageMsgLabel = new System.Windows.Forms.Label();
            this.InsertInfopanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.CtgrNmGna2TxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryNamelabel = new System.Windows.Forms.Label();
            this.CtgrIdGna2TxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryIDlabel = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.CategoryTabList_guna2DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.Toppanel.SuspendLayout();
            this.InsertInfopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTabList_guna2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Toppanel.Controls.Add(this.CategoryManageMsgLabel);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(1280, 34);
            this.Toppanel.TabIndex = 8;
            // 
            // CategoryManageMsgLabel
            // 
            this.CategoryManageMsgLabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryManageMsgLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CategoryManageMsgLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.CategoryManageMsgLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.CategoryManageMsgLabel.Location = new System.Drawing.Point(490, 5);
            this.CategoryManageMsgLabel.Name = "CategoryManageMsgLabel";
            this.CategoryManageMsgLabel.Size = new System.Drawing.Size(220, 25);
            this.CategoryManageMsgLabel.TabIndex = 0;
            this.CategoryManageMsgLabel.Text = "Category Management";
            this.CategoryManageMsgLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CategoryManageMsgLabel.Click += new System.EventHandler(this.CategoryManageMsgLabel_Click);
            // 
            // InsertInfopanel
            // 
            this.InsertInfopanel.BackColor = System.Drawing.SystemColors.Window;
            this.InsertInfopanel.Controls.Add(this.buttonClear);
            this.InsertInfopanel.Controls.Add(this.CtgrNmGna2TxtBx_db);
            this.InsertInfopanel.Controls.Add(this.CategoryNamelabel);
            this.InsertInfopanel.Controls.Add(this.CtgrIdGna2TxtBx_db);
            this.InsertInfopanel.Controls.Add(this.CategoryIDlabel);
            this.InsertInfopanel.Location = new System.Drawing.Point(0, 33);
            this.InsertInfopanel.Name = "InsertInfopanel";
            this.InsertInfopanel.Size = new System.Drawing.Size(1280, 77);
            this.InsertInfopanel.TabIndex = 14;
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
            // CtgrNmGna2TxtBx_db
            // 
            this.CtgrNmGna2TxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CtgrNmGna2TxtBx_db.DefaultText = "";
            this.CtgrNmGna2TxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CtgrNmGna2TxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CtgrNmGna2TxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CtgrNmGna2TxtBx_db.DisabledState.Parent = this.CtgrNmGna2TxtBx_db;
            this.CtgrNmGna2TxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CtgrNmGna2TxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CtgrNmGna2TxtBx_db.FocusedState.Parent = this.CtgrNmGna2TxtBx_db;
            this.CtgrNmGna2TxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CtgrNmGna2TxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CtgrNmGna2TxtBx_db.HoverState.Parent = this.CtgrNmGna2TxtBx_db;
            this.CtgrNmGna2TxtBx_db.Location = new System.Drawing.Point(741, 39);
            this.CtgrNmGna2TxtBx_db.Name = "CtgrNmGna2TxtBx_db";
            this.CtgrNmGna2TxtBx_db.PasswordChar = '\0';
            this.CtgrNmGna2TxtBx_db.PlaceholderText = "";
            this.CtgrNmGna2TxtBx_db.SelectedText = "";
            this.CtgrNmGna2TxtBx_db.ShadowDecoration.Parent = this.CtgrNmGna2TxtBx_db;
            this.CtgrNmGna2TxtBx_db.Size = new System.Drawing.Size(200, 25);
            this.CtgrNmGna2TxtBx_db.TabIndex = 3;
            this.CtgrNmGna2TxtBx_db.TextChanged += new System.EventHandler(this.CtgrNmGna2TxtBx_db_TextChanged);
            // 
            // CategoryNamelabel
            // 
            this.CategoryNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryNamelabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNamelabel.ForeColor = System.Drawing.Color.Chocolate;
            this.CategoryNamelabel.Location = new System.Drawing.Point(547, 39);
            this.CategoryNamelabel.Name = "CategoryNamelabel";
            this.CategoryNamelabel.Size = new System.Drawing.Size(151, 25);
            this.CategoryNamelabel.TabIndex = 2;
            this.CategoryNamelabel.Text = "Category name";
            this.CategoryNamelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CategoryNamelabel.Click += new System.EventHandler(this.CategoryNamelabel_Click);
            // 
            // CtgrIdGna2TxtBx_db
            // 
            this.CtgrIdGna2TxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CtgrIdGna2TxtBx_db.DefaultText = "";
            this.CtgrIdGna2TxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CtgrIdGna2TxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CtgrIdGna2TxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CtgrIdGna2TxtBx_db.DisabledState.Parent = this.CtgrIdGna2TxtBx_db;
            this.CtgrIdGna2TxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CtgrIdGna2TxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CtgrIdGna2TxtBx_db.FocusedState.Parent = this.CtgrIdGna2TxtBx_db;
            this.CtgrIdGna2TxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CtgrIdGna2TxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CtgrIdGna2TxtBx_db.HoverState.Parent = this.CtgrIdGna2TxtBx_db;
            this.CtgrIdGna2TxtBx_db.Location = new System.Drawing.Point(271, 39);
            this.CtgrIdGna2TxtBx_db.Name = "CtgrIdGna2TxtBx_db";
            this.CtgrIdGna2TxtBx_db.PasswordChar = '\0';
            this.CtgrIdGna2TxtBx_db.PlaceholderText = "";
            this.CtgrIdGna2TxtBx_db.SelectedText = "";
            this.CtgrIdGna2TxtBx_db.ShadowDecoration.Parent = this.CtgrIdGna2TxtBx_db;
            this.CtgrIdGna2TxtBx_db.Size = new System.Drawing.Size(200, 25);
            this.CtgrIdGna2TxtBx_db.TabIndex = 1;
            this.CtgrIdGna2TxtBx_db.TextChanged += new System.EventHandler(this.CtgrIdGna2TxtBx_db_TextChanged);
            // 
            // CategoryIDlabel
            // 
            this.CategoryIDlabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryIDlabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryIDlabel.ForeColor = System.Drawing.Color.Chocolate;
            this.CategoryIDlabel.Location = new System.Drawing.Point(118, 39);
            this.CategoryIDlabel.Name = "CategoryIDlabel";
            this.CategoryIDlabel.Size = new System.Drawing.Size(108, 25);
            this.CategoryIDlabel.TabIndex = 0;
            this.CategoryIDlabel.Text = "Category ID";
            this.CategoryIDlabel.Click += new System.EventHandler(this.CategoryIDlabel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.Location = new System.Drawing.Point(27, 393);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 33);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonEdit.Location = new System.Drawing.Point(27, 323);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 33);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.Location = new System.Drawing.Point(27, 243);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 33);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.Exitbutton.FlatAppearance.BorderSize = 2;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Exitbutton.ForeColor = System.Drawing.Color.Chocolate;
            this.Exitbutton.Location = new System.Drawing.Point(27, 648);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(100, 33);
            this.Exitbutton.TabIndex = 10;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // CategoryTabList_guna2DataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.CategoryTabList_guna2DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryTabList_guna2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryTabList_guna2DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CategoryTabList_guna2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTabList_guna2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryTabList_guna2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryTabList_guna2DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CategoryTabList_guna2DataGridView.ColumnHeadersHeight = 40;
            this.CategoryTabList_guna2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryTabList_guna2DataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.CategoryTabList_guna2DataGridView.EnableHeadersVisualStyles = false;
            this.CategoryTabList_guna2DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.CategoryTabList_guna2DataGridView.Location = new System.Drawing.Point(325, 203);
            this.CategoryTabList_guna2DataGridView.Name = "CategoryTabList_guna2DataGridView";
            this.CategoryTabList_guna2DataGridView.ReadOnly = true;
            this.CategoryTabList_guna2DataGridView.RowHeadersVisible = false;
            this.CategoryTabList_guna2DataGridView.RowTemplate.Height = 30;
            this.CategoryTabList_guna2DataGridView.RowTemplate.ReadOnly = true;
            this.CategoryTabList_guna2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryTabList_guna2DataGridView.Size = new System.Drawing.Size(720, 478);
            this.CategoryTabList_guna2DataGridView.TabIndex = 9;
            this.CategoryTabList_guna2DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.CategoryTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.CategoryTabList_guna2DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.CategoryTabList_guna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTabList_guna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.ReadOnly = true;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.CategoryTabList_guna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryTabList_guna2DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.CategoryTabList_guna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.CategoryTabList_guna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CategoryTabList_guna2DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryTabList_guna2DataGridView_CellContentClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonRefresh.FlatAppearance.BorderSize = 2;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonRefresh.Location = new System.Drawing.Point(27, 467);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 33);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "REFRESH";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // CategoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.Toppanel);
            this.Controls.Add(this.InsertInfopanel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.CategoryTabList_guna2DataGridView);
            this.Controls.Add(this.buttonRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryManage";
            this.Load += new System.EventHandler(this.CategoryManage_Load);
            this.Toppanel.ResumeLayout(false);
            this.InsertInfopanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTabList_guna2DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Label CategoryManageMsgLabel;
        private System.Windows.Forms.Panel InsertInfopanel;
        private System.Windows.Forms.Button buttonClear;
        private Guna.UI2.WinForms.Guna2TextBox CtgrNmGna2TxtBx_db;
        private System.Windows.Forms.Label CategoryNamelabel;
        private Guna.UI2.WinForms.Guna2TextBox CtgrIdGna2TxtBx_db;
        private System.Windows.Forms.Label CategoryIDlabel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button Exitbutton;
        private Guna.UI2.WinForms.Guna2DataGridView CategoryTabList_guna2DataGridView;
        private System.Windows.Forms.Button buttonRefresh;
    }
}