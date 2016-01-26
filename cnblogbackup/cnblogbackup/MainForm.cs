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
            PdfConvert.ConvertHtmlToPdf(new PdfDocument
            {
                Url = "http://www.cnblogs.com/SivilTaram",
                HeaderLeft = "[title]",
                HeaderRight = "[date] [time]",
                FooterCenter = "Page [page] of [topage]"

            }, new PdfOutput
            {
                OutputFilePath = "test.pdf"
            });
        }
    }
}
