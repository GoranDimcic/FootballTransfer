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
            this.listViewClubOffer = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listViewManagerOffer = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtPlayerSurname = new System.Windows.Forms.TextBox();
            this.txtPlayerCountry = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtPlayerPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewClubOffer
            // 
            this.listViewClubOffer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewClubOffer.HideSelection = false;
            this.listViewClubOffer.Location = new System.Drawing.Point(11, 200);
            this.listViewClubOffer.Margin = new System.Windows.Forms.Padding(2);
            this.listViewClubOffer.Name = "listViewClubOffer";
            this.listViewClubOffer.Size = new System.Drawing.Size(350, 300);
            this.listViewClubOffer.TabIndex = 2;
            this.listViewClubOffer.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista ponuda klubova";
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Location = new System.Drawing.Point(270, 22);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(91, 26);
            this.btnUpdatePlayer.TabIndex = 4;
            this.btnUpdatePlayer.Text = "Update";
            this.btnUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Obrisi igraca";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "prihvati ponudu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listViewManagerOffer
            // 
            this.listViewManagerOffer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewManagerOffer.HideSelection = false;
            this.listViewManagerOffer.Location = new System.Drawing.Point(423, 200);
            this.listViewManagerOffer.Margin = new System.Windows.Forms.Padding(2);
            this.listViewManagerOffer.Name = "listViewManagerOffer";
            this.listViewManagerOffer.Size = new System.Drawing.Size(350, 300);
            this.listViewManagerOffer.TabIndex = 7;
            this.listViewManagerOffer.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista ponuda menadzera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Position";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(125, 26);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(123, 19);
            this.txtPlayerName.TabIndex = 13;
            // 
            // txtPlayerSurname
            // 
            this.txtPlayerSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerSurname.Location = new System.Drawing.Point(125, 61);
            this.txtPlayerSurname.Name = "txtPlayerSurname";
            this.txtPlayerSurname.ReadOnly = true;
            this.txtPlayerSurname.Size = new System.Drawing.Size(123, 19);
            this.txtPlayerSurname.TabIndex = 14;
            // 
            // txtPlayerCountry
            // 
            this.txtPlayerCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerCountry.Location = new System.Drawing.Point(125, 96);
            this.txtPlayerCountry.Name = "txtPlayerCountry";
            this.txtPlayerCountry.ReadOnly = true;
            this.txtPlayerCountry.Size = new System.Drawing.Size(123, 19);
            this.txtPlayerCountry.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(651, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 40);
            this.button4.TabIndex = 17;
            this.button4.Text = "Odbi ponudu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(546, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 40);
            this.button5.TabIndex = 18;
            this.button5.Text = "prihvati ponudu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(423, 137);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 40);
            this.button6.TabIndex = 19;
            this.button6.Text = "Odbi ponudu";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtPlayerPosition
            // 
            this.txtPlayerPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerPosition.Location = new System.Drawing.Point(125, 131);
            this.txtPlayerPosition.Name = "txtPlayerPosition";
            this.txtPlayerPosition.ReadOnly = true;
            this.txtPlayerPosition.Size = new System.Drawing.Size(123, 19);
            this.txtPlayerPosition.TabIndex = 16;
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtPlayerPosition);
            this.Controls.Add(this.txtPlayerCountry);
            this.Controls.Add(this.txtPlayerSurname);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewManagerOffer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdatePlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewClubOffer);
            this.Name = "PlayerView";
            this.Text = "PlayerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewClubOffer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listViewManagerOffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtPlayerSurname;
        private System.Windows.Forms.TextBox txtPlayerCountry;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtPlayerPosition;
    }
}