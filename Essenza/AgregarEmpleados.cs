using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class AgregarEmpleados : Form
    {
        public AgregarEmpleados()
        {
            InitializeComponent();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text.Trim() != "" && Apellido.Text.Trim() != "" && Codigo.Text.Trim() != "")
            {
                if (Listas.buscar == -1)
                {
                    if (Listas.CEmp.IndexOf(Codigo.Text.Trim()) == -1)
                    {
                        Listas.NEmp.Add(Nombre.Text);
                        Listas.CEmp.Add(Codigo.Text);
                        Listas.AEmp.Add(Apellido.Text);
                        Listas.Pass.Add(Password.Text);
                        String nuevo = $"{Nombre.Text.Trim()},{Apellido.Text.Trim()},{Codigo.Text.Trim()},{Password.Text.Trim()}";
                        csv.escribir($"{csv.raiz}\\Data\\Login\\Login", nuevo);
                    }
                    else
                        MessageBox.Show("Este código ya fue registrado");
                }
                else
                {
                    if (Listas.CEmp.IndexOf(Codigo.Text.Trim()) == -1)
                    {
                        Listas.NEmp[Listas.buscar] = Nombre.Text;
                        Listas.AEmp[Listas.buscar] = Apellido.Text;
                        Listas.CEmp[Listas.buscar] = Codigo.Text;
                        Listas.Pass[Listas.buscar] = Password.Text;
                        String actualizar = "";
                        for (int x = 0; x < Listas.NombreCliente.Count; x++)
                        {
                            actualizar += $"{Listas.NEmp[x]},{Listas.AEmp[x]},{Listas.CEmp[x]},{Listas.Pass[x]}\n";
                        }
                        csv.reescribir($"{csv.raiz}\\Data\\Login\\Login", actualizar);
                    }
                    else
                        MessageBox.Show("Este código ya fue registrado");
                }
            }
            this.Hide();
        }
        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void AgregarEmpleados_Load_1(object sender, EventArgs e)
        {
            if (Listas.buscar != -1)
            {
                Nombre.Text = Listas.NEmp[Listas.buscar];
                Codigo.Text = Listas.Codigo[Listas.buscar];
                Apellido.Text = Listas.AEmp[Listas.buscar];
                Password.Text = Listas.Pass[Listas.buscar];
            }
            Continuar.BackColor = Color.FromArgb(232, 31, 118);
            Continuar.ForeColor = Color.FromArgb(10, 34, 64);
            L1.ForeColor = Color.FromArgb(232, 31, 118);
            L2.ForeColor = Color.FromArgb(232, 31, 118);
            L3.ForeColor = Color.FromArgb(232, 31, 118);
            L4.ForeColor = Color.FromArgb(232, 31, 118);
            this.BackColor = Color.FromArgb(10, 34, 64);
        }
    }
}