
namespace Aquarelle
{
    partial class AdminMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteUser = new System.Windows.Forms.TabPage();
            this.UserNameDel_lab = new System.Windows.Forms.Label();
            this.del_family_name_label = new System.Windows.Forms.Label();
            this.del_last_name_lab = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.main_Username_txt = new System.Windows.Forms.TextBox();
            this.main_family_name_txt = new System.Windows.Forms.TextBox();
            this.main_lastname_txt = new System.Windows.Forms.TextBox();
            this.main_department_txt = new System.Windows.Forms.TextBox();
            this.main_role_txt = new System.Windows.Forms.TextBox();
            this.CreateUsers = new System.Windows.Forms.TabPage();
            this.createuser_username_lab = new System.Windows.Forms.Label();
            this.Password_lab = new System.Windows.Forms.Label();
            this.createuser_family_name_lab = new System.Windows.Forms.Label();
            this.last_name_lab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createuser_username_txt = new System.Windows.Forms.TextBox();
            this.create_password_txt = new System.Windows.Forms.TextBox();
            this.createuser_family_name_txt = new System.Windows.Forms.TextBox();
            this.createuser_last_name_txt = new System.Windows.Forms.TextBox();
            this.createuser_department_cmb = new System.Windows.Forms.ComboBox();
            this.create_user_cbm = new System.Windows.Forms.ComboBox();
            this.CreateUser_but = new System.Windows.Forms.Button();
            this.Email_Address_lab = new System.Windows.Forms.Label();
            this.Email_address_txt = new System.Windows.Forms.TextBox();
            this.user_folder_txt = new System.Windows.Forms.TextBox();
            this.Path_label = new System.Windows.Forms.Label();
            this.userControl = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.Userselect_grp = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchUser_but = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.main_emailid_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.DeleteUser.SuspendLayout();
            this.CreateUsers.SuspendLayout();
            this.userControl.SuspendLayout();
            this.Userselect_grp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.createUserToolStripMenuItem.Text = "&Users";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Controls.Add(this.groupBox3);
            this.DeleteUser.Controls.Add(this.groupBox2);
            this.DeleteUser.Controls.Add(this.Userselect_grp);
            this.DeleteUser.Location = new System.Drawing.Point(4, 22);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteUser.Size = new System.Drawing.Size(739, 198);
            this.DeleteUser.TabIndex = 1;
            this.DeleteUser.Text = "User Maintenance";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // UserNameDel_lab
            // 
            this.UserNameDel_lab.AutoSize = true;
            this.UserNameDel_lab.Location = new System.Drawing.Point(6, 20);
            this.UserNameDel_lab.Name = "UserNameDel_lab";
            this.UserNameDel_lab.Size = new System.Drawing.Size(55, 13);
            this.UserNameDel_lab.TabIndex = 0;
            this.UserNameDel_lab.Text = "Username";
            // 
            // del_family_name_label
            // 
            this.del_family_name_label.AutoSize = true;
            this.del_family_name_label.Location = new System.Drawing.Point(6, 36);
            this.del_family_name_label.Name = "del_family_name_label";
            this.del_family_name_label.Size = new System.Drawing.Size(67, 13);
            this.del_family_name_label.TabIndex = 1;
            this.del_family_name_label.Text = "Family Name";
            // 
            // del_last_name_lab
            // 
            this.del_last_name_lab.AutoSize = true;
            this.del_last_name_lab.Location = new System.Drawing.Point(9, 75);
            this.del_last_name_lab.Name = "del_last_name_lab";
            this.del_last_name_lab.Size = new System.Drawing.Size(58, 13);
            this.del_last_name_lab.TabIndex = 2;
            this.del_last_name_lab.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User type";
            // 
            // main_Username_txt
            // 
            this.main_Username_txt.Location = new System.Drawing.Point(116, 20);
            this.main_Username_txt.Name = "main_Username_txt";
            this.main_Username_txt.Size = new System.Drawing.Size(100, 20);
            this.main_Username_txt.TabIndex = 5;
            // 
            // main_family_name_txt
            // 
            this.main_family_name_txt.Enabled = false;
            this.main_family_name_txt.Location = new System.Drawing.Point(114, 33);
            this.main_family_name_txt.Name = "main_family_name_txt";
            this.main_family_name_txt.ReadOnly = true;
            this.main_family_name_txt.Size = new System.Drawing.Size(100, 20);
            this.main_family_name_txt.TabIndex = 6;
            // 
            // main_lastname_txt
            // 
            this.main_lastname_txt.Enabled = false;
            this.main_lastname_txt.Location = new System.Drawing.Point(114, 75);
            this.main_lastname_txt.Name = "main_lastname_txt";
            this.main_lastname_txt.ReadOnly = true;
            this.main_lastname_txt.Size = new System.Drawing.Size(100, 20);
            this.main_lastname_txt.TabIndex = 7;
            // 
            // main_department_txt
            // 
            this.main_department_txt.Enabled = false;
            this.main_department_txt.Location = new System.Drawing.Point(316, 30);
            this.main_department_txt.Name = "main_department_txt";
            this.main_department_txt.ReadOnly = true;
            this.main_department_txt.Size = new System.Drawing.Size(135, 20);
            this.main_department_txt.TabIndex = 8;
            // 
            // main_role_txt
            // 
            this.main_role_txt.Enabled = false;
            this.main_role_txt.Location = new System.Drawing.Point(316, 71);
            this.main_role_txt.Name = "main_role_txt";
            this.main_role_txt.ReadOnly = true;
            this.main_role_txt.Size = new System.Drawing.Size(135, 20);
            this.main_role_txt.TabIndex = 9;
            // 
            // CreateUsers
            // 
            this.CreateUsers.Controls.Add(this.Path_label);
            this.CreateUsers.Controls.Add(this.user_folder_txt);
            this.CreateUsers.Controls.Add(this.Email_address_txt);
            this.CreateUsers.Controls.Add(this.createuser_last_name_txt);
            this.CreateUsers.Controls.Add(this.createuser_family_name_txt);
            this.CreateUsers.Controls.Add(this.create_password_txt);
            this.CreateUsers.Controls.Add(this.createuser_username_txt);
            this.CreateUsers.Controls.Add(this.Email_Address_lab);
            this.CreateUsers.Controls.Add(this.CreateUser_but);
            this.CreateUsers.Controls.Add(this.create_user_cbm);
            this.CreateUsers.Controls.Add(this.createuser_department_cmb);
            this.CreateUsers.Controls.Add(this.label4);
            this.CreateUsers.Controls.Add(this.label3);
            this.CreateUsers.Controls.Add(this.last_name_lab);
            this.CreateUsers.Controls.Add(this.createuser_family_name_lab);
            this.CreateUsers.Controls.Add(this.Password_lab);
            this.CreateUsers.Controls.Add(this.createuser_username_lab);
            this.CreateUsers.Location = new System.Drawing.Point(4, 22);
            this.CreateUsers.Name = "CreateUsers";
            this.CreateUsers.Padding = new System.Windows.Forms.Padding(3);
            this.CreateUsers.Size = new System.Drawing.Size(739, 198);
            this.CreateUsers.TabIndex = 0;
            this.CreateUsers.Text = "Create Users";
            this.CreateUsers.UseVisualStyleBackColor = true;
            this.CreateUsers.Click += new System.EventHandler(this.CreateUsers_Click);
            // 
            // createuser_username_lab
            // 
            this.createuser_username_lab.AutoSize = true;
            this.createuser_username_lab.Location = new System.Drawing.Point(18, 14);
            this.createuser_username_lab.Name = "createuser_username_lab";
            this.createuser_username_lab.Size = new System.Drawing.Size(57, 13);
            this.createuser_username_lab.TabIndex = 0;
            this.createuser_username_lab.Text = "UserName";
            // 
            // Password_lab
            // 
            this.Password_lab.AutoSize = true;
            this.Password_lab.Location = new System.Drawing.Point(206, 161);
            this.Password_lab.Name = "Password_lab";
            this.Password_lab.Size = new System.Drawing.Size(53, 13);
            this.Password_lab.TabIndex = 1;
            this.Password_lab.Text = "Password";
            this.Password_lab.Visible = false;
            // 
            // createuser_family_name_lab
            // 
            this.createuser_family_name_lab.AutoSize = true;
            this.createuser_family_name_lab.Location = new System.Drawing.Point(18, 78);
            this.createuser_family_name_lab.Name = "createuser_family_name_lab";
            this.createuser_family_name_lab.Size = new System.Drawing.Size(67, 13);
            this.createuser_family_name_lab.TabIndex = 2;
            this.createuser_family_name_lab.Text = "Family Name";
            // 
            // last_name_lab
            // 
            this.last_name_lab.AutoSize = true;
            this.last_name_lab.Location = new System.Drawing.Point(18, 113);
            this.last_name_lab.Name = "last_name_lab";
            this.last_name_lab.Size = new System.Drawing.Size(58, 13);
            this.last_name_lab.TabIndex = 3;
            this.last_name_lab.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "User Type";
            // 
            // createuser_username_txt
            // 
            this.createuser_username_txt.Location = new System.Drawing.Point(113, 14);
            this.createuser_username_txt.Name = "createuser_username_txt";
            this.createuser_username_txt.Size = new System.Drawing.Size(146, 20);
            this.createuser_username_txt.TabIndex = 6;
            // 
            // create_password_txt
            // 
            this.create_password_txt.Location = new System.Drawing.Point(285, 161);
            this.create_password_txt.Name = "create_password_txt";
            this.create_password_txt.Size = new System.Drawing.Size(146, 20);
            this.create_password_txt.TabIndex = 7;
            this.create_password_txt.Visible = false;
            this.create_password_txt.TextChanged += new System.EventHandler(this.create_password_txt_TextChanged);
            // 
            // createuser_family_name_txt
            // 
            this.createuser_family_name_txt.Location = new System.Drawing.Point(113, 78);
            this.createuser_family_name_txt.Name = "createuser_family_name_txt";
            this.createuser_family_name_txt.Size = new System.Drawing.Size(146, 20);
            this.createuser_family_name_txt.TabIndex = 8;
            // 
            // createuser_last_name_txt
            // 
            this.createuser_last_name_txt.Location = new System.Drawing.Point(113, 110);
            this.createuser_last_name_txt.Name = "createuser_last_name_txt";
            this.createuser_last_name_txt.Size = new System.Drawing.Size(146, 20);
            this.createuser_last_name_txt.TabIndex = 9;
            // 
            // createuser_department_cmb
            // 
            this.createuser_department_cmb.FormattingEnabled = true;
            this.createuser_department_cmb.Items.AddRange(new object[] {
            "DOCUMENTATION SQUAD",
            "OPERATION",
            "INFORMATION TECHNOLOGY"});
            this.createuser_department_cmb.Location = new System.Drawing.Point(408, 14);
            this.createuser_department_cmb.Name = "createuser_department_cmb";
            this.createuser_department_cmb.Size = new System.Drawing.Size(146, 21);
            this.createuser_department_cmb.TabIndex = 10;
            // 
            // create_user_cbm
            // 
            this.create_user_cbm.FormattingEnabled = true;
            this.create_user_cbm.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.create_user_cbm.Location = new System.Drawing.Point(113, 46);
            this.create_user_cbm.Name = "create_user_cbm";
            this.create_user_cbm.Size = new System.Drawing.Size(146, 21);
            this.create_user_cbm.TabIndex = 11;
            // 
            // CreateUser_but
            // 
            this.CreateUser_but.Location = new System.Drawing.Point(316, 108);
            this.CreateUser_but.Name = "CreateUser_but";
            this.CreateUser_but.Size = new System.Drawing.Size(126, 23);
            this.CreateUser_but.TabIndex = 12;
            this.CreateUser_but.Text = "CreateUser";
            this.CreateUser_but.UseVisualStyleBackColor = true;
            this.CreateUser_but.Click += new System.EventHandler(this.CreateUser_but_Click);
            // 
            // Email_Address_lab
            // 
            this.Email_Address_lab.AutoSize = true;
            this.Email_Address_lab.Location = new System.Drawing.Point(313, 54);
            this.Email_Address_lab.Name = "Email_Address_lab";
            this.Email_Address_lab.Size = new System.Drawing.Size(73, 13);
            this.Email_Address_lab.TabIndex = 13;
            this.Email_Address_lab.Text = "Email Address";
            // 
            // Email_address_txt
            // 
            this.Email_address_txt.Location = new System.Drawing.Point(408, 51);
            this.Email_address_txt.Name = "Email_address_txt";
            this.Email_address_txt.Size = new System.Drawing.Size(192, 20);
            this.Email_address_txt.TabIndex = 14;
            // 
            // user_folder_txt
            // 
            this.user_folder_txt.Enabled = false;
            this.user_folder_txt.Location = new System.Drawing.Point(543, 161);
            this.user_folder_txt.Name = "user_folder_txt";
            this.user_folder_txt.ReadOnly = true;
            this.user_folder_txt.Size = new System.Drawing.Size(192, 20);
            this.user_folder_txt.TabIndex = 15;
            this.user_folder_txt.Visible = false;
            // 
            // Path_label
            // 
            this.Path_label.AutoSize = true;
            this.Path_label.Location = new System.Drawing.Point(448, 161);
            this.Path_label.Name = "Path_label";
            this.Path_label.Size = new System.Drawing.Size(54, 13);
            this.Path_label.TabIndex = 16;
            this.Path_label.Text = "User Path";
            this.Path_label.Visible = false;
            // 
            // userControl
            // 
            this.userControl.Controls.Add(this.CreateUsers);
            this.userControl.Controls.Add(this.DeleteUser);
            this.userControl.Location = new System.Drawing.Point(12, 41);
            this.userControl.Name = "userControl";
            this.userControl.SelectedIndex = 0;
            this.userControl.Size = new System.Drawing.Size(747, 224);
            this.userControl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Userselect_grp
            // 
            this.Userselect_grp.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.Userselect_grp.Controls.Add(this.UserNameDel_lab);
            this.Userselect_grp.Controls.Add(this.main_Username_txt);
            this.Userselect_grp.Location = new System.Drawing.Point(10, 6);
            this.Userselect_grp.Name = "Userselect_grp";
            this.Userselect_grp.Size = new System.Drawing.Size(289, 65);
            this.Userselect_grp.TabIndex = 11;
            this.Userselect_grp.TabStop = false;
            this.Userselect_grp.Text = "UserCode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.main_emailid_txt);
            this.groupBox2.Controls.Add(this.del_family_name_label);
            this.groupBox2.Controls.Add(this.del_last_name_lab);
            this.groupBox2.Controls.Add(this.main_family_name_txt);
            this.groupBox2.Controls.Add(this.main_role_txt);
            this.groupBox2.Controls.Add(this.main_lastname_txt);
            this.groupBox2.Controls.Add(this.main_department_txt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Details";
            // 
            // SearchUser_but
            // 
            this.SearchUser_but.Location = new System.Drawing.Point(13, 18);
            this.SearchUser_but.Name = "SearchUser_but";
            this.SearchUser_but.Size = new System.Drawing.Size(84, 25);
            this.SearchUser_but.TabIndex = 13;
            this.SearchUser_but.Text = "Query User";
            this.SearchUser_but.UseVisualStyleBackColor = true;
            this.SearchUser_but.Click += new System.EventHandler(this.SearchUser_but_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.SearchUser_but);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(328, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 65);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // main_emailid_txt
            // 
            this.main_emailid_txt.Location = new System.Drawing.Point(552, 29);
            this.main_emailid_txt.Name = "main_emailid_txt";
            this.main_emailid_txt.ReadOnly = true;
            this.main_emailid_txt.Size = new System.Drawing.Size(163, 20);
            this.main_emailid_txt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 277);
            this.Controls.Add(this.userControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DeleteUser.ResumeLayout(false);
            this.CreateUsers.ResumeLayout(false);
            this.CreateUsers.PerformLayout();
            this.userControl.ResumeLayout(false);
            this.Userselect_grp.ResumeLayout(false);
            this.Userselect_grp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TabPage DeleteUser;
        private System.Windows.Forms.TextBox main_role_txt;
        private System.Windows.Forms.TextBox main_department_txt;
        private System.Windows.Forms.TextBox main_lastname_txt;
        private System.Windows.Forms.TextBox main_family_name_txt;
        private System.Windows.Forms.TextBox main_Username_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label del_last_name_lab;
        private System.Windows.Forms.Label del_family_name_label;
        private System.Windows.Forms.Label UserNameDel_lab;
        private System.Windows.Forms.TabPage CreateUsers;
        private System.Windows.Forms.Label Path_label;
        private System.Windows.Forms.TextBox user_folder_txt;
        private System.Windows.Forms.TextBox Email_address_txt;
        private System.Windows.Forms.TextBox createuser_last_name_txt;
        private System.Windows.Forms.TextBox createuser_family_name_txt;
        private System.Windows.Forms.TextBox create_password_txt;
        private System.Windows.Forms.TextBox createuser_username_txt;
        private System.Windows.Forms.Label Email_Address_lab;
        private System.Windows.Forms.Button CreateUser_but;
        private System.Windows.Forms.ComboBox create_user_cbm;
        private System.Windows.Forms.ComboBox createuser_department_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label last_name_lab;
        private System.Windows.Forms.Label createuser_family_name_lab;
        private System.Windows.Forms.Label Password_lab;
        private System.Windows.Forms.Label createuser_username_lab;
        private System.Windows.Forms.TabControl userControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SearchUser_but;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Userselect_grp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox main_emailid_txt;
        private System.Windows.Forms.Button button2;
    }
}