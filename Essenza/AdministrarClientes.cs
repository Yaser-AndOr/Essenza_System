using System;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class AdministrarClientes : Form
    {
        public AdministrarClientes()
        {
            InitializeComponent();
        }
        private void dgvfull()
        {
            int fila = 0;
            foreach (var llenar in Listas.NombreCliente)
            {
                dataGridView1[0, fila].Value = Listas.NombreCliente[fila];
                dataGridView1[1, fila].Value = Listas.NumeroCliente[fila];
                dataGridView1[2, fila].Value = Listas.CorreoCliente[fila];
                fila++;
            }
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Listas.buscar = -1;
            AgregarCliente aggc = new AgregarCliente();
            aggc.Show();
        }
        private void AdministrarClientes_Activated(object sender, EventArgs e)
        {
            if (Listas.buscar == -1)
                dataGridView1.Rows.Add();
            dgvfull();
            Listas.Buscado = "";
            Listas.buscar = 0;
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Listas.buscar = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
                AgregarCliente aggc = new AgregarCliente();
                aggc.Show();
            }
            catch
            {
                MessageBox.Show("Seleccione un cliente a modificar");
            }
        }
        private void AdministrarClientes_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < Listas.NombreCliente.Count; x++)
                dataGridView1.Rows.Add();
            dgvfull();
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Listas.NombreCliente.Count > 1)
            {
                try
                {
                    int del = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
                    Listas.DelCl(del);
                    dataGridView1.Rows.Remove(dataGridView1.Rows[del]);
                    String actualizar = "";
                    for (int x = 0; x < Listas.NombreCliente.Count; x++)
                    {
                        actualizar += $"{Listas.NombreCliente[x]},{Listas.NumeroCliente[x]},{Listas.CorreoCliente[x]}\n";
                    }
                    csv.reescribir($"{csv.raiz}\\Data\\Clientes\\Clientes", actualizar);
                    dgvfull();
                }
                catch
                {
                    MessageBox.Show("Seleccione un producto a eliminar");
                }
            }
            else
                MessageBox.Show("No puede haber menos de un cliente");

        }
        private void Atras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void AdministrarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}