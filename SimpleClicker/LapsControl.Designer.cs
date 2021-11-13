namespace SimpleClicker
{
    partial class LapsControl
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
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lapsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // lapsTextBox
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.lapsTextBox, true);
            this.lapsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lapsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lapsTextBox.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lapsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lapsTextBox.Location = new System.Drawing.Point(0, 0);
            this.lapsTextBox.Multiline = true;
            this.lapsTextBox.Name = "lapsTextBox";
            this.lapsTextBox.ReadOnly = true;
            this.lapsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lapsTextBox.Size = new System.Drawing.Size(507, 285);
            this.lapsTextBox.TabIndex = 0;
            // 
            // LapsControl
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this, true);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lapsTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "LapsControl";
            this.Size = new System.Drawing.Size(507, 285);
            this.Load += new System.EventHandler(this.LapsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.TextBox lapsTextBox;
    }
}
