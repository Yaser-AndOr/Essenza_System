using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text.Trim() != "" && Correo.Text.Trim() != "" && Numero.Text.Trim() != "")
            {
                if (Listas.buscar == -1)
                {
                    if (Listas.NumeroCliente.IndexOf(Numero.Text.Trim()) == -1)
                    {
                        if (Listas.CorreoCliente.IndexOf(Correo.Text.Trim()) == -1)
                        {
                            Listas.NombreCliente.Add(Nombre.Text);
                            Listas.NumeroCliente.Add(Numero.Text);
                            Listas.CorreoCliente.Add(Correo.Text);
                            String nuevo = $"{Nombre.Text.Trim()},{Numero.Text.Trim()},{Correo.Text.Trim()}";
                            csv.escribir($"{csv.raiz}\\Data\\Clientes\\Clientes", nuevo);
                        }
                        else
                            MessageBox.Show("Este correo electrónico ya fue registrado");
                    }
                    else
                        MessageBox.Show("Este número de teléfono ya fue registrado");
                }
                else
                {
                    Listas.NombreCliente[Listas.buscar] = Nombre.Text;
                    Listas.NumeroCliente[Listas.buscar] = Numero.Text;
                    Listas.CorreoCliente[Listas.buscar] = Correo.Text;
                    String actualizar = "";
                    for (int x = 0; x < Listas.NombreCliente.Count; x++)
                    {
                        actualizar += $"{Listas.NombreCliente[x]},{Listas.NumeroCliente[x]},{Listas.CorreoCliente[x]}\n";
                    }
                    csv.reescribir($"{csv.raiz}\\Data\\Clientes\\Clientes", actualizar);
                }
            }
            this.Hide();
        }
        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            if (Listas.buscar != -1)
            {
                Nombre.Text = Listas.NombreCliente[Listas.buscar];
                Numero.Text = Listas.NumeroCliente[Listas.buscar];
                Correo.Text = Listas.CorreoCliente[Listas.buscar];
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
        private void AgregarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}