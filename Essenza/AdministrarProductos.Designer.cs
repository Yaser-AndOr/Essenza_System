
namespace ImpresionPDF
{
    partial class AdministrarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarProductos));
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripciongv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(573, 72);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(152, 54);
            this.Editar.TabIndex = 20;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(573, 132);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(152, 54);
            this.Eliminar.TabIndex = 19;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigogv,
            this.Descripciongv,
            this.Preciogv});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 346);
            this.dataGridView1.TabIndex = 18;
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
            this.Descripciongv.Width = 276;
            // 
            // Preciogv
            // 
            this.Preciogv.HeaderText = "Precio";
            this.Preciogv.Name = "Preciogv";
            this.Preciogv.ReadOnly = true;
            this.Preciogv.Width = 90;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(573, 12);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(152, 54);
            this.Agregar.TabIndex = 17;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Red;
            this.Atras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Atras.Location = new System.Drawing.Point(629, 325);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(96, 33);
            this.Atras.TabIndex = 34;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // AdministrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarProductos";
            this.Activated += new System.EventHandler(this.AdministrarProductos_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministrarProductos_FormClosing);
            this.Load += new System.EventHandler(this.AdministrarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripciongv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciogv;
    }
}