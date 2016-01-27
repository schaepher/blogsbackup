namespace cnblogbackup
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            MetroFramework.Controls.MetroButton ConfigureButton;
            this.StartButton = new MetroFramework.Controls.MetroButton();
            ConfigureButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Highlight = false;
            this.StartButton.Location = new System.Drawing.Point(178, 102);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(230, 87);
            this.StartButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StartButton.StyleManager = null;
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "开始备份";
            this.StartButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ConfigureButton
            // 
            ConfigureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            ConfigureButton.Highlight = false;
            ConfigureButton.Location = new System.Drawing.Point(178, 231);
            ConfigureButton.Name = "ConfigureButton";
            ConfigureButton.Size = new System.Drawing.Size(230, 87);
            ConfigureButton.Style = MetroFramework.MetroColorStyle.Blue;
            ConfigureButton.StyleManager = null;
            ConfigureButton.TabIndex = 1;
            ConfigureButton.Text = "配置";
            ConfigureButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            ConfigureButton.Click += new System.EventHandler(this.ConfigureButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 376);
            this.Controls.Add(ConfigureButton);
            this.Controls.Add(this.StartButton);
            this.DisplayHeader = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton StartButton;
    }
}

