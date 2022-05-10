
namespace ImpresionPDF
{
    partial class AgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Continuar = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(12, 9);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(94, 13);
            this.L1.TabIndex = 0;
            this.L1.Text = "Nombre Completo:";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(12, 47);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(96, 13);
            this.L2.TabIndex = 1;
            this.L2.Text = "Correo electrónico:";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(12, 86);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(100, 13);
            this.L3.TabIndex = 2;
            this.L3.Text = "Número Telefónico:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(118, 6);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(266, 20);
            this.Nombre.TabIndex = 3;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(118, 46);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(198, 20);
            this.Correo.TabIndex = 4;
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(118, 84);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(105, 20);
            this.Numero.TabIndex = 5;
            // 
            // Continuar
            // 
            this.Continuar.Location = new System.Drawing.Point(114, 116);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(270, 33);
            this.Continuar.TabIndex = 6;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Red;
            this.Atras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Atras.Location = new System.Drawing.Point(12, 116);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(96, 33);
            this.Atras.TabIndex = 33;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 161);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarCliente_FormClosing);
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.Button Continuar;
        private System.Windows.Forms.Button Atras;
    }
}