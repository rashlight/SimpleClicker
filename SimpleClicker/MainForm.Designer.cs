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
            this.mainTimerText = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mainActionButton
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.mainActionButton, true);
            this.mainActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainActionButton.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainActionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainActionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainActionButton.Location = new System.Drawing.Point(368, 67);
            this.mainActionButton.Name = "mainActionButton";
            this.mainActionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainActionButton.Size = new System.Drawing.Size(157, 67);
            this.mainActionButton.TabIndex = 4;
            this.mainActionButton.Text = "Start";
            this.mainActionButton.UseVisualStyleBackColor = false;
            this.mainActionButton.Click += new System.EventHandler(this.mainActionButton_Click);
            // 
            // secondaryActionButton
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.secondaryActionButton, true);
            this.secondaryActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.secondaryActionButton.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.secondaryActionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.secondaryActionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.secondaryActionButton.Location = new System.Drawing.Point(368, 140);
            this.secondaryActionButton.Name = "secondaryActionButton";
            this.secondaryActionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secondaryActionButton.Size = new System.Drawing.Size(157, 67);
            this.secondaryActionButton.TabIndex = 5;
            this.secondaryActionButton.Text = "Options";
            this.secondaryActionButton.UseVisualStyleBackColor = false;
            this.secondaryActionButton.Click += new System.EventHandler(this.secondaryActionButton_Click);
            // 
            // tickTimerText
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.tickTimerText, true);
            this.tickTimerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tickTimerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tickTimerText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tickTimerText.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.tickTimerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tickTimerText.Location = new System.Drawing.Point(13, 156);
            this.tickTimerText.Name = "tickTimerText";
            this.tickTimerText.ReadOnly = true;
            this.tickTimerText.ShortcutsEnabled = false;
            this.tickTimerText.Size = new System.Drawing.Size(339, 40);
            this.tickTimerText.TabIndex = 3;
            this.tickTimerText.Text = "Ready to start.";
            this.tickTimerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tickTimerText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tickTimerText_MouseDown);
            // 
            // mainTimerText
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.mainTimerText, true);
            this.mainTimerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainTimerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTimerText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainTimerText.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.mainTimerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainTimerText.Location = new System.Drawing.Point(13, 67);
            this.mainTimerText.Name = "mainTimerText";
            this.mainTimerText.ReadOnly = true;
            this.mainTimerText.ShortcutsEnabled = false;
            this.mainTimerText.Size = new System.Drawing.Size(340, 94);
            this.mainTimerText.TabIndex = 2;
            this.mainTimerText.Text = "00:00:00";
            this.mainTimerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainTimerText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainTimerText_MouseDown);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(542, 226);
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
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mainActionButton;
        private System.Windows.Forms.Button secondaryActionButton;
        private System.Windows.Forms.TextBox tickTimerText;
        private System.Windows.Forms.TextBox mainTimerText;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}

