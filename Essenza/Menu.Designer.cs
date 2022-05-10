
namespace ImpresionPDF
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Facturar = new System.Windows.Forms.Button();
            this.Cortar = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.Button();
            this.Empleados = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Facturar
            // 
            this.Facturar.Location = new System.Drawing.Point(12, 12);
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(127, 32);
            this.Facturar.TabIndex = 0;
            this.Facturar.Text = "Facturación";
            this.Facturar.UseVisualStyleBackColor = true;
            this.Facturar.Click += new System.EventHandler(this.Facturar_Click);
            // 
            // Cortar
            // 
            this.Cortar.Location = new System.Drawing.Point(12, 56);
            this.Cortar.Name = "Cortar";
            this.Cortar.Size = new System.Drawing.Size(127, 32);
            this.Cortar.TabIndex = 1;
            this.Cortar.Text = "Corte";
            this.Cortar.UseVisualStyleBackColor = true;
            this.Cortar.Click += new System.EventHandler(this.Cortar_Click);
            // 
            // Clientes
            // 
            this.Clientes.Location = new System.Drawing.Point(12, 141);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(127, 32);
            this.Clientes.TabIndex = 2;
            this.Clientes.Text = "Administrar Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Productos
            // 
            this.Productos.Location = new System.Drawing.Point(12, 97);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(127, 32);
            this.Productos.TabIndex = 3;
            this.Productos.Text = "Administrar productos";
            this.Productos.UseVisualStyleBackColor = true;
            this.Productos.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // Empleados
            // 
            this.Empleados.Location = new System.Drawing.Point(12, 184);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(127, 32);
            this.Empleados.TabIndex = 4;
            this.Empleados.Text = "Administrar Empleados";
            this.Empleados.UseVisualStyleBackColor = true;
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(204, 173);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(292, 39);
            this.L1.TabIndex = 13;
            this.L1.Text = "Resaltamos tu belleza";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 230);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Empleados);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.Cortar);
            this.Controls.Add(this.Facturar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Eleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Facturar;
        private System.Windows.Forms.Button Cortar;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Button Empleados;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}