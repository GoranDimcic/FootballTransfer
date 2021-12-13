
namespace FootballTransfer
{
    partial class LoginPlayer
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
            this.lblLoginPlayer = new System.Windows.Forms.Label();
            this.txtEmailLoginPlayer = new System.Windows.Forms.TextBox();
            this.txtPasswordLoginPlayer = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLoginAsPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginPlayer
            // 
            this.lblLoginPlayer.AutoSize = true;
            this.lblLoginPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPlayer.Location = new System.Drawing.Point(165, 80);
            this.lblLoginPlayer.Name = "lblLoginPlayer";
            this.lblLoginPlayer.Size = new System.Drawing.Size(125, 25);
            this.lblLoginPlayer.TabIndex = 0;
            this.lblLoginPlayer.Text = "Player login";
            // 
            // txtEmailLoginPlayer
            // 
            this.txtEmailLoginPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLoginPlayer.Location = new System.Drawing.Point(150, 125);
            this.txtEmailLoginPlayer.Name = "txtEmailLoginPlayer";
            this.txtEmailLoginPlayer.Size = new System.Drawing.Size(150, 29);
            this.txtEmailLoginPlayer.TabIndex = 1;
            // 
            // txtPasswordLoginPlayer
            // 
            this.txtPasswordLoginPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLoginPlayer.Location = new System.Drawing.Point(150, 175);
            this.txtPasswordLoginPlayer.Name = "txtPasswordLoginPlayer";
            this.txtPasswordLoginPlayer.Size = new System.Drawing.Size(150, 29);
            this.txtPasswordLoginPlayer.TabIndex = 2;
            this.txtPasswordLoginPlayer.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(16, 177);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnLoginAsPlayer
            // 
            this.btnLoginAsPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAsPlayer.Location = new System.Drawing.Point(150, 225);
            this.btnLoginAsPlayer.Name = "btnLoginAsPlayer";
            this.btnLoginAsPlayer.Size = new System.Drawing.Size(150, 50);
            this.btnLoginAsPlayer.TabIndex = 5;
            this.btnLoginAsPlayer.Text = "Login";
            this.btnLoginAsPlayer.UseVisualStyleBackColor = true;
            this.btnLoginAsPlayer.Click += new System.EventHandler(this.btnLoginAsPlayer_Click);
            // 
            // LoginPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btnLoginAsPlayer);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPasswordLoginPlayer);
            this.Controls.Add(this.txtEmailLoginPlayer);
            this.Controls.Add(this.lblLoginPlayer);
            this.Name = "LoginPlayer";
            this.Text = "LoginPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginPlayer;
        private System.Windows.Forms.TextBox txtEmailLoginPlayer;
        private System.Windows.Forms.TextBox txtPasswordLoginPlayer;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLoginAsPlayer;
    }
}