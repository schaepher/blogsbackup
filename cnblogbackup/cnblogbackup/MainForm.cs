using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codaxy.WkHtmlToPdf;
using MetroFramework.Forms;
using System.IO;
using System.Reflection;
using System.Xml;

namespace cnblogbackup
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            XmlDocument xml_doc = new XmlDocument();
            try
            {
                xml_doc.Load("../../lib/Configure.xml");
                string root_path = ConfigureForm.ReadXmlToPath();
                Dictionary<string, XmlNode> blogs = ConfigureForm.ReadXmlToBlogNode(xml_doc);
                foreach (string user_number in blogs.Keys)
                {
                    XmlNode user = blogs[user_number];
                    string store_path = root_path + "/" + user_number;
                    if (!Directory.Exists(store_path))
                        Directory.CreateDirectory(store_path);
                    Dictionary<string, string> now_link = BlogsParser.UrlTitleDic(blogs[user_number].Attributes["home"].Value);
                    Dictionary<string, string> backup_link = ConfigureForm.ReadXmlToLink(blogs[user_number].Attributes["home"].Value);
                    foreach (string link_url in now_link.Keys)
                    {
                        // if the url has been backuped.
                        if (backup_link.ContainsKey(link_url))
                        {
                            // No backup
                        }
                        else
                        {
                            PdfConvert.ConvertHtmlToPdf(
                                new PdfDocument
                                {
                                    Url = link_url,
                                    HeaderLeft = link_url,
                                    HeaderRight = "[date] [time]",
                                    FooterCenter = "Page [page] of [topage]"

                                }, new PdfOutput
                                {
                                // [title] +".pdf"
                                OutputFilePath = store_path + "/" + now_link[link_url] + ".pdf"
                                });
                            //temp_task.Start();
                            user.AppendChild(GetLinkNode(xml_doc, now_link[link_url], link_url));
                        }

                    }
                }
                xml_doc.Save("../../lib/Configure.xml");
            }
            catch (System.IO.FileNotFoundException)
            {
                XmlNode node = xml_doc.CreateXmlDeclaration("1.0", "utf-8", "");
                xml_doc.AppendChild(node);
                XmlNode root_node = xml_doc.CreateElement("students");
                xml_doc.AppendChild(root_node);
                xml_doc.Save("../../lib/Configure.xml");
            }
        }

        private XmlNode GetLinkNode(XmlDocument root_node,string title,string url)
        {
            XmlNode temp = root_node.CreateElement("link");
            ((XmlElement)temp).SetAttribute("title", title);
            temp.InnerText = url;
            return temp;
        }

        private void ConfigureButton_Click(object sender, EventArgs e)
        {
            ConfigureForm config = new ConfigureForm();
            config.ShowDialog();
        }
    }
}
