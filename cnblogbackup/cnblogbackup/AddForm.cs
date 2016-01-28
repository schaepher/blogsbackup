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
            List<Numhome> result = new List<Numhome>();
            foreach (string line in allLines)
            {
                string[] data = line.Split(',');
                result.Add(new Numhome
                {
                    number = data[0],
                    home = data[1]
                });
            }
            main_form_control.Invoke(main_form_control.my_delegate,result);
        }
    }
}
