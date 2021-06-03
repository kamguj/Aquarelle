using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Aquarelle
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        

        private void ChangePassword_but_Click(object sender, EventArgs e)
        {

            

            using (SqlConnection sqlConn = new
        SqlConnection(@"Data Source=DESKTOP-DI52UQ6\SQLEXPRESS;Initial Catalog=AQUARELLE;Persist Security Info=True;User ID=sa;Password=Neeruv19!@"))
            {
                if (NewPassword_txt.Text == ReNewPassword_txt.Text)

                {

                    string Query = "UPDATE aquarelle_users SET password = '" + NewPassword_txt.Text + "'   WHERE password = '" + OldPassword_txt.Text + "' ;";
                    SqlCommand cmd = new SqlCommand(Query, sqlConn);
                    cmd.Connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show ("Your password has been updated, Please Login with New Password");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error " + ex.Message);
                    }

                }

            

                else
                MessageBox.Show(" Please ensure you have re-entered the new password correctly");

            

            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
