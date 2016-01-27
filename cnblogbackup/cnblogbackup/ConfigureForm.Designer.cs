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
            this.LinkFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddedButton = new MetroFramework.Controls.MetroButton();
            this.HyperToggleButton = new MetroFramework.Controls.MetroToggle();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.LinkFlow.SuspendLayout();
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
            this.PathTextBox.Size = new System.Drawing.Size(365, 35);
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
            this.PathConfButton.Location = new System.Drawing.Point(529, 76);
            this.PathConfButton.Name = "PathConfButton";
            this.PathConfButton.Size = new System.Drawing.Size(115, 35);
            this.PathConfButton.Style = MetroFramework.MetroColorStyle.Red;
            this.PathConfButton.StyleManager = null;
            this.PathConfButton.TabIndex = 1;
            this.PathConfButton.Text = "配置存储路径";
            this.PathConfButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PathConfButton.Click += new System.EventHandler(this.PathConfButton_Click);
            // 
            // LinkFlow
            // 
            this.LinkFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkFlow.AutoScroll = true;
            this.LinkFlow.AutoSize = true;
            this.LinkFlow.Controls.Add(this.flowLayoutPanel1);
            this.LinkFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LinkFlow.Location = new System.Drawing.Point(64, 145);
            this.LinkFlow.MaximumSize = new System.Drawing.Size(365, 200);
            this.LinkFlow.Name = "LinkFlow";
            this.LinkFlow.Size = new System.Drawing.Size(365, 200);
            this.LinkFlow.TabIndex = 3;
            this.LinkFlow.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // AddedButton
            // 
            this.AddedButton.Highlight = true;
            this.AddedButton.Location = new System.Drawing.Point(529, 239);
            this.AddedButton.Name = "AddedButton";
            this.AddedButton.Size = new System.Drawing.Size(115, 37);
            this.AddedButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddedButton.StyleManager = null;
            this.AddedButton.TabIndex = 4;
            this.AddedButton.Text = "增加映射对";
            this.AddedButton.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // HyperToggleButton
            // 
            this.HyperToggleButton.AutoSize = true;
            this.HyperToggleButton.CustomBackground = false;
            this.HyperToggleButton.DisplayStatus = true;
            this.HyperToggleButton.FontSize = MetroFramework.MetroLinkSize.Small;
            this.HyperToggleButton.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.HyperToggleButton.Location = new System.Drawing.Point(183, 374);
            this.HyperToggleButton.Name = "HyperToggleButton";
            this.HyperToggleButton.Size = new System.Drawing.Size(80, 16);
            this.HyperToggleButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HyperToggleButton.StyleManager = null;
            this.HyperToggleButton.TabIndex = 5;
            this.HyperToggleButton.Text = "Off";
            this.HyperToggleButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HyperToggleButton.UseStyleColors = false;
            this.HyperToggleButton.UseVisualStyleBackColor = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.CustomBackground = false;
            this.metroTextBox1.CustomForeColor = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBox1.Location = new System.Drawing.Point(474, 201);
            this.metroTextBox1.Multiline = false;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(240, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.StyleManager = null;
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.UseStyleColors = false;
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 422);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.HyperToggleButton);
            this.Controls.Add(this.AddedButton);
            this.Controls.Add(this.LinkFlow);
            this.Controls.Add(this.PathConfButton);
            this.Controls.Add(this.PathTextBox);
            this.DisplayHeader = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ConfigureForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "ConfigureForm";
            this.LinkFlow.ResumeLayout(false);
            this.LinkFlow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox PathTextBox;
        private MetroFramework.Controls.MetroButton PathConfButton;
        private System.Windows.Forms.FolderBrowserDialog PathBroswerDialog;
        private System.Windows.Forms.FlowLayoutPanel LinkFlow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton AddedButton;
        private MetroFramework.Controls.MetroToggle HyperToggleButton;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}