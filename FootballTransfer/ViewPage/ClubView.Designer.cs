
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
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtClubLeagueName = new System.Windows.Forms.TextBox();
            this.txtClubStadionName = new System.Windows.Forms.TextBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.txtClubFoundationDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista od 19 igraca, dugmici da mogu da raskinem ugovor ili da ih prodam";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 249);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 191);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(398, 249);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(367, 191);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista igraca koji su stavljeni na prodaju i kojima mogu da posaljem ponudu\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Izmeni podatke";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ugasi klub";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "Prikazi klub";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtClubLeagueName
            // 
            this.txtClubLeagueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubLeagueName.Location = new System.Drawing.Point(160, 92);
            this.txtClubLeagueName.Name = "txtClubLeagueName";
            this.txtClubLeagueName.ReadOnly = true;
            this.txtClubLeagueName.Size = new System.Drawing.Size(123, 26);
            this.txtClubLeagueName.TabIndex = 24;
            // 
            // txtClubStadionName
            // 
            this.txtClubStadionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubStadionName.Location = new System.Drawing.Point(160, 57);
            this.txtClubStadionName.Name = "txtClubStadionName";
            this.txtClubStadionName.ReadOnly = true;
            this.txtClubStadionName.Size = new System.Drawing.Size(123, 26);
            this.txtClubStadionName.TabIndex = 23;
            // 
            // txtClubName
            // 
            this.txtClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubName.Location = new System.Drawing.Point(160, 22);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.ReadOnly = true;
            this.txtClubName.Size = new System.Drawing.Size(123, 26);
            this.txtClubName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Foundation date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "League name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stadion name";
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
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Location = new System.Drawing.Point(305, 22);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(91, 26);
            this.btnUpdatePlayer.TabIndex = 17;
            this.btnUpdatePlayer.Text = "Update";
            this.btnUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // txtClubFoundationDate
            // 
            this.txtClubFoundationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubFoundationDate.Location = new System.Drawing.Point(160, 127);
            this.txtClubFoundationDate.Name = "txtClubFoundationDate";
            this.txtClubFoundationDate.ReadOnly = true;
            this.txtClubFoundationDate.Size = new System.Drawing.Size(123, 26);
            this.txtClubFoundationDate.TabIndex = 25;
            // 
            // ClubView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtClubFoundationDate);
            this.Controls.Add(this.txtClubLeagueName);
            this.Controls.Add(this.txtClubStadionName);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdatePlayer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Name = "ClubView";
            this.Text = "ClubView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtClubLeagueName;
        private System.Windows.Forms.TextBox txtClubStadionName;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.TextBox txtClubFoundationDate;
    }
}