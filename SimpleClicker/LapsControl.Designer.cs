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
            this.lapsListBox = new System.Windows.Forms.ListBox();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lapsListBox
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.lapsListBox, true);
            this.lapsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lapsListBox.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lapsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lapsListBox.FormattingEnabled = true;
            this.lapsListBox.ItemHeight = 30;
            this.lapsListBox.Location = new System.Drawing.Point(0, 0);
            this.lapsListBox.Name = "lapsListBox";
            this.lapsListBox.Size = new System.Drawing.Size(507, 274);
            this.lapsListBox.TabIndex = 0;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // LapsControl
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this, true);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lapsListBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "LapsControl";
            this.Size = new System.Drawing.Size(507, 279);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lapsListBox;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}
