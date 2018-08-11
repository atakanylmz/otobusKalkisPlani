namespace yapayZekaProje
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
            this.tarihCmb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ogleRBtn = new System.Windows.Forms.RadioButton();
            this.aksamRBtn = new System.Windows.Forms.RadioButton();
            this.sabahRBtn = new System.Windows.Forms.RadioButton();
            this.gosterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarihCmb
            // 
            this.tarihCmb.FormattingEnabled = true;
            this.tarihCmb.Location = new System.Drawing.Point(69, 56);
            this.tarihCmb.Name = "tarihCmb";
            this.tarihCmb.Size = new System.Drawing.Size(157, 21);
            this.tarihCmb.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.ogleRBtn);
            this.groupBox1.Controls.Add(this.aksamRBtn);
            this.groupBox1.Controls.Add(this.sabahRBtn);
            this.groupBox1.Controls.Add(this.gosterBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tarihCmb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ EKRANI";
            // 
            // ogleRBtn
            // 
            this.ogleRBtn.AutoSize = true;
            this.ogleRBtn.Location = new System.Drawing.Point(97, 114);
            this.ogleRBtn.Name = "ogleRBtn";
            this.ogleRBtn.Size = new System.Drawing.Size(45, 17);
            this.ogleRBtn.TabIndex = 5;
            this.ogleRBtn.TabStop = true;
            this.ogleRBtn.Text = "öğle";
            this.ogleRBtn.UseVisualStyleBackColor = true;
            // 
            // aksamRBtn
            // 
            this.aksamRBtn.AutoSize = true;
            this.aksamRBtn.Location = new System.Drawing.Point(170, 114);
            this.aksamRBtn.Name = "aksamRBtn";
            this.aksamRBtn.Size = new System.Drawing.Size(56, 17);
            this.aksamRBtn.TabIndex = 4;
            this.aksamRBtn.TabStop = true;
            this.aksamRBtn.Text = "akşam";
            this.aksamRBtn.UseVisualStyleBackColor = true;
            // 
            // sabahRBtn
            // 
            this.sabahRBtn.AutoSize = true;
            this.sabahRBtn.Checked = true;
            this.sabahRBtn.Location = new System.Drawing.Point(16, 114);
            this.sabahRBtn.Name = "sabahRBtn";
            this.sabahRBtn.Size = new System.Drawing.Size(54, 17);
            this.sabahRBtn.TabIndex = 3;
            this.sabahRBtn.TabStop = true;
            this.sabahRBtn.Text = "sabah";
            this.sabahRBtn.UseVisualStyleBackColor = true;
            // 
            // gosterBtn
            // 
            this.gosterBtn.Location = new System.Drawing.Point(72, 158);
            this.gosterBtn.Name = "gosterBtn";
            this.gosterBtn.Size = new System.Drawing.Size(94, 36);
            this.gosterBtn.TabIndex = 2;
            this.gosterBtn.Text = "GÖSTER";
            this.gosterBtn.UseVisualStyleBackColor = true;
            this.gosterBtn.Click += new System.EventHandler(this.gosterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TARİH:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(250, 400);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "OTOBÜS KALKIŞ SAATİ OLUŞTURMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox tarihCmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button gosterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton ogleRBtn;
        private System.Windows.Forms.RadioButton aksamRBtn;
        private System.Windows.Forms.RadioButton sabahRBtn;
    }
}

