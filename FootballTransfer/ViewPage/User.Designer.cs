
namespace FootballTransfer.ViewPage
{
    partial class User
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
            this.listViewManagerTransfer = new System.Windows.Forms.ListView();
            this.listViewClubTransfer = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnManagerTransfer = new System.Windows.Forms.Button();
            this.BtnClubTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewManagerTransfer
            // 
            this.listViewManagerTransfer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewManagerTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewManagerTransfer.HideSelection = false;
            this.listViewManagerTransfer.Location = new System.Drawing.Point(25, 100);
            this.listViewManagerTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.listViewManagerTransfer.Name = "listViewManagerTransfer";
            this.listViewManagerTransfer.Size = new System.Drawing.Size(750, 250);
            this.listViewManagerTransfer.TabIndex = 24;
            this.listViewManagerTransfer.UseCompatibleStateImageBehavior = false;
            this.listViewManagerTransfer.Visible = false;
            // 
            // listViewClubTransfer
            // 
            this.listViewClubTransfer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewClubTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClubTransfer.HideSelection = false;
            this.listViewClubTransfer.Location = new System.Drawing.Point(25, 100);
            this.listViewClubTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.listViewClubTransfer.Name = "listViewClubTransfer";
            this.listViewClubTransfer.Size = new System.Drawing.Size(750, 250);
            this.listViewClubTransfer.TabIndex = 25;
            this.listViewClubTransfer.UseCompatibleStateImageBehavior = false;
            this.listViewClubTransfer.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "Choose a transfer:";
            // 
            // BtnManagerTransfer
            // 
            this.BtnManagerTransfer.BackColor = System.Drawing.Color.Transparent;
            this.BtnManagerTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManagerTransfer.Location = new System.Drawing.Point(300, 22);
            this.BtnManagerTransfer.Name = "BtnManagerTransfer";
            this.BtnManagerTransfer.Size = new System.Drawing.Size(100, 50);
            this.BtnManagerTransfer.TabIndex = 32;
            this.BtnManagerTransfer.Text = "Manager";
            this.BtnManagerTransfer.UseVisualStyleBackColor = false;
            this.BtnManagerTransfer.Click += new System.EventHandler(this.BtnManagerTransfer_Click);
            // 
            // BtnClubTransfer
            // 
            this.BtnClubTransfer.BackColor = System.Drawing.Color.Transparent;
            this.BtnClubTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClubTransfer.Location = new System.Drawing.Point(425, 22);
            this.BtnClubTransfer.Name = "BtnClubTransfer";
            this.BtnClubTransfer.Size = new System.Drawing.Size(100, 50);
            this.BtnClubTransfer.TabIndex = 33;
            this.BtnClubTransfer.Text = "Club";
            this.BtnClubTransfer.UseVisualStyleBackColor = false;
            this.BtnClubTransfer.Click += new System.EventHandler(this.BtnClubTransfer_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.BtnClubTransfer);
            this.Controls.Add(this.BtnManagerTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewClubTransfer);
            this.Controls.Add(this.listViewManagerTransfer);
            this.Name = "User";
            this.Text = "UserPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewManagerTransfer;
        private System.Windows.Forms.ListView listViewClubTransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnManagerTransfer;
        private System.Windows.Forms.Button BtnClubTransfer;
    }
}