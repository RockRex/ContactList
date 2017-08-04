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
    public partial class FindingContacts : Form
    {
        public FindingContacts()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchMobile = "/contacts/contact[contains(contactMobileNumber,'" + this.txtSearchInfo.Text.Trim() + "')]";
            string searchName = "/contacts/contact[contains(contactName,'" + this.txtSearchInfo.Text.Trim() + "')]";
            string searchQQ = "/contacts/contact[contains(contactQqNumber,'" + this.txtSearchInfo.Text.Trim() + "')]";
            XmlDocument doc = XMLOperation.GetDocument();
            if (this.radioButtonMobilephoneNumber.Checked == true)
            {
                if(this.txtSearchInfo.Text.IndexOf(' ',0)==-1)
                {
                    XmlNode node = doc.SelectSingleNode(searchMobile);
                    ResultsFound result = new ResultsFound(node);
                    result.Show();
                }
                else
                {
                    string tempCommonMatchName = this.txtSearchInfo.Text
                        .Replace(" ","").Trim();
                    searchMobile = "/contacts/contact[contains(contactMobileNumber,'"+ tempCommonMatchName +"')]";
                    XmlNode node = doc.SelectSingleNode(searchMobile);
                    ResultsFound result = new ResultsFound(node);
                    result.Show();
                }

            }
            else if(this.radioButtonName.Checked == true)
            {
                if(this.txtSearchInfo.Text.IndexOf(' ',0)==-1)
                {
                     XmlNode node = doc.SelectSingleNode(searchName);
                    ResultsFound result = new ResultsFound(node);
                    result.Show();
                }
                else
                {
                    string tempCommonMatchName = this.txtSearchInfo.Text
                        .Replace(" ","").Trim();
                    searchName = "/contacts/contact[contains(contactName,'"+tempCommonMatchName+"')]";
                     XmlNode node = doc.SelectSingleNode(searchName);
                    ResultsFound result = new ResultsFound(node);
                    result.Show();
                }

            }
            else if (this.radioButtonQqNumber.Checked == true)
            {
                if (this.txtSearchInfo.Text.IndexOf(' ', 0) == -1)
                {
                    XmlNode node = doc.SelectSingleNode(searchQQ);
                    ResultsFound result = new ResultsFound(node);
                    result.Show();
                }
                else
                {
                    string tempCommonMatchName = this.txtSearchInfo.Text.Replace(" ", "").Trim();
                    searchQQ = "/contacts/contact[contains(contactQqNumber,'" + tempCommonMatchName + "')]";
                    XmlNode node = doc.SelectSingleNode(searchQQ);
                    ResultsFound result = new ResultsFound(node);
                    result.Show();
                }
            }
            else MessageBox.Show("请选择一个搜索匹配条件再进行查找","提示");
                                 
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
