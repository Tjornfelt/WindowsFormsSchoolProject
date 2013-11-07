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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.scOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.mcCustomControl});
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(708, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // scOpenFileDialog
            // 
            this.scOpenFileDialog.FileName = "openFileDialog1";
            this.scOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.scOpenFileDialog_FileOk);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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

    }
}

