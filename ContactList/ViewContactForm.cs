using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ContactList
{
    public partial class ViewContactForm : ContactList.ContactForm
        
    {
        public static bool IfOk = false;
        public string QqNumber;
        public ViewContactForm(string QqNumberPassIn)
        {
            InitializeComponent();
            QqNumber = QqNumberPassIn;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            IfOk = false;
            this.Close();
        }

        private void ViewContactForm_Load(object sender, EventArgs e)
        {
            XmlDocument doc = XMLOperation.GetDocument();
            XmlNode node = doc.SelectSingleNode("/contacts/contact[contactQqNumber=" + QqNumber + "]");
            XmlNodeList nodeList = node.ChildNodes;
            this.txtAcademyName.Text = nodeList[2].InnerText;
            this.txtClass.Text = nodeList[4].InnerText;
            this.txtContactName.Text = nodeList[0].InnerText;
            this.txtEmail.Text = nodeList[8].InnerText;
            this.txtGrade.Text = nodeList[3].InnerText;
            this.txtHomeAddress.Text = nodeList[9].InnerText;
            this.txtMobilePhoneNumber.Text = nodeList[5].InnerText;
            this.txtQqNumber.Text = nodeList[7].InnerText;
            this.txtSchoolName.Text = nodeList[1].InnerText;
            this.txtTelephoneNumber.Text = nodeList[6].InnerText;
            this.richTxtBlessingWords.Text = nodeList[10].InnerText;
        }

              
    }
}
