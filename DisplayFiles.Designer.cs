
namespace Aquarelle
{
    partial class DisplayFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayFiles));
            this.FilesListing_lst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.axAcroPDF_read = new AxAcroPDFLib.AxAcroPDF();
            this.printed_validated = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_read)).BeginInit();
            this.SuspendLayout();
            // 
            // FilesListing_lst
            // 
            this.FilesListing_lst.FormattingEnabled = true;
            this.FilesListing_lst.Location = new System.Drawing.Point(26, 58);
            this.FilesListing_lst.Name = "FilesListing_lst";
            this.FilesListing_lst.Size = new System.Drawing.Size(327, 199);
            this.FilesListing_lst.TabIndex = 0;
            this.FilesListing_lst.SelectedIndexChanged += new System.EventHandler(this.FilesListing_lst_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Customer Documents Available";
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(278, 307);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(75, 23);
            this.exit_but.TabIndex = 2;
            this.exit_but.Text = "Exit";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // axAcroPDF_read
            // 
            this.axAcroPDF_read.Enabled = true;
            this.axAcroPDF_read.Location = new System.Drawing.Point(449, 58);
            this.axAcroPDF_read.Name = "axAcroPDF_read";
            this.axAcroPDF_read.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF_read.OcxState")));
            this.axAcroPDF_read.Size = new System.Drawing.Size(500, 500);
            this.axAcroPDF_read.TabIndex = 3;
            // 
            // printed_validated
            // 
            this.printed_validated.Location = new System.Drawing.Point(26, 307);
            this.printed_validated.Name = "printed_validated";
            this.printed_validated.Size = new System.Drawing.Size(117, 23);
            this.printed_validated.TabIndex = 4;
            this.printed_validated.Text = "Archiving";
            this.printed_validated.UseVisualStyleBackColor = true;
            this.printed_validated.Click += new System.EventHandler(this.printed_validated_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printed_validated);
            this.Controls.Add(this.axAcroPDF_read);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilesListing_lst);
            this.Name = "DisplayFiles";
            this.Text = "DisplayFiles";
            this.Load += new System.EventHandler(this.DisplayFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_read)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilesListing_lst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_but;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF_read;
        private System.Windows.Forms.Button printed_validated;
        private System.Windows.Forms.Button button1;
    }
}