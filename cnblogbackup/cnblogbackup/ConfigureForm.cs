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
using DevComponents.DotNetBar;

namespace cnblogbackup
{
    public partial class ConfigureForm : MetroForm
    {
        private Dictionary<string, string> blogs_dict;
        private MetroLink last_click = null;
        public ConfigureForm()
        {
            InitializeComponent();
            //blogs_dict= new Dictionary<string, List<post>>();
            blogs_dict = new Dictionary<string, string>();
            ReadXml();
            FillDisplayFlow();
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
        private void ReadXml()
        {
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
                    string blog_home = single_blog.Attributes["home"].Value;
                    blogs_dict.Add(blog_owner, blog_home);
                    //List<post> blog_link = new List<post>();
                    //foreach(XmlNode single_link in single_blog.ChildNodes)
                    //{
                    //    blog_link.Add(new post
                    //    {
                    //        title = single_link.Attributes["title"].Value,
                    //        link  = single_link.InnerText
                    //    });
                    //}
                    //blogs_dict.Add(blog_owner, blog_link);
                }
            }
            catch (System.Xml.XmlException)
            {

            }
        }

        private void FillDisplayFlow()
        {
            int y = 0;
            foreach (string key in blogs_dict.Keys)
            {
                MetroLink name_label = GetLink(key);
                NamePanel.Controls.Add(name_label);
                ToolTip.SetToolTip(name_label, blogs_dict[key]);
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
    }
    class post
    {
        public string title { get; set; }
        public string link { get; set; }
    }

}
