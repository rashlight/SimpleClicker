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
            this.elementsPanel = new System.Windows.Forms.Panel();
            this.lapsControl = new SimpleClicker.LapsControl();
            this.settingsControl = new SimpleClicker.SettingsControl();
            this.mainTimerText = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.elementsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainActionButton
            // 
            this.mainActionButton.Font = new System.Drawing.Font("Segoe UI Semilight", 22F);
            this.mainActionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainActionButton.Location = new System.Drawing.Point(368, 67);
            this.mainActionButton.Name = "mainActionButton";
            this.mainActionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainActionButton.Size = new System.Drawing.Size(157, 67);
            this.mainActionButton.TabIndex = 4;
            this.mainActionButton.Text = "Start";
            this.mainActionButton.UseVisualStyleBackColor = true;
            this.mainActionButton.Click += new System.EventHandler(this.mainActionButton_Click);
            // 
            // secondaryActionButton
            // 
            this.secondaryActionButton.Font = new System.Drawing.Font("Segoe UI Semilight", 19F);
            this.secondaryActionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.secondaryActionButton.Location = new System.Drawing.Point(368, 140);
            this.secondaryActionButton.Name = "secondaryActionButton";
            this.secondaryActionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secondaryActionButton.Size = new System.Drawing.Size(157, 67);
            this.secondaryActionButton.TabIndex = 5;
            this.secondaryActionButton.Text = "Options";
            this.secondaryActionButton.UseVisualStyleBackColor = true;
            this.secondaryActionButton.Click += new System.EventHandler(this.secondaryActionButton_Click);
            // 
            // tickTimerText
            // 
            this.tickTimerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tickTimerText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tickTimerText.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.tickTimerText.Location = new System.Drawing.Point(13, 156);
            this.tickTimerText.Name = "tickTimerText";
            this.tickTimerText.Size = new System.Drawing.Size(339, 40);
            this.tickTimerText.TabIndex = 3;
            this.tickTimerText.Text = "Ready to start.";
            this.tickTimerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tickTimerText.Enter += new System.EventHandler(this.tickTimerText_Enter);
            // 
            // elementsPanel
            // 
            this.elementsPanel.Controls.Add(this.lapsControl);
            this.elementsPanel.Controls.Add(this.settingsControl);
            this.elementsPanel.Location = new System.Drawing.Point(18, 213);
            this.elementsPanel.Name = "elementsPanel";
            this.elementsPanel.Size = new System.Drawing.Size(507, 300);
            this.elementsPanel.TabIndex = 3;
            // 
            // lapsControl
            // 
            this.lapsControl.Location = new System.Drawing.Point(0, 13);
            this.lapsControl.Name = "lapsControl";
            this.lapsControl.Size = new System.Drawing.Size(507, 287);
            this.lapsControl.TabIndex = 1;
            this.lapsControl.Visible = false;
            // 
            // settingsControl
            // 
            this.settingsControl.Location = new System.Drawing.Point(0, 0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(507, 300);
            this.settingsControl.TabIndex = 0;
            // 
            // mainTimerText
            // 
            this.mainTimerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTimerText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainTimerText.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.mainTimerText.Location = new System.Drawing.Point(13, 67);
            this.mainTimerText.Name = "mainTimerText";
            this.mainTimerText.Size = new System.Drawing.Size(340, 94);
            this.mainTimerText.TabIndex = 2;
            this.mainTimerText.Text = "00:00:00";
            this.mainTimerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainTimerText.Enter += new System.EventHandler(this.mainTimerText_Enter);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(542, 529);
            this.Controls.Add(this.elementsPanel);
            this.Controls.Add(this.secondaryActionButton);
            this.Controls.Add(this.mainActionButton);
            this.Controls.Add(this.tickTimerText);
            this.Controls.Add(this.mainTimerText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Simple Clicker";
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
        private LapsControl lapsControl;
        private System.Windows.Forms.Timer timer;
    }
}

