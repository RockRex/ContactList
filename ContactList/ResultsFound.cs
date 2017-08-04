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
    public partial class ResultsFound : Form
    {
        public XmlNode node;
        public ResultsFound(XmlNode nodePassIn)
        {
            InitializeComponent();
            node = nodePassIn;
            listViewContactsFound.Columns.Add("姓名", 80, HorizontalAlignment.Left);
            listViewContactsFound.Columns.Add("班级", 80, HorizontalAlignment.Left);
            listViewContactsFound.Columns.Add("电话号码", 100, HorizontalAlignment.Left);
            listViewContactsFound.Columns.Add("手机号码", 100, HorizontalAlignment.Left);
            listViewContactsFound.Columns.Add("QQ号码", 100, HorizontalAlignment.Left);
            listViewContactsFound.Columns.Add("Email", 150, HorizontalAlignment.Left);
            listViewContactsFound.Columns.Add("联系地址", 150, HorizontalAlignment.Left);
        }

        private void ResultsFound_Load(object sender, EventArgs e)
        {
            XmlElement xe = (XmlElement)node;
            XmlNodeList childNodeList = xe.ChildNodes;
            ListViewItem lvItem = new ListViewItem(new string[]
                    {childNodeList[0].InnerText,childNodeList[4].InnerText,
                    childNodeList[6].InnerText,childNodeList[5].InnerText,
                    childNodeList[7].InnerText,childNodeList[8].InnerText,
                    childNodeList[9].InnerText});
            listViewContactsFound.Items.Add(lvItem);
        }

           

    }
}
