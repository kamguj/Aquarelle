using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aquarelle
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void Cancel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            
            SqlConnection con =  new SqlConnection(@"Data Source=DESKTOP-DI52UQ6\SQLEXPRESS;Initial Catalog=AQUARELLE;Persist Security Info=True;User ID=sa;Password=Neeruv19!@"); 
            SqlDataAdapter sda_user = new SqlDataAdapter ("select * from aquarelle_users where usercode = '" + username_txt.Text + "' and password = '" + password_txt.Text + "'", con);
       
            DataTable dt_user = new DataTable();

            
            sda_user.Fill(dt_user);


            string cmbItemValue = usertype_combo.SelectedItem.ToString();


            if (dt_user.Rows.Count > 0)
             {
               

                for (int i =0; i<dt_user.Rows.Count; i++)
                 { if (dt_user.Rows[i]["role"].ToString() == cmbItemValue)
                        if (usertype_combo.SelectedIndex == 0)

                        {
                            AdminMenu a = new AdminMenu();
                            a.Show();
                            this.Hide();
                        }
                        else
                        {

                            GlobalUserName.usercode = dt_user.Rows[0]["usercode"].ToString();
                            GlobalUserName.family_name = dt_user.Rows[0]["family_name"].ToString();
                            GlobalUserName.last_name = dt_user.Rows[0]["last_name"].ToString();
                            MainMenu u = new MainMenu();
                            u.Show();
                            this.Hide();
                        }
                 }

              
            }

            else
            { MessageBox.Show("Please check your username and password"); 
            }


        }
    }
}
