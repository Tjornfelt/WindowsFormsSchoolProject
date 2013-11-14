using WindowsFormsSchoolProject.CustomControls;

namespace WindowsFormsSchoolProject.Forms
{
    partial class WindowsForms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.printPreview = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.Label();
            this.scOpenFile = new System.Windows.Forms.Button();
            this.scClear = new System.Windows.Forms.Button();
            this.scSave = new System.Windows.Forms.Button();
            this.scRichText = new System.Windows.Forms.RichTextBox();
            this.scClickMe = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mcMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mcCustomControl = new System.Windows.Forms.ToolStripMenuItem();
            this.mDIFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Xml = new System.Windows.Forms.TabPage();
            this.ReadXml = new System.Windows.Forms.Button();
            this.SaveXml = new System.Windows.Forms.Button();
            this.xmlTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateRawXml = new System.Windows.Forms.Button();
            this.scOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.showUsers = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Xml.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Xml);
            this.tabControl1.Location = new System.Drawing.Point(13, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.showUsers);
            this.tabPage1.Controls.Add(this.printPreview);
            this.tabPage1.Controls.Add(this.Print);
            this.tabPage1.Controls.Add(this.filename);
            this.tabPage1.Controls.Add(this.scOpenFile);
            this.tabPage1.Controls.Add(this.scClear);
            this.tabPage1.Controls.Add(this.scSave);
            this.tabPage1.Controls.Add(this.scRichText);
            this.tabPage1.Controls.Add(this.scClickMe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple Controls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // printPreview
            // 
            this.printPreview.Location = new System.Drawing.Point(6, 95);
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(182, 23);
            this.printPreview.TabIndex = 7;
            this.printPreview.Text = "Print with preview";
            this.printPreview.UseVisualStyleBackColor = true;
            this.printPreview.Click += new System.EventHandler(this.printPreview_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(7, 66);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(181, 23);
            this.Print.TabIndex = 6;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(7, 66);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(0, 13);
            this.filename.TabIndex = 5;
            // 
            // scOpenFile
            // 
            this.scOpenFile.Location = new System.Drawing.Point(7, 36);
            this.scOpenFile.Name = "scOpenFile";
            this.scOpenFile.Size = new System.Drawing.Size(181, 23);
            this.scOpenFile.TabIndex = 4;
            this.scOpenFile.Text = "Open File";
            this.scOpenFile.UseVisualStyleBackColor = true;
            this.scOpenFile.Click += new System.EventHandler(this.scOpenFile_Click);
            // 
            // scClear
            // 
            this.scClear.Location = new System.Drawing.Point(546, 393);
            this.scClear.Name = "scClear";
            this.scClear.Size = new System.Drawing.Size(75, 23);
            this.scClear.TabIndex = 3;
            this.scClear.Text = "Clear";
            this.scClear.UseVisualStyleBackColor = true;
            this.scClear.Click += new System.EventHandler(this.scClear_Click);
            // 
            // scSave
            // 
            this.scSave.Location = new System.Drawing.Point(627, 393);
            this.scSave.Name = "scSave";
            this.scSave.Size = new System.Drawing.Size(75, 23);
            this.scSave.TabIndex = 2;
            this.scSave.Text = "Save";
            this.scSave.UseVisualStyleBackColor = true;
            this.scSave.Click += new System.EventHandler(this.scSave_Click);
            // 
            // scRichText
            // 
            this.scRichText.Location = new System.Drawing.Point(202, 6);
            this.scRichText.Name = "scRichText";
            this.scRichText.Size = new System.Drawing.Size(500, 385);
            this.scRichText.TabIndex = 1;
            this.scRichText.Text = "";
            this.scRichText.TextChanged += new System.EventHandler(this.scRichText_TextChanged);
            // 
            // scClickMe
            // 
            this.scClickMe.Location = new System.Drawing.Point(6, 6);
            this.scClickMe.Name = "scClickMe";
            this.scClickMe.Size = new System.Drawing.Size(182, 23);
            this.scClickMe.TabIndex = 0;
            this.scClickMe.Text = "Click me!";
            this.scClickMe.UseVisualStyleBackColor = true;
            this.scClickMe.Click += new System.EventHandler(this.scClickMe_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menu Controls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mcMenuItem1
            // 
            this.mcMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcCustomControl,
            this.mDIFormsToolStripMenuItem});
            this.mcMenuItem1.Name = "mcMenuItem1";
            this.mcMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.mcMenuItem1.Text = "Menu Item 1";
            // 
            // mcCustomControl
            // 
            this.mcCustomControl.Name = "mcCustomControl";
            this.mcCustomControl.Size = new System.Drawing.Size(159, 22);
            this.mcCustomControl.Text = "Custom Control";
            this.mcCustomControl.Click += new System.EventHandler(this.mcCustomControl_Click);
            // 
            // mDIFormsToolStripMenuItem
            // 
            this.mDIFormsToolStripMenuItem.Name = "mDIFormsToolStripMenuItem";
            this.mDIFormsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mDIFormsToolStripMenuItem.Text = "MDI forms";
            this.mDIFormsToolStripMenuItem.Click += new System.EventHandler(this.mDIFormsToolStripMenuItem_Click);
            // 
            // Xml
            // 
            this.Xml.Controls.Add(this.ReadXml);
            this.Xml.Controls.Add(this.SaveXml);
            this.Xml.Controls.Add(this.xmlTextBox);
            this.Xml.Controls.Add(this.GenerateRawXml);
            this.Xml.Location = new System.Drawing.Point(4, 22);
            this.Xml.Name = "Xml";
            this.Xml.Padding = new System.Windows.Forms.Padding(3);
            this.Xml.Size = new System.Drawing.Size(708, 419);
            this.Xml.TabIndex = 2;
            this.Xml.Text = "Xml";
            this.Xml.UseVisualStyleBackColor = true;
            // 
            // ReadXml
            // 
            this.ReadXml.Location = new System.Drawing.Point(7, 37);
            this.ReadXml.Name = "ReadXml";
            this.ReadXml.Size = new System.Drawing.Size(189, 23);
            this.ReadXml.TabIndex = 3;
            this.ReadXml.Text = "Read Xml File";
            this.ReadXml.UseVisualStyleBackColor = true;
            this.ReadXml.Click += new System.EventHandler(this.ReadXml_Click);
            // 
            // SaveXml
            // 
            this.SaveXml.Location = new System.Drawing.Point(593, 389);
            this.SaveXml.Name = "SaveXml";
            this.SaveXml.Size = new System.Drawing.Size(108, 23);
            this.SaveXml.TabIndex = 2;
            this.SaveXml.Text = "Save Xml File";
            this.SaveXml.UseVisualStyleBackColor = true;
            this.SaveXml.Click += new System.EventHandler(this.SaveXml_Click);
            // 
            // xmlTextBox
            // 
            this.xmlTextBox.Location = new System.Drawing.Point(202, 6);
            this.xmlTextBox.Name = "xmlTextBox";
            this.xmlTextBox.Size = new System.Drawing.Size(500, 376);
            this.xmlTextBox.TabIndex = 1;
            this.xmlTextBox.Text = "";
            // 
            // GenerateRawXml
            // 
            this.GenerateRawXml.Location = new System.Drawing.Point(7, 7);
            this.GenerateRawXml.Name = "GenerateRawXml";
            this.GenerateRawXml.Size = new System.Drawing.Size(189, 23);
            this.GenerateRawXml.TabIndex = 0;
            this.GenerateRawXml.Text = "Generate Raw Xml";
            this.GenerateRawXml.UseVisualStyleBackColor = true;
            this.GenerateRawXml.Click += new System.EventHandler(this.GenerateRawXml_Click);
            // 
            // scOpenFileDialog
            // 
            this.scOpenFileDialog.FileName = "openFileDialog1";
            this.scOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.scOpenFileDialog_FileOk);
            // 
            // showUsers
            // 
            this.showUsers.Location = new System.Drawing.Point(7, 124);
            this.showUsers.Name = "showUsers";
            this.showUsers.Size = new System.Drawing.Size(181, 23);
            this.showUsers.TabIndex = 8;
            this.showUsers.Text = "Show All Users";
            this.showUsers.UseVisualStyleBackColor = true;
            this.showUsers.Click += new System.EventHandler(this.showUsers_Click);
            // 
            // WindowsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 460);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WindowsForms";
            this.Text = "Windows Forms School Project";
            this.Load += new System.EventHandler(this.WindowsForms_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Xml.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Xml;
        private System.Windows.Forms.Button scClickMe;
        private System.Windows.Forms.RichTextBox scRichText;
        private System.Windows.Forms.Button scSave;
        private System.Windows.Forms.Button scClear;
        private System.Windows.Forms.OpenFileDialog scOpenFileDialog;
        private System.Windows.Forms.Button scOpenFile;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mcMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mcCustomControl;
        private System.Windows.Forms.Button ReadXml;
        private System.Windows.Forms.Button SaveXml;
        private System.Windows.Forms.RichTextBox xmlTextBox;
        private System.Windows.Forms.Button GenerateRawXml;
        private System.Windows.Forms.ToolStripMenuItem mDIFormsToolStripMenuItem;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button printPreview;
        private System.Windows.Forms.Button showUsers;

    }
}

