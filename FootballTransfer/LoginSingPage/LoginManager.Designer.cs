
namespace FootballTransfer.Login
{
    partial class LoginManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginManager));
            this.BtnLoginAsManager = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPasswordLoginManager = new System.Windows.Forms.TextBox();
            this.txtEmailLoginManager = new System.Windows.Forms.TextBox();
            this.lblLoginPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLoginAsManager
            // 
            this.BtnLoginAsManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginAsManager.Location = new System.Drawing.Point(150, 225);
            this.BtnLoginAsManager.Name = "BtnLoginAsManager";
            this.BtnLoginAsManager.Size = new System.Drawing.Size(150, 50);
            this.BtnLoginAsManager.TabIndex = 11;
            this.BtnLoginAsManager.Text = "Login";
            this.BtnLoginAsManager.UseVisualStyleBackColor = true;
            this.BtnLoginAsManager.Click += new System.EventHandler(this.BtnLoginAsManager_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(16, 177);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // txtPasswordLoginManager
            // 
            this.txtPasswordLoginManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLoginManager.Location = new System.Drawing.Point(150, 175);
            this.txtPasswordLoginManager.Name = "txtPasswordLoginManager";
            this.txtPasswordLoginManager.Size = new System.Drawing.Size(150, 29);
            this.txtPasswordLoginManager.TabIndex = 8;
            this.txtPasswordLoginManager.UseSystemPasswordChar = true;
            this.txtPasswordLoginManager.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEnterClick_KeyDown);
            // 
            // txtEmailLoginManager
            // 
            this.txtEmailLoginManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLoginManager.Location = new System.Drawing.Point(150, 125);
            this.txtEmailLoginManager.Name = "txtEmailLoginManager";
            this.txtEmailLoginManager.Size = new System.Drawing.Size(150, 29);
            this.txtEmailLoginManager.TabIndex = 7;
            this.txtEmailLoginManager.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEnterClick_KeyDown);
            // 
            // lblLoginPlayer
            // 
            this.lblLoginPlayer.AutoSize = true;
            this.lblLoginPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPlayer.Location = new System.Drawing.Point(150, 80);
            this.lblLoginPlayer.Name = "lblLoginPlayer";
            this.lblLoginPlayer.Size = new System.Drawing.Size(149, 25);
            this.lblLoginPlayer.TabIndex = 6;
            this.lblLoginPlayer.Text = "Manager login";
            // 
            // LoginManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.BtnLoginAsManager);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPasswordLoginManager);
            this.Controls.Add(this.txtEmailLoginManager);
            this.Controls.Add(this.lblLoginPlayer);
            this.Name = "LoginManager";
            this.Text = "LoginManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoginAsManager;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPasswordLoginManager;
        private System.Windows.Forms.TextBox txtEmailLoginManager;
        private System.Windows.Forms.Label lblLoginPlayer;
    }
}