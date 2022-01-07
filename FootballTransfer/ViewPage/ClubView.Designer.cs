
namespace FootballTransfer.ViewPage
{
    partial class ClubView
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
            this.txtClubStadionName = new System.Windows.Forms.TextBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdateClub = new System.Windows.Forms.Button();
            this.txtClubCapacity = new System.Windows.Forms.TextBox();
            this.txtClubLeagueName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDeleteClub = new System.Windows.Forms.Button();
            this.listViewFreePlayers = new System.Windows.Forms.ListView();
            this.BtnSeeMyTeam = new System.Windows.Forms.Button();
            this.BtnSeeFreePlayers = new System.Windows.Forms.Button();
            this.BtnCreateOffer = new System.Windows.Forms.Button();
            this.comboBoxUpdateClubLeagueName = new System.Windows.Forms.ComboBox();
            this.BtnSaveUpdatedClub = new System.Windows.Forms.Button();
            this.BtnCloseUpdate = new System.Windows.Forms.Button();
            this.BtnSeeMyOffers = new System.Windows.Forms.Button();
            this.LblChoose = new System.Windows.Forms.Label();
            this.listViewMyOffers = new System.Windows.Forms.ListView();
            this.listViewMyPlayers = new System.Windows.Forms.ListView();
            this.BtnTerminateTheContract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClubStadionName
            // 
            this.txtClubStadionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClubStadionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubStadionName.Location = new System.Drawing.Point(160, 70);
            this.txtClubStadionName.Name = "txtClubStadionName";
            this.txtClubStadionName.ReadOnly = true;
            this.txtClubStadionName.Size = new System.Drawing.Size(123, 19);
            this.txtClubStadionName.TabIndex = 24;
            // 
            // txtClubName
            // 
            this.txtClubName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubName.Location = new System.Drawing.Point(160, 35);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.ReadOnly = true;
            this.txtClubName.Size = new System.Drawing.Size(123, 19);
            this.txtClubName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Stadion name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // BtnUpdateClub
            // 
            this.BtnUpdateClub.Location = new System.Drawing.Point(300, 30);
            this.BtnUpdateClub.Name = "BtnUpdateClub";
            this.BtnUpdateClub.Size = new System.Drawing.Size(100, 30);
            this.BtnUpdateClub.TabIndex = 17;
            this.BtnUpdateClub.Text = "Update";
            this.BtnUpdateClub.UseVisualStyleBackColor = true;
            this.BtnUpdateClub.Click += new System.EventHandler(this.BtnUpdatePlayer_Click);
            // 
            // txtClubCapacity
            // 
            this.txtClubCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClubCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubCapacity.Location = new System.Drawing.Point(160, 105);
            this.txtClubCapacity.Name = "txtClubCapacity";
            this.txtClubCapacity.ReadOnly = true;
            this.txtClubCapacity.Size = new System.Drawing.Size(123, 19);
            this.txtClubCapacity.TabIndex = 25;
            this.txtClubCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClubCapacity_KeyPress);
            // 
            // txtClubLeagueName
            // 
            this.txtClubLeagueName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClubLeagueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubLeagueName.Location = new System.Drawing.Point(160, 140);
            this.txtClubLeagueName.Name = "txtClubLeagueName";
            this.txtClubLeagueName.ReadOnly = true;
            this.txtClubLeagueName.Size = new System.Drawing.Size(123, 19);
            this.txtClubLeagueName.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "League name";
            // 
            // BtnDeleteClub
            // 
            this.BtnDeleteClub.Location = new System.Drawing.Point(300, 66);
            this.BtnDeleteClub.Name = "BtnDeleteClub";
            this.BtnDeleteClub.Size = new System.Drawing.Size(100, 30);
            this.BtnDeleteClub.TabIndex = 34;
            this.BtnDeleteClub.Text = "Delete";
            this.BtnDeleteClub.UseVisualStyleBackColor = true;
            this.BtnDeleteClub.Click += new System.EventHandler(this.BtnDeleteClub_Click);
            // 
            // listViewFreePlayers
            // 
            this.listViewFreePlayers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewFreePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFreePlayers.HideSelection = false;
            this.listViewFreePlayers.Location = new System.Drawing.Point(25, 250);
            this.listViewFreePlayers.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFreePlayers.Name = "listViewFreePlayers";
            this.listViewFreePlayers.Size = new System.Drawing.Size(600, 250);
            this.listViewFreePlayers.TabIndex = 35;
            this.listViewFreePlayers.UseCompatibleStateImageBehavior = false;
            // 
            // BtnSeeMyTeam
            // 
            this.BtnSeeMyTeam.Location = new System.Drawing.Point(525, 200);
            this.BtnSeeMyTeam.Name = "BtnSeeMyTeam";
            this.BtnSeeMyTeam.Size = new System.Drawing.Size(100, 40);
            this.BtnSeeMyTeam.TabIndex = 37;
            this.BtnSeeMyTeam.Text = "See my team";
            this.BtnSeeMyTeam.UseVisualStyleBackColor = true;
            this.BtnSeeMyTeam.Click += new System.EventHandler(this.BtnSeeMyTeam_Click);
            // 
            // BtnSeeFreePlayers
            // 
            this.BtnSeeFreePlayers.Location = new System.Drawing.Point(400, 200);
            this.BtnSeeFreePlayers.Name = "BtnSeeFreePlayers";
            this.BtnSeeFreePlayers.Size = new System.Drawing.Size(100, 40);
            this.BtnSeeFreePlayers.TabIndex = 36;
            this.BtnSeeFreePlayers.Text = "See free players";
            this.BtnSeeFreePlayers.UseVisualStyleBackColor = true;
            this.BtnSeeFreePlayers.Click += new System.EventHandler(this.BtnSeeFreePlayers_Click);
            // 
            // BtnCreateOffer
            // 
            this.BtnCreateOffer.Location = new System.Drawing.Point(645, 250);
            this.BtnCreateOffer.Name = "BtnCreateOffer";
            this.BtnCreateOffer.Size = new System.Drawing.Size(100, 40);
            this.BtnCreateOffer.TabIndex = 38;
            this.BtnCreateOffer.Text = "Create offer";
            this.BtnCreateOffer.UseVisualStyleBackColor = true;
            this.BtnCreateOffer.Click += new System.EventHandler(this.BtnCreateOffer_Click);
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
            this.comboBoxUpdateClubLeagueName.Location = new System.Drawing.Point(160, 137);
            this.comboBoxUpdateClubLeagueName.Name = "comboBoxUpdateClubLeagueName";
            this.comboBoxUpdateClubLeagueName.Size = new System.Drawing.Size(126, 28);
            this.comboBoxUpdateClubLeagueName.TabIndex = 39;
            this.comboBoxUpdateClubLeagueName.Visible = false;
            // 
            // BtnSaveUpdatedClub
            // 
            this.BtnSaveUpdatedClub.Location = new System.Drawing.Point(300, 31);
            this.BtnSaveUpdatedClub.Name = "BtnSaveUpdatedClub";
            this.BtnSaveUpdatedClub.Size = new System.Drawing.Size(100, 30);
            this.BtnSaveUpdatedClub.TabIndex = 40;
            this.BtnSaveUpdatedClub.Text = "Save";
            this.BtnSaveUpdatedClub.UseVisualStyleBackColor = true;
            this.BtnSaveUpdatedClub.Visible = false;
            this.BtnSaveUpdatedClub.Click += new System.EventHandler(this.BtnSaveUpdatedClub_Click);
            // 
            // BtnCloseUpdate
            // 
            this.BtnCloseUpdate.Location = new System.Drawing.Point(300, 66);
            this.BtnCloseUpdate.Name = "BtnCloseUpdate";
            this.BtnCloseUpdate.Size = new System.Drawing.Size(100, 30);
            this.BtnCloseUpdate.TabIndex = 41;
            this.BtnCloseUpdate.Text = "Close";
            this.BtnCloseUpdate.UseVisualStyleBackColor = true;
            this.BtnCloseUpdate.Visible = false;
            this.BtnCloseUpdate.Click += new System.EventHandler(this.BtnCloseUpdate_Click);
            // 
            // BtnSeeMyOffers
            // 
            this.BtnSeeMyOffers.Location = new System.Drawing.Point(275, 200);
            this.BtnSeeMyOffers.Name = "BtnSeeMyOffers";
            this.BtnSeeMyOffers.Size = new System.Drawing.Size(100, 40);
            this.BtnSeeMyOffers.TabIndex = 42;
            this.BtnSeeMyOffers.Text = "See my offers";
            this.BtnSeeMyOffers.UseVisualStyleBackColor = true;
            this.BtnSeeMyOffers.Click += new System.EventHandler(this.BtnSeeMyOffers_Click);
            // 
            // LblChoose
            // 
            this.LblChoose.AutoSize = true;
            this.LblChoose.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChoose.Location = new System.Drawing.Point(25, 200);
            this.LblChoose.Name = "LblChoose";
            this.LblChoose.Size = new System.Drawing.Size(181, 36);
            this.LblChoose.TabIndex = 43;
            this.LblChoose.Text = "Choose a player:";
            // 
            // listViewMyOffers
            // 
            this.listViewMyOffers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewMyOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMyOffers.HideSelection = false;
            this.listViewMyOffers.Location = new System.Drawing.Point(25, 250);
            this.listViewMyOffers.Margin = new System.Windows.Forms.Padding(2);
            this.listViewMyOffers.Name = "listViewMyOffers";
            this.listViewMyOffers.Size = new System.Drawing.Size(600, 250);
            this.listViewMyOffers.TabIndex = 44;
            this.listViewMyOffers.UseCompatibleStateImageBehavior = false;
            this.listViewMyOffers.Visible = false;
            // 
            // listViewMyPlayers
            // 
            this.listViewMyPlayers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewMyPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMyPlayers.HideSelection = false;
            this.listViewMyPlayers.Location = new System.Drawing.Point(25, 250);
            this.listViewMyPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.listViewMyPlayers.Name = "listViewMyPlayers";
            this.listViewMyPlayers.Size = new System.Drawing.Size(600, 250);
            this.listViewMyPlayers.TabIndex = 45;
            this.listViewMyPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewMyPlayers.Visible = false;
            // 
            // BtnTerminateTheContract
            // 
            this.BtnTerminateTheContract.Location = new System.Drawing.Point(645, 250);
            this.BtnTerminateTheContract.Name = "BtnTerminateTheContract";
            this.BtnTerminateTheContract.Size = new System.Drawing.Size(100, 40);
            this.BtnTerminateTheContract.TabIndex = 46;
            this.BtnTerminateTheContract.Text = "Terminate the contract";
            this.BtnTerminateTheContract.UseVisualStyleBackColor = true;
            this.BtnTerminateTheContract.Visible = false;
            // 
            // ClubView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.BtnTerminateTheContract);
            this.Controls.Add(this.listViewMyPlayers);
            this.Controls.Add(this.listViewMyOffers);
            this.Controls.Add(this.LblChoose);
            this.Controls.Add(this.BtnSeeMyOffers);
            this.Controls.Add(this.BtnCloseUpdate);
            this.Controls.Add(this.BtnSaveUpdatedClub);
            this.Controls.Add(this.comboBoxUpdateClubLeagueName);
            this.Controls.Add(this.BtnCreateOffer);
            this.Controls.Add(this.BtnSeeMyTeam);
            this.Controls.Add(this.BtnSeeFreePlayers);
            this.Controls.Add(this.listViewFreePlayers);
            this.Controls.Add(this.BtnDeleteClub);
            this.Controls.Add(this.txtClubLeagueName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtClubCapacity);
            this.Controls.Add(this.txtClubStadionName);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnUpdateClub);
            this.Name = "ClubView";
            this.Text = "ClubView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtClubStadionName;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnUpdateClub;
        private System.Windows.Forms.TextBox txtClubCapacity;
        private System.Windows.Forms.TextBox txtClubLeagueName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDeleteClub;
        private System.Windows.Forms.ListView listViewFreePlayers;
        private System.Windows.Forms.Button BtnSeeMyTeam;
        private System.Windows.Forms.Button BtnSeeFreePlayers;
        private System.Windows.Forms.Button BtnCreateOffer;
        private System.Windows.Forms.ComboBox comboBoxUpdateClubLeagueName;
        private System.Windows.Forms.Button BtnSaveUpdatedClub;
        private System.Windows.Forms.Button BtnCloseUpdate;
        private System.Windows.Forms.Button BtnSeeMyOffers;
        private System.Windows.Forms.Label LblChoose;
        private System.Windows.Forms.ListView listViewMyOffers;
        private System.Windows.Forms.ListView listViewMyPlayers;
        private System.Windows.Forms.Button BtnTerminateTheContract;
    }
}