namespace GunaWinForm_Add_Login
{
    partial class ProductsManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrdctMngPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.PrdctSlctCtgrComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SearchFillPanelTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.PrdctsTabList_guna2DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.InsertInfopanel = new System.Windows.Forms.Panel();
            this.ToCtgrMngButton = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.PrdctEmplcmntMgsnTxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PrdctDateFactrTxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductIDlabel = new System.Windows.Forms.Label();
            this.PrdctQteTxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrdctDésignationTxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrdctRéfPiéceTxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductQtelabel = new System.Windows.Forms.Label();
            this.PrdctRéfMoyenTxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrdctMrqTxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.PrdctFctrNmbrTxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductNamelabel = new System.Windows.Forms.Label();
            this.PrdctExpdtrTxtBx_db = new Guna.UI2.WinForms.Guna2TextBox();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.PrdctsManageMsgLabel = new System.Windows.Forms.Label();
            this.PrdctMngPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrdctsTabList_guna2DataGridView)).BeginInit();
            this.InsertInfopanel.SuspendLayout();
            this.Toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrdctMngPanel
            // 
            this.PrdctMngPanel.Controls.Add(this.ButtonsPanel);
            this.PrdctMngPanel.Controls.Add(this.PrdctsTabList_guna2DataGridView);
            this.PrdctMngPanel.Controls.Add(this.InsertInfopanel);
            this.PrdctMngPanel.Controls.Add(this.Toppanel);
            this.PrdctMngPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrdctMngPanel.Location = new System.Drawing.Point(0, 0);
            this.PrdctMngPanel.Name = "PrdctMngPanel";
            this.PrdctMngPanel.Size = new System.Drawing.Size(1280, 700);
            this.PrdctMngPanel.TabIndex = 0;
            this.PrdctMngPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PrdctMngPanel_Paint);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.PrdctSlctCtgrComboBox);
            this.ButtonsPanel.Controls.Add(this.SearchFillPanelTextBox);
            this.ButtonsPanel.Controls.Add(this.Exitbutton);
            this.ButtonsPanel.Controls.Add(this.buttonRefresh);
            this.ButtonsPanel.Controls.Add(this.buttonSearch);
            this.ButtonsPanel.Controls.Add(this.buttonDelete);
            this.ButtonsPanel.Controls.Add(this.buttonEdit);
            this.ButtonsPanel.Controls.Add(this.buttonAdd);
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 160);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(1280, 61);
            this.ButtonsPanel.TabIndex = 51;
            this.ButtonsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonsPanel_Paint);
            // 
            // PrdctSlctCtgrComboBox
            // 
            this.PrdctSlctCtgrComboBox.BackColor = System.Drawing.Color.Transparent;
            this.PrdctSlctCtgrComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PrdctSlctCtgrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrdctSlctCtgrComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctSlctCtgrComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctSlctCtgrComboBox.FocusedState.Parent = this.PrdctSlctCtgrComboBox;
            this.PrdctSlctCtgrComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrdctSlctCtgrComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PrdctSlctCtgrComboBox.HoverState.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PrdctSlctCtgrComboBox.HoverState.ForeColor = System.Drawing.Color.Chocolate;
            this.PrdctSlctCtgrComboBox.HoverState.Parent = this.PrdctSlctCtgrComboBox;
            this.PrdctSlctCtgrComboBox.ItemHeight = 30;
            this.PrdctSlctCtgrComboBox.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PrdctSlctCtgrComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.Chocolate;
            this.PrdctSlctCtgrComboBox.ItemsAppearance.Parent = this.PrdctSlctCtgrComboBox;
            this.PrdctSlctCtgrComboBox.Location = new System.Drawing.Point(925, 15);
            this.PrdctSlctCtgrComboBox.Name = "PrdctSlctCtgrComboBox";
            this.PrdctSlctCtgrComboBox.ShadowDecoration.Parent = this.PrdctSlctCtgrComboBox;
            this.PrdctSlctCtgrComboBox.Size = new System.Drawing.Size(200, 36);
            this.PrdctSlctCtgrComboBox.TabIndex = 57;
            this.PrdctSlctCtgrComboBox.SelectedIndexChanged += new System.EventHandler(this.PrdctSlctCtgrComboBox_SelectedIndexChanged);
            // 
            // SearchFillPanelTextBox
            // 
            this.SearchFillPanelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchFillPanelTextBox.DefaultText = "";
            this.SearchFillPanelTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchFillPanelTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchFillPanelTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchFillPanelTextBox.DisabledState.Parent = this.SearchFillPanelTextBox;
            this.SearchFillPanelTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchFillPanelTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchFillPanelTextBox.FocusedState.Parent = this.SearchFillPanelTextBox;
            this.SearchFillPanelTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchFillPanelTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchFillPanelTextBox.HoverState.Parent = this.SearchFillPanelTextBox;
            this.SearchFillPanelTextBox.Location = new System.Drawing.Point(669, 20);
            this.SearchFillPanelTextBox.Name = "SearchFillPanelTextBox";
            this.SearchFillPanelTextBox.PasswordChar = '\0';
            this.SearchFillPanelTextBox.PlaceholderText = "";
            this.SearchFillPanelTextBox.SelectedText = "";
            this.SearchFillPanelTextBox.ShadowDecoration.Parent = this.SearchFillPanelTextBox;
            this.SearchFillPanelTextBox.Size = new System.Drawing.Size(240, 25);
            this.SearchFillPanelTextBox.TabIndex = 56;
            this.SearchFillPanelTextBox.TextChanged += new System.EventHandler(this.SearchFillPanelTextBox_TextChanged);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.Exitbutton.FlatAppearance.BorderSize = 2;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Exitbutton.ForeColor = System.Drawing.Color.Chocolate;
            this.Exitbutton.Location = new System.Drawing.Point(1137, 18);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(100, 29);
            this.Exitbutton.TabIndex = 55;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonRefresh.FlatAppearance.BorderSize = 2;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonRefresh.Location = new System.Drawing.Point(413, 18);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 29);
            this.buttonRefresh.TabIndex = 54;
            this.buttonRefresh.Text = "REFRESH";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonSearch.Location = new System.Drawing.Point(543, 18);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 29);
            this.buttonSearch.TabIndex = 53;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.Location = new System.Drawing.Point(281, 18);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 29);
            this.buttonDelete.TabIndex = 52;
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
            this.buttonEdit.Location = new System.Drawing.Point(149, 18);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 29);
            this.buttonEdit.TabIndex = 51;
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
            this.buttonAdd.Location = new System.Drawing.Point(17, 18);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 29);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // PrdctsTabList_guna2DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.PrdctsTabList_guna2DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PrdctsTabList_guna2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PrdctsTabList_guna2DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PrdctsTabList_guna2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrdctsTabList_guna2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrdctsTabList_guna2DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PrdctsTabList_guna2DataGridView.ColumnHeadersHeight = 40;
            this.PrdctsTabList_guna2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrdctsTabList_guna2DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrdctsTabList_guna2DataGridView.EnableHeadersVisualStyles = false;
            this.PrdctsTabList_guna2DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.PrdctsTabList_guna2DataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrdctsTabList_guna2DataGridView.Location = new System.Drawing.Point(10, 253);
            this.PrdctsTabList_guna2DataGridView.Name = "PrdctsTabList_guna2DataGridView";
            this.PrdctsTabList_guna2DataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrdctsTabList_guna2DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PrdctsTabList_guna2DataGridView.RowHeadersVisible = false;
            this.PrdctsTabList_guna2DataGridView.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrdctsTabList_guna2DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.PrdctsTabList_guna2DataGridView.RowTemplate.Height = 30;
            this.PrdctsTabList_guna2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrdctsTabList_guna2DataGridView.Size = new System.Drawing.Size(1260, 435);
            this.PrdctsTabList_guna2DataGridView.TabIndex = 50;
            this.PrdctsTabList_guna2DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.ReadOnly = true;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.PrdctsTabList_guna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.PrdctsTabList_guna2DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrdctsTabList_guna2DataGridView_CellContentClick);
            // 
            // InsertInfopanel
            // 
            this.InsertInfopanel.BackColor = System.Drawing.SystemColors.Window;
            this.InsertInfopanel.Controls.Add(this.ToCtgrMngButton);
            this.InsertInfopanel.Controls.Add(this.buttonClear);
            this.InsertInfopanel.Controls.Add(this.PrdctEmplcmntMgsnTxtBx_db);
            this.InsertInfopanel.Controls.Add(this.label5);
            this.InsertInfopanel.Controls.Add(this.PrdctDateFactrTxtBx_db);
            this.InsertInfopanel.Controls.Add(this.ProductIDlabel);
            this.InsertInfopanel.Controls.Add(this.PrdctQteTxtBx_db);
            this.InsertInfopanel.Controls.Add(this.label6);
            this.InsertInfopanel.Controls.Add(this.label4);
            this.InsertInfopanel.Controls.Add(this.PrdctDésignationTxtBx_db);
            this.InsertInfopanel.Controls.Add(this.label3);
            this.InsertInfopanel.Controls.Add(this.PrdctRéfPiéceTxtBx_db);
            this.InsertInfopanel.Controls.Add(this.label2);
            this.InsertInfopanel.Controls.Add(this.ProductQtelabel);
            this.InsertInfopanel.Controls.Add(this.PrdctRéfMoyenTxtBx_db);
            this.InsertInfopanel.Controls.Add(this.label1);
            this.InsertInfopanel.Controls.Add(this.PrdctMrqTxtBx_db);
            this.InsertInfopanel.Controls.Add(this.PrdctFctrNmbrTxtBx_db);
            this.InsertInfopanel.Controls.Add(this.ProductNamelabel);
            this.InsertInfopanel.Controls.Add(this.PrdctExpdtrTxtBx_db);
            this.InsertInfopanel.Location = new System.Drawing.Point(0, 34);
            this.InsertInfopanel.Name = "InsertInfopanel";
            this.InsertInfopanel.Size = new System.Drawing.Size(1280, 126);
            this.InsertInfopanel.TabIndex = 33;
            this.InsertInfopanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InsertInfopanel_Paint);
            // 
            // ToCtgrMngButton
            // 
            this.ToCtgrMngButton.BackColor = System.Drawing.Color.Transparent;
            this.ToCtgrMngButton.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.ToCtgrMngButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToCtgrMngButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ToCtgrMngButton.ForeColor = System.Drawing.Color.Chocolate;
            this.ToCtgrMngButton.Location = new System.Drawing.Point(1126, 12);
            this.ToCtgrMngButton.Name = "ToCtgrMngButton";
            this.ToCtgrMngButton.Size = new System.Drawing.Size(102, 33);
            this.ToCtgrMngButton.TabIndex = 30;
            this.ToCtgrMngButton.Text = "Category";
            this.ToCtgrMngButton.UseVisualStyleBackColor = false;
            this.ToCtgrMngButton.Click += new System.EventHandler(this.ToCtgrMngButton_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonClear.Location = new System.Drawing.Point(1126, 82);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 33);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // PrdctEmplcmntMgsnTxtBx_db
            // 
            this.PrdctEmplcmntMgsnTxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrdctEmplcmntMgsnTxtBx_db.DefaultText = "";
            this.PrdctEmplcmntMgsnTxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrdctEmplcmntMgsnTxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrdctEmplcmntMgsnTxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctEmplcmntMgsnTxtBx_db.DisabledState.Parent = this.PrdctEmplcmntMgsnTxtBx_db;
            this.PrdctEmplcmntMgsnTxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctEmplcmntMgsnTxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctEmplcmntMgsnTxtBx_db.FocusedState.Parent = this.PrdctEmplcmntMgsnTxtBx_db;
            this.PrdctEmplcmntMgsnTxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrdctEmplcmntMgsnTxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctEmplcmntMgsnTxtBx_db.HoverState.Parent = this.PrdctEmplcmntMgsnTxtBx_db;
            this.PrdctEmplcmntMgsnTxtBx_db.Location = new System.Drawing.Point(574, 90);
            this.PrdctEmplcmntMgsnTxtBx_db.Name = "PrdctEmplcmntMgsnTxtBx_db";
            this.PrdctEmplcmntMgsnTxtBx_db.PasswordChar = '\0';
            this.PrdctEmplcmntMgsnTxtBx_db.PlaceholderText = "";
            this.PrdctEmplcmntMgsnTxtBx_db.SelectedText = "";
            this.PrdctEmplcmntMgsnTxtBx_db.ShadowDecoration.Parent = this.PrdctEmplcmntMgsnTxtBx_db;
            this.PrdctEmplcmntMgsnTxtBx_db.Size = new System.Drawing.Size(160, 25);
            this.PrdctEmplcmntMgsnTxtBx_db.TabIndex = 28;
            this.PrdctEmplcmntMgsnTxtBx_db.TextChanged += new System.EventHandler(this.PrdctEmplcmntMgsnTxtBx_db_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(373, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Emplacement Magasin";
            // 
            // PrdctDateFactrTxtBx_db
            // 
            this.PrdctDateFactrTxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrdctDateFactrTxtBx_db.DefaultText = "";
            this.PrdctDateFactrTxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrdctDateFactrTxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrdctDateFactrTxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctDateFactrTxtBx_db.DisabledState.Parent = this.PrdctDateFactrTxtBx_db;
            this.PrdctDateFactrTxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctDateFactrTxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctDateFactrTxtBx_db.FocusedState.Parent = this.PrdctDateFactrTxtBx_db;
            this.PrdctDateFactrTxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrdctDateFactrTxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctDateFactrTxtBx_db.HoverState.Parent = this.PrdctDateFactrTxtBx_db;
            this.PrdctDateFactrTxtBx_db.Location = new System.Drawing.Point(902, 90);
            this.PrdctDateFactrTxtBx_db.Name = "PrdctDateFactrTxtBx_db";
            this.PrdctDateFactrTxtBx_db.PasswordChar = '\0';
            this.PrdctDateFactrTxtBx_db.PlaceholderText = "";
            this.PrdctDateFactrTxtBx_db.SelectedText = "";
            this.PrdctDateFactrTxtBx_db.ShadowDecoration.Parent = this.PrdctDateFactrTxtBx_db;
            this.PrdctDateFactrTxtBx_db.Size = new System.Drawing.Size(160, 25);
            this.PrdctDateFactrTxtBx_db.TabIndex = 26;
            // 
            // ProductIDlabel
            // 
            this.ProductIDlabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductIDlabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDlabel.ForeColor = System.Drawing.Color.Chocolate;
            this.ProductIDlabel.Location = new System.Drawing.Point(373, 12);
            this.ProductIDlabel.Name = "ProductIDlabel";
            this.ProductIDlabel.Size = new System.Drawing.Size(90, 25);
            this.ProductIDlabel.TabIndex = 24;
            this.ProductIDlabel.Text = "N°Facture";
            // 
            // PrdctQteTxtBx_db
            // 
            this.PrdctQteTxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrdctQteTxtBx_db.DefaultText = "";
            this.PrdctQteTxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrdctQteTxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrdctQteTxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctQteTxtBx_db.DisabledState.Parent = this.PrdctQteTxtBx_db;
            this.PrdctQteTxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctQteTxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctQteTxtBx_db.FocusedState.Parent = this.PrdctQteTxtBx_db;
            this.PrdctQteTxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrdctQteTxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctQteTxtBx_db.HoverState.Parent = this.PrdctQteTxtBx_db;
            this.PrdctQteTxtBx_db.Location = new System.Drawing.Point(173, 90);
            this.PrdctQteTxtBx_db.Name = "PrdctQteTxtBx_db";
            this.PrdctQteTxtBx_db.PasswordChar = '\0';
            this.PrdctQteTxtBx_db.PlaceholderText = "";
            this.PrdctQteTxtBx_db.SelectedText = "";
            this.PrdctQteTxtBx_db.ShadowDecoration.Parent = this.PrdctQteTxtBx_db;
            this.PrdctQteTxtBx_db.Size = new System.Drawing.Size(160, 25);
            this.PrdctQteTxtBx_db.TabIndex = 22;
            this.PrdctQteTxtBx_db.TextChanged += new System.EventHandler(this.PrdctQteTxtBx_db_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Expéditeur";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Qte";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PrdctDésignationTxtBx_db
            // 
            this.PrdctDésignationTxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrdctDésignationTxtBx_db.DefaultText = "";
            this.PrdctDésignationTxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrdctDésignationTxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrdctDésignationTxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctDésignationTxtBx_db.DisabledState.Parent = this.PrdctDésignationTxtBx_db;
            this.PrdctDésignationTxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctDésignationTxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctDésignationTxtBx_db.FocusedState.Parent = this.PrdctDésignationTxtBx_db;
            this.PrdctDésignationTxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrdctDésignationTxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctDésignationTxtBx_db.HoverState.Parent = this.PrdctDésignationTxtBx_db;
            this.PrdctDésignationTxtBx_db.Location = new System.Drawing.Point(902, 51);
            this.PrdctDésignationTxtBx_db.Name = "PrdctDésignationTxtBx_db";
            this.PrdctDésignationTxtBx_db.PasswordChar = '\0';
            this.PrdctDésignationTxtBx_db.PlaceholderText = "";
            this.PrdctDésignationTxtBx_db.SelectedText = "";
            this.PrdctDésignationTxtBx_db.ShadowDecoration.Parent = this.PrdctDésignationTxtBx_db;
            this.PrdctDésignationTxtBx_db.Size = new System.Drawing.Size(160, 25);
            this.PrdctDésignationTxtBx_db.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(773, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Désignation";
            // 
            // PrdctRéfPiéceTxtBx_db
            // 
            this.PrdctRéfPiéceTxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrdctRéfPiéceTxtBx_db.DefaultText = "";
            this.PrdctRéfPiéceTxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrdctRéfPiéceTxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrdctRéfPiéceTxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctRéfPiéceTxtBx_db.DisabledState.Parent = this.PrdctRéfPiéceTxtBx_db;
            this.PrdctRéfPiéceTxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctRéfPiéceTxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctRéfPiéceTxtBx_db.FocusedState.Parent = this.PrdctRéfPiéceTxtBx_db;
            this.PrdctRéfPiéceTxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrdctRéfPiéceTxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctRéfPiéceTxtBx_db.HoverState.Parent = this.PrdctRéfPiéceTxtBx_db;
            this.PrdctRéfPiéceTxtBx_db.Location = new System.Drawing.Point(574, 51);
            this.PrdctRéfPiéceTxtBx_db.Name = "PrdctRéfPiéceTxtBx_db";
            this.PrdctRéfPiéceTxtBx_db.PasswordChar = '\0';
            this.PrdctRéfPiéceTxtBx_db.PlaceholderText = "";
            this.PrdctRéfPiéceTxtBx_db.SelectedText = "";
            this.PrdctRéfPiéceTxtBx_db.ShadowDecoration.Parent = this.PrdctRéfPiéceTxtBx_db;
            this.PrdctRéfPiéceTxtBx_db.Size = new System.Drawing.Size(160, 25);
            this.PrdctRéfPiéceTxtBx_db.TabIndex = 18;
            this.PrdctRéfPiéceTxtBx_db.TextChanged += new System.EventHandler(this.PrdctRéfPiéceTxtBx_db_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(373, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Référence Piéce";
            // 
            // ProductQtelabel
            // 
            this.ProductQtelabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductQtelabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQtelabel.ForeColor = System.Drawing.Color.Chocolate;
            this.ProductQtelabel.Location = new System.Drawing.Point(773, 12);
            this.ProductQtelabel.Name = "ProductQtelabel";
            this.ProductQtelabel.Size = new System.Drawing.Size(70, 25);
            this.ProductQtelabel.TabIndex = 13;
            this.ProductQtelabel.Text = "Marque";
            this.ProductQtelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrdctRéfMoyenTxtBx_db
            // 
            this.PrdctRéfMoyenTxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrdctRéfMoyenTxtBx_db.DefaultText = "";
            this.PrdctRéfMoyenTxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrdctRéfMoyenTxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrdctRéfMoyenTxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctRéfMoyenTxtBx_db.DisabledState.Parent = this.PrdctRéfMoyenTxtBx_db;
            this.PrdctRéfMoyenTxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctRéfMoyenTxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctRéfMoyenTxtBx_db.FocusedState.Parent = this.PrdctRéfMoyenTxtBx_db;
            this.PrdctRéfMoyenTxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrdctRéfMoyenTxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctRéfMoyenTxtBx_db.HoverState.Parent = this.PrdctRéfMoyenTxtBx_db;
            this.PrdctRéfMoyenTxtBx_db.Location = new System.Drawing.Point(173, 51);
            this.PrdctRéfMoyenTxtBx_db.Name = "PrdctRéfMoyenTxtBx_db";
            this.PrdctRéfMoyenTxtBx_db.PasswordChar = '\0';
            this.PrdctRéfMoyenTxtBx_db.PlaceholderText = "";
            this.PrdctRéfMoyenTxtBx_db.SelectedText = "";
            this.PrdctRéfMoyenTxtBx_db.ShadowDecoration.Parent = this.PrdctRéfMoyenTxtBx_db;
            this.PrdctRéfMoyenTxtBx_db.Size = new System.Drawing.Size(160, 25);
            this.PrdctRéfMoyenTxtBx_db.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Référence Moyen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrdctMrqTxtBx_db
            // 
            this.PrdctMrqTxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrdctMrqTxtBx_db.DefaultText = "";
            this.PrdctMrqTxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrdctMrqTxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrdctMrqTxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctMrqTxtBx_db.DisabledState.Parent = this.PrdctMrqTxtBx_db;
            this.PrdctMrqTxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctMrqTxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctMrqTxtBx_db.FocusedState.Parent = this.PrdctMrqTxtBx_db;
            this.PrdctMrqTxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrdctMrqTxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctMrqTxtBx_db.HoverState.Parent = this.PrdctMrqTxtBx_db;
            this.PrdctMrqTxtBx_db.Location = new System.Drawing.Point(902, 12);
            this.PrdctMrqTxtBx_db.Name = "PrdctMrqTxtBx_db";
            this.PrdctMrqTxtBx_db.PasswordChar = '\0';
            this.PrdctMrqTxtBx_db.PlaceholderText = "";
            this.PrdctMrqTxtBx_db.SelectedText = "";
            this.PrdctMrqTxtBx_db.ShadowDecoration.Parent = this.PrdctMrqTxtBx_db;
            this.PrdctMrqTxtBx_db.Size = new System.Drawing.Size(160, 25);
            this.PrdctMrqTxtBx_db.TabIndex = 14;
            // 
            // PrdctFctrNmbrTxtBx_db
            // 
            this.PrdctFctrNmbrTxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrdctFctrNmbrTxtBx_db.DefaultText = "";
            this.PrdctFctrNmbrTxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrdctFctrNmbrTxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrdctFctrNmbrTxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctFctrNmbrTxtBx_db.DisabledState.Parent = this.PrdctFctrNmbrTxtBx_db;
            this.PrdctFctrNmbrTxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctFctrNmbrTxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctFctrNmbrTxtBx_db.FocusedState.Parent = this.PrdctFctrNmbrTxtBx_db;
            this.PrdctFctrNmbrTxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrdctFctrNmbrTxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctFctrNmbrTxtBx_db.HoverState.Parent = this.PrdctFctrNmbrTxtBx_db;
            this.PrdctFctrNmbrTxtBx_db.Location = new System.Drawing.Point(574, 12);
            this.PrdctFctrNmbrTxtBx_db.Name = "PrdctFctrNmbrTxtBx_db";
            this.PrdctFctrNmbrTxtBx_db.PasswordChar = '\0';
            this.PrdctFctrNmbrTxtBx_db.PlaceholderText = "";
            this.PrdctFctrNmbrTxtBx_db.SelectedText = "";
            this.PrdctFctrNmbrTxtBx_db.ShadowDecoration.Parent = this.PrdctFctrNmbrTxtBx_db;
            this.PrdctFctrNmbrTxtBx_db.Size = new System.Drawing.Size(160, 25);
            this.PrdctFctrNmbrTxtBx_db.TabIndex = 3;
            // 
            // ProductNamelabel
            // 
            this.ProductNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductNamelabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNamelabel.ForeColor = System.Drawing.Color.Chocolate;
            this.ProductNamelabel.Location = new System.Drawing.Point(773, 90);
            this.ProductNamelabel.Name = "ProductNamelabel";
            this.ProductNamelabel.Size = new System.Drawing.Size(110, 25);
            this.ProductNamelabel.TabIndex = 2;
            this.ProductNamelabel.Text = "Date Facture";
            this.ProductNamelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrdctExpdtrTxtBx_db
            // 
            this.PrdctExpdtrTxtBx_db.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrdctExpdtrTxtBx_db.DefaultText = "";
            this.PrdctExpdtrTxtBx_db.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrdctExpdtrTxtBx_db.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrdctExpdtrTxtBx_db.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctExpdtrTxtBx_db.DisabledState.Parent = this.PrdctExpdtrTxtBx_db;
            this.PrdctExpdtrTxtBx_db.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrdctExpdtrTxtBx_db.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctExpdtrTxtBx_db.FocusedState.Parent = this.PrdctExpdtrTxtBx_db;
            this.PrdctExpdtrTxtBx_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrdctExpdtrTxtBx_db.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrdctExpdtrTxtBx_db.HoverState.Parent = this.PrdctExpdtrTxtBx_db;
            this.PrdctExpdtrTxtBx_db.Location = new System.Drawing.Point(173, 12);
            this.PrdctExpdtrTxtBx_db.Name = "PrdctExpdtrTxtBx_db";
            this.PrdctExpdtrTxtBx_db.PasswordChar = '\0';
            this.PrdctExpdtrTxtBx_db.PlaceholderText = "";
            this.PrdctExpdtrTxtBx_db.SelectedText = "";
            this.PrdctExpdtrTxtBx_db.ShadowDecoration.Parent = this.PrdctExpdtrTxtBx_db;
            this.PrdctExpdtrTxtBx_db.Size = new System.Drawing.Size(160, 25);
            this.PrdctExpdtrTxtBx_db.TabIndex = 1;
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Toppanel.Controls.Add(this.PrdctsManageMsgLabel);
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(1280, 34);
            this.Toppanel.TabIndex = 32;
            this.Toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Toppanel_Paint);
            // 
            // PrdctsManageMsgLabel
            // 
            this.PrdctsManageMsgLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrdctsManageMsgLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PrdctsManageMsgLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.PrdctsManageMsgLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.PrdctsManageMsgLabel.Location = new System.Drawing.Point(490, 5);
            this.PrdctsManageMsgLabel.Name = "PrdctsManageMsgLabel";
            this.PrdctsManageMsgLabel.Size = new System.Drawing.Size(220, 25);
            this.PrdctsManageMsgLabel.TabIndex = 0;
            this.PrdctsManageMsgLabel.Text = "Status Générale De Stock";
            this.PrdctsManageMsgLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductsManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.PrdctMngPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PrdctMngPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrdctsTabList_guna2DataGridView)).EndInit();
            this.InsertInfopanel.ResumeLayout(false);
            this.Toppanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PrdctMngPanel;
        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Label PrdctsManageMsgLabel;
        private System.Windows.Forms.Panel InsertInfopanel;
        private System.Windows.Forms.Button ToCtgrMngButton;
        private System.Windows.Forms.Button buttonClear;
        private Guna.UI2.WinForms.Guna2TextBox PrdctEmplcmntMgsnTxtBx_db;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox PrdctDateFactrTxtBx_db;
        private System.Windows.Forms.Label ProductIDlabel;
        private Guna.UI2.WinForms.Guna2TextBox PrdctQteTxtBx_db;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox PrdctDésignationTxtBx_db;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox PrdctRéfPiéceTxtBx_db;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductQtelabel;
        private Guna.UI2.WinForms.Guna2TextBox PrdctRéfMoyenTxtBx_db;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PrdctMrqTxtBx_db;
        private Guna.UI2.WinForms.Guna2TextBox PrdctFctrNmbrTxtBx_db;
        private System.Windows.Forms.Label ProductNamelabel;
        private Guna.UI2.WinForms.Guna2TextBox PrdctExpdtrTxtBx_db;
        private Guna.UI2.WinForms.Guna2DataGridView PrdctsTabList_guna2DataGridView;
        private System.Windows.Forms.Panel ButtonsPanel;
        private Guna.UI2.WinForms.Guna2ComboBox PrdctSlctCtgrComboBox;
        private Guna.UI2.WinForms.Guna2TextBox SearchFillPanelTextBox;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}