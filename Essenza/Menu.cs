using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Eleccion_Load(object sender, EventArgs e)
        {
            Clientes.BackColor = Color.FromArgb(232, 31, 118);
            Clientes.ForeColor = Color.FromArgb(10, 34, 64);
            Empleados.BackColor = Color.FromArgb(232, 31, 118);
            Empleados.ForeColor = Color.FromArgb(10, 34, 64);
            Productos.BackColor = Color.FromArgb(232, 31, 118);
            Productos.ForeColor = Color.FromArgb(10, 34, 64);
            Cortar.BackColor = Color.FromArgb(232, 31, 118);
            Cortar.ForeColor = Color.FromArgb(10, 34, 64);
            Facturar.BackColor = Color.FromArgb(232, 31, 118);
            Facturar.ForeColor = Color.FromArgb(10, 34, 64);
            this.BackColor = Color.FromArgb(10, 34, 64);
        }
        private void Facturar_Click(object sender, EventArgs e)
        {
            Facturar facturar = new Facturar();
            facturar.Show();
            this.Hide();
        }
        private void Cortar_Click(object sender, EventArgs e)
        {
            Listas.inicio = 1;
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            AdministrarClientes agg = new AdministrarClientes();
            agg.Show();
            this.Hide();
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Inventario_Click(object sender, EventArgs e)
        {
            AdministrarProductos admpr = new AdministrarProductos();
            admpr.Show();
            this.Hide();
        }
        private void Empleados_Click(object sender, EventArgs e)
        {
            Listas.inicio = 2;
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}