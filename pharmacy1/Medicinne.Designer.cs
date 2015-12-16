namespace pharmacy1
{
    partial class Medicinne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicinne));
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Bk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(71, 31);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(119, 51);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add/Modfiy Medicine";
            this.Add.UseCompatibleTextRendering = true;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(71, 115);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(119, 47);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search/Delete Medicine";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Bk
            // 
            this.Bk.Location = new System.Drawing.Point(87, 193);
            this.Bk.Name = "Bk";
            this.Bk.Size = new System.Drawing.Size(103, 33);
            this.Bk.TabIndex = 4;
            this.Bk.Text = "Back";
            this.Bk.UseVisualStyleBackColor = true;
            this.Bk.Click += new System.EventHandler(this.Bk_Click);
            // 
            // Medicinne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.Bk);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.DoubleBuffered = true;
            this.Name = "Medicinne";
            this.Text = "Medicinne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Bk;
    }
}