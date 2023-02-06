namespace CorvinMoziUj
{
    partial class Statisztika
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
            this.Statiszttext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Statiszttext
            // 
            this.Statiszttext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Statiszttext.Location = new System.Drawing.Point(0, 0);
            this.Statiszttext.Name = "Statiszttext";
            this.Statiszttext.Size = new System.Drawing.Size(1200, 658);
            this.Statiszttext.TabIndex = 0;
            this.Statiszttext.Text = "";
            // 
            // Statisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.Statiszttext);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Statisztika";
            this.Text = "Statisztika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Statiszttext;
    }
}