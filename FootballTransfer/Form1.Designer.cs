
namespace FootballTransfer
{
    partial class Form1
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
            this.btnPlayer = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnClub = new System.Windows.Forms.Button();
            this.btnLoginPlayer = new System.Windows.Forms.Button();
            this.btnRegistryPlayer = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnX1 = new System.Windows.Forms.Button();
            this.lblManager = new System.Windows.Forms.Label();
            this.btnLoginManager = new System.Windows.Forms.Button();
            this.btnRegistryManager = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnLoginClub = new System.Windows.Forms.Button();
            this.btnRegistryClub = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.lblClub = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayer
            // 
            this.btnPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer.Location = new System.Drawing.Point(50, 175);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(150, 100);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.Text = "Player";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(40, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(163, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Transfer market";
            // 
            // btnManager
            // 
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.Location = new System.Drawing.Point(300, 175);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(150, 100);
            this.btnManager.TabIndex = 2;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnClub
            // 
            this.btnClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClub.Location = new System.Drawing.Point(550, 175);
            this.btnClub.Name = "btnClub";
            this.btnClub.Size = new System.Drawing.Size(150, 100);
            this.btnClub.TabIndex = 3;
            this.btnClub.Text = "Club";
            this.btnClub.UseVisualStyleBackColor = true;
            this.btnClub.Click += new System.EventHandler(this.btnClub_Click);
            // 
            // btnLoginPlayer
            // 
            this.btnLoginPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPlayer.Location = new System.Drawing.Point(50, 175);
            this.btnLoginPlayer.Name = "btnLoginPlayer";
            this.btnLoginPlayer.Size = new System.Drawing.Size(150, 50);
            this.btnLoginPlayer.TabIndex = 4;
            this.btnLoginPlayer.Text = "Login";
            this.btnLoginPlayer.UseVisualStyleBackColor = true;
            this.btnLoginPlayer.Visible = false;
            this.btnLoginPlayer.Click += new System.EventHandler(this.btnLoginPlayer_Click);
            // 
            // btnRegistryPlayer
            // 
            this.btnRegistryPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistryPlayer.Location = new System.Drawing.Point(50, 225);
            this.btnRegistryPlayer.Name = "btnRegistryPlayer";
            this.btnRegistryPlayer.Size = new System.Drawing.Size(150, 50);
            this.btnRegistryPlayer.TabIndex = 5;
            this.btnRegistryPlayer.Text = "Sign up";
            this.btnRegistryPlayer.UseVisualStyleBackColor = true;
            this.btnRegistryPlayer.Visible = false;
            this.btnRegistryPlayer.Click += new System.EventHandler(this.btnRegistryPlayer_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(85, 140);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(73, 25);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.Visible = false;
            // 
            // btnX1
            // 
            this.btnX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX1.Location = new System.Drawing.Point(100, 280);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(40, 40);
            this.btnX1.TabIndex = 7;
            this.btnX1.Text = "X";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Visible = false;
            this.btnX1.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.Location = new System.Drawing.Point(325, 140);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(97, 25);
            this.lblManager.TabIndex = 8;
            this.lblManager.Text = "Manager";
            this.lblManager.Visible = false;
            // 
            // btnLoginManager
            // 
            this.btnLoginManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginManager.Location = new System.Drawing.Point(300, 175);
            this.btnLoginManager.Name = "btnLoginManager";
            this.btnLoginManager.Size = new System.Drawing.Size(150, 50);
            this.btnLoginManager.TabIndex = 9;
            this.btnLoginManager.Text = "Login";
            this.btnLoginManager.UseVisualStyleBackColor = true;
            this.btnLoginManager.Visible = false;
            // 
            // btnRegistryManager
            // 
            this.btnRegistryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistryManager.Location = new System.Drawing.Point(300, 225);
            this.btnRegistryManager.Name = "btnRegistryManager";
            this.btnRegistryManager.Size = new System.Drawing.Size(150, 50);
            this.btnRegistryManager.TabIndex = 10;
            this.btnRegistryManager.Text = "Sign up";
            this.btnRegistryManager.UseVisualStyleBackColor = true;
            this.btnRegistryManager.Visible = false;
            // 
            // btnX2
            // 
            this.btnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX2.Location = new System.Drawing.Point(350, 280);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(40, 40);
            this.btnX2.TabIndex = 11;
            this.btnX2.Text = "X";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Visible = false;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btnLoginClub
            // 
            this.btnLoginClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginClub.Location = new System.Drawing.Point(550, 175);
            this.btnLoginClub.Name = "btnLoginClub";
            this.btnLoginClub.Size = new System.Drawing.Size(150, 50);
            this.btnLoginClub.TabIndex = 12;
            this.btnLoginClub.Text = "Login";
            this.btnLoginClub.UseVisualStyleBackColor = true;
            this.btnLoginClub.Visible = false;
            // 
            // btnRegistryClub
            // 
            this.btnRegistryClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistryClub.Location = new System.Drawing.Point(550, 225);
            this.btnRegistryClub.Name = "btnRegistryClub";
            this.btnRegistryClub.Size = new System.Drawing.Size(150, 50);
            this.btnRegistryClub.TabIndex = 13;
            this.btnRegistryClub.Text = "Sign up";
            this.btnRegistryClub.UseVisualStyleBackColor = true;
            this.btnRegistryClub.Visible = false;
            // 
            // btnX3
            // 
            this.btnX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX3.Location = new System.Drawing.Point(600, 280);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(40, 40);
            this.btnX3.TabIndex = 14;
            this.btnX3.Text = "X";
            this.btnX3.UseVisualStyleBackColor = true;
            this.btnX3.Visible = false;
            this.btnX3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(595, 140);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(56, 25);
            this.lblClub.TabIndex = 15;
            this.lblClub.Text = "Club";
            this.lblClub.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.btnX3);
            this.Controls.Add(this.btnRegistryClub);
            this.Controls.Add(this.btnLoginClub);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnRegistryManager);
            this.Controls.Add(this.btnLoginManager);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.btnX1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnRegistryPlayer);
            this.Controls.Add(this.btnLoginPlayer);
            this.Controls.Add(this.btnClub);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnClub;
        private System.Windows.Forms.Button btnLoginPlayer;
        private System.Windows.Forms.Button btnRegistryPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnLoginManager;
        private System.Windows.Forms.Button btnRegistryManager;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnLoginClub;
        private System.Windows.Forms.Button btnRegistryClub;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Label lblClub;
    }
}

