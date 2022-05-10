
namespace ImpresionPDF
{
    partial class AdministrarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarClientes));
            this.Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombregv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numerogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correogv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(573, 132);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(152, 54);
            this.Eliminar.TabIndex = 15;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombregv,
            this.Numerogv,
            this.Correogv});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 346);
            this.dataGridView1.TabIndex = 14;
            // 
            // Nombregv
            // 
            this.Nombregv.HeaderText = "Nombre Completo";
            this.Nombregv.Name = "Nombregv";
            this.Nombregv.ReadOnly = true;
            this.Nombregv.Width = 220;
            // 
            // Numerogv
            // 
            this.Numerogv.HeaderText = "Número Telefónico";
            this.Numerogv.Name = "Numerogv";
            this.Numerogv.ReadOnly = true;
            this.Numerogv.Width = 146;
            // 
            // Correogv
            // 
            this.Correogv.HeaderText = "Correo Electrónico";
            this.Correogv.Name = "Correogv";
            this.Correogv.ReadOnly = true;
            this.Correogv.Width = 146;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(573, 12);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(152, 54);
            this.Agregar.TabIndex = 13;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(573, 72);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(152, 54);
            this.Editar.TabIndex = 16;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Red;
            this.Atras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Atras.Location = new System.Drawing.Point(629, 325);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(96, 33);
            this.Atras.TabIndex = 35;
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
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // AdministrarClientes
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
            this.Name = "AdministrarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Clientes";
            this.Activated += new System.EventHandler(this.AdministrarClientes_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministrarClientes_FormClosing);
            this.Load += new System.EventHandler(this.AdministrarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombregv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numerogv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correogv;
    }
}