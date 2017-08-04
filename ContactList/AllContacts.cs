using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ContactList
{
    public partial class AllContacts : Form
    {
        private XmlDocument xmlDoc;
        public string contactQqNumber;
        public AllContacts()
        {
            InitializeComponent();
        }

        private void mItemViewContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               this.contactQqNumber = this.listViewAllContactsInfo
                    .SelectedItems[0].SubItems[4].Text;
                ViewContactForm viewContact = new ViewContactForm(this.contactQqNumber);
                viewContact.Show();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mItemEditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.contactQqNumber = this.listViewAllContactsInfo.SelectedItems[0].SubItems[4].Text;
            EditContactForm editContact = new EditContactForm(this.contactQqNumber);
           // EditContactForm editContact = new EditContactForm();
            editContact.Show();
        }

        private void mItemDeleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否要删除联系人","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                XmlDocument doc = XMLOperation.GetDocument();
                string tempQqNumber = this.listViewAllContactsInfo.SelectedItems[0].SubItems[4].Text;
                string searchString = "/contacts/contact[contactQqNumber='"+tempQqNumber+"']";
                XmlNode node = doc.SelectSingleNode(searchString);
                node.ParentNode.RemoveChild(node);
                XMLOperation.SaveDocument(doc);
                this.listViewAllContactsInfo.Clear();
                this.Refresh();
            }
            else this.listViewAllContactsInfo.Focus();
        }

        private void mItemRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewAllContactsInfo.Clear();
            this.Refresh();
        }
        public override void Refresh()
        {
            this.listViewAllContactsInfo.Columns.Add("Name", "名字", 60);
            this.listViewAllContactsInfo.Columns.Add("Class", "班级", 62);
            this.listViewAllContactsInfo.Columns.Add("TeleNumber", "电话号码", 115);
            this.listViewAllContactsInfo.Columns.Add("MobileNumber", "手机号码",111);
            this.listViewAllContactsInfo.Columns.Add("QqNumber", "QQ号码", 85);
            this.listViewAllContactsInfo.Columns.Add("Email", "Email", 142);
            this.listViewAllContactsInfo.Columns.Add("Address","联系地址", 229);
            XmlDocument doc = XMLOperation.GetDocument();
            XmlNodeList nodeList = doc.SelectNodes("/contacts/contact");
            foreach (XmlNode node in nodeList)
            {
                XmlNodeList childNodeList = node.ChildNodes;
                ListViewItem lvItem = new ListViewItem(new string[]
                    {childNodeList[0].InnerText,childNodeList[4].InnerText,
                    childNodeList[6].InnerText,childNodeList[5].InnerText,
                    childNodeList[7].InnerText,childNodeList[8].InnerText,
                    childNodeList[9].InnerText});
                this.listViewAllContactsInfo.Items.Add(lvItem);
            }
            base.Refresh();

        }

        private void AllContacts_Load(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + "\\contacts.xml";
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(filename);
                lmInfo_Click(xmlDoc);
            }
            catch (System.IO.FileNotFoundException)
            {
                string mStr = "<contacts>"
                    //+ "<联系人 姓名 组别>"
                    //  //+ "<手机号码/>
                    //  //+ "<家庭号码/>
                    //+ "<联系人>"
                              + "</contacts>";
                xmlDoc.LoadXml(mStr);
                xmlDoc.Save(filename);
            }
        }
        private void lmInfo_Click(XmlDocument xmlDoc)
        {
            listViewAllContactsInfo.Clear();
            listViewAllContactsInfo.Columns.Add("姓名", 80, HorizontalAlignment.Left);
            listViewAllContactsInfo.Columns.Add("班级",80, HorizontalAlignment.Left);
            listViewAllContactsInfo.Columns.Add("电话号码", 100, HorizontalAlignment.Left);
            listViewAllContactsInfo.Columns.Add("手机号码", 100, HorizontalAlignment.Left);
            listViewAllContactsInfo.Columns.Add("QQ号码", 100, HorizontalAlignment.Left);
            listViewAllContactsInfo.Columns.Add("Email", 150, HorizontalAlignment.Left);
            listViewAllContactsInfo.Columns.Add("联系地址", 150, HorizontalAlignment.Left);
           
            XmlNodeList nodes = xmlDoc.SelectNodes("contacts/contact");
            foreach (XmlNode node in nodes)
            {
                XmlElement xe = (XmlElement)node;
                /*string userName = xe.ChildNodes[0].InnerText;
                string userClass = xe.ChildNodes[4].InnerText;
                string userPhoneNumber = xe.ChildNodes[6].InnerText;
                string userMobileNumber = xe.ChildNodes[5].InnerText;
                string userQqNumber = xe.ChildNodes[7].InnerText;
                string userEmail = xe.ChildNodes[8].InnerText;
                string userAddress = xe.ChildNodes[4].InnerText;*/
               /* ListViewItem str = new ListViewItem(new string[]{userName,
                 userClass,userPhoneNumber,userMobileNumber,userQqNumber,userEmail,userAddress});*/
                /*ListViewItem str = new ListViewItem(userName);
                str.SubItems.Add(userClass);
                str.SubItems.Add(userPhoneNumber);
                str.SubItems.Add(userMobileNumber);
                str.SubItems.Add(userQqNumber);
                str.SubItems.Add(userEmail);
                str.SubItems.Add(userAddress);*/           
              //  listViewAllContactsInfo.Items.Add(str);
               // XmlElement xe = (XmlElement)node;
                XmlNodeList childNodeList = xe.ChildNodes;
                ListViewItem lvItem = new ListViewItem(new string[]
                    {childNodeList[0].InnerText,childNodeList[4].InnerText,
                    childNodeList[6].InnerText,childNodeList[5].InnerText,
                    childNodeList[7].InnerText,childNodeList[8].InnerText,
                    childNodeList[9].InnerText});
                listViewAllContactsInfo.Items.Add(lvItem);
            }
        }
      
    }
}
