﻿namespace WindowsFormsSchoolProject.Forms
{
    partial class CustomControlsForm
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
            this.superButton1 = new WindowsFormsSchoolProject.CustomControls.SuperButton();
            this.SuspendLayout();
            // 
            // superButton1
            // 
            this.superButton1.IsSuper = false;
            this.superButton1.Location = new System.Drawing.Point(13, 13);
            this.superButton1.Name = "superButton1";
            this.superButton1.Size = new System.Drawing.Size(75, 23);
            this.superButton1.TabIndex = 0;
            this.superButton1.Text = "superButton1";
            this.superButton1.UseVisualStyleBackColor = true;
            this.superButton1.Click += new System.EventHandler(this.superButton1_Click);
            // 
            // CustomControlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.superButton1);
            this.Name = "CustomControlsForm";
            this.Text = "CustomControlsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.SuperButton superButton1;
    }
}