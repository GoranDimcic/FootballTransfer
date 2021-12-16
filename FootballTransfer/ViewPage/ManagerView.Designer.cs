﻿
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
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtManagerCountry = new System.Windows.Forms.TextBox();
            this.txtManagerSurname = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdateManager = new System.Windows.Forms.Button();
            this.BtnDeleteManager = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManagerRepresent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista igraca koje zastupam / lista slobodnih igraca kojima mogu da posaljem ponud" +
    "u";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 193);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 247);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Izmeni podatke";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(681, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 47);
            this.button3.TabIndex = 9;
            this.button3.Text = "Prikazi menadjera";
            this.button3.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Surname";
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
            this.BtnUpdateManager.Click += new System.EventHandler(this.BtnUpdatePlayer_Click);
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
            this.txtManagerRepresent.Location = new System.Drawing.Point(125, 130);
            this.txtManagerRepresent.Name = "txtManagerRepresent";
            this.txtManagerRepresent.ReadOnly = true;
            this.txtManagerRepresent.Size = new System.Drawing.Size(123, 19);
            this.txtManagerRepresent.TabIndex = 27;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtManagerRepresent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDeleteManager);
            this.Controls.Add(this.txtManagerCountry);
            this.Controls.Add(this.txtManagerSurname);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUpdateManager);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtManagerCountry;
        private System.Windows.Forms.TextBox txtManagerSurname;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUpdateManager;
        private System.Windows.Forms.Button BtnDeleteManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtManagerRepresent;
    }
}