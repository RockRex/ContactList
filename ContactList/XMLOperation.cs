using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Windows.Forms;
using System.IO;

namespace ContactList
{
    class XMLOperation
    {
        public static string xmlPath = Application.StartupPath + @"\contacts.xml";
        public static string settingPath = Application.StartupPath + @"\setting.con";
        private static string xmlText;
        public static XmlDocument GetDocument()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            return xmlDoc;
        }
        public static void SaveDocument(XmlDocument doc)
        {
            doc.Save(xmlPath);
        }
        public static XPathNavigator GetNavigator()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XPathNavigator navigator = xmlDoc.CreateNavigator();
            return navigator;
        }
        public static int SaveContact(ContactForm contactForm)
        {
            XmlDocument doc = XMLOperation.GetDocument();
            XPathNavigator navigator = doc.CreateNavigator();
            XmlNode root = doc.SelectSingleNode("contacts");
            XmlElement contactElement;
            XmlElement childElement;
            string searchExpression = "/contacts/contact[contactName='"
                + contactForm.txtContactName.Text + "']";
            try
            {
                if (navigator.SelectSingleNode(searchExpression) == null)
                {
                    contactElement = doc.CreateElement("contact");
                    childElement = doc.CreateElement("contactName");
                    childElement.InnerText = contactForm.txtContactName.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactSchoolName");
                    childElement.InnerText = contactForm.txtSchoolName.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactAcademyName");
                    childElement.InnerText = contactForm.txtAcademyName.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactGrade");
                    childElement.InnerText = contactForm.txtGrade.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactClass");
                    childElement.InnerText = contactForm.txtClass.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactMobileNumber");
                    childElement.InnerText = contactForm.txtMobilePhoneNumber.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactTelephoneNumber");
                    childElement.InnerText = contactForm.txtTelephoneNumber.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactQqNumber");
                    childElement.InnerText = contactForm.txtQqNumber.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactEmail");
                    childElement.InnerText = contactForm.txtEmail.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactAddress");
                    childElement.InnerText = contactForm.txtHomeAddress.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                    childElement = doc.CreateElement("contactBlessingWords");
                    childElement.InnerText = contactForm.richTxtBlessingWords.Text;
                    contactElement.AppendChild((XmlNode)childElement);
                  //  if (contactForm.strPicturePath != null)
                    {
                       // FileStream stream = new FileStream(contactForm.strPicturePath,
                       //     FileMode.Open, FileAccess.Read);
                       /* long picLength = stream.Length;
                        byte[] buffer = new byte[(int)picLength];
                        stream.Read(buffer, 0, (int)picLength);
                        childElement = doc.CreateElement("contactImage");
                        childElement.InnerText = Convert.ToBase64String(buffer);
                        contactElement.AppendChild((XmlNode)childElement);*/
                    }
                    root.AppendChild((XmlNode)contactElement);
                    XMLOperation.SaveDocument(doc);
                    return 1;
                }
                else throw new Exception();
            }
            catch (System.Exception e)
            {
                MessageBox.Show("联系人已存在!" + e.ToString());
                return 0;

            }
        }

    }
}
