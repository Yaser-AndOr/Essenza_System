
namespace ImpresionPDF
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.L1 = new System.Windows.Forms.Label();
            this.NombreProducto = new System.Windows.Forms.TextBox();
            this.ProductoCompleto = new System.Windows.Forms.ComboBox();
            this.Continuar = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(16, 15);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(109, 13);
            this.L1.TabIndex = 18;
            this.L1.Text = "Nombre del producto:";
            // 
            // NombreProducto
            // 
            this.NombreProducto.Location = new System.Drawing.Point(134, 12);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(220, 20);
            this.NombreProducto.TabIndex = 17;
            this.NombreProducto.TextChanged += new System.EventHandler(this.NombreProducto_TextChanged);
            // 
            // ProductoCompleto
            // 
            this.ProductoCompleto.FormattingEnabled = true;
            this.ProductoCompleto.Location = new System.Drawing.Point(19, 39);
            this.ProductoCompleto.Name = "ProductoCompleto";
            this.ProductoCompleto.Size = new System.Drawing.Size(335, 21);
            this.ProductoCompleto.TabIndex = 19;
            // 
            // Continuar
            // 
            this.Continuar.Location = new System.Drawing.Point(121, 66);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(233, 35);
            this.Continuar.TabIndex = 20;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Red;
            this.Atras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Atras.Location = new System.Drawing.Point(19, 68);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(96, 33);
            this.Atras.TabIndex = 34;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 113);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.ProductoCompleto);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.NombreProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox NombreProducto;
        private System.Windows.Forms.ComboBox ProductoCompleto;
        private System.Windows.Forms.Button Continuar;
        private System.Windows.Forms.Button Atras;
    }
}