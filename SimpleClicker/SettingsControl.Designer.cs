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
            this.components = new System.ComponentModel.Container();
            this.enableLappingText = new System.Windows.Forms.TextBox();
            this.lappingToggle = new MetroFramework.Controls.MetroToggle();
            this.lappingChooser = new System.Windows.Forms.NumericUpDown();
            this.preparationTimeText = new System.Windows.Forms.TextBox();
            this.prepTimeChooser = new System.Windows.Forms.NumericUpDown();
            this.updateThresholdText = new System.Windows.Forms.TextBox();
            this.updateThresholdChooser = new System.Windows.Forms.NumericUpDown();
            this.aboutButton = new System.Windows.Forms.Button();
            this.moreOptionsButton = new System.Windows.Forms.Button();
            this.timePrecisionText = new System.Windows.Forms.TextBox();
            this.timePrecisionChooser = new System.Windows.Forms.NumericUpDown();
            this.delayTimeText = new System.Windows.Forms.TextBox();
            this.delayStartChooser = new System.Windows.Forms.NumericUpDown();
            this.delayStopChooser = new System.Windows.Forms.NumericUpDown();
            this.delayToText = new System.Windows.Forms.Label();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lappingChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepTimeChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateThresholdChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePrecisionChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayStartChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayStopChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // enableLappingText
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.enableLappingText, true);
            this.enableLappingText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enableLappingText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enableLappingText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.enableLappingText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.enableLappingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // lappingChooser
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.lappingChooser, true);
            this.lappingChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lappingChooser.Enabled = false;
            this.lappingChooser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lappingChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lappingChooser.Location = new System.Drawing.Point(112, 53);
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
            this.lappingChooser.Size = new System.Drawing.Size(136, 27);
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
            this.metroStyleExtender.SetApplyMetroTheme(this.preparationTimeText, true);
            this.preparationTimeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.preparationTimeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preparationTimeText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.preparationTimeText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.preparationTimeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.metroStyleExtender.SetApplyMetroTheme(this.prepTimeChooser, true);
            this.prepTimeChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prepTimeChooser.DecimalPlaces = 2;
            this.prepTimeChooser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTimeChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prepTimeChooser.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prepTimeChooser.Location = new System.Drawing.Point(261, 53);
            this.prepTimeChooser.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.prepTimeChooser.Name = "prepTimeChooser";
            this.prepTimeChooser.ReadOnly = true;
            this.prepTimeChooser.Size = new System.Drawing.Size(221, 27);
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
            this.metroStyleExtender.SetApplyMetroTheme(this.updateThresholdText, true);
            this.updateThresholdText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateThresholdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateThresholdText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.updateThresholdText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.updateThresholdText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.metroStyleExtender.SetApplyMetroTheme(this.updateThresholdChooser, true);
            this.updateThresholdChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateThresholdChooser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateThresholdChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.updateThresholdChooser.Size = new System.Drawing.Size(213, 34);
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
            // aboutButton
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.aboutButton, true);
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutButton.Location = new System.Drawing.Point(328, 223);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(154, 39);
            this.aboutButton.TabIndex = 19;
            this.aboutButton.Text = "About...";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // moreOptionsButton
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.moreOptionsButton, true);
            this.moreOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.moreOptionsButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.moreOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moreOptionsButton.Location = new System.Drawing.Point(20, 223);
            this.moreOptionsButton.Name = "moreOptionsButton";
            this.moreOptionsButton.Size = new System.Drawing.Size(302, 39);
            this.moreOptionsButton.TabIndex = 20;
            this.moreOptionsButton.Text = "More options...";
            this.moreOptionsButton.UseVisualStyleBackColor = false;
            this.moreOptionsButton.Click += new System.EventHandler(this.moreOptionsButton_Click);
            // 
            // timePrecisionText
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.timePrecisionText, true);
            this.timePrecisionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timePrecisionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timePrecisionText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.timePrecisionText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.timePrecisionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.metroStyleExtender.SetApplyMetroTheme(this.timePrecisionChooser, true);
            this.timePrecisionChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timePrecisionChooser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePrecisionChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timePrecisionChooser.Location = new System.Drawing.Point(217, 138);
            this.timePrecisionChooser.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.timePrecisionChooser.Name = "timePrecisionChooser";
            this.timePrecisionChooser.ReadOnly = true;
            this.timePrecisionChooser.Size = new System.Drawing.Size(266, 34);
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
            this.metroStyleExtender.SetApplyMetroTheme(this.delayTimeText, true);
            this.delayTimeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delayTimeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delayTimeText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.delayTimeText.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.delayTimeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.metroStyleExtender.SetApplyMetroTheme(this.delayStartChooser, true);
            this.delayStartChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delayStartChooser.DecimalPlaces = 2;
            this.delayStartChooser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayStartChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.delayStartChooser.Size = new System.Drawing.Size(137, 34);
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
            // delayStopChooser
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.delayStopChooser, true);
            this.delayStopChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delayStopChooser.DecimalPlaces = 2;
            this.delayStopChooser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayStopChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.delayStopChooser.Size = new System.Drawing.Size(136, 34);
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
            // delayToText
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.delayToText, true);
            this.delayToText.AutoSize = true;
            this.delayToText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delayToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delayToText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delayToText.Location = new System.Drawing.Point(311, 97);
            this.delayToText.Name = "delayToText";
            this.delayToText.Size = new System.Drawing.Size(28, 25);
            this.delayToText.TabIndex = 25;
            this.delayToText.Text = "to";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // SettingsControl
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this, true);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delayStopChooser);
            this.Controls.Add(this.delayToText);
            this.Controls.Add(this.delayStartChooser);
            this.Controls.Add(this.delayTimeText);
            this.Controls.Add(this.timePrecisionChooser);
            this.Controls.Add(this.timePrecisionText);
            this.Controls.Add(this.moreOptionsButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.updateThresholdChooser);
            this.Controls.Add(this.updateThresholdText);
            this.Controls.Add(this.prepTimeChooser);
            this.Controls.Add(this.preparationTimeText);
            this.Controls.Add(this.lappingChooser);
            this.Controls.Add(this.enableLappingText);
            this.Controls.Add(this.lappingToggle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(507, 279);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lappingChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepTimeChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateThresholdChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePrecisionChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayStartChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayStopChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enableLappingText;
        private MetroFramework.Controls.MetroToggle lappingToggle;
        private System.Windows.Forms.NumericUpDown lappingChooser;
        private System.Windows.Forms.TextBox preparationTimeText;
        private System.Windows.Forms.NumericUpDown prepTimeChooser;
        private System.Windows.Forms.TextBox updateThresholdText;
        private System.Windows.Forms.NumericUpDown updateThresholdChooser;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button moreOptionsButton;
        private System.Windows.Forms.TextBox timePrecisionText;
        private System.Windows.Forms.NumericUpDown timePrecisionChooser;
        private System.Windows.Forms.TextBox delayTimeText;
        private System.Windows.Forms.NumericUpDown delayStartChooser;
        private System.Windows.Forms.NumericUpDown delayStopChooser;
        private System.Windows.Forms.Label delayToText;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
    }
}
