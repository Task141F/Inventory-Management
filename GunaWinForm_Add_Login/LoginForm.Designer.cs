namespace GunaWinForm_Add_Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Text1BoxLgFrm = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Text2BoxLgFrm = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ButtonClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonExit = new Guna.UI2.WinForms.Guna2Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 78);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(120, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // guna2Text1BoxLgFrm
            // 
            this.guna2Text1BoxLgFrm.BorderColor = System.Drawing.Color.Chocolate;
            this.guna2Text1BoxLgFrm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Text1BoxLgFrm.DefaultText = "";
            this.guna2Text1BoxLgFrm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2Text1BoxLgFrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2Text1BoxLgFrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Text1BoxLgFrm.DisabledState.Parent = this.guna2Text1BoxLgFrm;
            this.guna2Text1BoxLgFrm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Text1BoxLgFrm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Text1BoxLgFrm.FocusedState.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Text1BoxLgFrm.FocusedState.Parent = this.guna2Text1BoxLgFrm;
            this.guna2Text1BoxLgFrm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Text1BoxLgFrm.ForeColor = System.Drawing.Color.Chocolate;
            this.guna2Text1BoxLgFrm.HoverState.BorderColor = System.Drawing.Color.SandyBrown;
            this.guna2Text1BoxLgFrm.HoverState.Parent = this.guna2Text1BoxLgFrm;
            this.guna2Text1BoxLgFrm.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2Text1BoxLgFrm.IconLeft")));
            this.guna2Text1BoxLgFrm.Location = new System.Drawing.Point(42, 191);
            this.guna2Text1BoxLgFrm.Name = "guna2Text1BoxLgFrm";
            this.guna2Text1BoxLgFrm.PasswordChar = '\0';
            this.guna2Text1BoxLgFrm.PlaceholderForeColor = System.Drawing.Color.Chocolate;
            this.guna2Text1BoxLgFrm.PlaceholderText = "Enter Your Username";
            this.guna2Text1BoxLgFrm.SelectedText = "";
            this.guna2Text1BoxLgFrm.ShadowDecoration.Parent = this.guna2Text1BoxLgFrm;
            this.guna2Text1BoxLgFrm.Size = new System.Drawing.Size(260, 36);
            this.guna2Text1BoxLgFrm.TabIndex = 1;
            this.guna2Text1BoxLgFrm.TextOffset = new System.Drawing.Point(8, 0);
            this.guna2Text1BoxLgFrm.TextChanged += new System.EventHandler(this.guna2Text1BoxLgFrm_TextChanged);
            // 
            // guna2Text2BoxLgFrm
            // 
            this.guna2Text2BoxLgFrm.BorderColor = System.Drawing.Color.Chocolate;
            this.guna2Text2BoxLgFrm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Text2BoxLgFrm.DefaultText = "";
            this.guna2Text2BoxLgFrm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2Text2BoxLgFrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2Text2BoxLgFrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Text2BoxLgFrm.DisabledState.Parent = this.guna2Text2BoxLgFrm;
            this.guna2Text2BoxLgFrm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Text2BoxLgFrm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Text2BoxLgFrm.FocusedState.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Text2BoxLgFrm.FocusedState.Parent = this.guna2Text2BoxLgFrm;
            this.guna2Text2BoxLgFrm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Text2BoxLgFrm.ForeColor = System.Drawing.Color.Chocolate;
            this.guna2Text2BoxLgFrm.HoverState.BorderColor = System.Drawing.Color.SandyBrown;
            this.guna2Text2BoxLgFrm.HoverState.Parent = this.guna2Text2BoxLgFrm;
            this.guna2Text2BoxLgFrm.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2Text2BoxLgFrm.IconLeft")));
            this.guna2Text2BoxLgFrm.Location = new System.Drawing.Point(42, 279);
            this.guna2Text2BoxLgFrm.Name = "guna2Text2BoxLgFrm";
            this.guna2Text2BoxLgFrm.PasswordChar = '\0';
            this.guna2Text2BoxLgFrm.PlaceholderForeColor = System.Drawing.Color.Chocolate;
            this.guna2Text2BoxLgFrm.PlaceholderText = "Enter Your Password";
            this.guna2Text2BoxLgFrm.SelectedText = "";
            this.guna2Text2BoxLgFrm.ShadowDecoration.Parent = this.guna2Text2BoxLgFrm;
            this.guna2Text2BoxLgFrm.Size = new System.Drawing.Size(260, 36);
            this.guna2Text2BoxLgFrm.TabIndex = 2;
            this.guna2Text2BoxLgFrm.TextOffset = new System.Drawing.Point(8, 0);
            this.guna2Text2BoxLgFrm.UseSystemPasswordChar = true;
            this.guna2Text2BoxLgFrm.TextChanged += new System.EventHandler(this.guna2Text2BoxLgFrm_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Location = new System.Drawing.Point(74, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chocolate;
            this.panel3.Location = new System.Drawing.Point(74, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 4;
            // 
            // guna2ButtonClear
            // 
            this.guna2ButtonClear.BorderColor = System.Drawing.Color.Empty;
            this.guna2ButtonClear.CheckedState.Parent = this.guna2ButtonClear;
            this.guna2ButtonClear.CustomImages.Parent = this.guna2ButtonClear;
            this.guna2ButtonClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonClear.DisabledState.Parent = this.guna2ButtonClear;
            this.guna2ButtonClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ButtonClear.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonClear.ForeColor = System.Drawing.Color.Chocolate;
            this.guna2ButtonClear.HoverState.Parent = this.guna2ButtonClear;
            this.guna2ButtonClear.Location = new System.Drawing.Point(23, 363);
            this.guna2ButtonClear.Name = "guna2ButtonClear";
            this.guna2ButtonClear.ShadowDecoration.Parent = this.guna2ButtonClear;
            this.guna2ButtonClear.Size = new System.Drawing.Size(77, 27);
            this.guna2ButtonClear.TabIndex = 5;
            this.guna2ButtonClear.Text = "Clear";
            this.guna2ButtonClear.Click += new System.EventHandler(this.guna2ButtonClear_Click);
            // 
            // guna2ButtonLogin
            // 
            this.guna2ButtonLogin.BorderColor = System.Drawing.Color.Chocolate;
            this.guna2ButtonLogin.BorderThickness = 2;
            this.guna2ButtonLogin.CheckedState.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.CustomImages.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonLogin.DisabledState.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ButtonLogin.Font = new System.Drawing.Font("Arial", 15.75F);
            this.guna2ButtonLogin.ForeColor = System.Drawing.Color.Chocolate;
            this.guna2ButtonLogin.HoverState.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.Location = new System.Drawing.Point(110, 474);
            this.guna2ButtonLogin.Name = "guna2ButtonLogin";
            this.guna2ButtonLogin.ShadowDecoration.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.Size = new System.Drawing.Size(86, 33);
            this.guna2ButtonLogin.TabIndex = 7;
            this.guna2ButtonLogin.Text = "login";
            //this.guna2ButtonLogin.Click += new System.EventHandler(this.guna2ButtonLogin_Click);
            // 
            // guna2ButtonExit
            // 
            this.guna2ButtonExit.BorderColor = System.Drawing.Color.Chocolate;
            this.guna2ButtonExit.BorderThickness = 2;
            this.guna2ButtonExit.CheckedState.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.CustomImages.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonExit.DisabledState.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ButtonExit.Font = new System.Drawing.Font("Arial", 15.75F);
            this.guna2ButtonExit.ForeColor = System.Drawing.Color.Chocolate;
            this.guna2ButtonExit.HoverState.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.Location = new System.Drawing.Point(119, 615);
            this.guna2ButtonExit.Name = "guna2ButtonExit";
            this.guna2ButtonExit.ShadowDecoration.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.Size = new System.Drawing.Size(77, 27);
            this.guna2ButtonExit.TabIndex = 8;
            this.guna2ButtonExit.Text = "Exit";
            this.guna2ButtonExit.Click += new System.EventHandler(this.guna2ButtonExit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chocolate;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Century", 11.25F);
            this.checkBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.checkBox1.Location = new System.Drawing.Point(165, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 22);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(344, 768);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.guna2ButtonExit);
            this.Controls.Add(this.guna2ButtonLogin);
            this.Controls.Add(this.guna2ButtonClear);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Text2BoxLgFrm);
            this.Controls.Add(this.guna2Text1BoxLgFrm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2TextBox guna2Text1BoxLgFrm;
        public Guna.UI2.WinForms.Guna2TextBox guna2Text2BoxLgFrm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonClear;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonLogin;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

