using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Aquarelle
{
    public partial class MainMenu : Form
    {

        private System.IO.FileSystemWatcher folder_watcher; 
        public MainMenu()
        {
            InitializeComponent();
        }

        public static string ExtractTextFromPdf(string path)
        {
            PdfReader reader = new PdfReader(path);
            int intPageNum = reader.NumberOfPages;
            string[] words;
            string line;

            for (int i = 1; i <= intPageNum; i++)
            {
                var text = PdfTextExtractor.GetTextFromPage(reader, i, new LocationTextExtractionStrategy());

                words = text.Split('\n');

              //  var header = "PDF Name|Date|Customer Name|Family Name";
                var textToSave = "CUSINFO.12456879724.pdf|";
                var accountNumber1 = "";
                var accountNumber2 = "";

                int counter = 0;

                for (int j = 0, len = words.Length; j < len; j++)
                {
                    line = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(words[j]));

                    if (line.Contains("Date:"))
                    {
                        textToSave += line.Substring(5);
                    }

                    if (line.Contains("Customer Number:"))
                    {
                        textToSave += "|";
                        textToSave += line.Substring(16);
                    }

                    if (line.Contains("Family name:"))
                    {
                        textToSave += "|";
                        textToSave += line.Substring(12);
                    }

                    if (counter == 3)
                    {
                        using (TextWriter tsw = new StreamWriter(@"C:\Print\Archive\sampletext.txt", true))
                        {
                           // tsw.WriteLine(header);
                            tsw.WriteLine(textToSave);
                            tsw.WriteLine(accountNumber1);
                            tsw.WriteLine(accountNumber2);
                        }
                        counter++;

                    }

                    if (counter == 2)
                    {
                        accountNumber2 += line.Substring(0, 10);
                        accountNumber2 += "|";
                        accountNumber2 += line.Substring(10, 12);

                        counter++;
                    }
                    if (counter == 1)
                    {
                        accountNumber1 += line.Substring(0, 10);
                        accountNumber1 += "|";
                        accountNumber1 += line.Substring(10, 12);
                        counter++;
                    }
                    if (line.Contains("Account Number Account Creation Date"))
                    {
                        counter++;
                    }

                }
            }

            return null;

        }

        public static string ExtractTextFromPdf2(string path)
        {
            PdfReader reader = new PdfReader(path);
            int intPageNum = reader.NumberOfPages;
            string[] words;
            string line;

            for (int i = 1; i <= intPageNum; i++)
            {
                var text = PdfTextExtractor.GetTextFromPage(reader, i, new LocationTextExtractionStrategy());

                words = text.Split('\n');

               // var header = "PDF Name|Date|Customer Name|Family Name";
                var textToSave = "CUSINFO.2456789790126.pdf|";
                var accountNumber1 = "";
                var accountNumber2 = "";

                int counter = 0;

                for (int j = 0, len = words.Length; j < len; j++)
                {
                    line = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(words[j]));

                    if (line.Contains("Date:"))
                    {
                        textToSave += line.Substring(5);
                    }

                    if (line.Contains("Customer Number:"))
                    {
                        textToSave += "|";
                        textToSave += line.Substring(16);
                    }

                    if (line.Contains("Family name:"))
                    {
                        textToSave += "|";
                        textToSave += line.Substring(12);
                    }

                    if (counter == 3)
                    {
                        using (TextWriter tsw = new StreamWriter(@"C:\Print\Archive\sampletext.txt", true))
                        {
                          //  tsw.WriteLine(header);
                            tsw.WriteLine(textToSave);
                            tsw.WriteLine(accountNumber1);
                            tsw.WriteLine(accountNumber2);
                        }
                        counter++;

                    }

                    if (counter == 2)
                    {
                        accountNumber2 += line.Substring(0, 10);
                        accountNumber2 += "|";
                        accountNumber2 += line.Substring(10, 12);

                        counter++;
                    }
                    if (counter == 1)
                    {
                        accountNumber1 += line.Substring(0, 10);
                        accountNumber1 += "|";
                        accountNumber1 += line.Substring(10, 12);
                        counter++;
                    }
                    if (line.Contains("Account Number  Account Creation Date  "))
                    {
                        counter++;
                    }

                }
            }

            return null;

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword a = new ChangePassword();
            a.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            watch();

          /*  labelUsername.Text =  GlobalUserName.usercode;*/
            statusBarPanel1.Text = "UserCode:"  + "  " + GlobalUserName.usercode;
            statusBarPanel2.Text = "Name:" + "  " +GlobalUserName.last_name + "  " + GlobalUserName.family_name;
            
        }

        void watch() 
        
        {
        
        try {


                folder_watcher = new System.IO.FileSystemWatcher();
                folder_watcher.Filter = "*.pdf";
                folder_watcher.Path = @"c:\Print\" + GlobalUserName.usercode;
                folder_watcher.IncludeSubdirectories = true;
                folder_watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
                folder_watcher.Created += new FileSystemEventHandler(OnChanged);
                folder_watcher.EnableRaisingEvents = true;

            }

         catch (Exception ex)
            
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something is wrong");
            }
        
        }


        public void OnChanged(object server, FileSystemEventArgs e)
        {


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
            MailAddress ToEmail = new MailAddress("kamini.gujadhur@gmail.com");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "File is available",
                Body = " Dear User, Please note that file is available for printing "
            };
            Message.To.Add(ToEmail);

            try
            {

                Client.Send(Message);
                MessageBox.Show("Email sent successfully to the employee");
                MessageBox.Show(e.FullPath + "File is Available");

            }


            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something is wrong");
            }




          

        }

        private void scanFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFiles child = new DisplayFiles();
            child.MdiParent = MainMenu.ActiveForm;
            child.Show();

          
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePassword child2 = new ChangePassword();
            child2.MdiParent = MainMenu.ActiveForm;
            child2.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void convertPDFInTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var ExtractedPDFToString
            = ExtractTextFromPdf(@"C:\Print\Archive\CUSINFO.12456879724.pdf");
           

            var ExtractedPDFToString2
            = ExtractTextFromPdf2(@"C:\Print\Archive\CUSINFO.2456789790126.pdf");

            MessageBox.Show("File has Processed for Auditing Purposes");
        }
    }
}
