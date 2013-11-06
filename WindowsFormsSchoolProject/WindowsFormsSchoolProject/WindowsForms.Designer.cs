namespace WindowsFormsSchoolProject
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
            this.scClickMe = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.scRichText = new System.Windows.Forms.RichTextBox();
            this.scSave = new System.Windows.Forms.Button();
            this.scClear = new System.Windows.Forms.Button();
            this.scOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.scOpenFile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // scRichText
            // 
            this.scRichText.Location = new System.Drawing.Point(202, 6);
            this.scRichText.Name = "scRichText";
            this.scRichText.Size = new System.Drawing.Size(500, 385);
            this.scRichText.TabIndex = 1;
            this.scRichText.Text = "";
            this.scRichText.TextChanged += new System.EventHandler(this.scRichText_TextChanged);
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
            // scOpenFileDialog
            // 
            this.scOpenFileDialog.FileName = "openFileDialog1";
            this.scOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.scOpenFileDialog_FileOk);
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
            // WindowsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 460);
            this.Controls.Add(this.tabControl1);
            this.Name = "WindowsForms";
            this.Text = "Windows Forms School Project";
            this.Load += new System.EventHandler(this.WindowsForms_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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

    }
}

