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

namespace WindowsFormsSchoolProject.Forms
{
    public partial class WindowsForms : Form
    {
        string appPath;
        string scText;
        string folderName;
        string folderPath;
        string filePath;

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

    }
}
