namespace Banco
{
    partial class frmCaixaEletronico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numValorSaque = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor do saque:";
            // 
            // numValorSaque
            // 
            this.numValorSaque.Location = new System.Drawing.Point(236, 171);
            this.numValorSaque.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numValorSaque.Name = "numValorSaque";
            this.numValorSaque.Size = new System.Drawing.Size(120, 20);
            this.numValorSaque.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldo.Location = new System.Drawing.Point(274, 85);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(67, 38);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo ";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 315);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numValorSaque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCaixaEletronico";
            this.Text = "Caixa Eletrônico";
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numValorSaque;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSaldo;
    }
}

