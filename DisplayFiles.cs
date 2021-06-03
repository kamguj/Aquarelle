using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Aquarelle
{
    public partial class DisplayFiles : Form
    {
       

        public DisplayFiles()
        {
            InitializeComponent();
        }

        private void DisplayFiles_Load(object sender, EventArgs e)
        {

            string foldername = @"c:\Print\" + GlobalUserName.usercode;
            foreach (var item in Directory.GetFiles(foldername))
            {

                FilesListing_lst.Items.Add(item);
            }


        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     


        private void FilesListing_lst_SelectedIndexChanged(object sender, EventArgs e)
        {


            /* string selectedItems = FilesListing_lst.SelectedItems.ToString();
             string all = Path.GetFullPath(selectedItems);
             MessageBox.Show(all);*/

           

            var selectedItem = FilesListing_lst.SelectedItem;
            /*string path = selectedItem.ToString();*/

            filepath.file_path = selectedItem.ToString();

            MessageBox.Show(filepath.file_path);

            axAcroPDF_read.src = filepath.file_path;


            
           

        }

        private void printed_validated_Click(object sender, EventArgs e)
        {

            var filename = System.IO.Path.GetFileName(filepath.file_path);


            var selectedItem = FilesListing_lst.SelectedItem;
            filepath.file_path = selectedItem.ToString();
         

            DialogResult dialogResult = MessageBox.Show("Validation and Printing Completed For " + filepath.file_path + "?", "Archiving of Customer Document", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {

                string rootFolderPath = @"c:\Print\" + GlobalUserName.usercode;
                string destinationPath = @"c:\Print\Archive\";
                string fileToMove = filepath.file_path;
                string moveTo = destinationPath + filename;

            


                //moving file
                File.Move(fileToMove, moveTo);

                MessageBox.Show(" The File has been Transfered to : " + destinationPath);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("File Not Archived, Please Complete Validation and Printing");
            }

            

        }

        private void refresh_but_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilesListing_lst.Items.Clear();

            string foldername = @"c:\Print\" + GlobalUserName.usercode;
            foreach (var item in Directory.GetFiles(foldername))
            {
                FilesListing_lst.Items.Clear();
                FilesListing_lst.Items.Add(item);
            }
        }
    }

    

        
  
}
