using SkipBo.Core;

namespace SkipBo.Gui
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
            this.spielerControl2 = new SkipBo.Core.SpielerControl();
            this.stapelControl1 = new SkipBo.Core.StapelControl();
            this.spielerControl1 = new SkipBo.Core.SpielerControl();
            this.SuspendLayout();
            // 
            // spielerControl2
            // 
            this.spielerControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.spielerControl2.Location = new System.Drawing.Point(222, 10);
            this.spielerControl2.Margin = new System.Windows.Forms.Padding(2);
            this.spielerControl2.MinimumSize = new System.Drawing.Size(172, 244);
            this.spielerControl2.Name = "spielerControl2";
            this.spielerControl2.Size = new System.Drawing.Size(209, 309);
            this.spielerControl2.TabIndex = 20;
            // 
            // stapelControl1
            // 
            this.stapelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stapelControl1.Location = new System.Drawing.Point(436, 10);
            this.stapelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.stapelControl1.Name = "stapelControl1";
            this.stapelControl1.Size = new System.Drawing.Size(206, 309);
            this.stapelControl1.TabIndex = 19;
            // 
            // spielerControl1
            // 
            this.spielerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.spielerControl1.Location = new System.Drawing.Point(9, 10);
            this.spielerControl1.Margin = new System.Windows.Forms.Padding(2);
            this.spielerControl1.MinimumSize = new System.Drawing.Size(172, 244);
            this.spielerControl1.Name = "spielerControl1";
            this.spielerControl1.Size = new System.Drawing.Size(209, 309);
            this.spielerControl1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 330);
            this.Controls.Add(this.spielerControl2);
            this.Controls.Add(this.stapelControl1);
            this.Controls.Add(this.spielerControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Skip-Bo";
            this.ResumeLayout(false);

        }

        #endregion

        private SpielerControl spielerControl1;
        private StapelControl stapelControl1;
        private SpielerControl spielerControl2;
    }
}

