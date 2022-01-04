﻿
namespace FootballTransfer.Login
{
    partial class LoginClub
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
            this.BtnLoginAsPlayer = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPasswordLoginClub = new System.Windows.Forms.TextBox();
            this.txtEmailLoginClub = new System.Windows.Forms.TextBox();
            this.lblLoginPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLoginAsPlayer
            // 
            this.BtnLoginAsPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginAsPlayer.Location = new System.Drawing.Point(150, 225);
            this.BtnLoginAsPlayer.Name = "BtnLoginAsPlayer";
            this.BtnLoginAsPlayer.Size = new System.Drawing.Size(150, 50);
            this.BtnLoginAsPlayer.TabIndex = 11;
            this.BtnLoginAsPlayer.Text = "Login";
            this.BtnLoginAsPlayer.UseVisualStyleBackColor = true;
            this.BtnLoginAsPlayer.Click += new System.EventHandler(this.BtnLoginAsPlayer_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
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
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // txtPasswordLoginClub
            // 
            this.txtPasswordLoginClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLoginClub.Location = new System.Drawing.Point(150, 175);
            this.txtPasswordLoginClub.Name = "txtPasswordLoginClub";
            this.txtPasswordLoginClub.Size = new System.Drawing.Size(150, 29);
            this.txtPasswordLoginClub.TabIndex = 8;
            this.txtPasswordLoginClub.UseSystemPasswordChar = true;
            this.txtPasswordLoginClub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPasswordLoginClub_KeyDown);
            // 
            // txtEmailLoginClub
            // 
            this.txtEmailLoginClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLoginClub.Location = new System.Drawing.Point(150, 125);
            this.txtEmailLoginClub.Name = "txtEmailLoginClub";
            this.txtEmailLoginClub.Size = new System.Drawing.Size(150, 29);
            this.txtEmailLoginClub.TabIndex = 7;
            this.txtEmailLoginClub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmailLoginClub_KeyDown);
            // 
            // lblLoginPlayer
            // 
            this.lblLoginPlayer.AutoSize = true;
            this.lblLoginPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPlayer.Location = new System.Drawing.Point(165, 80);
            this.lblLoginPlayer.Name = "lblLoginPlayer";
            this.lblLoginPlayer.Size = new System.Drawing.Size(108, 25);
            this.lblLoginPlayer.TabIndex = 6;
            this.lblLoginPlayer.Text = "Club login";
            // 
            // LoginClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.BtnLoginAsPlayer);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPasswordLoginClub);
            this.Controls.Add(this.txtEmailLoginClub);
            this.Controls.Add(this.lblLoginPlayer);
            this.Name = "LoginClub";
            this.Text = "LoginClub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoginAsPlayer;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPasswordLoginClub;
        private System.Windows.Forms.TextBox txtEmailLoginClub;
        private System.Windows.Forms.Label lblLoginPlayer;
    }
}