
namespace Aquarelle
{
    partial class ChangePassword
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
            this.OldPassword_lab = new System.Windows.Forms.Label();
            this.NewPasswordLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OldPassword_txt = new System.Windows.Forms.TextBox();
            this.NewPassword_txt = new System.Windows.Forms.TextBox();
            this.ReNewPassword_txt = new System.Windows.Forms.TextBox();
            this.ChangePassword_but = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldPassword_lab
            // 
            this.OldPassword_lab.AutoSize = true;
            this.OldPassword_lab.Location = new System.Drawing.Point(89, 34);
            this.OldPassword_lab.Name = "OldPassword_lab";
            this.OldPassword_lab.Size = new System.Drawing.Size(72, 13);
            this.OldPassword_lab.TabIndex = 0;
            this.OldPassword_lab.Text = "Old Password";
            // 
            // NewPasswordLab
            // 
            this.NewPasswordLab.AutoSize = true;
            this.NewPasswordLab.Location = new System.Drawing.Point(89, 64);
            this.NewPasswordLab.Name = "NewPasswordLab";
            this.NewPasswordLab.Size = new System.Drawing.Size(78, 13);
            this.NewPasswordLab.TabIndex = 1;
            this.NewPasswordLab.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Re-Enter New Password";
            // 
            // OldPassword_txt
            // 
            this.OldPassword_txt.Location = new System.Drawing.Point(278, 31);
            this.OldPassword_txt.Name = "OldPassword_txt";
            this.OldPassword_txt.Size = new System.Drawing.Size(100, 20);
            this.OldPassword_txt.TabIndex = 3;
            this.OldPassword_txt.UseSystemPasswordChar = true;
            // 
            // NewPassword_txt
            // 
            this.NewPassword_txt.Location = new System.Drawing.Point(278, 61);
            this.NewPassword_txt.Name = "NewPassword_txt";
            this.NewPassword_txt.Size = new System.Drawing.Size(100, 20);
            this.NewPassword_txt.TabIndex = 4;
            this.NewPassword_txt.UseSystemPasswordChar = true;
            // 
            // ReNewPassword_txt
            // 
            this.ReNewPassword_txt.Location = new System.Drawing.Point(278, 93);
            this.ReNewPassword_txt.Name = "ReNewPassword_txt";
            this.ReNewPassword_txt.Size = new System.Drawing.Size(100, 20);
            this.ReNewPassword_txt.TabIndex = 5;
            this.ReNewPassword_txt.UseSystemPasswordChar = true;
            // 
            // ChangePassword_but
            // 
            this.ChangePassword_but.Location = new System.Drawing.Point(425, 54);
            this.ChangePassword_but.Name = "ChangePassword_but";
            this.ChangePassword_but.Size = new System.Drawing.Size(110, 23);
            this.ChangePassword_but.TabIndex = 6;
            this.ChangePassword_but.Text = "Change Password";
            this.ChangePassword_but.UseVisualStyleBackColor = true;
            this.ChangePassword_but.Click += new System.EventHandler(this.ChangePassword_but_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(425, 90);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(110, 23);
            this.Exit_button.TabIndex = 7;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 166);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.ChangePassword_but);
            this.Controls.Add(this.ReNewPassword_txt);
            this.Controls.Add(this.NewPassword_txt);
            this.Controls.Add(this.OldPassword_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewPasswordLab);
            this.Controls.Add(this.OldPassword_lab);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldPassword_lab;
        private System.Windows.Forms.Label NewPasswordLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OldPassword_txt;
        private System.Windows.Forms.TextBox NewPassword_txt;
        private System.Windows.Forms.TextBox ReNewPassword_txt;
        private System.Windows.Forms.Button ChangePassword_but;
        private System.Windows.Forms.Button Exit_button;
    }
}