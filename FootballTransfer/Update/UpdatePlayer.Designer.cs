
namespace FootballTransfer.Update
{
    partial class UpdatePlayer
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
            this.txtUpdatePlayerCountry = new System.Windows.Forms.TextBox();
            this.txtUpdatePlayerSurname = new System.Windows.Forms.TextBox();
            this.txtUpdatePlayerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxUpdatePlayerPosition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtUpdatePlayerCountry
            // 
            this.txtUpdatePlayerCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePlayerCountry.Location = new System.Drawing.Point(150, 147);
            this.txtUpdatePlayerCountry.Name = "txtUpdatePlayerCountry";
            this.txtUpdatePlayerCountry.Size = new System.Drawing.Size(123, 26);
            this.txtUpdatePlayerCountry.TabIndex = 24;
            // 
            // txtUpdatePlayerSurname
            // 
            this.txtUpdatePlayerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePlayerSurname.Location = new System.Drawing.Point(150, 94);
            this.txtUpdatePlayerSurname.Name = "txtUpdatePlayerSurname";
            this.txtUpdatePlayerSurname.Size = new System.Drawing.Size(123, 26);
            this.txtUpdatePlayerSurname.TabIndex = 23;
            // 
            // txtUpdatePlayerName
            // 
            this.txtUpdatePlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePlayerName.Location = new System.Drawing.Point(150, 47);
            this.txtUpdatePlayerName.Name = "txtUpdatePlayerName";
            this.txtUpdatePlayerName.Size = new System.Drawing.Size(123, 26);
            this.txtUpdatePlayerName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(150, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 44);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.comboBoxUpdatePlayerPosition.Location = new System.Drawing.Point(150, 194);
            this.comboBoxUpdatePlayerPosition.Name = "comboBoxUpdatePlayerPosition";
            this.comboBoxUpdatePlayerPosition.Size = new System.Drawing.Size(123, 28);
            this.comboBoxUpdatePlayerPosition.TabIndex = 27;
            // 
            // UpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.comboBoxUpdatePlayerPosition);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpdatePlayerCountry);
            this.Controls.Add(this.txtUpdatePlayerSurname);
            this.Controls.Add(this.txtUpdatePlayerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePlayer";
            this.Text = "UpdatePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUpdatePlayerCountry;
        private System.Windows.Forms.TextBox txtUpdatePlayerSurname;
        private System.Windows.Forms.TextBox txtUpdatePlayerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxUpdatePlayerPosition;
    }
}