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
using System.Data.Odbc;
using System.IO;

namespace cnblogbackup
{
    partial class AddForm : MetroForm
    {
        private ConfigureForm main_form_control;
        public AddForm(ConfigureForm _main_form)
        {
            InitializeComponent();
            main_form_control = _main_form;
        }

        private void SetPathLink_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void CsvImportButton_Click(object sender, EventArgs e)
        {
            string csv_path = PathTextBox.Text;
            if (!File.Exists(csv_path))
            {
                MessageBox.Show("请输入正确的csv路径!");
                return;
            }
            string[] allLines = File.ReadAllLines(csv_path);
            List<blog> result = new List<blog>();
            foreach (string line in allLines)
            {
                string[] data = line.Split(',');
                result.Add(new blog
                {
                    number = data[0],
                    homepage = data[1]
                });
            }
            main_form_control.Invoke(main_form_control.my_delegate,result);
        }

        private void AddedButton_Click(object sender, EventArgs e)
        {
            string Prefix = "";
            // number and blogname
            string Number = NumberTextBox.Text;
            string Blog = UserTextBox.Text;
            if (CnblogRadio.Checked == true)
            {
                Prefix = "http://www.cnblogs.com/" + Blog;
            }
            else if (GithubRadio.Checked == true)
            {
                Prefix = "http://" + Blog + ".github.io/";
            }
            else if(CsdnRadio.Checked == true)
            {
                Prefix = "http://blog.csdn.net/" + Blog;
            }
            else if(CustomRadio.Checked == true)
            {
                Prefix = Blog;
            }
            main_form_control.Invoke(main_form_control.my_delegate, new object[] {
            new List<blog>(){
                new blog {
                    number = Number,
                    homepage = Prefix
                    }
            } });
            NumberTextBox.Text = "";
            UserTextBox.Text = "";
        }

        private void HttpImportButton_Click(object sender, EventArgs e)
        {
            string post_url = PathTextBox.Text;
            Dictionary<string,string> num_home = BlogsParser.NumberHomepageDic(post_url, Options.FromBlogContent);
            List<blog> result = new List<blog>(num_home.Count);
            foreach (string key in num_home.Keys)
            {
                result.Add(new blog
                {
                    number = key,
                    homepage = num_home[key]
                });
            }
            main_form_control.Invoke(main_form_control.my_delegate,result);
        }
    }
}
