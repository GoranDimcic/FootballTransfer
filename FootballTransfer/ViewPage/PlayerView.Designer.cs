namespace FootballTransfer.ViewPage
{
    partial class PlayerView
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
            this.BtnUpdatePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtPlayerAddress = new System.Windows.Forms.TextBox();
            this.txtPlayerCountry = new System.Windows.Forms.TextBox();
            this.txtPlayerPosition = new System.Windows.Forms.TextBox();
            this.BtnDeletePlayer = new System.Windows.Forms.Button();
            this.BtnShowClubOffer = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnSaveUpdatedPlayer = new System.Windows.Forms.Button();
            this.comboBoxUpdatePlayerPosition = new System.Windows.Forms.ComboBox();
            this.BtnCloseUpdate = new System.Windows.Forms.Button();
            this.listViewManagerOffer = new System.Windows.Forms.ListView();
            this.listViewClubOffer = new System.Windows.Forms.ListView();
            this.BtnShowManagerOffer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdatePlayer
            // 
            this.BtnUpdatePlayer.Location = new System.Drawing.Point(270, 31);
            this.BtnUpdatePlayer.Name = "BtnUpdatePlayer";
            this.BtnUpdatePlayer.Size = new System.Drawing.Size(100, 30);
            this.BtnUpdatePlayer.TabIndex = 4;
            this.BtnUpdatePlayer.Text = "Update";
            this.BtnUpdatePlayer.UseVisualStyleBackColor = true;
            this.BtnUpdatePlayer.Click += new System.EventHandler(this.BtnUpdatePlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Position";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(125, 35);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(123, 19);
            this.txtPlayerName.TabIndex = 13;
            // 
            // txtPlayerAddress
            // 
            this.txtPlayerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerAddress.Location = new System.Drawing.Point(125, 70);
            this.txtPlayerAddress.Name = "txtPlayerAddress";
            this.txtPlayerAddress.ReadOnly = true;
            this.txtPlayerAddress.Size = new System.Drawing.Size(123, 19);
            this.txtPlayerAddress.TabIndex = 14;
            // 
            // txtPlayerCountry
            // 
            this.txtPlayerCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerCountry.Location = new System.Drawing.Point(125, 105);
            this.txtPlayerCountry.Name = "txtPlayerCountry";
            this.txtPlayerCountry.ReadOnly = true;
            this.txtPlayerCountry.Size = new System.Drawing.Size(123, 19);
            this.txtPlayerCountry.TabIndex = 15;
            // 
            // txtPlayerPosition
            // 
            this.txtPlayerPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerPosition.Location = new System.Drawing.Point(125, 140);
            this.txtPlayerPosition.Name = "txtPlayerPosition";
            this.txtPlayerPosition.ReadOnly = true;
            this.txtPlayerPosition.Size = new System.Drawing.Size(123, 19);
            this.txtPlayerPosition.TabIndex = 16;
            // 
            // BtnDeletePlayer
            // 
            this.BtnDeletePlayer.Location = new System.Drawing.Point(270, 66);
            this.BtnDeletePlayer.Name = "BtnDeletePlayer";
            this.BtnDeletePlayer.Size = new System.Drawing.Size(100, 30);
            this.BtnDeletePlayer.TabIndex = 20;
            this.BtnDeletePlayer.Text = "Delete";
            this.BtnDeletePlayer.UseVisualStyleBackColor = true;
            this.BtnDeletePlayer.Click += new System.EventHandler(this.BtnDeletePlayer_Click);
            // 
            // BtnShowClubOffer
            // 
            this.BtnShowClubOffer.Location = new System.Drawing.Point(525, 200);
            this.BtnShowClubOffer.Name = "BtnShowClubOffer";
            this.BtnShowClubOffer.Size = new System.Drawing.Size(100, 40);
            this.BtnShowClubOffer.TabIndex = 22;
            this.BtnShowClubOffer.Text = "Club offer";
            this.BtnShowClubOffer.UseVisualStyleBackColor = true;
            this.BtnShowClubOffer.Click += new System.EventHandler(this.BtnShowClubOffer_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(645, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 40);
            this.button6.TabIndex = 26;
            this.button6.Text = "Reject";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 25;
            this.button3.Text = "Accept";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnSaveUpdatedPlayer
            // 
            this.BtnSaveUpdatedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveUpdatedPlayer.Location = new System.Drawing.Point(270, 30);
            this.BtnSaveUpdatedPlayer.Name = "BtnSaveUpdatedPlayer";
            this.BtnSaveUpdatedPlayer.Size = new System.Drawing.Size(100, 30);
            this.BtnSaveUpdatedPlayer.TabIndex = 27;
            this.BtnSaveUpdatedPlayer.Text = "Save";
            this.BtnSaveUpdatedPlayer.UseVisualStyleBackColor = true;
            this.BtnSaveUpdatedPlayer.Visible = false;
            this.BtnSaveUpdatedPlayer.Click += new System.EventHandler(this.BtnSaveUpdatedPlayer_Click);
            // 
            // comboBoxUpdatePlayerPosition
            // 
            this.comboBoxUpdatePlayerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdatePlayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUpdatePlayerPosition.FormattingEnabled = true;
            this.comboBoxUpdatePlayerPosition.Items.AddRange(new object[] {
            "Attack",
            "Middlefield",
            "Defence",
            "Goalkeeper"});
            this.comboBoxUpdatePlayerPosition.Location = new System.Drawing.Point(125, 137);
            this.comboBoxUpdatePlayerPosition.Name = "comboBoxUpdatePlayerPosition";
            this.comboBoxUpdatePlayerPosition.Size = new System.Drawing.Size(123, 28);
            this.comboBoxUpdatePlayerPosition.TabIndex = 28;
            this.comboBoxUpdatePlayerPosition.Visible = false;
            // 
            // BtnCloseUpdate
            // 
            this.BtnCloseUpdate.Location = new System.Drawing.Point(270, 66);
            this.BtnCloseUpdate.Name = "BtnCloseUpdate";
            this.BtnCloseUpdate.Size = new System.Drawing.Size(100, 30);
            this.BtnCloseUpdate.TabIndex = 29;
            this.BtnCloseUpdate.Text = "Close";
            this.BtnCloseUpdate.UseVisualStyleBackColor = true;
            this.BtnCloseUpdate.Visible = false;
            this.BtnCloseUpdate.Click += new System.EventHandler(this.BtnCloseUpdate_Click);
            // 
            // listViewManagerOffer
            // 
            this.listViewManagerOffer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewManagerOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewManagerOffer.HideSelection = false;
            this.listViewManagerOffer.Location = new System.Drawing.Point(25, 250);
            this.listViewManagerOffer.Margin = new System.Windows.Forms.Padding(2);
            this.listViewManagerOffer.Name = "listViewManagerOffer";
            this.listViewManagerOffer.Size = new System.Drawing.Size(600, 250);
            this.listViewManagerOffer.TabIndex = 7;
            this.listViewManagerOffer.UseCompatibleStateImageBehavior = false;
            // 
            // listViewClubOffer
            // 
            this.listViewClubOffer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewClubOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClubOffer.HideSelection = false;
            this.listViewClubOffer.Location = new System.Drawing.Point(25, 250);
            this.listViewClubOffer.Margin = new System.Windows.Forms.Padding(2);
            this.listViewClubOffer.Name = "listViewClubOffer";
            this.listViewClubOffer.Size = new System.Drawing.Size(600, 250);
            this.listViewClubOffer.TabIndex = 23;
            this.listViewClubOffer.UseCompatibleStateImageBehavior = false;
            this.listViewClubOffer.Visible = false;
            // 
            // BtnShowManagerOffer
            // 
            this.BtnShowManagerOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowManagerOffer.Location = new System.Drawing.Point(400, 200);
            this.BtnShowManagerOffer.Name = "BtnShowManagerOffer";
            this.BtnShowManagerOffer.Size = new System.Drawing.Size(100, 40);
            this.BtnShowManagerOffer.TabIndex = 21;
            this.BtnShowManagerOffer.Text = "Manager offer";
            this.BtnShowManagerOffer.UseVisualStyleBackColor = true;
            this.BtnShowManagerOffer.Click += new System.EventHandler(this.BtnShowManagerOffer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "Choose an offer:";
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCloseUpdate);
            this.Controls.Add(this.comboBoxUpdatePlayerPosition);
            this.Controls.Add(this.BtnSaveUpdatedPlayer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listViewClubOffer);
            this.Controls.Add(this.BtnShowClubOffer);
            this.Controls.Add(this.BtnShowManagerOffer);
            this.Controls.Add(this.BtnDeletePlayer);
            this.Controls.Add(this.txtPlayerPosition);
            this.Controls.Add(this.txtPlayerCountry);
            this.Controls.Add(this.txtPlayerAddress);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewManagerOffer);
            this.Controls.Add(this.BtnUpdatePlayer);
            this.Name = "PlayerView";
            this.Text = "PlayerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnUpdatePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtPlayerAddress;
        private System.Windows.Forms.TextBox txtPlayerCountry;
        private System.Windows.Forms.TextBox txtPlayerPosition;
        private System.Windows.Forms.Button BtnDeletePlayer;
        private System.Windows.Forms.Button BtnShowClubOffer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnSaveUpdatedPlayer;
        private System.Windows.Forms.ComboBox comboBoxUpdatePlayerPosition;
        private System.Windows.Forms.Button BtnCloseUpdate;
        private System.Windows.Forms.ListView listViewManagerOffer;
        private System.Windows.Forms.ListView listViewClubOffer;
        private System.Windows.Forms.Button BtnShowManagerOffer;
        private System.Windows.Forms.Label label2;
    }
}