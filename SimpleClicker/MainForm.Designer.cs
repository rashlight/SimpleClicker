namespace SimpleClicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainActionButton = new System.Windows.Forms.Button();
            this.secondaryActionButton = new System.Windows.Forms.Button();
            this.tickTimerText = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.elementsPanel = new System.Windows.Forms.Panel();
            this.lapsControl = new SimpleClicker.LapsControl();
            this.settingsControl = new SimpleClicker.SettingsControl();
            this.mainTimerText = new System.Windows.Forms.TextBox();
            this.elementsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainActionButton
            // 
            resources.ApplyResources(this.mainActionButton, "mainActionButton");
            this.mainActionButton.Name = "mainActionButton";
            this.mainActionButton.UseVisualStyleBackColor = true;
            this.mainActionButton.Click += new System.EventHandler(this.mainActionButton_Click);
            // 
            // secondaryActionButton
            // 
            resources.ApplyResources(this.secondaryActionButton, "secondaryActionButton");
            this.secondaryActionButton.Name = "secondaryActionButton";
            this.secondaryActionButton.UseVisualStyleBackColor = true;
            this.secondaryActionButton.Click += new System.EventHandler(this.secondaryActionButton_Click);
            // 
            // tickTimerText
            // 
            this.tickTimerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tickTimerText.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.tickTimerText, "tickTimerText");
            this.tickTimerText.Name = "tickTimerText";
            this.tickTimerText.Enter += new System.EventHandler(this.tickTimerText_Enter);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // elementsPanel
            // 
            this.elementsPanel.Controls.Add(this.lapsControl);
            this.elementsPanel.Controls.Add(this.settingsControl);
            resources.ApplyResources(this.elementsPanel, "elementsPanel");
            this.elementsPanel.Name = "elementsPanel";
            // 
            // lapsControl
            // 
            resources.ApplyResources(this.lapsControl, "lapsControl");
            this.lapsControl.Name = "lapsControl";
            // 
            // settingsControl
            // 
            resources.ApplyResources(this.settingsControl, "settingsControl");
            this.settingsControl.Name = "settingsControl";
            // 
            // mainTimerText
            // 
            this.mainTimerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTimerText.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.mainTimerText, "mainTimerText");
            this.mainTimerText.Name = "mainTimerText";
            this.mainTimerText.Enter += new System.EventHandler(this.mainTimerText_Enter);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.elementsPanel);
            this.Controls.Add(this.secondaryActionButton);
            this.Controls.Add(this.mainActionButton);
            this.Controls.Add(this.tickTimerText);
            this.Controls.Add(this.mainTimerText);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.elementsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mainActionButton;
        private System.Windows.Forms.Button secondaryActionButton;
        private System.Windows.Forms.TextBox tickTimerText;
        private System.Windows.Forms.Panel elementsPanel;
        private SettingsControl settingsControl;
        private System.Windows.Forms.TextBox mainTimerText;
        private System.Windows.Forms.Timer timer;
        private LapsControl lapsControl;
    }
}

