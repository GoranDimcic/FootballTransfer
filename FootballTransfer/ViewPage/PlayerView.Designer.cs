﻿namespace FootballTransfer.ViewPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listViewManagerOffer = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewClubOffer
            // 
            this.listViewClubOffer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewClubOffer.HideSelection = false;
            this.listViewClubOffer.Location = new System.Drawing.Point(12, 138);
            this.listViewClubOffer.Margin = new System.Windows.Forms.Padding(2);
            this.listViewClubOffer.Name = "listViewClubOffer";
            this.listViewClubOffer.Size = new System.Drawing.Size(350, 300);
            this.listViewClubOffer.TabIndex = 2;
            this.listViewClubOffer.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista ponuda klubova";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Izmeni podatke";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Obrisi igraca";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Dodaj igraca";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listViewManagerOffer
            // 
            this.listViewManagerOffer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewManagerOffer.HideSelection = false;
            this.listViewManagerOffer.Location = new System.Drawing.Point(400, 138);
            this.listViewManagerOffer.Margin = new System.Windows.Forms.Padding(2);
            this.listViewManagerOffer.Name = "listViewManagerOffer";
            this.listViewManagerOffer.Size = new System.Drawing.Size(350, 300);
            this.listViewManagerOffer.TabIndex = 7;
            this.listViewManagerOffer.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista ponuda menadzera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pozition";
            // 
            // txtProba
            // 
            this.txtProba.Location = new System.Drawing.Point(91, 9);
            this.txtProba.Name = "txtProba";
            this.txtProba.Size = new System.Drawing.Size(100, 20);
            this.txtProba.TabIndex = 13;
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.txtProba);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewManagerOffer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listViewManagerOffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProba;
    }
}