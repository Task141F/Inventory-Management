namespace GunaWinForm_Add_Login
{
    partial class MessgeBoxForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.MsgBxGuna2TxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Chocolate;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 15.75F);
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(347, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 32);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MsgBxGuna2TxtBx
            // 
            this.MsgBxGuna2TxtBx.AutoSize = true;
            this.MsgBxGuna2TxtBx.BorderColor = System.Drawing.Color.Chocolate;
            this.MsgBxGuna2TxtBx.BorderThickness = 2;
            this.MsgBxGuna2TxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MsgBxGuna2TxtBx.DefaultText = "Select User From The List";
            this.MsgBxGuna2TxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MsgBxGuna2TxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MsgBxGuna2TxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MsgBxGuna2TxtBx.DisabledState.Parent = this.MsgBxGuna2TxtBx;
            this.MsgBxGuna2TxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MsgBxGuna2TxtBx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MsgBxGuna2TxtBx.FocusedState.BorderColor = System.Drawing.Color.LightGray;
            this.MsgBxGuna2TxtBx.FocusedState.Parent = this.MsgBxGuna2TxtBx;
            this.MsgBxGuna2TxtBx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBxGuna2TxtBx.ForeColor = System.Drawing.Color.Chocolate;
            this.MsgBxGuna2TxtBx.HoverState.BorderColor = System.Drawing.Color.SandyBrown;
            this.MsgBxGuna2TxtBx.HoverState.Parent = this.MsgBxGuna2TxtBx;
            this.MsgBxGuna2TxtBx.IconLeftSize = new System.Drawing.Size(0, 0);
            this.MsgBxGuna2TxtBx.IconRightSize = new System.Drawing.Size(0, 0);
            this.MsgBxGuna2TxtBx.Location = new System.Drawing.Point(86, 142);
            this.MsgBxGuna2TxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.MsgBxGuna2TxtBx.Name = "MsgBxGuna2TxtBx";
            this.MsgBxGuna2TxtBx.PasswordChar = '\0';
            this.MsgBxGuna2TxtBx.PlaceholderForeColor = System.Drawing.Color.White;
            this.MsgBxGuna2TxtBx.PlaceholderText = "";
            this.MsgBxGuna2TxtBx.ReadOnly = true;
            this.MsgBxGuna2TxtBx.SelectedText = "";
            this.MsgBxGuna2TxtBx.SelectionStart = 25;
            this.MsgBxGuna2TxtBx.ShadowDecoration.Parent = this.MsgBxGuna2TxtBx;
            this.MsgBxGuna2TxtBx.Size = new System.Drawing.Size(220, 30);
            this.MsgBxGuna2TxtBx.TabIndex = 4;
            this.MsgBxGuna2TxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 36);
            this.panel1.TabIndex = 5;
            // 
            // MessgeBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MsgBxGuna2TxtBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessgeBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessgeBoxForm";
            this.Load += new System.EventHandler(this.MessgeBoxForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        public Guna.UI2.WinForms.Guna2TextBox MsgBxGuna2TxtBx;
        private System.Windows.Forms.Panel panel1;
    }
}