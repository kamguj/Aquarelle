using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Aquarelle
{
    public partial class AdminMenu : Form
    {

        public AdminMenu()
        {
            InitializeComponent();
        }


        //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DI52UQ6\SQLEXPRESS;Initial Catalog=AQUARELLE;Persist Security Info=True;User ID=sa;Password=Neeruv19!@");


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

      
        private void CreateUser_but_Click(object sender, EventArgs e)
        {
            string randomstring = string.Empty;
            char[] array = "0123456789qwertyuiopasdfghjklzxcvbnm@$&%".ToCharArray();
            Random r1 = new Random();
            for (int i = 0; i < 8; i++)
            {
                int point = r1.Next(1, array.Length);
                if (!randomstring.Contains(array.GetValue(point).ToString()))
                    randomstring += array.GetValue(point);
                else
                    i--;
            }

            create_password_txt.Text = randomstring;

            try

            {

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into aquarelle_userS values('" + createuser_username_txt.Text + "', '" + create_password_txt.Text + "', '" + createuser_family_name_txt.Text + "', '" + createuser_last_name_txt.Text + "', '" + createuser_department_cmb.Text + "', '" + create_user_cbm.Text + "', '" + Email_address_txt.Text + "', NULL )", con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("User Created Successfully....Please wait while we notify the employee for his Password");
                con.Close();

            }

            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }




            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "kamini.unauth@gmail.com",
                    Password = "cdyeffbtsfvbmajl"
                }
            };
            MailAddress FromEmail = new MailAddress("kamini.unauth@gmail.com");
            MailAddress ToEmail = new MailAddress(Email_address_txt.Text);
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Password for user " + createuser_username_txt.Text ,
                Body = " Dear " + createuser_last_name_txt.Text + " " +  createuser_family_name_txt.Text + " , " +  " " +  "Your one time password for Aquarelle App is " + create_password_txt.Text     
            };
            Message.To.Add(ToEmail);

            try
            {

                Client.Send(Message);
                MessageBox.Show("Email sent successfully to the employee");

            }


            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something is wrong");
            }



            string path = @"C:\Print\";
            string user = createuser_username_txt.Text;
            string user_folder = path + user;
            if (!Directory.Exists(user_folder))
            {
                Directory.CreateDirectory(user_folder);


                using (SqlConnection sqlConnPath = new
            SqlConnection(@"Data Source=DESKTOP-DI52UQ6\SQLEXPRESS;Initial Catalog=AQUARELLE;Persist Security Info=True;User ID=sa;Password=Neeruv19!@"))
                {


                    string Query = "UPDATE aquarelle_users SET userpath =  '" + user_folder + "'   WHERE usercode = '" + createuser_username_txt.Text + "'; ";
                    SqlCommand cmd1 = new SqlCommand(Query, sqlConnPath);
                    cmd1.Connection.Open();
                    try
                    {
                        cmd1.ExecuteNonQuery();
                       
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error " + ex.Message);
                    }



                    MessageBox.Show(" User Folder Created");


                }



            }
            else
            {
                MessageBox.Show(" Directory already exists");
            }



        }

        private void create_password_txt_TextChanged(object sender, EventArgs e)
        {
          
        }

       
        private void CreateUsers_Click(object sender, EventArgs e)
        {

        }

        private void CreateUsers_LOAD(object sender, EventArgs e)
        {
       
        }


        private void DeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void SearchUser_but_Click(object sender, EventArgs e)
        {
            SqlConnection constring = new SqlConnection(@"Data Source=DESKTOP-DI52UQ6\SQLEXPRESS;Initial Catalog=AQUARELLE;Persist Security Info=True;User ID=sa;Password=Neeruv19!@");
            SqlDataAdapter maint_user = new SqlDataAdapter("select * from aquarelle_users where usercode = '" + main_Username_txt.Text + "' ", con);

            DataTable dt_maint_user = new DataTable();


            maint_user.Fill(dt_maint_user);



            if (dt_maint_user.Rows.Count > 0)
            {


                main_emailid_txt.Text = dt_maint_user.Rows[0]["email_addess"].ToString();
                main_family_name_txt.Text = dt_maint_user.Rows[0]["family_name"].ToString();
                main_lastname_txt.Text = dt_maint_user.Rows[0]["last_name"].ToString();
                main_department_txt.Text = dt_maint_user.Rows[0]["department"].ToString();
                main_role_txt.Text = dt_maint_user.Rows[0]["role"].ToString();
            }
            else
            {
                MessageBox.Show(" Please ensure you have entered the correct user code");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_Username_txt.Text = "";
            main_emailid_txt.Text = "";
            main_family_name_txt.Text = "";
            main_lastname_txt.Text = "";
            main_department_txt.Text = "";
            main_role_txt.Text = "";
        }
    }
}
