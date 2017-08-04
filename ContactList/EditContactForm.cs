using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace ContactList
{
    public partial class EditContactForm: ContactList.ContactForm
    {
        public string QqNumber;
        public EditContactForm(string QqNumberPassIn)
        {
            InitializeComponent();
            QqNumber = QqNumberPassIn;
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            XmlDocument doc = XMLOperation.GetDocument();
            //string tempQqNumber = this.txtQqNumber.Text.Trim();
           // string searchString = "/contacts/contact[@contactQqNumber='" + tempQqNumber + "']";
            XmlNode node = doc.SelectSingleNode("/contacts/contact[contactQqNumber=" + QqNumber + "]");
            XmlNodeList nodeList = node.ChildNodes;
            nodeList[2].InnerText = this.txtAcademyName.Text;
            nodeList[4].InnerText = this.txtClass.Text;
            nodeList[0].InnerText = this.txtContactName.Text;
            nodeList[8].InnerText = this.txtEmail.Text;
            nodeList[3].InnerText = this.txtGrade.Text;
            nodeList[9].InnerText = this.txtHomeAddress.Text;
            nodeList[5].InnerText = this.txtMobilePhoneNumber.Text;
            nodeList[7].InnerText = this.txtQqNumber.Text;
            nodeList[1].InnerText = this.txtSchoolName.Text;
            nodeList[6].InnerText = this.txtTelephoneNumber.Text;
            nodeList[10].InnerText = this.richTxtBlessingWords.Text;
           // if (strPicturePath!= null)
            {
             //   FileStream stream = new FileStream(strPicturePath, FileMode.Open, FileAccess.Read); 
              /*  long picLength = stream.Length;
                byte[] buffer = new byte[(int)picLength];
                stream.Read(buffer, 0, (int)picLength);
                nodeList[11].InnerText = Convert.ToBase64String(buffer);*/
            }
            XMLOperation.SaveDocument(doc);
            MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
