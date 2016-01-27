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
    public partial class ConfigureForm : MetroForm
    {
        private Dictionary<string, string> blogs_dict;
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
            foreach(string key in blogs_dict.Keys)
            {
                MetroLabel name_label = new MetroLabel();
                MetroLink link_label = new MetroLink();
                name_label.Text = key;
                link_label.Text = blogs_dict[key];
                link_label.AutoSize = true;
                name_label.AutoSize = true;
                name_label.TextAlign = ContentAlignment.MiddleCenter;
                link_label.TextAlign = ContentAlignment.MiddleCenter;
                link_label.UseStyleColors = true;
                link_label.Click += Link_label_Click;
                LinkFlow.Controls.Add(name_label);
                LinkFlow.Controls.Add(link_label);
            }
        }

        private void Link_label_Click(object sender, EventArgs e)
        {
            MetroLink temp = (MetroLink)sender;
            System.Diagnostics.Process.Start(temp.Text);
        }
    }
    class post
    {
        public string title { get; set; }
        public string link { get; set; }
    }
}
