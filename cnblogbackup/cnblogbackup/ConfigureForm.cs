using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Xml;
using System.Reflection;
using MetroFramework.Controls;

namespace cnblogbackup
{
    partial class ConfigureForm : MetroForm
    {
        private Dictionary<string, string> blogs_dict;
        private MetroLink last_click = null;
        public delegate void UpdatePanel(List<blog> list);
        public UpdatePanel my_delegate;
        public ConfigureForm()
        {
            InitializeComponent();
            InitialPanel();
            my_delegate = new UpdatePanel(UpdataPanelMethod);
        }

        public void UpdataPanelMethod(List<blog> _list)
        {
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load("../../lib/Configure.xml");
            XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
            Dictionary<string, string> temp_queue = new Dictionary<string, string>();
            bool is_repeated = false;
            foreach (blog temp in _list)
            {
                if (!blogs_dict.ContainsKey(temp.number))
                {
                    blogs_dict.Add(temp.number, temp.homepage);
                    NamePanel.Controls.Add(GetLink(temp.number));
                    XmlElement blog_home = xml_doc.CreateElement("cnblogs");
                    blog_home.SetAttribute("number", temp.number);
                    blog_home.SetAttribute("home", temp.homepage);
                    root_node.AppendChild(blog_home);
                }
                else
                {
                    temp_queue.Add(temp.number, temp.homepage);
                    is_repeated = true;
                }
            }
            if (is_repeated && MessageBox.Show("检测到有重复学号录入，是否要覆盖？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (string new_key in temp_queue.Keys)
                {
                    blogs_dict[new_key] = temp_queue[new_key];
                }
            }
            xml_doc.Save("../../lib/Configure.xml");
        }

        private void PathConfButton_Click(object sender, EventArgs e)
        {
            // if success then display the root file path.
            if (PathBroswerDialog.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = PathBroswerDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Read xml from "../../lib/Configure.xml" 
        /// A standard xml look like this:
        /// <students>
        ///     <cnblogs number="123456" home="http://cnblogs.com/SivilTaram">
        ///        <link title="我对软工有话说[上]">
        ///             http://www.cnblogs.com/SivilTaram/p/advice_for_software.html
        ///        </link>
        ///     </cnblogs> 
        /// </students>
        /// </summary>
        private void InitialPanel()
        {
            XmlDocument xml_doc = new XmlDocument();
            try
            {
                xml_doc.Load("../../lib/Configure.xml");
                //if load success
            }
            catch (System.IO.FileNotFoundException)
            {
                //create a xml file
                XmlNode node = xml_doc.CreateXmlDeclaration("1.0", "utf-8", "");
                xml_doc.AppendChild(node);
                XmlNode root_node = xml_doc.CreateElement("students");
                xml_doc.AppendChild(root_node);
                xml_doc.Save("../../lib/Configure.xml");
            }
            finally
            {
                XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
                string path;
                if ((path = ((XmlElement)root_node).GetAttribute("path")) != null)
                {
                    PathTextBox.Text = path;
                }
                blogs_dict = ReadXmlToBlogString();
                foreach (string key in blogs_dict.Keys)
                {
                    MetroLink name_label = GetLink(key);
                    NamePanel.Controls.Add(name_label);
                    ToolTip.SetToolTip(name_label, blogs_dict[key]);
                }
            }
        }

        public static Dictionary<string,XmlNode> ReadXmlToBlogNode(XmlDocument xml_doc)
        {
            Dictionary<string,XmlNode> dict = new Dictionary<string,XmlNode>();
            XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
            foreach (XmlNode single_blog in root_node.ChildNodes)
            {
                //<cnblogs number="123456" home="http://cnblogs.com/SivilTaram">
                string blog_owner = single_blog.Attributes["number"].Value;
                XmlNode blog_node = single_blog;
                dict.Add(blog_owner, blog_node);
            }
            return dict;
        }

        public static Dictionary<string,string> ReadXmlToBlogString()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load("../../lib/Configure.xml");
            XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
            foreach (XmlNode single_blog in root_node.ChildNodes)
            {
                //<cnblogs number="123456" home="http://cnblogs.com/SivilTaram">
                string blog_owner = single_blog.Attributes["number"].Value;
                string blog_home = single_blog.Attributes["home"].Value;
                dict.Add(blog_owner, blog_home);
            }
            return dict;
        }

        public static Dictionary<string,string> ReadXmlToLink(string home_page)
        {
            Dictionary<string, string> url_title_dict = new Dictionary<string, string>();
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load("../../lib/Configure.xml");
            XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
            foreach (XmlNode single_blog in root_node.ChildNodes)
            {
                if( home_page == single_blog.Attributes["home"].Value)
                {
                    foreach(XmlNode single_link in single_blog.ChildNodes)
                    {
                        string title = ((XmlElement)single_link).Attributes["title"].Value;
                        string url = ((XmlElement)single_link).InnerText;
                        url_title_dict.Add(url, title);
                    }
                    return url_title_dict;
                }
            }
            // if count = 0;
            return url_title_dict;
        }

        public static string ReadXmlToPath()
        {
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load("../../lib/Configure.xml");
            XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
            string path;
            if ((path = ((XmlElement)root_node).GetAttribute("path")) != null)
            {
                return path;
            }
            else
            {
                return "";
            }
        }

        private MetroLink GetLink(string text)
        {
            MetroLink name_label = new MetroLink();
            name_label.Text = text;
            name_label.Width = 100;
            name_label.TextAlign = ContentAlignment.MiddleLeft;
            name_label.UseStyleColors = true;
            name_label.Click += Link_label_Click;
            name_label.FontSize = MetroFramework.MetroLinkSize.Medium;
            return name_label;
        }

        private void Link_label_Click(object sender, EventArgs e)
        {
            MetroLink temp = (MetroLink)sender;
            NumberTextBox.Text = temp.Text;
            BlogTextBox.Text = blogs_dict[temp.Text];
            last_click = temp;
            //System.Diagnostics.Process.Start(blogs_dict[temp.Text]);
        }


        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (last_click == null)
            {
                MessageBox.Show("未选中任何学生！");
                return;
            }
            XmlDocument xml_doc = new XmlDocument();
            try
            {
                xml_doc.Load("../../lib/Configure.xml");
                //if load success
                XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
                foreach (XmlNode single_blog in root_node.ChildNodes)
                {
                    //<cnblogs number="123456" home="http://cnblogs.com/SivilTaram">
                    string blog_owner = single_blog.Attributes["number"].Value;
                    if(blog_owner == last_click.Text)
                    {
                        ((XmlElement)single_blog).SetAttribute("number",NumberTextBox.Text);
                        ((XmlElement)single_blog).SetAttribute("home",BlogTextBox.Text);
                        blogs_dict.Remove(last_click.Text);
                        blogs_dict.Add(NumberTextBox.Text, BlogTextBox.Text);
                    }
                }
                xml_doc.Save("../../lib/Configure.xml");
                last_click.Text = NumberTextBox.Text;
                ToolTip.SetToolTip(last_click, BlogTextBox.Text);
            }
            catch(System.Xml.XmlException)
            {

            }
         }

        private void BlogTextBox_DoubleClick(object sender, EventArgs e)
        {
            MetroTextBox temp = (MetroTextBox)sender;
            System.Diagnostics.Process.Start(temp.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (last_click == null)
            {
                MessageBox.Show("未选中任何一名学生！");
                return;
            }
            XmlDocument xml_doc = new XmlDocument();
            try
            {
                xml_doc.Load("../../lib/Configure.xml");
                //if load success
                XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
                foreach (XmlNode single_blog in root_node.ChildNodes)
                {
                    //<cnblogs number="123456" home="http://cnblogs.com/SivilTaram">
                    string blog_owner = single_blog.Attributes["number"].Value;
                    if (blog_owner == last_click.Text)
                    {
                        root_node.RemoveChild(single_blog);
                        blogs_dict.Remove(last_click.Text);
                        break;
                    }
                }
                xml_doc.Save("../../lib/Configure.xml");
                NamePanel.Controls.Remove(last_click);
                NumberTextBox.Text = "";
                BlogTextBox.Text = "";
            }
            catch (System.Xml.XmlException)
            {

            }
        }

        private void NamePanel_MouseEnter(object sender, EventArgs e)
        {
            NamePanel.Focus();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm add_form = new AddForm(this);
            add_form.ShowDialog();
        }

        private void SaveConfButton_Click(object sender, EventArgs e)
        {
            string path = PathTextBox.Text;
            if (!Directory.Exists(path))
            {
                MessageBox.Show("请输入正确的存储路径！");
            }
            else
            {
                XmlDocument xml_doc = new XmlDocument();
                xml_doc.Load("../../lib/Configure.xml");
                XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
                ((XmlElement)root_node).SetAttribute("path", path);
                xml_doc.Save("../../lib/Configure.xml");
                this.Close();
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            blogs_dict.Clear();
            NamePanel.Controls.Clear();
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load("../../lib/Configure.xml");
            XmlNode root_node = xml_doc.DocumentElement.SelectSingleNode("/students");
            root_node.RemoveAll();
            xml_doc.Save("../../lib/Configure.xml");
            NumberTextBox.Text = "";
            BlogTextBox.Text = "";
        }
    }
    class blog
    {
        public string number { get; set; }
        public string homepage { get; set; }
    }

}
