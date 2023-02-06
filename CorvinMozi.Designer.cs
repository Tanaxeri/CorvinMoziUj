namespace CorvinMoziUj
{
    partial class CorvinMozi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorvinMozi));
            this.MoziPanel = new System.Windows.Forms.Panel();
            this.Mentesgomb = new System.Windows.Forms.Button();
            this.Statiszgomb = new System.Windows.Forms.Button();
            this.Jobbgomb = new System.Windows.Forms.Button();
            this.Balgomb = new System.Windows.Forms.Button();
            this.mozikep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mozikep)).BeginInit();
            this.SuspendLayout();
            // 
            // MoziPanel
            // 
            this.MoziPanel.Location = new System.Drawing.Point(307, 48);
            this.MoziPanel.Name = "MoziPanel";
            this.MoziPanel.Size = new System.Drawing.Size(810, 275);
            this.MoziPanel.TabIndex = 0;
            // 
            // Mentesgomb
            // 
            this.Mentesgomb.Location = new System.Drawing.Point(371, 443);
            this.Mentesgomb.Name = "Mentesgomb";
            this.Mentesgomb.Size = new System.Drawing.Size(149, 55);
            this.Mentesgomb.TabIndex = 4;
            this.Mentesgomb.Text = "Mentés";
            this.Mentesgomb.UseVisualStyleBackColor = true;
            // 
            // Statiszgomb
            // 
            this.Statiszgomb.Location = new System.Drawing.Point(660, 443);
            this.Statiszgomb.Name = "Statiszgomb";
            this.Statiszgomb.Size = new System.Drawing.Size(149, 55);
            this.Statiszgomb.TabIndex = 5;
            this.Statiszgomb.Text = "Statisztika";
            this.Statiszgomb.UseVisualStyleBackColor = true;
            // 
            // Jobbgomb
            // 
            this.Jobbgomb.Image = global::CorvinMoziUj.Properties.Resources.jobbra;
            this.Jobbgomb.Location = new System.Drawing.Point(846, 557);
            this.Jobbgomb.Name = "Jobbgomb";
            this.Jobbgomb.Size = new System.Drawing.Size(89, 63);
            this.Jobbgomb.TabIndex = 3;
            this.Jobbgomb.UseVisualStyleBackColor = true;
            // 
            // Balgomb
            // 
            this.Balgomb.Image = global::CorvinMoziUj.Properties.Resources.balra;
            this.Balgomb.Location = new System.Drawing.Point(262, 557);
            this.Balgomb.Name = "Balgomb";
            this.Balgomb.Size = new System.Drawing.Size(90, 63);
            this.Balgomb.TabIndex = 2;
            this.Balgomb.UseVisualStyleBackColor = true;
            // 
            // mozikep
            // 
            this.mozikep.Location = new System.Drawing.Point(28, 28);
            this.mozikep.Name = "mozikep";
            this.mozikep.Size = new System.Drawing.Size(158, 202);
            this.mozikep.TabIndex = 1;
            this.mozikep.TabStop = false;
            // 
            // CorvinMozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.Statiszgomb);
            this.Controls.Add(this.Mentesgomb);
            this.Controls.Add(this.Jobbgomb);
            this.Controls.Add(this.Balgomb);
            this.Controls.Add(this.mozikep);
            this.Controls.Add(this.MoziPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CorvinMozi";
            this.Text = "CorvinMozi";
            this.Load += new System.EventHandler(this.CorvinMozi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mozikep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MoziPanel;
        private System.Windows.Forms.PictureBox mozikep;
        private System.Windows.Forms.Button Balgomb;
        private System.Windows.Forms.Button Jobbgomb;
        private System.Windows.Forms.Button Mentesgomb;
        private System.Windows.Forms.Button Statiszgomb;
    }
}

