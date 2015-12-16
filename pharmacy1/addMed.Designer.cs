namespace pharmacy1
{
    partial class addMed
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
            this.SaveMe = new System.Windows.Forms.Button();
            this.addname = new System.Windows.Forms.TextBox();
            this.addDes = new System.Windows.Forms.TextBox();
            this.addqu = new System.Windows.Forms.TextBox();
            this.addpric = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Modify = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveMe
            // 
            this.SaveMe.Location = new System.Drawing.Point(15, 203);
            this.SaveMe.Name = "SaveMe";
            this.SaveMe.Size = new System.Drawing.Size(103, 33);
            this.SaveMe.TabIndex = 0;
            this.SaveMe.Text = "Save";
            this.SaveMe.UseVisualStyleBackColor = true;
            this.SaveMe.Click += new System.EventHandler(this.SaveMe_Click);
            // 
            // addname
            // 
            this.addname.Location = new System.Drawing.Point(141, 26);
            this.addname.Name = "addname";
            this.addname.Size = new System.Drawing.Size(131, 20);
            this.addname.TabIndex = 1;
            // 
            // addDes
            // 
            this.addDes.Location = new System.Drawing.Point(141, 66);
            this.addDes.Name = "addDes";
            this.addDes.Size = new System.Drawing.Size(131, 20);
            this.addDes.TabIndex = 2;
            // 
            // addqu
            // 
            this.addqu.Location = new System.Drawing.Point(141, 106);
            this.addqu.Name = "addqu";
            this.addqu.Size = new System.Drawing.Size(131, 20);
            this.addqu.TabIndex = 3;
            // 
            // addpric
            // 
            this.addpric.Location = new System.Drawing.Point(141, 144);
            this.addpric.Name = "addpric";
            this.addpric.Size = new System.Drawing.Size(131, 20);
            this.addpric.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medicine name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(169, 203);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(103, 33);
            this.Modify.TabIndex = 9;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(92, 257);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 33);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // addMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addpric);
            this.Controls.Add(this.addqu);
            this.Controls.Add(this.addDes);
            this.Controls.Add(this.addname);
            this.Controls.Add(this.SaveMe);
            this.Name = "addMed";
            this.Text = "addMed";
            this.Load += new System.EventHandler(this.addMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveMe;
        private System.Windows.Forms.TextBox addname;
        private System.Windows.Forms.TextBox addDes;
        private System.Windows.Forms.TextBox addqu;
        private System.Windows.Forms.TextBox addpric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Back;
    }
}