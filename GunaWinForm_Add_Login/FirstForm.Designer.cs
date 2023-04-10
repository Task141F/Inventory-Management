namespace GunaWinForm_Add_Login
{
    partial class FirstForm
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SeparatorPanel = new System.Windows.Forms.Panel();
            this.FilledPanel = new System.Windows.Forms.Panel();
            this.ShowLoginFormButton = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.FilledPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(344, 768);
            this.LeftPanel.TabIndex = 0;
            // 
            // SeparatorPanel
            // 
            this.SeparatorPanel.BackColor = System.Drawing.Color.Chocolate;
            this.SeparatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SeparatorPanel.Location = new System.Drawing.Point(344, 0);
            this.SeparatorPanel.Name = "SeparatorPanel";
            this.SeparatorPanel.Size = new System.Drawing.Size(4, 768);
            this.SeparatorPanel.TabIndex = 1;
            // 
            // FilledPanel
            // 
            this.FilledPanel.BackColor = System.Drawing.SystemColors.Control;
            this.FilledPanel.BackgroundImage = global::GunaWinForm_Add_Login.Properties.Resources.Inventory_management;
            this.FilledPanel.Controls.Add(this.ShowLoginFormButton);
            this.FilledPanel.Controls.Add(this.MinimizeButton);
            this.FilledPanel.Controls.Add(this.ExitButton);
            this.FilledPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledPanel.Location = new System.Drawing.Point(348, 0);
            this.FilledPanel.Name = "FilledPanel";
            this.FilledPanel.Size = new System.Drawing.Size(1018, 768);
            this.FilledPanel.TabIndex = 2;
            // 
            // ShowLoginFormButton
            // 
            this.ShowLoginFormButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowLoginFormButton.CheckedState.Parent = this.ShowLoginFormButton;
            this.ShowLoginFormButton.CustomImages.Parent = this.ShowLoginFormButton;
            this.ShowLoginFormButton.DefaultAutoSize = true;
            this.ShowLoginFormButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowLoginFormButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShowLoginFormButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowLoginFormButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShowLoginFormButton.DisabledState.Parent = this.ShowLoginFormButton;
            this.ShowLoginFormButton.FillColor = System.Drawing.Color.Transparent;
            this.ShowLoginFormButton.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLoginFormButton.ForeColor = System.Drawing.Color.Chocolate;
            this.ShowLoginFormButton.HoverState.Parent = this.ShowLoginFormButton;
            this.ShowLoginFormButton.Location = new System.Drawing.Point(399, 525);
            this.ShowLoginFormButton.Name = "ShowLoginFormButton";
            this.ShowLoginFormButton.ShadowDecoration.Parent = this.ShowLoginFormButton;
            this.ShowLoginFormButton.Size = new System.Drawing.Size(298, 33);
            this.ShowLoginFormButton.TabIndex = 2;
            this.ShowLoginFormButton.Text = "Welcome,to Enter Click Here";
            this.ShowLoginFormButton.Click += new System.EventHandler(this.ShowLoginFormButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.CheckedState.Parent = this.MinimizeButton;
            this.MinimizeButton.CustomBorderColor = System.Drawing.Color.Chocolate;
            this.MinimizeButton.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.MinimizeButton.CustomImages.Parent = this.MinimizeButton;
            this.MinimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeButton.DisabledState.Parent = this.MinimizeButton;
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.Chocolate;
            this.MinimizeButton.HoverState.Parent = this.MinimizeButton;
            this.MinimizeButton.Location = new System.Drawing.Point(867, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.ShadowDecoration.Parent = this.MinimizeButton;
            this.MinimizeButton.Size = new System.Drawing.Size(60, 35);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.CustomBorderColor = System.Drawing.Color.Chocolate;
            this.ExitButton.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.ExitButton.CustomImages.Parent = this.ExitButton;
            this.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButton.DisabledState.Parent = this.ExitButton;
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 18F);
            this.ExitButton.ForeColor = System.Drawing.Color.Chocolate;
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.Location = new System.Drawing.Point(946, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(60, 35);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.FilledPanel);
            this.Controls.Add(this.SeparatorPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FilledPanel.ResumeLayout(false);
            this.FilledPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel SeparatorPanel;
        private System.Windows.Forms.Panel FilledPanel;
        private Guna.UI2.WinForms.Guna2Button MinimizeButton;
        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private Guna.UI2.WinForms.Guna2Button ShowLoginFormButton;
    }
}