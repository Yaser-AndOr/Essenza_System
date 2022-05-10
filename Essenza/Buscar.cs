using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }
        private int busqueda(String comprobar, String buscar)
        {
            buscar = buscar.ToUpper();
            comprobar = comprobar.ToUpper();
            int existe = 0;
            List<int> coincidencias = new List<int>();
            foreach (var letra in buscar)
            {
                int x = comprobar.IndexOf(letra);
                coincidencias.Add(x);
            }
            if (coincidencias.IndexOf(-1) == -1)
                existe = 1;
            return existe;
        }
        private void NombreProducto_TextChanged(object sender, EventArgs e)
        {
            List<String> listabuscada = new List<String>();
            if (Listas.buscar == 1)
                listabuscada = Listas.Nombre;
            if (Listas.buscar == 2)
                listabuscada = Listas.NombreCliente;
            if (Listas.buscar == 3)
                listabuscada = Listas.NEmp;

            List<String> productos = new List<String>();
            int found = 0, revisado = 0;
            foreach (var revision in listabuscada)
            {
                revision.ToUpper();
                NombreProducto.Text.ToUpper();
                found = busqueda(revision, NombreProducto.Text);
                if (found == 1)
                {
                    String coincide = "";
                    if (Listas.buscar == 1)
                        coincide = $"{Listas.Codigo[revisado]},{Listas.Nombre[revisado]},${Listas.Precio[revisado]}";
                    if (Listas.buscar == 2)
                        coincide = $"{Listas.NombreCliente[revisado]},{Listas.NumeroCliente[revisado]},{Listas.CorreoCliente[revisado]}";
                    if (Listas.buscar == 3)
                        coincide = $"{Listas.NEmp[revisado]} {Listas.AEmp[revisado]},{Listas.CEmp[revisado]}";
                    productos.Add(coincide);
                }
                revisado++;
            }
            if (productos.Count == 0)
            {
                ProductoCompleto.Text = "";
            }
            ProductoCompleto.DataSource = productos;
        }
        private void Continuar_Click(object sender, EventArgs e)
        {
            Listas.Buscado = ("" + ProductoCompleto.SelectedItem).Split(',')[0];
            this.Hide();
        }
        private void Buscar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(10, 34, 64);
            L1.ForeColor = Color.FromArgb(232, 31, 118);
            Continuar.BackColor = Color.FromArgb(232, 31, 118);
            switch (Listas.buscar)
            {
                case 1:
                    L1.Text = "Nombre del producto:";
                    break;
                case 2:
                    L1.Text = "Nombre del cliente:";
                    break;
                case 3:
                    L1.Text = "Atiende:";
                    break;
            }
        }
        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}