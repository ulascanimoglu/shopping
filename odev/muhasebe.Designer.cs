
namespace odev
{
    partial class muhasebe
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
            this.lblkazanc = new System.Windows.Forms.Label();
            this.lblkazancpara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkazanc
            // 
            this.lblkazanc.AutoSize = true;
            this.lblkazanc.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkazanc.Location = new System.Drawing.Point(129, 90);
            this.lblkazanc.Name = "lblkazanc";
            this.lblkazanc.Size = new System.Drawing.Size(129, 20);
            this.lblkazanc.TabIndex = 0;
            this.lblkazanc.Text = "Kazancınız : ";
            // 
            // lblkazancpara
            // 
            this.lblkazancpara.AutoSize = true;
            this.lblkazancpara.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkazancpara.Location = new System.Drawing.Point(319, 90);
            this.lblkazancpara.Name = "lblkazancpara";
            this.lblkazancpara.Size = new System.Drawing.Size(67, 20);
            this.lblkazancpara.TabIndex = 1;
            this.lblkazancpara.Text = "label2";
            // 
            // muhasebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 242);
            this.Controls.Add(this.lblkazancpara);
            this.Controls.Add(this.lblkazanc);
            this.Name = "muhasebe";
            this.Text = "muhasebe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkazanc;
        private System.Windows.Forms.Label lblkazancpara;
    }
}