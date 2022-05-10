
namespace ImpresionPDF
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.Atras = new System.Windows.Forms.Button();
            this.Continuar = new System.Windows.Forms.Button();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.L3 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Red;
            this.Atras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Atras.Location = new System.Drawing.Point(12, 116);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(96, 33);
            this.Atras.TabIndex = 41;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Continuar
            // 
            this.Continuar.Location = new System.Drawing.Point(114, 116);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(224, 33);
            this.Continuar.TabIndex = 40;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(118, 84);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(105, 20);
            this.Precio.TabIndex = 39;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(118, 46);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(220, 20);
            this.Nombre.TabIndex = 38;
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(118, 6);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(105, 20);
            this.Codigo.TabIndex = 37;
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(12, 86);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(77, 13);
            this.L3.TabIndex = 36;
            this.L3.Text = "Precio unitario:";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(12, 47);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(66, 13);
            this.L2.TabIndex = 35;
            this.L2.Text = "Descripción:";
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(12, 9);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(43, 13);
            this.L1.TabIndex = 34;
            this.L1.Text = "Código:";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 159);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Continuar;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L1;
    }
}