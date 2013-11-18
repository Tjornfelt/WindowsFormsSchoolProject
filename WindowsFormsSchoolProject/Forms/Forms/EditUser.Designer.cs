namespace WindowsFormsSchoolProject.Forms
{
    partial class EditUser
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
            this.txt_editUsername = new System.Windows.Forms.TextBox();
            this.txt_editEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_editUserOk = new System.Windows.Forms.Button();
            this.btn_editUserCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_editUserId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_editUsername
            // 
            this.txt_editUsername.Location = new System.Drawing.Point(114, 48);
            this.txt_editUsername.Name = "txt_editUsername";
            this.txt_editUsername.Size = new System.Drawing.Size(228, 20);
            this.txt_editUsername.TabIndex = 0;
            // 
            // txt_editEmail
            // 
            this.txt_editEmail.Location = new System.Drawing.Point(114, 75);
            this.txt_editEmail.Name = "txt_editEmail";
            this.txt_editEmail.Size = new System.Drawing.Size(228, 20);
            this.txt_editEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New email";
            // 
            // btn_editUserOk
            // 
            this.btn_editUserOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_editUserOk.Location = new System.Drawing.Point(186, 101);
            this.btn_editUserOk.Name = "btn_editUserOk";
            this.btn_editUserOk.Size = new System.Drawing.Size(75, 23);
            this.btn_editUserOk.TabIndex = 4;
            this.btn_editUserOk.Text = "OK";
            this.btn_editUserOk.UseVisualStyleBackColor = true;
            this.btn_editUserOk.Click += new System.EventHandler(this.btn_editUserOk_Click);
            // 
            // btn_editUserCancel
            // 
            this.btn_editUserCancel.Location = new System.Drawing.Point(267, 101);
            this.btn_editUserCancel.Name = "btn_editUserCancel";
            this.btn_editUserCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_editUserCancel.TabIndex = 5;
            this.btn_editUserCancel.Text = "Cancel";
            this.btn_editUserCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserId";
            // 
            // txt_editUserId
            // 
            this.txt_editUserId.Location = new System.Drawing.Point(114, 20);
            this.txt_editUserId.Name = "txt_editUserId";
            this.txt_editUserId.Size = new System.Drawing.Size(42, 20);
            this.txt_editUserId.TabIndex = 7;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 136);
            this.Controls.Add(this.txt_editUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_editUserCancel);
            this.Controls.Add(this.btn_editUserOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_editEmail);
            this.Controls.Add(this.txt_editUsername);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_editUsername;
        private System.Windows.Forms.TextBox txt_editEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_editUserOk;
        private System.Windows.Forms.Button btn_editUserCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_editUserId;
    }
}