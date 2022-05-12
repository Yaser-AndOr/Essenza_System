using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }
        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            if (Listas.buscar != -1)
            {
                Codigo.Text = Listas.Codigo[Listas.buscar];
                Precio.Text = Listas.Precio[Listas.buscar];
                Nombre.Text = Listas.Nombre[Listas.buscar];
            }
            Continuar.BackColor = Color.FromArgb(232, 31, 118);
            Continuar.ForeColor = Color.FromArgb(10, 34, 64);
            L1.ForeColor = Color.FromArgb(232, 31, 118);
            L2.ForeColor = Color.FromArgb(232, 31, 118);
            L3.ForeColor = Color.FromArgb(232, 31, 118);
            this.BackColor = Color.FromArgb(10, 34, 64);
        }
        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Continuar_Click(object sender, EventArgs e)
        {
            if (Codigo.Text.Trim() != "" && Nombre.Text.Trim() != "" && Precio.Text.Trim() != "")
            {
                if (Listas.buscar == -1)
                {
                    if (Listas.Codigo.IndexOf(Codigo.Text.Trim()) == -1)
                    {
                        Listas.Codigo.Add(Codigo.Text);
                        Listas.Precio.Add(Precio.Text);
                        Listas.Nombre.Add(Nombre.Text);
                        String nuevo = $"{Codigo.Text.Trim()},{Nombre.Text.Trim()},{Precio.Text.Trim()}";
                        csv.escribir($"{csv.raiz}\\Data\\Productos\\Productos", nuevo);
                    }
                    else
                        MessageBox.Show("Este código ya fue registrado");
                }
                else
                {
                    if (Listas.Codigo.IndexOf(Codigo.Text.Trim()) == -1)
                    {
                        Listas.Codigo[Listas.buscar] = Codigo.Text;
                        Listas.Precio[Listas.buscar] = Precio.Text;
                        Listas.Nombre[Listas.buscar] = Nombre.Text;
                        String actualizar = "";
                        for (int x = 0; x < Listas.Nombre.Count; x++)
                        {
                            actualizar += $"{Listas.Codigo[x]},{Listas.Nombre[x]},{Listas.Precio[x]}\n";
                        }
                        csv.reescribir($"{csv.raiz}\\Data\\Productos\\Productos", actualizar);
                    }
                    else
                        MessageBox.Show("Este código ya fue registrado");
                }
            }
            this.Hide();
        }
    }
}