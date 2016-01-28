namespace cnblogbackup
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CustomRadio = new MetroFramework.Controls.MetroRadioButton();
            this.GithubRadio = new MetroFramework.Controls.MetroRadioButton();
            this.CsdnRadio = new MetroFramework.Controls.MetroRadioButton();
            this.CnblogRadio = new MetroFramework.Controls.MetroRadioButton();
            this.NumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddedButton = new MetroFramework.Controls.MetroButton();
            this.CsvImportButton = new MetroFramework.Controls.MetroButton();
            this.HttpImportButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.用户名 = new MetroFramework.Controls.MetroLabel();
            this.PathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SetPathLink = new MetroFramework.Controls.MetroLink();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CommentImportButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.CustomRadio);
            this.metroPanel1.Controls.Add(this.GithubRadio);
            this.metroPanel1.Controls.Add(this.CsdnRadio);
            this.metroPanel1.Controls.Add(this.CnblogRadio);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(33, 33);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(157, 155);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // CustomRadio
            // 
            this.CustomRadio.AutoSize = true;
            this.CustomRadio.CustomBackground = false;
            this.CustomRadio.CustomForeColor = false;
            this.CustomRadio.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CustomRadio.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.CustomRadio.Location = new System.Drawing.Point(27, 123);
            this.CustomRadio.Name = "CustomRadio";
            this.CustomRadio.Size = new System.Drawing.Size(88, 15);
            this.CustomRadio.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomRadio.StyleManager = null;
            this.CustomRadio.TabIndex = 5;
            this.CustomRadio.TabStop = true;
            this.CustomRadio.Text = "自定义域名";
            this.CustomRadio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomRadio.UseStyleColors = false;
            this.CustomRadio.UseVisualStyleBackColor = true;
            // 
            // GithubRadio
            // 
            this.GithubRadio.AutoSize = true;
            this.GithubRadio.CustomBackground = false;
            this.GithubRadio.CustomForeColor = false;
            this.GithubRadio.FontSize = MetroFramework.MetroLinkSize.Small;
            this.GithubRadio.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.GithubRadio.Location = new System.Drawing.Point(27, 53);
            this.GithubRadio.Name = "GithubRadio";
            this.GithubRadio.Size = new System.Drawing.Size(85, 15);
            this.GithubRadio.Style = MetroFramework.MetroColorStyle.Blue;
            this.GithubRadio.StyleManager = null;
            this.GithubRadio.TabIndex = 4;
            this.GithubRadio.TabStop = true;
            this.GithubRadio.Text = "Github博客";
            this.GithubRadio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GithubRadio.UseStyleColors = false;
            this.GithubRadio.UseVisualStyleBackColor = true;
            // 
            // CsdnRadio
            // 
            this.CsdnRadio.AutoSize = true;
            this.CsdnRadio.CustomBackground = false;
            this.CsdnRadio.CustomForeColor = false;
            this.CsdnRadio.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CsdnRadio.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.CsdnRadio.Location = new System.Drawing.Point(27, 89);
            this.CsdnRadio.Name = "CsdnRadio";
            this.CsdnRadio.Size = new System.Drawing.Size(80, 15);
            this.CsdnRadio.Style = MetroFramework.MetroColorStyle.Blue;
            this.CsdnRadio.StyleManager = null;
            this.CsdnRadio.TabIndex = 3;
            this.CsdnRadio.TabStop = true;
            this.CsdnRadio.Text = "CSDN博客";
            this.CsdnRadio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CsdnRadio.UseStyleColors = false;
            this.CsdnRadio.UseVisualStyleBackColor = true;
            // 
            // CnblogRadio
            // 
            this.CnblogRadio.AutoSize = true;
            this.CnblogRadio.CustomBackground = false;
            this.CnblogRadio.CustomForeColor = false;
            this.CnblogRadio.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CnblogRadio.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.CnblogRadio.Location = new System.Drawing.Point(27, 19);
            this.CnblogRadio.Name = "CnblogRadio";
            this.CnblogRadio.Size = new System.Drawing.Size(62, 15);
            this.CnblogRadio.Style = MetroFramework.MetroColorStyle.Blue;
            this.CnblogRadio.StyleManager = null;
            this.CnblogRadio.TabIndex = 2;
            this.CnblogRadio.TabStop = true;
            this.CnblogRadio.Text = "博客园";
            this.CnblogRadio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CnblogRadio.UseStyleColors = false;
            this.CnblogRadio.UseVisualStyleBackColor = true;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.CustomBackground = false;
            this.NumberTextBox.CustomForeColor = false;
            this.NumberTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NumberTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.NumberTextBox.Location = new System.Drawing.Point(273, 52);
            this.NumberTextBox.Multiline = false;
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.SelectedText = "";
            this.NumberTextBox.Size = new System.Drawing.Size(218, 30);
            this.NumberTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.NumberTextBox.StyleManager = null;
            this.NumberTextBox.TabIndex = 1;
            this.NumberTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NumberTextBox.UseStyleColors = true;
            // 
            // UserTextBox
            // 
            this.UserTextBox.CustomBackground = false;
            this.UserTextBox.CustomForeColor = false;
            this.UserTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.UserTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.UserTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserTextBox.Location = new System.Drawing.Point(273, 94);
            this.UserTextBox.Multiline = false;
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.SelectedText = "";
            this.UserTextBox.Size = new System.Drawing.Size(218, 30);
            this.UserTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.UserTextBox.StyleManager = null;
            this.UserTextBox.TabIndex = 2;
            this.UserTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserTextBox.UseStyleColors = true;
            // 
            // AddedButton
            // 
            this.AddedButton.Highlight = true;
            this.AddedButton.Location = new System.Drawing.Point(324, 154);
            this.AddedButton.Name = "AddedButton";
            this.AddedButton.Size = new System.Drawing.Size(112, 34);
            this.AddedButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.AddedButton.StyleManager = null;
            this.AddedButton.TabIndex = 3;
            this.AddedButton.Text = "添加";
            this.AddedButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddedButton.Click += new System.EventHandler(this.AddedButton_Click);
            // 
            // CsvImportButton
            // 
            this.CsvImportButton.Highlight = false;
            this.CsvImportButton.Location = new System.Drawing.Point(73, 275);
            this.CsvImportButton.Name = "CsvImportButton";
            this.CsvImportButton.Size = new System.Drawing.Size(111, 40);
            this.CsvImportButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CsvImportButton.StyleManager = null;
            this.CsvImportButton.TabIndex = 4;
            this.CsvImportButton.Text = "CSV导入";
            this.CsvImportButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CsvImportButton.Click += new System.EventHandler(this.CsvImportButton_Click);
            // 
            // HttpImportButton
            // 
            this.HttpImportButton.Highlight = false;
            this.HttpImportButton.Location = new System.Drawing.Point(225, 275);
            this.HttpImportButton.Name = "HttpImportButton";
            this.HttpImportButton.Size = new System.Drawing.Size(112, 40);
            this.HttpImportButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HttpImportButton.StyleManager = null;
            this.HttpImportButton.TabIndex = 5;
            this.HttpImportButton.Text = "博客导入";
            this.HttpImportButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HttpImportButton.Click += new System.EventHandler(this.HttpImportButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.ForeColor = System.Drawing.Color.Coral;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(225, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "学号";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // 用户名
            // 
            this.用户名.AutoSize = true;
            this.用户名.CustomBackground = false;
            this.用户名.CustomForeColor = false;
            this.用户名.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.用户名.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.用户名.ForeColor = System.Drawing.Color.Black;
            this.用户名.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.用户名.Location = new System.Drawing.Point(213, 103);
            this.用户名.Name = "用户名";
            this.用户名.Size = new System.Drawing.Size(51, 19);
            this.用户名.Style = MetroFramework.MetroColorStyle.Blue;
            this.用户名.StyleManager = null;
            this.用户名.TabIndex = 7;
            this.用户名.Text = "博客名";
            this.用户名.Theme = MetroFramework.MetroThemeStyle.Light;
            this.用户名.UseStyleColors = false;
            // 
            // PathTextBox
            // 
            this.PathTextBox.CustomBackground = false;
            this.PathTextBox.CustomForeColor = true;
            this.PathTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PathTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PathTextBox.Location = new System.Drawing.Point(73, 220);
            this.PathTextBox.Multiline = false;
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.SelectedText = "";
            this.PathTextBox.Size = new System.Drawing.Size(308, 30);
            this.PathTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PathTextBox.StyleManager = null;
            this.PathTextBox.TabIndex = 8;
            this.PathTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PathTextBox.UseStyleColors = true;
            // 
            // SetPathLink
            // 
            this.SetPathLink.CustomBackground = false;
            this.SetPathLink.CustomForeColor = false;
            this.SetPathLink.FontSize = MetroFramework.MetroLinkSize.Small;
            this.SetPathLink.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.SetPathLink.Location = new System.Drawing.Point(387, 227);
            this.SetPathLink.Name = "SetPathLink";
            this.SetPathLink.Size = new System.Drawing.Size(122, 23);
            this.SetPathLink.Style = MetroFramework.MetroColorStyle.Teal;
            this.SetPathLink.StyleManager = null;
            this.SetPathLink.TabIndex = 9;
            this.SetPathLink.Text = "快速设置csv路径";
            this.SetPathLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SetPathLink.UseStyleColors = true;
            this.SetPathLink.Click += new System.EventHandler(this.SetPathLink_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // CommentImportButton
            // 
            this.CommentImportButton.Highlight = false;
            this.CommentImportButton.Location = new System.Drawing.Point(387, 275);
            this.CommentImportButton.Name = "CommentImportButton";
            this.CommentImportButton.Size = new System.Drawing.Size(112, 40);
            this.CommentImportButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CommentImportButton.StyleManager = null;
            this.CommentImportButton.TabIndex = 10;
            this.CommentImportButton.Text = "评论区导入";
            this.CommentImportButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CommentImportButton.Click += new System.EventHandler(this.CommentImportButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 338);
            this.Controls.Add(this.CommentImportButton);
            this.Controls.Add(this.SetPathLink);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.用户名);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.HttpImportButton);
            this.Controls.Add(this.CsvImportButton);
            this.Controls.Add(this.AddedButton);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AddForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "AddForm";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton CustomRadio;
        private MetroFramework.Controls.MetroRadioButton GithubRadio;
        private MetroFramework.Controls.MetroRadioButton CsdnRadio;
        private MetroFramework.Controls.MetroRadioButton CnblogRadio;
        private MetroFramework.Controls.MetroTextBox NumberTextBox;
        private MetroFramework.Controls.MetroTextBox UserTextBox;
        private MetroFramework.Controls.MetroButton AddedButton;
        private MetroFramework.Controls.MetroButton CsvImportButton;
        private MetroFramework.Controls.MetroButton HttpImportButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel 用户名;
        private MetroFramework.Controls.MetroTextBox PathTextBox;
        private MetroFramework.Controls.MetroLink SetPathLink;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroButton CommentImportButton;
    }
}