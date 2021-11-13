namespace SimpleClicker
{
    partial class ExtendForm
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
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.lapsControl = new SimpleClicker.LapsControl();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.settingsControl = new SimpleClicker.SettingsControl();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lapsControl
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.lapsControl, true);
            this.lapsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lapsControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lapsControl.Location = new System.Drawing.Point(18, -1);
            this.lapsControl.Name = "lapsControl";
            this.lapsControl.Size = new System.Drawing.Size(507, 279);
            this.lapsControl.TabIndex = 1;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // settingsControl
            // 
            this.settingsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settingsControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsControl.Location = new System.Drawing.Point(18, -1);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(507, 279);
            this.settingsControl.TabIndex = 0;
            // 
            // TimeSetupForm
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this, true);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 290);
            this.ControlBox = false;
            this.Controls.Add(this.settingsControl);
            this.Controls.Add(this.lapsControl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Time Setup Form";
            this.Load += new System.EventHandler(this.TimeExtendForm_Load);
            this.MouseEnter += new System.EventHandler(this.ExtendForm_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public SettingsControl settingsControl;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        public LapsControl lapsControl;
    }
}