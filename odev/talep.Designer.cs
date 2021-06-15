
namespace odev
{
    partial class talep
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
            this.isturun = new System.Windows.Forms.Label();
            this.istfiyat = new System.Windows.Forms.Label();
            this.istmiktar = new System.Windows.Forms.Label();
            this.cmbisturun = new System.Windows.Forms.ComboBox();
            this.txtboxistfiyat = new System.Windows.Forms.TextBox();
            this.txtboxistmiktar = new System.Windows.Forms.TextBox();
            this.btntalep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isturun
            // 
            this.isturun.AutoSize = true;
            this.isturun.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isturun.Location = new System.Drawing.Point(74, 80);
            this.isturun.Name = "isturun";
            this.isturun.Size = new System.Drawing.Size(176, 20);
            this.isturun.TabIndex = 0;
            this.isturun.Text = "İstediğiniz Ürün :";
            // 
            // istfiyat
            // 
            this.istfiyat.AutoSize = true;
            this.istfiyat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istfiyat.Location = new System.Drawing.Point(74, 134);
            this.istfiyat.Name = "istfiyat";
            this.istfiyat.Size = new System.Drawing.Size(177, 20);
            this.istfiyat.TabIndex = 1;
            this.istfiyat.Text = "İstediğiniz Fiyat :";
            // 
            // istmiktar
            // 
            this.istmiktar.AutoSize = true;
            this.istmiktar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istmiktar.Location = new System.Drawing.Point(74, 182);
            this.istmiktar.Name = "istmiktar";
            this.istmiktar.Size = new System.Drawing.Size(190, 20);
            this.istmiktar.TabIndex = 2;
            this.istmiktar.Text = "İstediğiniz Miktar :";
            // 
            // cmbisturun
            // 
            this.cmbisturun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbisturun.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbisturun.FormattingEnabled = true;
            this.cmbisturun.Items.AddRange(new object[] {
            "Arpa",
            "Buğday",
            "Bulgur",
            "Ekmek",
            "Pamuk",
            "Petrol",
            "Pirinç",
            "Su",
            "Yulaf"});
            this.cmbisturun.Location = new System.Drawing.Point(303, 80);
            this.cmbisturun.Name = "cmbisturun";
            this.cmbisturun.Size = new System.Drawing.Size(121, 28);
            this.cmbisturun.TabIndex = 3;
            // 
            // txtboxistfiyat
            // 
            this.txtboxistfiyat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxistfiyat.Location = new System.Drawing.Point(303, 134);
            this.txtboxistfiyat.Name = "txtboxistfiyat";
            this.txtboxistfiyat.Size = new System.Drawing.Size(121, 28);
            this.txtboxistfiyat.TabIndex = 4;
            // 
            // txtboxistmiktar
            // 
            this.txtboxistmiktar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxistmiktar.Location = new System.Drawing.Point(303, 182);
            this.txtboxistmiktar.Name = "txtboxistmiktar";
            this.txtboxistmiktar.Size = new System.Drawing.Size(121, 28);
            this.txtboxistmiktar.TabIndex = 5;
            // 
            // btntalep
            // 
            this.btntalep.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntalep.Location = new System.Drawing.Point(283, 238);
            this.btntalep.Name = "btntalep";
            this.btntalep.Size = new System.Drawing.Size(161, 66);
            this.btntalep.TabIndex = 6;
            this.btntalep.Text = "Talep Oluştur";
            this.btntalep.UseVisualStyleBackColor = true;
            this.btntalep.Click += new System.EventHandler(this.btntalep_Click);
            // 
            // talep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 369);
            this.Controls.Add(this.btntalep);
            this.Controls.Add(this.txtboxistmiktar);
            this.Controls.Add(this.txtboxistfiyat);
            this.Controls.Add(this.cmbisturun);
            this.Controls.Add(this.istmiktar);
            this.Controls.Add(this.istfiyat);
            this.Controls.Add(this.isturun);
            this.Name = "talep";
            this.Text = "talep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isturun;
        private System.Windows.Forms.Label istfiyat;
        private System.Windows.Forms.Label istmiktar;
        private System.Windows.Forms.ComboBox cmbisturun;
        private System.Windows.Forms.TextBox txtboxistfiyat;
        private System.Windows.Forms.TextBox txtboxistmiktar;
        private System.Windows.Forms.Button btntalep;
    }
}