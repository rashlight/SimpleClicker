namespace SimpleClicker
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enableLappingText = new System.Windows.Forms.TextBox();
            this.lappingToggle = new MetroFramework.Controls.MetroToggle();
            this.creditsLabel = new System.Windows.Forms.LinkLabel();
            this.lappingChooser = new System.Windows.Forms.NumericUpDown();
            this.preparationTimeText = new System.Windows.Forms.TextBox();
            this.prepTimeChooser = new System.Windows.Forms.NumericUpDown();
            this.updateThresholdText = new System.Windows.Forms.TextBox();
            this.updateThresholdChooser = new System.Windows.Forms.NumericUpDown();
            this.supportButton = new System.Windows.Forms.Button();
            this.moreOptionsButton = new System.Windows.Forms.Button();
            this.timePrecisionText = new System.Windows.Forms.TextBox();
            this.timePrecisionChooser = new System.Windows.Forms.NumericUpDown();
            this.delayTimeText = new System.Windows.Forms.TextBox();
            this.delayStartChooser = new System.Windows.Forms.NumericUpDown();
            this.delayToText = new System.Windows.Forms.Label();
            this.delayStopChooser = new System.Windows.Forms.NumericUpDown();
            this.licenseLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lappingChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepTimeChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateThresholdChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePrecisionChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayStartChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayStopChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // enableLappingText
            // 
            this.enableLappingText.BackColor = System.Drawing.Color.White;
            this.enableLappingText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enableLappingText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.enableLappingText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.enableLappingText.Location = new System.Drawing.Point(19, 16);
            this.enableLappingText.Name = "enableLappingText";
            this.enableLappingText.Size = new System.Drawing.Size(236, 29);
            this.enableLappingText.TabIndex = 5;
            this.enableLappingText.Text = "Enable Lapping";
            this.enableLappingText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enableLappingText.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
            // 
            // lappingToggle
            // 
            this.lappingToggle.AutoSize = true;
            this.lappingToggle.BackColor = System.Drawing.SystemColors.Control;
            this.lappingToggle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lappingToggle.Location = new System.Drawing.Point(19, 56);
            this.lappingToggle.Name = "lappingToggle";
            this.lappingToggle.Size = new System.Drawing.Size(80, 21);
            this.lappingToggle.TabIndex = 4;
            this.lappingToggle.Text = "Off";
            this.lappingToggle.UseVisualStyleBackColor = false;
            this.lappingToggle.CheckedChanged += new System.EventHandler(this.lappingToggle_CheckedChanged);
            // 
            // creditsLabel
            // 
            this.creditsLabel.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.BackColor = System.Drawing.Color.White;
            this.creditsLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold);
            this.creditsLabel.LinkColor = System.Drawing.Color.MidnightBlue;
            this.creditsLabel.Location = new System.Drawing.Point(28, 270);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(268, 23);
            this.creditsLabel.TabIndex = 9;
            this.creditsLabel.TabStop = true;
            this.creditsLabel.Text = "~ Made with 💖 by rashlight ~";
            this.creditsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsLabel_LinkClicked);
            // 
            // lappingChooser
            // 
            this.lappingChooser.Enabled = false;
            this.lappingChooser.Location = new System.Drawing.Point(105, 56);
            this.lappingChooser.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.lappingChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.lappingChooser.Name = "lappingChooser";
            this.lappingChooser.ReadOnly = true;
            this.lappingChooser.Size = new System.Drawing.Size(150, 22);
            this.lappingChooser.TabIndex = 11;
            this.lappingChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lappingChooser.ThousandsSeparator = true;
            this.lappingChooser.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lappingChooser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lappingChooser_MouseUp);
            // 
            // preparationTimeText
            // 
            this.preparationTimeText.BackColor = System.Drawing.Color.White;
            this.preparationTimeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preparationTimeText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.preparationTimeText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.preparationTimeText.Location = new System.Drawing.Point(262, 16);
            this.preparationTimeText.Name = "preparationTimeText";
            this.preparationTimeText.Size = new System.Drawing.Size(221, 29);
            this.preparationTimeText.TabIndex = 12;
            this.preparationTimeText.Text = "Preparation Time";
            this.preparationTimeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.preparationTimeText.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
            // 
            // prepTimeChooser
            // 
            this.prepTimeChooser.DecimalPlaces = 2;
            this.prepTimeChooser.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prepTimeChooser.Location = new System.Drawing.Point(262, 56);
            this.prepTimeChooser.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.prepTimeChooser.Name = "prepTimeChooser";
            this.prepTimeChooser.ReadOnly = true;
            this.prepTimeChooser.Size = new System.Drawing.Size(221, 22);
            this.prepTimeChooser.TabIndex = 13;
            this.prepTimeChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prepTimeChooser.ThousandsSeparator = true;
            this.prepTimeChooser.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.prepTimeChooser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.prepTimeChooser_MouseUp);
            // 
            // updateThresholdText
            // 
            this.updateThresholdText.BackColor = System.Drawing.Color.White;
            this.updateThresholdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateThresholdText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.updateThresholdText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.updateThresholdText.Location = new System.Drawing.Point(19, 183);
            this.updateThresholdText.Name = "updateThresholdText";
            this.updateThresholdText.Size = new System.Drawing.Size(245, 29);
            this.updateThresholdText.TabIndex = 14;
            this.updateThresholdText.Text = "Update Threshold";
            this.updateThresholdText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateThresholdText.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
            // 
            // updateThresholdChooser
            // 
            this.updateThresholdChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateThresholdChooser.Location = new System.Drawing.Point(270, 182);
            this.updateThresholdChooser.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.updateThresholdChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updateThresholdChooser.Name = "updateThresholdChooser";
            this.updateThresholdChooser.ReadOnly = true;
            this.updateThresholdChooser.Size = new System.Drawing.Size(213, 30);
            this.updateThresholdChooser.TabIndex = 15;
            this.updateThresholdChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateThresholdChooser.ThousandsSeparator = true;
            this.updateThresholdChooser.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updateThresholdChooser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateThresholdChooser_MouseUp);
            // 
            // supportButton
            // 
            this.supportButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.supportButton.Location = new System.Drawing.Point(328, 223);
            this.supportButton.Name = "supportButton";
            this.supportButton.Size = new System.Drawing.Size(154, 39);
            this.supportButton.TabIndex = 19;
            this.supportButton.Text = "Support...";
            this.supportButton.UseVisualStyleBackColor = true;
            this.supportButton.Click += new System.EventHandler(this.supportButton_Click);
            // 
            // moreOptionsButton
            // 
            this.moreOptionsButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.moreOptionsButton.Location = new System.Drawing.Point(20, 223);
            this.moreOptionsButton.Name = "moreOptionsButton";
            this.moreOptionsButton.Size = new System.Drawing.Size(302, 39);
            this.moreOptionsButton.TabIndex = 20;
            this.moreOptionsButton.Text = "More options...";
            this.moreOptionsButton.UseVisualStyleBackColor = true;
            this.moreOptionsButton.Click += new System.EventHandler(this.moreOptionsButton_Click);
            // 
            // timePrecisionText
            // 
            this.timePrecisionText.BackColor = System.Drawing.Color.White;
            this.timePrecisionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timePrecisionText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.timePrecisionText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.timePrecisionText.Location = new System.Drawing.Point(19, 138);
            this.timePrecisionText.Name = "timePrecisionText";
            this.timePrecisionText.Size = new System.Drawing.Size(190, 29);
            this.timePrecisionText.TabIndex = 21;
            this.timePrecisionText.Text = "Time Precision";
            this.timePrecisionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timePrecisionText.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
            // 
            // timePrecisionChooser
            // 
            this.timePrecisionChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timePrecisionChooser.Location = new System.Drawing.Point(217, 138);
            this.timePrecisionChooser.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.timePrecisionChooser.Name = "timePrecisionChooser";
            this.timePrecisionChooser.ReadOnly = true;
            this.timePrecisionChooser.Size = new System.Drawing.Size(266, 30);
            this.timePrecisionChooser.TabIndex = 22;
            this.timePrecisionChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timePrecisionChooser.ThousandsSeparator = true;
            this.timePrecisionChooser.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.timePrecisionChooser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timePrecisionChooser_MouseUp);
            // 
            // delayTimeText
            // 
            this.delayTimeText.BackColor = System.Drawing.Color.White;
            this.delayTimeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delayTimeText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.delayTimeText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.delayTimeText.Location = new System.Drawing.Point(18, 93);
            this.delayTimeText.Name = "delayTimeText";
            this.delayTimeText.Size = new System.Drawing.Size(145, 29);
            this.delayTimeText.TabIndex = 23;
            this.delayTimeText.Text = "Delay Time";
            this.delayTimeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayTimeText.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
            // 
            // delayStartChooser
            // 
            this.delayStartChooser.DecimalPlaces = 2;
            this.delayStartChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delayStartChooser.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.delayStartChooser.Location = new System.Drawing.Point(169, 92);
            this.delayStartChooser.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delayStartChooser.Name = "delayStartChooser";
            this.delayStartChooser.ReadOnly = true;
            this.delayStartChooser.Size = new System.Drawing.Size(137, 30);
            this.delayStartChooser.TabIndex = 24;
            this.delayStartChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayStartChooser.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.delayStartChooser.ValueChanged += new System.EventHandler(this.delayStartChooser_ValueChanged);
            this.delayStartChooser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.delayStartChooser_MouseUp);
            // 
            // delayToText
            // 
            this.delayToText.AutoSize = true;
            this.delayToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delayToText.Location = new System.Drawing.Point(312, 94);
            this.delayToText.Name = "delayToText";
            this.delayToText.Size = new System.Drawing.Size(28, 25);
            this.delayToText.TabIndex = 25;
            this.delayToText.Text = "to";
            // 
            // delayStopChooser
            // 
            this.delayStopChooser.DecimalPlaces = 2;
            this.delayStopChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delayStopChooser.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.delayStopChooser.Location = new System.Drawing.Point(346, 92);
            this.delayStopChooser.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.delayStopChooser.Name = "delayStopChooser";
            this.delayStopChooser.ReadOnly = true;
            this.delayStopChooser.Size = new System.Drawing.Size(136, 30);
            this.delayStopChooser.TabIndex = 26;
            this.delayStopChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayStopChooser.ThousandsSeparator = true;
            this.delayStopChooser.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.delayStopChooser.ValueChanged += new System.EventHandler(this.delayStopChooser_ValueChanged);
            this.delayStopChooser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.delayStopChooser_MouseUp);
            // 
            // licenseLabel
            // 
            this.licenseLabel.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.BackColor = System.Drawing.Color.White;
            this.licenseLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold);
            this.licenseLabel.LinkColor = System.Drawing.Color.MidnightBlue;
            this.licenseLabel.Location = new System.Drawing.Point(297, 270);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(179, 23);
            this.licenseLabel.TabIndex = 27;
            this.licenseLabel.TabStop = true;
            this.licenseLabel.Text = "Licensed by GPL 3.0";
            this.licenseLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenseLabel_LinkClicked);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.licenseLabel);
            this.Controls.Add(this.delayStopChooser);
            this.Controls.Add(this.delayToText);
            this.Controls.Add(this.delayStartChooser);
            this.Controls.Add(this.delayTimeText);
            this.Controls.Add(this.timePrecisionChooser);
            this.Controls.Add(this.timePrecisionText);
            this.Controls.Add(this.moreOptionsButton);
            this.Controls.Add(this.supportButton);
            this.Controls.Add(this.updateThresholdChooser);
            this.Controls.Add(this.updateThresholdText);
            this.Controls.Add(this.prepTimeChooser);
            this.Controls.Add(this.preparationTimeText);
            this.Controls.Add(this.lappingChooser);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.enableLappingText);
            this.Controls.Add(this.lappingToggle);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(507, 300);
            ((System.ComponentModel.ISupportInitialize)(this.lappingChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepTimeChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateThresholdChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePrecisionChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayStartChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayStopChooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enableLappingText;
        private MetroFramework.Controls.MetroToggle lappingToggle;
        private System.Windows.Forms.LinkLabel creditsLabel;
        private System.Windows.Forms.NumericUpDown lappingChooser;
        private System.Windows.Forms.TextBox preparationTimeText;
        private System.Windows.Forms.NumericUpDown prepTimeChooser;
        private System.Windows.Forms.TextBox updateThresholdText;
        private System.Windows.Forms.NumericUpDown updateThresholdChooser;
        private System.Windows.Forms.Button supportButton;
        private System.Windows.Forms.Button moreOptionsButton;
        private System.Windows.Forms.TextBox timePrecisionText;
        private System.Windows.Forms.NumericUpDown timePrecisionChooser;
        private System.Windows.Forms.TextBox delayTimeText;
        private System.Windows.Forms.NumericUpDown delayStartChooser;
        private System.Windows.Forms.Label delayToText;
        private System.Windows.Forms.NumericUpDown delayStopChooser;
        private System.Windows.Forms.LinkLabel licenseLabel;
    }
}
