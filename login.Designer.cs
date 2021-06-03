
namespace Aquarelle
{
    partial class login_form
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
            this.login_button = new System.Windows.Forms.Button();
            this.Cancel_but = new System.Windows.Forms.Button();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_type_label = new System.Windows.Forms.Label();
            this.usertype_combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(750, 43);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Cancel_but
            // 
            this.Cancel_but.Location = new System.Drawing.Point(750, 88);
            this.Cancel_but.Name = "Cancel_but";
            this.Cancel_but.Size = new System.Drawing.Size(75, 23);
            this.Cancel_but.TabIndex = 1;
            this.Cancel_but.Text = "Cancel";
            this.Cancel_but.UseVisualStyleBackColor = true;
            this.Cancel_but.Click += new System.EventHandler(this.Cancel_but_Click);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(449, 28);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(57, 13);
            this.Username_label.TabIndex = 2;
            this.Username_label.Text = "UserName";
            this.Username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(453, 68);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Password";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(541, 28);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(171, 20);
            this.username_txt.TabIndex = 4;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(541, 68);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(171, 20);
            this.password_txt.TabIndex = 5;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aquarelle.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 134);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // user_type_label
            // 
            this.user_type_label.AutoSize = true;
            this.user_type_label.Location = new System.Drawing.Point(453, 107);
            this.user_type_label.Name = "user_type_label";
            this.user_type_label.Size = new System.Drawing.Size(56, 13);
            this.user_type_label.TabIndex = 7;
            this.user_type_label.Text = "User Type";
            // 
            // usertype_combo
            // 
            this.usertype_combo.FormattingEnabled = true;
            this.usertype_combo.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.usertype_combo.Location = new System.Drawing.Point(541, 107);
            this.usertype_combo.Name = "usertype_combo";
            this.usertype_combo.Size = new System.Drawing.Size(171, 21);
            this.usertype_combo.TabIndex = 8;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 194);
            this.Controls.Add(this.usertype_combo);
            this.Controls.Add(this.user_type_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Cancel_but);
            this.Controls.Add(this.login_button);
            this.Name = "login_form";
            this.Text = "                                                                                 " +
    "                                            Aquarelle Login ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button Cancel_but;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label user_type_label;
        private System.Windows.Forms.ComboBox usertype_combo;
    }
}

