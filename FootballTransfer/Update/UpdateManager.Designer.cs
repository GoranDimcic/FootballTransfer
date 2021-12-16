
namespace FootballTransfer.Update
{
    partial class UpdateManager
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
            this.txtUpdateManagerCountry = new System.Windows.Forms.TextBox();
            this.txtUpdateManagerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(150, 150);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(109, 44);
            this.BtnUpdate.TabIndex = 35;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtUpdateManagerCountry
            // 
            this.txtUpdateManagerCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateManagerCountry.Location = new System.Drawing.Point(150, 97);
            this.txtUpdateManagerCountry.Name = "txtUpdateManagerCountry";
            this.txtUpdateManagerCountry.Size = new System.Drawing.Size(125, 26);
            this.txtUpdateManagerCountry.TabIndex = 34;
            // 
            // txtUpdateManagerName
            // 
            this.txtUpdateManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateManagerName.Location = new System.Drawing.Point(150, 47);
            this.txtUpdateManagerName.Name = "txtUpdateManagerName";
            this.txtUpdateManagerName.Size = new System.Drawing.Size(125, 26);
            this.txtUpdateManagerName.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Country";
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
            // UpdateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.txtUpdateManagerCountry);
            this.Controls.Add(this.txtUpdateManagerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "UpdateManager";
            this.Text = "UpdateManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox txtUpdateManagerCountry;
        private System.Windows.Forms.TextBox txtUpdateManagerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}