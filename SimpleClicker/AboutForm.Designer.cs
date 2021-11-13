namespace SimpleClicker
{
    partial class AboutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.versionText = new System.Windows.Forms.Label();
            this.aboutTabControl = new MetroFramework.Controls.MetroTabControl();
            this.infoTab = new MetroFramework.Controls.MetroTabPage();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.attributionsTab = new MetroFramework.Controls.MetroTabPage();
            this.aboutTextBox = new System.Windows.Forms.RichTextBox();
            this.licenseTab = new MetroFramework.Controls.MetroTabPage();
            this.licenseTextBox = new System.Windows.Forms.RichTextBox();
            this.systemInfoTab = new MetroFramework.Controls.MetroTabPage();
            this.systemInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.aboutTabControl.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.attributionsTab.SuspendLayout();
            this.licenseTab.SuspendLayout();
            this.systemInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.label1, true);
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(121, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Simple Clicker";
            // 
            // versionText
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.versionText, true);
            this.versionText.AutoSize = true;
            this.versionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.versionText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.versionText.Location = new System.Drawing.Point(426, 81);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(85, 23);
            this.versionText.TabIndex = 13;
            this.versionText.Text = "ver. x.x.x.x";
            // 
            // aboutTabControl
            // 
            this.aboutTabControl.Controls.Add(this.infoTab);
            this.aboutTabControl.Controls.Add(this.attributionsTab);
            this.aboutTabControl.Controls.Add(this.licenseTab);
            this.aboutTabControl.Controls.Add(this.systemInfoTab);
            this.aboutTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.aboutTabControl.Location = new System.Drawing.Point(257, 104);
            this.aboutTabControl.Name = "aboutTabControl";
            this.aboutTabControl.SelectedIndex = 0;
            this.aboutTabControl.Size = new System.Drawing.Size(361, 232);
            this.aboutTabControl.TabIndex = 14;
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.infoTextBox);
            this.infoTab.HorizontalScrollbarBarColor = true;
            this.infoTab.Location = new System.Drawing.Point(4, 39);
            this.infoTab.Name = "infoTab";
            this.infoTab.Size = new System.Drawing.Size(353, 189);
            this.infoTab.TabIndex = 0;
            this.infoTab.Text = "Infos";
            this.infoTab.VerticalScrollbarBarColor = true;
            // 
            // infoTextBox
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.infoTextBox, true);
            this.infoTextBox.AutoWordSelection = true;
            this.infoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.infoTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.infoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoTextBox.Location = new System.Drawing.Point(0, 7);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(353, 171);
            this.infoTextBox.TabIndex = 13;
            this.infoTextBox.Text = resources.GetString("infoTextBox.Text");
            this.infoTextBox.Enter += new System.EventHandler(this.UnfocusComponents_Enter);
            // 
            // attributionsTab
            // 
            this.attributionsTab.Controls.Add(this.aboutTextBox);
            this.attributionsTab.HorizontalScrollbarBarColor = true;
            this.attributionsTab.Location = new System.Drawing.Point(4, 39);
            this.attributionsTab.Name = "attributionsTab";
            this.attributionsTab.Size = new System.Drawing.Size(353, 170);
            this.attributionsTab.TabIndex = 3;
            this.attributionsTab.Text = "Attributions";
            this.attributionsTab.VerticalScrollbarBarColor = true;
            // 
            // aboutTextBox
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.aboutTextBox, true);
            this.aboutTextBox.AutoWordSelection = true;
            this.aboutTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.aboutTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutTextBox.Location = new System.Drawing.Point(2, 7);
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(351, 165);
            this.aboutTextBox.TabIndex = 15;
            this.aboutTextBox.Text = resources.GetString("aboutTextBox.Text");
            this.aboutTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.aboutTextBox_LinkClicked);
            this.aboutTextBox.Enter += new System.EventHandler(this.UnfocusComponents_Enter);
            // 
            // licenseTab
            // 
            this.licenseTab.Controls.Add(this.licenseTextBox);
            this.licenseTab.HorizontalScrollbarBarColor = true;
            this.licenseTab.Location = new System.Drawing.Point(4, 39);
            this.licenseTab.Name = "licenseTab";
            this.licenseTab.Size = new System.Drawing.Size(353, 170);
            this.licenseTab.TabIndex = 2;
            this.licenseTab.Text = "License";
            this.licenseTab.VerticalScrollbarBarColor = true;
            // 
            // licenseTextBox
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.licenseTextBox, true);
            this.licenseTextBox.AutoWordSelection = true;
            this.licenseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.licenseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.licenseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licenseTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licenseTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.licenseTextBox.Location = new System.Drawing.Point(0, 7);
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.ReadOnly = true;
            this.licenseTextBox.Size = new System.Drawing.Size(353, 165);
            this.licenseTextBox.TabIndex = 14;
            this.licenseTextBox.Text = resources.GetString("licenseTextBox.Text");
            // 
            // systemInfoTab
            // 
            this.systemInfoTab.Controls.Add(this.systemInfoTextBox);
            this.systemInfoTab.HorizontalScrollbarBarColor = true;
            this.systemInfoTab.Location = new System.Drawing.Point(4, 39);
            this.systemInfoTab.Name = "systemInfoTab";
            this.systemInfoTab.Size = new System.Drawing.Size(353, 170);
            this.systemInfoTab.TabIndex = 1;
            this.systemInfoTab.Text = "System Info";
            this.systemInfoTab.VerticalScrollbarBarColor = true;
            // 
            // systemInfoTextBox
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.systemInfoTextBox, true);
            this.systemInfoTextBox.AutoWordSelection = true;
            this.systemInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.systemInfoTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.systemInfoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.systemInfoTextBox.Location = new System.Drawing.Point(0, 7);
            this.systemInfoTextBox.Name = "systemInfoTextBox";
            this.systemInfoTextBox.ReadOnly = true;
            this.systemInfoTextBox.Size = new System.Drawing.Size(353, 165);
            this.systemInfoTextBox.TabIndex = 15;
            this.systemInfoTextBox.Text = "\n";
            // 
            // iconPictureBox
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.iconPictureBox, true);
            this.iconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox.BackgroundImage = global::SimpleClicker.Properties.Resources.blue_simpleclicker;
            this.iconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconPictureBox.Location = new System.Drawing.Point(15, 116);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(230, 205);
            this.iconPictureBox.TabIndex = 11;
            this.iconPictureBox.TabStop = false;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(632, 339);
            this.Controls.Add(this.aboutTabControl);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox);
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.aboutTabControl.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.attributionsTab.ResumeLayout(false);
            this.licenseTab.ResumeLayout(false);
            this.systemInfoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionText;
        private MetroFramework.Controls.MetroTabControl aboutTabControl;
        private MetroFramework.Controls.MetroTabPage infoTab;
        private MetroFramework.Controls.MetroTabPage systemInfoTab;
        private MetroFramework.Controls.MetroTabPage licenseTab;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private MetroFramework.Controls.MetroTabPage attributionsTab;
        private System.Windows.Forms.RichTextBox aboutTextBox;
        private System.Windows.Forms.RichTextBox licenseTextBox;
        private System.Windows.Forms.RichTextBox systemInfoTextBox;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
    }
}