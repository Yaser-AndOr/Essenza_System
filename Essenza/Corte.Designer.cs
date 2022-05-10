
namespace ImpresionPDF
{
    partial class Corte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corte));
            this.Desde = new System.Windows.Forms.MonthCalendar();
            this.Hasta = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Diario = new System.Windows.Forms.CheckBox();
            this.Tiempo = new System.Windows.Forms.CheckBox();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.Obtener = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Desde
            // 
            this.Desde.Enabled = false;
            this.Desde.Location = new System.Drawing.Point(88, 39);
            this.Desde.Name = "Desde";
            this.Desde.TabIndex = 0;
            this.Desde.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Desde_DateChanged);
            // 
            // Hasta
            // 
            this.Hasta.Enabled = false;
            this.Hasta.Location = new System.Drawing.Point(354, 39);
            this.Hasta.Name = "Hasta";
            this.Hasta.TabIndex = 1;
            this.Hasta.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Hasta_DateChanged);
            // 
            // Diario
            // 
            this.Diario.AutoSize = true;
            this.Diario.Location = new System.Drawing.Point(12, 57);
            this.Diario.Name = "Diario";
            this.Diario.Size = new System.Drawing.Size(53, 17);
            this.Diario.TabIndex = 2;
            this.Diario.Text = "Diario";
            this.Diario.UseVisualStyleBackColor = true;
            this.Diario.CheckedChanged += new System.EventHandler(this.Diario_CheckedChanged);
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSize = true;
            this.Tiempo.Location = new System.Drawing.Point(12, 144);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(61, 17);
            this.Tiempo.TabIndex = 3;
            this.Tiempo.Text = "Tiempo";
            this.Tiempo.UseVisualStyleBackColor = true;
            this.Tiempo.CheckedChanged += new System.EventHandler(this.Tiempo_CheckedChanged);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(187, 17);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(38, 13);
            this.L1.TabIndex = 4;
            this.L1.Text = "Desde";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(455, 17);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(35, 13);
            this.L2.TabIndex = 5;
            this.L2.Text = "Hasta";
            // 
            // Obtener
            // 
            this.Obtener.Location = new System.Drawing.Point(87, 213);
            this.Obtener.Name = "Obtener";
            this.Obtener.Size = new System.Drawing.Size(415, 28);
            this.Obtener.TabIndex = 6;
            this.Obtener.Text = "Obtener";
            this.Obtener.UseVisualStyleBackColor = true;
            this.Obtener.Click += new System.EventHandler(this.Obtener_Click);
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Red;
            this.Atras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Atras.Location = new System.Drawing.Point(508, 210);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(94, 31);
            this.Atras.TabIndex = 33;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 254);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Obtener);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.Diario);
            this.Controls.Add(this.Hasta);
            this.Controls.Add(this.Desde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Corte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Corte_FormClosing);
            this.Load += new System.EventHandler(this.Corte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Desde;
        private System.Windows.Forms.MonthCalendar Hasta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox Diario;
        private System.Windows.Forms.CheckBox Tiempo;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Button Obtener;
        private System.Windows.Forms.Button Atras;
    }
}