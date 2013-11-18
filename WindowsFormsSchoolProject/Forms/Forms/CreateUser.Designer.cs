namespace WindowsFormsSchoolProject.Forms
{
    partial class CreateUser
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createUserOk = new System.Windows.Forms.Button();
            this.createUserCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(73, 12);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(207, 20);
            this.txt_username.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(73, 35);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(207, 20);
            this.txt_email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // createUserOk
            // 
            this.createUserOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createUserOk.Location = new System.Drawing.Point(124, 61);
            this.createUserOk.Name = "createUserOk";
            this.createUserOk.Size = new System.Drawing.Size(75, 23);
            this.createUserOk.TabIndex = 4;
            this.createUserOk.Text = "OK";
            this.createUserOk.UseVisualStyleBackColor = true;
            this.createUserOk.Click += new System.EventHandler(this.createUserOk_Click);
            // 
            // createUserCancel
            // 
            this.createUserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createUserCancel.Location = new System.Drawing.Point(205, 61);
            this.createUserCancel.Name = "createUserCancel";
            this.createUserCancel.Size = new System.Drawing.Size(75, 23);
            this.createUserCancel.TabIndex = 5;
            this.createUserCancel.Text = "Cancel";
            this.createUserCancel.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 91);
            this.Controls.Add(this.createUserCancel);
            this.Controls.Add(this.createUserOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_username);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createUserOk;
        private System.Windows.Forms.Button createUserCancel;
    }
}