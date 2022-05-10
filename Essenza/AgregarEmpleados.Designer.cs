
namespace ImpresionPDF
{
    partial class AgregarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleados));
            this.Atras = new System.Windows.Forms.Button();
            this.Continuar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.L3 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.L4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Red;
            this.Atras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Atras.Location = new System.Drawing.Point(12, 170);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(96, 34);
            this.Atras.TabIndex = 41;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Continuar
            // 
            this.Continuar.Location = new System.Drawing.Point(115, 170);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(231, 34);
            this.Continuar.TabIndex = 40;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(119, 90);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(105, 20);
            this.Codigo.TabIndex = 39;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(119, 52);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(227, 20);
            this.Apellido.TabIndex = 38;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(119, 12);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(227, 20);
            this.Nombre.TabIndex = 37;
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(13, 92);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(43, 13);
            this.L3.TabIndex = 36;
            this.L3.Text = "Código:";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(13, 53);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(47, 13);
            this.L2.TabIndex = 35;
            this.L2.Text = "Apellido:";
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(13, 15);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(47, 13);
            this.L1.TabIndex = 34;
            this.L1.Text = "Nombre:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(119, 132);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(227, 20);
            this.Password.TabIndex = 43;
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Location = new System.Drawing.Point(13, 134);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(64, 13);
            this.L4.TabIndex = 42;
            this.L4.Text = "Contraseña:";
            // 
            // AgregarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 216);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEmpleados";
            this.Load += new System.EventHandler(this.AgregarEmpleados_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Continuar;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label L4;
    }
}