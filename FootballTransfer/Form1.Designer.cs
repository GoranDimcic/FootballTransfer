
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
            this.btnX = new System.Windows.Forms.Button();
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
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(100, 280);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(40, 40);
            this.btnX.TabIndex = 7;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Visible = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnX);
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
        private System.Windows.Forms.Button btnX;
    }
}

