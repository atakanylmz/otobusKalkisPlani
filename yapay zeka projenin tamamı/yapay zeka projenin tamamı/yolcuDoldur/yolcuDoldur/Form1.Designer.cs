namespace yolcuDoldur
{
    partial class Form1
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
            this.doldurBtn = new System.Windows.Forms.Button();
            this.bosalBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doldurBtn
            // 
            this.doldurBtn.Location = new System.Drawing.Point(116, 100);
            this.doldurBtn.Name = "doldurBtn";
            this.doldurBtn.Size = new System.Drawing.Size(75, 23);
            this.doldurBtn.TabIndex = 0;
            this.doldurBtn.Text = "doldur";
            this.doldurBtn.UseVisualStyleBackColor = true;
            this.doldurBtn.Click += new System.EventHandler(this.doldurBtn_Click);
            // 
            // bosalBtn
            // 
            this.bosalBtn.Location = new System.Drawing.Point(279, 100);
            this.bosalBtn.Name = "bosalBtn";
            this.bosalBtn.Size = new System.Drawing.Size(75, 23);
            this.bosalBtn.TabIndex = 1;
            this.bosalBtn.Text = "boşalt";
            this.bosalBtn.UseVisualStyleBackColor = true;
            this.bosalBtn.Click += new System.EventHandler(this.bosalBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(265, 158);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 2;
            this.testBtn.Text = "test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 339);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.bosalBtn);
            this.Controls.Add(this.doldurBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doldurBtn;
        private System.Windows.Forms.Button bosalBtn;
        private System.Windows.Forms.Button testBtn;
    }
}

