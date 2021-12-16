
namespace FootballTransfer.Update
{
    partial class UpdateClub
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateClubStadionName = new System.Windows.Forms.TextBox();
            this.txtUpdateClubName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUpdateClubLeagueName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdateClubCapacity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(150, 250);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(109, 44);
            this.BtnUpdate.TabIndex = 35;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtUpdateClubStadionName
            // 
            this.txtUpdateClubStadionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateClubStadionName.Location = new System.Drawing.Point(175, 97);
            this.txtUpdateClubStadionName.Name = "txtUpdateClubStadionName";
            this.txtUpdateClubStadionName.Size = new System.Drawing.Size(125, 26);
            this.txtUpdateClubStadionName.TabIndex = 34;
            // 
            // txtUpdateClubName
            // 
            this.txtUpdateClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateClubName.Location = new System.Drawing.Point(175, 47);
            this.txtUpdateClubName.Name = "txtUpdateClubName";
            this.txtUpdateClubName.Size = new System.Drawing.Size(125, 26);
            this.txtUpdateClubName.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "League name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Stadion name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // comboBoxUpdateClubLeagueName
            // 
            this.comboBoxUpdateClubLeagueName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateClubLeagueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUpdateClubLeagueName.FormattingEnabled = true;
            this.comboBoxUpdateClubLeagueName.Items.AddRange(new object[] {
            "La Liga",
            "Premier League",
            "Serie A",
            "Ligue 1",
            "Bundesliga"});
            this.comboBoxUpdateClubLeagueName.Location = new System.Drawing.Point(175, 197);
            this.comboBoxUpdateClubLeagueName.Name = "comboBoxUpdateClubLeagueName";
            this.comboBoxUpdateClubLeagueName.Size = new System.Drawing.Size(125, 28);
            this.comboBoxUpdateClubLeagueName.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Capacity";
            // 
            // txtUpdateClubCapacity
            // 
            this.txtUpdateClubCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateClubCapacity.Location = new System.Drawing.Point(175, 147);
            this.txtUpdateClubCapacity.Name = "txtUpdateClubCapacity";
            this.txtUpdateClubCapacity.Size = new System.Drawing.Size(125, 26);
            this.txtUpdateClubCapacity.TabIndex = 39;
            this.txtUpdateClubCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUpdateClubCapacity_KeyPress);
            // 
            // UpdateClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.txtUpdateClubCapacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUpdateClubLeagueName);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.txtUpdateClubStadionName);
            this.Controls.Add(this.txtUpdateClubName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UpdateClub";
            this.Text = "ClubUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox txtUpdateClubStadionName;
        private System.Windows.Forms.TextBox txtUpdateClubName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUpdateClubLeagueName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateClubCapacity;
    }
}