
namespace FootballTransfer.ViewPage
{
    partial class ManagerView
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
            this.listViewFreePlayers = new System.Windows.Forms.ListView();
            this.BtnCreateOffer = new System.Windows.Forms.Button();
            this.txtManagerCountry = new System.Windows.Forms.TextBox();
            this.txtManagerSurname = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdateManager = new System.Windows.Forms.Button();
            this.BtnDeleteManager = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManagerRepresent = new System.Windows.Forms.TextBox();
            this.BtnSeeFreePlayers = new System.Windows.Forms.Button();
            this.BtnSeeMyPlayers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManagerAge = new System.Windows.Forms.TextBox();
            this.BtnSaveUpdatedManager = new System.Windows.Forms.Button();
            this.BtnCloseUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFreePlayers
            // 
            this.listViewFreePlayers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewFreePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFreePlayers.HideSelection = false;
            this.listViewFreePlayers.Location = new System.Drawing.Point(29, 200);
            this.listViewFreePlayers.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFreePlayers.Name = "listViewFreePlayers";
            this.listViewFreePlayers.Size = new System.Drawing.Size(550, 250);
            this.listViewFreePlayers.TabIndex = 5;
            this.listViewFreePlayers.UseCompatibleStateImageBehavior = false;
            // 
            // BtnCreateOffer
            // 
            this.BtnCreateOffer.Location = new System.Drawing.Point(600, 200);
            this.BtnCreateOffer.Name = "BtnCreateOffer";
            this.BtnCreateOffer.Size = new System.Drawing.Size(85, 41);
            this.BtnCreateOffer.TabIndex = 7;
            this.BtnCreateOffer.Text = "Create offer";
            this.BtnCreateOffer.UseVisualStyleBackColor = true;
            // 
            // txtManagerCountry
            // 
            this.txtManagerCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManagerCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerCountry.Location = new System.Drawing.Point(125, 96);
            this.txtManagerCountry.Name = "txtManagerCountry";
            this.txtManagerCountry.ReadOnly = true;
            this.txtManagerCountry.Size = new System.Drawing.Size(123, 19);
            this.txtManagerCountry.TabIndex = 24;
            // 
            // txtManagerSurname
            // 
            this.txtManagerSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManagerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerSurname.Location = new System.Drawing.Point(125, 61);
            this.txtManagerSurname.Name = "txtManagerSurname";
            this.txtManagerSurname.ReadOnly = true;
            this.txtManagerSurname.Size = new System.Drawing.Size(123, 19);
            this.txtManagerSurname.TabIndex = 23;
            // 
            // txtManagerName
            // 
            this.txtManagerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerName.Location = new System.Drawing.Point(125, 26);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.ReadOnly = true;
            this.txtManagerName.Size = new System.Drawing.Size(123, 19);
            this.txtManagerName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // BtnUpdateManager
            // 
            this.BtnUpdateManager.Location = new System.Drawing.Point(270, 22);
            this.BtnUpdateManager.Name = "BtnUpdateManager";
            this.BtnUpdateManager.Size = new System.Drawing.Size(91, 26);
            this.BtnUpdateManager.TabIndex = 17;
            this.BtnUpdateManager.Text = "Update";
            this.BtnUpdateManager.UseVisualStyleBackColor = true;
            this.BtnUpdateManager.Click += new System.EventHandler(this.BtnUpdateManager_Click);
            // 
            // BtnDeleteManager
            // 
            this.BtnDeleteManager.Location = new System.Drawing.Point(370, 22);
            this.BtnDeleteManager.Name = "BtnDeleteManager";
            this.BtnDeleteManager.Size = new System.Drawing.Size(91, 26);
            this.BtnDeleteManager.TabIndex = 25;
            this.BtnDeleteManager.Text = "Delete";
            this.BtnDeleteManager.UseVisualStyleBackColor = true;
            this.BtnDeleteManager.Click += new System.EventHandler(this.BtnDeleteManager_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Represent";
            // 
            // txtManagerRepresent
            // 
            this.txtManagerRepresent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManagerRepresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerRepresent.Location = new System.Drawing.Point(125, 131);
            this.txtManagerRepresent.Name = "txtManagerRepresent";
            this.txtManagerRepresent.ReadOnly = true;
            this.txtManagerRepresent.Size = new System.Drawing.Size(123, 19);
            this.txtManagerRepresent.TabIndex = 27;
            // 
            // BtnSeeFreePlayers
            // 
            this.BtnSeeFreePlayers.Location = new System.Drawing.Point(370, 144);
            this.BtnSeeFreePlayers.Name = "BtnSeeFreePlayers";
            this.BtnSeeFreePlayers.Size = new System.Drawing.Size(91, 41);
            this.BtnSeeFreePlayers.TabIndex = 29;
            this.BtnSeeFreePlayers.Text = "See free players";
            this.BtnSeeFreePlayers.UseVisualStyleBackColor = true;
            // 
            // BtnSeeMyPlayers
            // 
            this.BtnSeeMyPlayers.Location = new System.Drawing.Point(488, 144);
            this.BtnSeeMyPlayers.Name = "BtnSeeMyPlayers";
            this.BtnSeeMyPlayers.Size = new System.Drawing.Size(91, 41);
            this.BtnSeeMyPlayers.TabIndex = 30;
            this.BtnSeeMyPlayers.Text = "See my players";
            this.BtnSeeMyPlayers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Age";
            // 
            // txtManagerAge
            // 
            this.txtManagerAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManagerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerAge.Location = new System.Drawing.Point(125, 61);
            this.txtManagerAge.Name = "txtManagerAge";
            this.txtManagerAge.ReadOnly = true;
            this.txtManagerAge.Size = new System.Drawing.Size(123, 19);
            this.txtManagerAge.TabIndex = 32;
            // 
            // BtnSaveUpdatedManager
            // 
            this.BtnSaveUpdatedManager.Location = new System.Drawing.Point(270, 22);
            this.BtnSaveUpdatedManager.Name = "BtnSaveUpdatedManager";
            this.BtnSaveUpdatedManager.Size = new System.Drawing.Size(91, 26);
            this.BtnSaveUpdatedManager.TabIndex = 33;
            this.BtnSaveUpdatedManager.Text = "Save";
            this.BtnSaveUpdatedManager.UseVisualStyleBackColor = true;
            this.BtnSaveUpdatedManager.Visible = false;
            this.BtnSaveUpdatedManager.Click += new System.EventHandler(this.BtnSaveUpdatedManager_Click);
            // 
            // BtnCloseUpdate
            // 
            this.BtnCloseUpdate.Location = new System.Drawing.Point(270, 59);
            this.BtnCloseUpdate.Name = "BtnCloseUpdate";
            this.BtnCloseUpdate.Size = new System.Drawing.Size(91, 26);
            this.BtnCloseUpdate.TabIndex = 34;
            this.BtnCloseUpdate.Text = "Close";
            this.BtnCloseUpdate.UseVisualStyleBackColor = true;
            this.BtnCloseUpdate.Visible = false;
            this.BtnCloseUpdate.Click += new System.EventHandler(this.BtnCloseUpdate_Click);
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.BtnCloseUpdate);
            this.Controls.Add(this.BtnSaveUpdatedManager);
            this.Controls.Add(this.txtManagerAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSeeMyPlayers);
            this.Controls.Add(this.BtnSeeFreePlayers);
            this.Controls.Add(this.txtManagerRepresent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDeleteManager);
            this.Controls.Add(this.txtManagerCountry);
            this.Controls.Add(this.txtManagerSurname);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUpdateManager);
            this.Controls.Add(this.BtnCreateOffer);
            this.Controls.Add(this.listViewFreePlayers);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewFreePlayers;
        private System.Windows.Forms.Button BtnCreateOffer;
        private System.Windows.Forms.TextBox txtManagerCountry;
        private System.Windows.Forms.TextBox txtManagerSurname;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUpdateManager;
        private System.Windows.Forms.Button BtnDeleteManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtManagerRepresent;
        private System.Windows.Forms.Button BtnSeeFreePlayers;
        private System.Windows.Forms.Button BtnSeeMyPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManagerAge;
        private System.Windows.Forms.Button BtnSaveUpdatedManager;
        private System.Windows.Forms.Button BtnCloseUpdate;
    }
}