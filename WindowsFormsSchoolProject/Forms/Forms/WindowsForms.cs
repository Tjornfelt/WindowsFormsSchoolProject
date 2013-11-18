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
using System.Xml;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Xml.Serialization;
using WindowsFormsSchoolProject.Helpers;
using System.Threading;

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
        bool databaseAvailable;

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

            databaseAvailable = en.IsDatabaseAvailable();

            //If the database is available...
            if (databaseAvailable)
            {
                //If the users in the database and the xml document differs, update the database with the local data.
                List<User> xmlUserList = XMLhelpers.FetchUsersFromXml();
                List<User> userList = en.GetAllUsers();

                bool inSync = true;
                for (int i = 0; i < xmlUserList.Count(); i++)
                {
                    if (xmlUserList[i].username  != userList[i].username || xmlUserList[i].email != userList[i].email || xmlUserList[i].id != userList[i].id)
                    {
                        inSync = false;
                    }
                }

                if (!inSync)
                {
                    MessageBox.Show("Detected unsynced data. Overwriting database with local data.");
                    en.TruncateTable();
                    en.PopulateTable(xmlUserList);
                    userList = en.GetAllUsers();
                    dataGridView1.DataSource = userList;
                }
                else
                {
                    dataGridView1.DataSource = userList;
                }
                //The database is available, and data has been fetched from it. Now, just save the data into XML so it
                //is available offline also!
                XMLhelpers.SaveUsersToXml(userList);
            }
            else
            {
                this.Text += " - Offline mode";
                MessageBox.Show("Can't connect to database. Starting in offline mode");

                //In offline mode, all data is loaded from the local xml document.
                dataGridView1.DataSource = XMLhelpers.FetchUsersFromXml();
            }
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newUser_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser(databaseAvailable);

            DialogResult dResult = createUser.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                //TODO confirmation message
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (databaseAvailable)
            {
                Entity en = new Entity();
                List<User> userList = en.GetAllUsers();
                dataGridView1.DataSource = userList;
            }
            else
            {
                dataGridView1.DataSource = XMLhelpers.FetchUsersFromXml();
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser(databaseAvailable);

            DialogResult dResult = deleteUser.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                //TODO confirmation message
            }
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser(databaseAvailable);

            DialogResult dResult = editUser.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                //TODO confirmation message
            }
        }

        private void btn_backgroundWorker_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(100); // 1/10 second.
                backgroundWorker1.ReportProgress(10);
            }
            MessageBox.Show("One second has passed!");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value += e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
        }
    }
}
