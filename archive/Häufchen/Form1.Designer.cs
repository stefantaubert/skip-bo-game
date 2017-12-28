namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Karte5 = new System.Windows.Forms.RadioButton();
            this.Karte4 = new System.Windows.Forms.RadioButton();
            this.Karte3 = new System.Windows.Forms.RadioButton();
            this.Karte2 = new System.Windows.Forms.RadioButton();
            this.Karte1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(573, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stapel mischen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Karten: 5";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stapel: 80 Karten";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Karte5);
            this.groupBox1.Controls.Add(this.Karte4);
            this.groupBox1.Controls.Add(this.Karte3);
            this.groupBox1.Controls.Add(this.Karte2);
            this.groupBox1.Controls.Add(this.Karte1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(556, 340);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spieler 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ablage";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(205, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 239);
            this.panel1.TabIndex = 22;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.Location = new System.Drawing.Point(7, 235);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 30);
            this.button8.TabIndex = 21;
            this.button8.Text = "in Ablage";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(7, 199);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 30);
            this.button6.TabIndex = 19;
            this.button6.Text = "Hinlegen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(5, 38);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(194, 21);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.Text = "Stapel Oben (noch 10)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Stapel";
            // 
            // Karte5
            // 
            this.Karte5.AutoSize = true;
            this.Karte5.Location = new System.Drawing.Point(5, 174);
            this.Karte5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Karte5.Name = "Karte5";
            this.Karte5.Size = new System.Drawing.Size(71, 21);
            this.Karte5.TabIndex = 14;
            this.Karte5.Text = "Karte5";
            this.Karte5.UseVisualStyleBackColor = true;
            this.Karte5.CheckedChanged += new System.EventHandler(this.Karte5_CheckedChanged);
            // 
            // Karte4
            // 
            this.Karte4.AutoSize = true;
            this.Karte4.Location = new System.Drawing.Point(5, 146);
            this.Karte4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Karte4.Name = "Karte4";
            this.Karte4.Size = new System.Drawing.Size(71, 21);
            this.Karte4.TabIndex = 14;
            this.Karte4.Text = "Karte4";
            this.Karte4.UseVisualStyleBackColor = true;
            this.Karte4.CheckedChanged += new System.EventHandler(this.Karte4_CheckedChanged);
            // 
            // Karte3
            // 
            this.Karte3.AutoSize = true;
            this.Karte3.Location = new System.Drawing.Point(5, 119);
            this.Karte3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Karte3.Name = "Karte3";
            this.Karte3.Size = new System.Drawing.Size(71, 21);
            this.Karte3.TabIndex = 14;
            this.Karte3.Text = "Karte3";
            this.Karte3.UseVisualStyleBackColor = true;
            this.Karte3.CheckedChanged += new System.EventHandler(this.Karte3_CheckedChanged);
            // 
            // Karte2
            // 
            this.Karte2.AutoSize = true;
            this.Karte2.Location = new System.Drawing.Point(5, 92);
            this.Karte2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Karte2.Name = "Karte2";
            this.Karte2.Size = new System.Drawing.Size(71, 21);
            this.Karte2.TabIndex = 14;
            this.Karte2.Text = "Karte2";
            this.Karte2.UseVisualStyleBackColor = true;
            this.Karte2.CheckedChanged += new System.EventHandler(this.Karte2_CheckedChanged);
            // 
            // Karte1
            // 
            this.Karte1.AutoSize = true;
            this.Karte1.Checked = true;
            this.Karte1.Location = new System.Drawing.Point(5, 65);
            this.Karte1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Karte1.Name = "Karte1";
            this.Karte1.Size = new System.Drawing.Size(71, 21);
            this.Karte1.TabIndex = 14;
            this.Karte1.TabStop = true;
            this.Karte1.Text = "Karte1";
            this.Karte1.UseVisualStyleBackColor = true;
            this.Karte1.CheckedChanged += new System.EventHandler(this.Karte1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 178);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Häufchen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Karte5;
        private System.Windows.Forms.RadioButton Karte4;
        private System.Windows.Forms.RadioButton Karte3;
        private System.Windows.Forms.RadioButton Karte2;
        private System.Windows.Forms.RadioButton Karte1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

