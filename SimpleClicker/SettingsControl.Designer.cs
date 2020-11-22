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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lappingToggle = new MetroFramework.Controls.MetroToggle();
            this.creditsLabel = new System.Windows.Forms.LinkLabel();
            this.lappingChooser = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prepTimeChooser = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.updateThresholdChooser = new System.Windows.Forms.NumericUpDown();
            this.supportButton = new System.Windows.Forms.Button();
            this.moreOptionsButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.timePrecisionChooser = new System.Windows.Forms.NumericUpDown();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.delayStartChooser = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
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
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox3.Location = new System.Drawing.Point(19, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 29);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Enable Lapping";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox1.Location = new System.Drawing.Point(262, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 29);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Preparation Time";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox2.Location = new System.Drawing.Point(20, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 29);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Update Threshold";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
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
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox5.Location = new System.Drawing.Point(20, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 29);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Time Precision";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
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
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox6.Location = new System.Drawing.Point(19, 93);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 29);
            this.textBox6.TabIndex = 23;
            this.textBox6.Text = "Delay Time";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.Enter += new System.EventHandler(this.UnfocusComponent_Enter);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(312, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "to";
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
            this.delayStopChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delayStartChooser);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.timePrecisionChooser);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.moreOptionsButton);
            this.Controls.Add(this.supportButton);
            this.Controls.Add(this.updateThresholdChooser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.prepTimeChooser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lappingChooser);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.textBox3);
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

        private System.Windows.Forms.TextBox textBox3;
        private MetroFramework.Controls.MetroToggle lappingToggle;
        private System.Windows.Forms.LinkLabel creditsLabel;
        private System.Windows.Forms.NumericUpDown lappingChooser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown prepTimeChooser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown updateThresholdChooser;
        private System.Windows.Forms.Button supportButton;
        private System.Windows.Forms.Button moreOptionsButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown timePrecisionChooser;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.NumericUpDown delayStartChooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown delayStopChooser;
        private System.Windows.Forms.LinkLabel licenseLabel;
    }
}
