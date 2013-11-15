﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Drawing.Printing;
using System.Diagnostics;

namespace WindowsFormsSchoolProject.Forms
{
    public partial class WindowsForms : Form
    {
        string appPath;
        string scText;
        string folderName;
        string folderPath;
        string filePath;
        XmlDocument doc = new XmlDocument();

        public WindowsForms()
        {
            InitializeComponent();
        }

        private void WindowsForms_Load(object sender, EventArgs e)
        {
            appPath = Path.GetDirectoryName(Application.ExecutablePath);
            scText = "Congratulations! You clicked the button! " + Environment.NewLine +
                     "Now, enter some text and save it. It will be saved to a .txt file.";

            folderName = @"\UserFiles";
            folderPath = appPath + folderName;
            scOpenFileDialog.InitialDirectory = folderPath;

            Entity en = new Entity();
            List<User> userList = en.GetAllUsers();
            dataGridView1.DataSource = userList;
        }

        private void scClickMe_Click(object sender, EventArgs e)
        {
            scRichText.Text = scText;
        }

        private void scRichText_TextChanged(object sender, EventArgs e)
        {

        }

        private void scSave_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm();

            popup.Text = "Gem fil";

            popup.Size = new Size(410, 150);

            DialogResult dResult = popup.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                string folderPath = appPath + folderName;
                bool folderExists = System.IO.Directory.Exists(folderPath);
                if (!folderExists)
                {
                    
                    System.IO.Directory.CreateDirectory(folderPath);
                }


                string filePath = appPath + folderName + popup.fileName;
                System.IO.File.WriteAllText(filePath, scRichText.Text);
            }
        }

        private void scClear_Click(object sender, EventArgs e)
        {
            scRichText.Text = string.Empty;
        }

        private void scOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = scOpenFileDialog.FileName;

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    String line = sr.ReadToEnd();
                    scRichText.Text += line;
                    filename.Text = scOpenFileDialog.SafeFileName;
                }
            }
            catch (Exception ex)
            {
                scRichText.Text = "The file could not be read:" + Environment.NewLine;
                scRichText.Text += ex.Message;
            }

        }

        private void scOpenFile_Click(object sender, EventArgs e)
        {
            scOpenFileDialog.ShowDialog();
        }

        private void mcCustomControl_Click(object sender, EventArgs e)
        {
            CustomControlsForm customControlsForm = new CustomControlsForm();

            customControlsForm.Text = "Custom Controls!";

            customControlsForm.Size = new Size(300, 300);

            DialogResult dResult = customControlsForm.ShowDialog();
        }

        private void GenerateRawXml_Click(object sender, EventArgs e)
        {
            XmlDocument newDoc = new XmlDocument();
            XmlElement el = (XmlElement)newDoc.AppendChild(newDoc.CreateElement("RootElement"));
            el.SetAttribute("Attribute1", "Value");
            el.AppendChild(newDoc.CreateElement("NestedElement")).InnerText = "InnerTextValue1";
            el.AppendChild(newDoc.CreateElement("NestedElement")).InnerText = "InnerTextValue2";
            xmlTextBox.Text = BeautifyXml.Beautify(newDoc);
        }

        private void SaveXml_Click(object sender, EventArgs e)
        {
            //Save the text into a new xml string.
            string xmlString = xmlTextBox.Text;

            doc.LoadXml(xmlString);
        }

        private void ReadXml_Click(object sender, EventArgs e)
        {
            //Clear the textbox.
            xmlTextBox.Text = string.Empty;

            if (!string.IsNullOrWhiteSpace(doc.OuterXml))
            {
                XmlNodeList xnList = doc.SelectNodes("/RootElement/NestedElement");
                foreach (XmlNode xn in xnList)
                {
                    string nestedElement = xn.InnerText;
                    xmlTextBox.Text += "NestedElement Value: " + nestedElement + Environment.NewLine;
                }
            }
            else
            {
                xmlTextBox.Text = "Remember to generate the xml first!";
            }
        }

        private void mDIFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIparent mdiParent = new MDIparent();

            mdiParent.Text = "MDI parent";

            mdiParent.Size = new Size(500,500);

            mdiParent.Show();
            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDocument.Print();
            }
            
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);

            int startX = 20;
            int startY = 20;

            graphic.DrawString(scText, font, new SolidBrush(Color.Black), startX, startY);
        }

        private void printPreview_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();                        //Sets up a "standard" print preview page.
            PrintDocument printDocument = new PrintDocument();                              //Create the actual document.
            printDocument.PrintPage += printDocument_PrintPage; //Set up the printpage: content, font-size etc.  This is an eventhandler. Create a new eventhandler, and specify the function to call when triggered.           
            pageSetupDialog.Document = printDocument;                                       //Save the printDocument object into the pageSetupDialog.Document object.              
            DialogResult setupResult = pageSetupDialog.ShowDialog();                        //Show the pageSetupDialog and save the users choice.

            //User clicks 'OK'
            if (setupResult == DialogResult.OK)
            {
                PrintDialog printDialog = new PrintDialog();                                //Create a new PrintDialog object.
                printDialog.Document = pageSetupDialog.Document;                            //Save the document previously created using the PageSetupDialog into the PrintDialog

                DialogResult printResult = printDialog.ShowDialog();                        //Show the PrintDialog and save the users choice.

                //User clicks 'OK'
                if (printResult == DialogResult.OK)                                         
                {
                    printDialog.Document.Print();                                           //Use the PrintDialog to print the page. The Document has been thrown from object to object and now needs to be printed.
                }
            }
        }

        private void showUsers_Click(object sender, EventArgs e)
        {
            Entity en = new Entity();

            List<User> userList = en.GetAllUsers();

            foreach (var item in userList)
	        {
                scRichText.Text += item.username + Environment.NewLine;
	        }
        }

        private void scClickMe_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void onscreenKeyboard_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("OSK.exe");
            }
            catch (Exception error)
            {
                string err = error.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
