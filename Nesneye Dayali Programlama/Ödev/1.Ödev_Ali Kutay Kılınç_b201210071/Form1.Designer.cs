
namespace _1.Ödev_Ali_Kutay_Kılınç_b201210071
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnArkadas = new System.Windows.Forms.Button();
            this.btnSon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(76, 50);
            this.txtSayi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(110, 23);
            this.txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(76, 107);
            this.txtSayi2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(110, 23);
            this.txtSayi2.TabIndex = 3;
            // 
            // btnArkadas
            // 
            this.btnArkadas.AutoSize = true;
            this.btnArkadas.Location = new System.Drawing.Point(27, 178);
            this.btnArkadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArkadas.Name = "btnArkadas";
            this.btnArkadas.Size = new System.Drawing.Size(88, 25);
            this.btnArkadas.TabIndex = 4;
            this.btnArkadas.Text = "Arkadaş mı?";
            this.btnArkadas.UseVisualStyleBackColor = true;
            this.btnArkadas.Click += new System.EventHandler(this.btnArkadas_Click);
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(120, 178);
            this.btnSon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(82, 22);
            this.btnSon.TabIndex = 5;
            this.btnSon.Text = "SON";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 227);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.btnArkadas);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnArkadas;
        private System.Windows.Forms.Button btnSon;
    }
}

