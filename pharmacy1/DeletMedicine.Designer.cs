namespace pharmacy1
{
    partial class DeletMedicine
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
            this.seachdelet = new System.Windows.Forms.TextBox();
            this.Delet = new System.Windows.Forms.Button();
            this.Backk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seachdelet
            // 
            this.seachdelet.Location = new System.Drawing.Point(84, 87);
            this.seachdelet.Multiline = true;
            this.seachdelet.Name = "seachdelet";
            this.seachdelet.Size = new System.Drawing.Size(142, 38);
            this.seachdelet.TabIndex = 0;
            // 
            // Delet
            // 
            this.Delet.Location = new System.Drawing.Point(152, 182);
            this.Delet.Name = "Delet";
            this.Delet.Size = new System.Drawing.Size(120, 29);
            this.Delet.TabIndex = 1;
            this.Delet.Text = "Delet";
            this.Delet.UseVisualStyleBackColor = true;
            this.Delet.Click += new System.EventHandler(this.Delet_Click);
            // 
            // Backk
            // 
            this.Backk.Location = new System.Drawing.Point(84, 221);
            this.Backk.Name = "Backk";
            this.Backk.Size = new System.Drawing.Size(109, 29);
            this.Backk.TabIndex = 2;
            this.Backk.Text = "Back";
            this.Backk.UseVisualStyleBackColor = true;
            this.Backk.Click += new System.EventHandler(this.Backk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medicine Name";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 182);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(120, 28);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DeletMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backk);
            this.Controls.Add(this.Delet);
            this.Controls.Add(this.seachdelet);
            this.Name = "DeletMedicine";
            this.Text = "DeletMedicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox seachdelet;
        private System.Windows.Forms.Button Delet;
        private System.Windows.Forms.Button Backk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
    }
}