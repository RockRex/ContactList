using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactList
{
    public partial class AddNewContactForm : ContactList.ContactForm
    {
        public AddNewContactForm()
        {
            InitializeComponent();
        }

        private void txtContactName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            if (XMLOperation.SaveContact(this) == 1)
            {
                MessageBox.Show("保存成功", "提示?", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
