namespace ContactList
{
    partial class ViewContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewContactForm));
            this.SuspendLayout();
            // 
            // txtContactName
            // 
            this.txtContactName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtContactName.ReadOnly = true;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSchoolName.ReadOnly = true;
            // 
            // txtAcademyName
            // 
            this.txtAcademyName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtAcademyName.ReadOnly = true;
            // 
            // txtGrade
            // 
            this.txtGrade.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtGrade.ReadOnly = true;
            // 
            // txtClass
            // 
            this.txtClass.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtClass.ReadOnly = true;
            // 
            // txtMobilePhoneNumber
            // 
            this.txtMobilePhoneNumber.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMobilePhoneNumber.ReadOnly = true;
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtTelephoneNumber.ReadOnly = true;
            // 
            // txtQqNumber
            // 
            this.txtQqNumber.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtQqNumber.ReadOnly = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtEmail.ReadOnly = true;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtHomeAddress.ReadOnly = true;
            // 
            // richTxtBlessingWords
            // 
            this.richTxtBlessingWords.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.richTxtBlessingWords.ReadOnly = true;
            this.richTxtBlessingWords.Size = new System.Drawing.Size(232, 106);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(388, 314);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Enabled = false;
            this.btnSaveContact.Location = new System.Drawing.Point(519, 314);
            this.btnSaveContact.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // ViewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(673, 354);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ViewContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看联系人信息";
            this.Load += new System.EventHandler(this.ViewContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
