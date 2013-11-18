namespace WindowsFormsSchoolProject.Forms
{
    partial class DeleteUser
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
            this.btn_deleteUSer = new System.Windows.Forms.Button();
            this.txt_deleteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_deleteUSer
            // 
            this.btn_deleteUSer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_deleteUSer.Location = new System.Drawing.Point(166, 7);
            this.btn_deleteUSer.Name = "btn_deleteUSer";
            this.btn_deleteUSer.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteUSer.TabIndex = 0;
            this.btn_deleteUSer.Text = "Delete";
            this.btn_deleteUSer.UseVisualStyleBackColor = true;
            this.btn_deleteUSer.Click += new System.EventHandler(this.btn_deleteUSer_Click);
            // 
            // txt_deleteId
            // 
            this.txt_deleteId.Location = new System.Drawing.Point(60, 9);
            this.txt_deleteId.Name = "txt_deleteId";
            this.txt_deleteId.Size = new System.Drawing.Size(100, 20);
            this.txt_deleteId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Id";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 56);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_deleteId);
            this.Controls.Add(this.btn_deleteUSer);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deleteUSer;
        private System.Windows.Forms.TextBox txt_deleteId;
        private System.Windows.Forms.Label label1;
    }
}