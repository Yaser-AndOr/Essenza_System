
namespace ImpresionPDF
{
    partial class Facturar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturar));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Print = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.CodigoProducto = new System.Windows.Forms.TextBox();
            this.NombreProducto = new System.Windows.Forms.TextBox();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripciongv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.Button();
            this.L4 = new System.Windows.Forms.Label();
            this.PrecioUnitario = new System.Windows.Forms.TextBox();
            this.BuscarPr = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BuscarPe = new System.Windows.Forms.Button();
            this.NumeroCl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreCl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Efectivo = new System.Windows.Forms.CheckBox();
            this.Tarjeta = new System.Windows.Forms.CheckBox();
            this.Atras = new System.Windows.Forms.Button();
            this.Cupon = new System.Windows.Forms.CheckBox();
            this.Transferencia = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(724, 450);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(205, 54);
            this.Print.TabIndex = 0;
            this.Print.Text = "Imprimir";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(12, 158);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(105, 13);
            this.L1.TabIndex = 1;
            this.L1.Text = "Código del producto:";
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.Location = new System.Drawing.Point(123, 155);
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Size = new System.Drawing.Size(65, 20);
            this.CodigoProducto.TabIndex = 2;
            this.CodigoProducto.TextChanged += new System.EventHandler(this.CodigoProducto_TextChanged);
            this.CodigoProducto.Enter += new System.EventHandler(this.regreso);
            // 
            // NombreProducto
            // 
            this.NombreProducto.Enabled = false;
            this.NombreProducto.Location = new System.Drawing.Point(309, 155);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Size = new System.Drawing.Size(238, 20);
            this.NombreProducto.TabIndex = 3;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(194, 158);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(109, 13);
            this.L2.TabIndex = 6;
            this.L2.Text = "Nombre del producto:";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(553, 158);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(74, 13);
            this.L3.TabIndex = 8;
            this.L3.Text = "Precio unitario";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(724, 195);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(205, 54);
            this.Agregar.TabIndex = 10;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigogv,
            this.Descripciongv,
            this.Preciogv,
            this.Cantidadgv});
            this.dataGridView1.Location = new System.Drawing.Point(18, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 358);
            this.dataGridView1.TabIndex = 11;
            // 
            // Codigogv
            // 
            this.Codigogv.HeaderText = "Código";
            this.Codigogv.Name = "Codigogv";
            this.Codigogv.ReadOnly = true;
            this.Codigogv.Width = 146;
            // 
            // Descripciongv
            // 
            this.Descripciongv.HeaderText = "Descripción";
            this.Descripciongv.Name = "Descripciongv";
            this.Descripciongv.ReadOnly = true;
            this.Descripciongv.Width = 220;
            // 
            // Preciogv
            // 
            this.Preciogv.HeaderText = "Precio Unitario";
            this.Preciogv.Name = "Preciogv";
            this.Preciogv.ReadOnly = true;
            this.Preciogv.Width = 146;
            // 
            // Cantidadgv
            // 
            this.Cantidadgv.HeaderText = "Cantidad";
            this.Cantidadgv.Name = "Cantidadgv";
            this.Cantidadgv.ReadOnly = true;
            this.Cantidadgv.Width = 145;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(724, 273);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(205, 54);
            this.Eliminar.TabIndex = 12;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Location = new System.Drawing.Point(699, 158);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(49, 13);
            this.L4.TabIndex = 15;
            this.L4.Text = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.Enabled = false;
            this.PrecioUnitario.Location = new System.Drawing.Point(633, 155);
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Size = new System.Drawing.Size(60, 20);
            this.PrecioUnitario.TabIndex = 14;
            // 
            // BuscarPr
            // 
            this.BuscarPr.Location = new System.Drawing.Point(814, 149);
            this.BuscarPr.Name = "BuscarPr";
            this.BuscarPr.Size = new System.Drawing.Size(115, 30);
            this.BuscarPr.TabIndex = 16;
            this.BuscarPr.Text = "Buscar Producto";
            this.BuscarPr.UseVisualStyleBackColor = true;
            this.BuscarPr.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(754, 155);
            this.Cantidad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(37, 20);
            this.Cantidad.TabIndex = 17;
            this.Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cantidad.ValueChanged += new System.EventHandler(this.Cantidad_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // BuscarPe
            // 
            this.BuscarPe.Location = new System.Drawing.Point(814, 107);
            this.BuscarPe.Name = "BuscarPe";
            this.BuscarPe.Size = new System.Drawing.Size(115, 30);
            this.BuscarPe.TabIndex = 19;
            this.BuscarPe.Text = "Buscar Cliente";
            this.BuscarPe.UseVisualStyleBackColor = true;
            this.BuscarPe.Click += new System.EventHandler(this.BuscarPe_Click);
            // 
            // NumeroCl
            // 
            this.NumeroCl.Enabled = false;
            this.NumeroCl.Location = new System.Drawing.Point(473, 113);
            this.NumeroCl.Name = "NumeroCl";
            this.NumeroCl.ReadOnly = true;
            this.NumeroCl.Size = new System.Drawing.Size(102, 20);
            this.NumeroCl.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Número Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre cliente:";
            // 
            // NombreCl
            // 
            this.NombreCl.Enabled = false;
            this.NombreCl.Location = new System.Drawing.Point(99, 113);
            this.NombreCl.Name = "NombreCl";
            this.NombreCl.ReadOnly = true;
            this.NombreCl.Size = new System.Drawing.Size(288, 20);
            this.NombreCl.TabIndex = 26;
            this.NombreCl.TextChanged += new System.EventHandler(this.NombreCl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(789, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Método de pago:";
            // 
            // Efectivo
            // 
            this.Efectivo.AutoSize = true;
            this.Efectivo.Location = new System.Drawing.Point(726, 382);
            this.Efectivo.Name = "Efectivo";
            this.Efectivo.Size = new System.Drawing.Size(65, 17);
            this.Efectivo.TabIndex = 30;
            this.Efectivo.Text = "Efectivo";
            this.Efectivo.UseVisualStyleBackColor = true;
            this.Efectivo.CheckedChanged += new System.EventHandler(this.Efectivo_CheckedChanged);
            // 
            // Tarjeta
            // 
            this.Tarjeta.AutoSize = true;
            this.Tarjeta.Location = new System.Drawing.Point(724, 422);
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.Size = new System.Drawing.Size(59, 17);
            this.Tarjeta.TabIndex = 31;
            this.Tarjeta.Text = "Tarjeta";
            this.Tarjeta.UseVisualStyleBackColor = true;
            this.Tarjeta.CheckedChanged += new System.EventHandler(this.Tarjeta_CheckedChanged);
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Red;
            this.Atras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Atras.Location = new System.Drawing.Point(835, 522);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(94, 31);
            this.Atras.TabIndex = 32;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Cupon
            // 
            this.Cupon.AutoSize = true;
            this.Cupon.Location = new System.Drawing.Point(833, 382);
            this.Cupon.Name = "Cupon";
            this.Cupon.Size = new System.Drawing.Size(57, 17);
            this.Cupon.TabIndex = 33;
            this.Cupon.Text = "Cupón";
            this.Cupon.UseVisualStyleBackColor = true;
            this.Cupon.CheckedChanged += new System.EventHandler(this.Cupon_CheckedChanged);
            // 
            // Transferencia
            // 
            this.Transferencia.AutoSize = true;
            this.Transferencia.Location = new System.Drawing.Point(833, 422);
            this.Transferencia.Name = "Transferencia";
            this.Transferencia.Size = new System.Drawing.Size(91, 17);
            this.Transferencia.TabIndex = 34;
            this.Transferencia.Text = "Transferencia";
            this.Transferencia.UseVisualStyleBackColor = true;
            this.Transferencia.CheckedChanged += new System.EventHandler(this.Transferencia_CheckedChanged);
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 565);
            this.Controls.Add(this.Transferencia);
            this.Controls.Add(this.Cupon);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Tarjeta);
            this.Controls.Add(this.Efectivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreCl);
            this.Controls.Add(this.NumeroCl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarPe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.BuscarPr);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.PrecioUnitario);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.CodigoProducto);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.Print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar";
            this.Activated += new System.EventHandler(this.regreso);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox NombreProducto;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.TextBox PrecioUnitario;
        private System.Windows.Forms.Button BuscarPr;
        private System.Windows.Forms.NumericUpDown Cantidad;
        public System.Windows.Forms.TextBox CodigoProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BuscarPe;
        private System.Windows.Forms.TextBox NumeroCl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NombreCl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Efectivo;
        private System.Windows.Forms.CheckBox Tarjeta;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.CheckBox Cupon;
        private System.Windows.Forms.CheckBox Transferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripciongv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadgv;
    }
}

