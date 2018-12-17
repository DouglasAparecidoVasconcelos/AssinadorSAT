namespace AssinadorSatA1Doug
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAssinar = new System.Windows.Forms.Button();
            this.txtAssinatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoftwareHouse = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAssinar
            // 
            this.btnAssinar.Location = new System.Drawing.Point(424, 27);
            this.btnAssinar.Name = "btnAssinar";
            this.btnAssinar.Size = new System.Drawing.Size(82, 34);
            this.btnAssinar.TabIndex = 0;
            this.btnAssinar.Text = "Assinar";
            this.btnAssinar.UseVisualStyleBackColor = true;
            this.btnAssinar.Click += new System.EventHandler(this.btnAssinar_Click);
            // 
            // txtAssinatura
            // 
            this.txtAssinatura.Location = new System.Drawing.Point(12, 76);
            this.txtAssinatura.Multiline = true;
            this.txtAssinatura.Name = "txtAssinatura";
            this.txtAssinatura.Size = new System.Drawing.Size(506, 121);
            this.txtAssinatura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CNPJ Software House:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNPJ Cliente:";
            // 
            // txtSoftwareHouse
            // 
            this.txtSoftwareHouse.Location = new System.Drawing.Point(131, 24);
            this.txtSoftwareHouse.Name = "txtSoftwareHouse";
            this.txtSoftwareHouse.Size = new System.Drawing.Size(96, 20);
            this.txtSoftwareHouse.TabIndex = 4;
            this.txtSoftwareHouse.Text = "15288349000148";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(131, 50);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(96, 20);
            this.txtCliente.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 212);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtSoftwareHouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAssinatura);
            this.Controls.Add(this.btnAssinar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Assinador Sat A1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssinar;
        private System.Windows.Forms.TextBox txtAssinatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoftwareHouse;
        private System.Windows.Forms.TextBox txtCliente;
    }
}

