namespace cnblogbackup
{
    partial class ConfigureForm
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
            this.PathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PathConfButton = new MetroFramework.Controls.MetroButton();
            this.PathBroswerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ChangeButton = new MetroFramework.Controls.MetroButton();
            this.BlogTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ToolTip = new MetroFramework.Components.MetroToolTip();
            this.RemoveButton = new MetroFramework.Controls.MetroButton();
            this.NumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.CustomBackground = false;
            this.PathTextBox.CustomForeColor = false;
            this.PathTextBox.Enabled = false;
            this.PathTextBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.PathTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.PathTextBox.Location = new System.Drawing.Point(64, 76);
            this.PathTextBox.Multiline = false;
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.SelectedText = "";
            this.PathTextBox.Size = new System.Drawing.Size(332, 35);
            this.PathTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PathTextBox.StyleManager = null;
            this.PathTextBox.TabIndex = 0;
            this.PathTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PathTextBox.UseStyleColors = false;
            // 
            // PathConfButton
            // 
            this.PathConfButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PathConfButton.Highlight = true;
            this.PathConfButton.Location = new System.Drawing.Point(450, 76);
            this.PathConfButton.Name = "PathConfButton";
            this.PathConfButton.Size = new System.Drawing.Size(134, 35);
            this.PathConfButton.Style = MetroFramework.MetroColorStyle.Red;
            this.PathConfButton.StyleManager = null;
            this.PathConfButton.TabIndex = 1;
            this.PathConfButton.Text = "配置存储路径";
            this.PathConfButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PathConfButton.Click += new System.EventHandler(this.PathConfButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Highlight = true;
            this.ChangeButton.Location = new System.Drawing.Point(305, 265);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(115, 37);
            this.ChangeButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChangeButton.StyleManager = null;
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "保存";
            this.ChangeButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // BlogTextBox
            // 
            this.BlogTextBox.CustomBackground = false;
            this.BlogTextBox.CustomForeColor = false;
            this.BlogTextBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.BlogTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.BlogTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BlogTextBox.Location = new System.Drawing.Point(321, 203);
            this.BlogTextBox.Multiline = false;
            this.BlogTextBox.Name = "BlogTextBox";
            this.BlogTextBox.SelectedText = "";
            this.BlogTextBox.Size = new System.Drawing.Size(263, 30);
            this.BlogTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.BlogTextBox.StyleManager = null;
            this.BlogTextBox.TabIndex = 6;
            this.BlogTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BlogTextBox.UseStyleColors = true;
            this.BlogTextBox.DoubleClick += new System.EventHandler(this.BlogTextBox_DoubleClick);
            // 
            // NamePanel
            // 
            this.NamePanel.AutoScroll = true;
            this.NamePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NamePanel.Location = new System.Drawing.Point(64, 145);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(167, 185);
            this.NamePanel.TabIndex = 7;
            // 
            // ToolTip
            // 
            this.ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip.StyleManager = null;
            this.ToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Highlight = true;
            this.RemoveButton.Location = new System.Drawing.Point(459, 265);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(115, 37);
            this.RemoveButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RemoveButton.StyleManager = null;
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "删除";
            this.RemoveButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.CustomBackground = false;
            this.NumberTextBox.CustomForeColor = false;
            this.NumberTextBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.NumberTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.NumberTextBox.Location = new System.Drawing.Point(321, 161);
            this.NumberTextBox.Multiline = false;
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.SelectedText = "";
            this.NumberTextBox.Size = new System.Drawing.Size(263, 30);
            this.NumberTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.NumberTextBox.StyleManager = null;
            this.NumberTextBox.TabIndex = 9;
            this.NumberTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NumberTextBox.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(269, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "学号";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(250, 214);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "博客主页";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // AddButton
            // 
            this.AddButton.Highlight = true;
            this.AddButton.Location = new System.Drawing.Point(379, 327);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(115, 37);
            this.AddButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddButton.StyleManager = null;
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "添加";
            this.AddButton.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 422);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.BlogTextBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.PathConfButton);
            this.Controls.Add(this.PathTextBox);
            this.DisplayHeader = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ConfigureForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "ConfigureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox PathTextBox;
        private MetroFramework.Controls.MetroButton PathConfButton;
        private System.Windows.Forms.FolderBrowserDialog PathBroswerDialog;
        private MetroFramework.Controls.MetroButton ChangeButton;
        private MetroFramework.Controls.MetroTextBox BlogTextBox;
        private System.Windows.Forms.FlowLayoutPanel NamePanel;
        private MetroFramework.Components.MetroToolTip ToolTip;
        private MetroFramework.Controls.MetroButton RemoveButton;
        private MetroFramework.Controls.MetroTextBox NumberTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton AddButton;
    }
}