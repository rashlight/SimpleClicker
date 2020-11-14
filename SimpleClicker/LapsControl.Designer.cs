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
            this.lapsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lapsListBox
            // 
            this.lapsListBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lapsListBox.FormattingEnabled = true;
            this.lapsListBox.ItemHeight = 35;
            this.lapsListBox.Location = new System.Drawing.Point(0, 0);
            this.lapsListBox.Name = "lapsListBox";
            this.lapsListBox.Size = new System.Drawing.Size(507, 284);
            this.lapsListBox.TabIndex = 0;
            // 
            // LapsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lapsListBox);
            this.Name = "LapsControl";
            this.Size = new System.Drawing.Size(507, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lapsListBox;
    }
}
