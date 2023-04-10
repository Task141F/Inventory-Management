namespace GunaWinForm_Add_Login
{
    partial class MainForm
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
            this.Toppanel = new System.Windows.Forms.Panel();
            this.buttonMax = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.Usersbutton = new System.Windows.Forms.Button();
            this.MainMsglabel = new System.Windows.Forms.Label();
            this.Productsbutton = new System.Windows.Forms.Button();
            this.Separatorpanel = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.Fillpanel = new System.Windows.Forms.Panel();
            this.Toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Toppanel.Controls.Add(this.buttonMax);
            this.Toppanel.Controls.Add(this.button2);
            this.Toppanel.Controls.Add(this.button1);
            this.Toppanel.Controls.Add(this.buttonMin);
            this.Toppanel.Controls.Add(this.Usersbutton);
            this.Toppanel.Controls.Add(this.MainMsglabel);
            this.Toppanel.Controls.Add(this.Productsbutton);
            this.Toppanel.Controls.Add(this.Separatorpanel);
            this.Toppanel.Controls.Add(this.buttonClose);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(1260, 60);
            this.Toppanel.TabIndex = 0;
            this.Toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Toppanel_Paint);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.BackColor = System.Drawing.Color.Transparent;
            this.buttonMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.buttonMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMax.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonMax.Location = new System.Drawing.Point(1142, 3);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(50, 32);
            this.buttonMax.TabIndex = 4;
            this.buttonMax.Text = "#";
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Chocolate;
            this.button2.Location = new System.Drawing.Point(255, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sortie EC10";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(134, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Entrée M14";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.BackColor = System.Drawing.Color.Transparent;
            this.buttonMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.buttonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonMin.Location = new System.Drawing.Point(1086, 3);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(50, 32);
            this.buttonMin.TabIndex = 3;
            this.buttonMin.Text = "_";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // Usersbutton
            // 
            this.Usersbutton.BackColor = System.Drawing.Color.Transparent;
            this.Usersbutton.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.Usersbutton.FlatAppearance.BorderSize = 2;
            this.Usersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usersbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Usersbutton.ForeColor = System.Drawing.Color.Chocolate;
            this.Usersbutton.Location = new System.Drawing.Point(376, 19);
            this.Usersbutton.Name = "Usersbutton";
            this.Usersbutton.Size = new System.Drawing.Size(115, 30);
            this.Usersbutton.TabIndex = 1;
            this.Usersbutton.Text = "Users";
            this.Usersbutton.UseVisualStyleBackColor = false;
            this.Usersbutton.Click += new System.EventHandler(this.Usersbutton_Click);
            // 
            // MainMsglabel
            // 
            this.MainMsglabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMsglabel.AutoSize = true;
            this.MainMsglabel.BackColor = System.Drawing.Color.Transparent;
            this.MainMsglabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainMsglabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMsglabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMsglabel.ForeColor = System.Drawing.Color.Chocolate;
            this.MainMsglabel.Location = new System.Drawing.Point(630, 9);
            this.MainMsglabel.Name = "MainMsglabel";
            this.MainMsglabel.Size = new System.Drawing.Size(138, 31);
            this.MainMsglabel.TabIndex = 2;
            this.MainMsglabel.Text = "Main Form";
            // 
            // Productsbutton
            // 
            this.Productsbutton.BackColor = System.Drawing.Color.Transparent;
            this.Productsbutton.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.Productsbutton.FlatAppearance.BorderSize = 2;
            this.Productsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productsbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Productsbutton.ForeColor = System.Drawing.Color.Chocolate;
            this.Productsbutton.Location = new System.Drawing.Point(13, 19);
            this.Productsbutton.Name = "Productsbutton";
            this.Productsbutton.Size = new System.Drawing.Size(115, 30);
            this.Productsbutton.TabIndex = 0;
            this.Productsbutton.Text = "Magasin";
            this.Productsbutton.UseVisualStyleBackColor = false;
            this.Productsbutton.Click += new System.EventHandler(this.Productsbutton_Click);
            // 
            // Separatorpanel
            // 
            this.Separatorpanel.BackColor = System.Drawing.Color.Chocolate;
            this.Separatorpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separatorpanel.Location = new System.Drawing.Point(0, 55);
            this.Separatorpanel.Name = "Separatorpanel";
            this.Separatorpanel.Size = new System.Drawing.Size(1260, 5);
            this.Separatorpanel.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 15.75F);
            this.buttonClose.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonClose.Location = new System.Drawing.Point(1198, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 32);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Fillpanel
            // 
            this.Fillpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fillpanel.Location = new System.Drawing.Point(0, 60);
            this.Fillpanel.Name = "Fillpanel";
            this.Fillpanel.Size = new System.Drawing.Size(1260, 640);
            this.Fillpanel.TabIndex = 2;
            this.Fillpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Fillpanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 700);
            this.Controls.Add(this.Fillpanel);
            this.Controls.Add(this.Toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel Separatorpanel;
        private System.Windows.Forms.Panel Fillpanel;
        private System.Windows.Forms.Label MainMsglabel;
        private System.Windows.Forms.Button Usersbutton;
        private System.Windows.Forms.Button Productsbutton;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMax;
    }
}