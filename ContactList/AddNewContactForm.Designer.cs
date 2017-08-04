namespace ContactList
{
    partial class AddNewContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewContactForm));
            this.SuspendLayout();
            // 
            // txtContactName
            // 
            this.txtContactName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtAcademyName
            // 
            this.txtAcademyName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtGrade
            // 
            this.txtGrade.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtClass
            // 
            this.txtClass.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtMobilePhoneNumber
            // 
            this.txtMobilePhoneNumber.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtQqNumber
            // 
            this.txtQqNumber.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtEmail
            // 
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            // 
            // richTxtBlessingWords
            // 
            this.richTxtBlessingWords.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.richTxtBlessingWords.Size = new System.Drawing.Size(232, 106);
            // 
            // btnExit
            // 
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // AddNewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(679, 378);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "AddNewContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加联系人信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
