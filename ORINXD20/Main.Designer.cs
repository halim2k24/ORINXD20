namespace ORINXD20
{
    partial class Main
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Send = new System.Windows.Forms.Label();
            this.SendInput = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ReceiveResponsLavel = new System.Windows.Forms.Label();
            this.ReceiveRespons = new System.Windows.Forms.Label();
            this.Respons = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 29);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Send
            // 
            this.Send.AutoSize = true;
            this.Send.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Send.Location = new System.Drawing.Point(12, 69);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(65, 19);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send :";
            // 
            // SendInput
            // 
            this.SendInput.Location = new System.Drawing.Point(87, 69);
            this.SendInput.Name = "SendInput";
            this.SendInput.Size = new System.Drawing.Size(216, 19);
            this.SendInput.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(141, 103);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ReceiveResponsLavel
            // 
            this.ReceiveResponsLavel.AutoSize = true;
            this.ReceiveResponsLavel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReceiveResponsLavel.Location = new System.Drawing.Point(12, 168);
            this.ReceiveResponsLavel.Name = "ReceiveResponsLavel";
            this.ReceiveResponsLavel.Size = new System.Drawing.Size(77, 16);
            this.ReceiveResponsLavel.TabIndex = 4;
            this.ReceiveResponsLavel.Text = "Receive :";
            // 
            // ReceiveRespons
            // 
            this.ReceiveRespons.AutoSize = true;
            this.ReceiveRespons.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReceiveRespons.Location = new System.Drawing.Point(95, 168);
            this.ReceiveRespons.Name = "ReceiveRespons";
            this.ReceiveRespons.Size = new System.Drawing.Size(0, 16);
            this.ReceiveRespons.TabIndex = 5;
            // 
            // Respons
            // 
            this.Respons.AutoSize = true;
            this.Respons.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Respons.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Respons.Location = new System.Drawing.Point(96, 172);
            this.Respons.Name = "Respons";
            this.Respons.Size = new System.Drawing.Size(31, 16);
            this.Respons.TabIndex = 6;
            this.Respons.Text = "......";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Respons);
            this.Controls.Add(this.ReceiveRespons);
            this.Controls.Add(this.ReceiveResponsLavel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendInput);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NXD Controller";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label Send;
        private System.Windows.Forms.TextBox SendInput;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label ReceiveResponsLavel;
        private System.Windows.Forms.Label ReceiveRespons;
        private System.Windows.Forms.Label Respons;
    }
}

