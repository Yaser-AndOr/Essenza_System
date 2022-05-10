using System;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class AdministrarProductos : Form
    {
        public AdministrarProductos()
        {
            InitializeComponent();
        }
        private void dgvfull()
        {
            int fila = 0;
            foreach (var llenar in Listas.Nombre)
            {
                dataGridView1[0, fila].Value = Listas.Codigo[fila];
                dataGridView1[1, fila].Value = Listas.Nombre[fila];
                dataGridView1[2, fila].Value = Listas.Precio[fila];
                fila++;
            }
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Listas.buscar = -1;
            AgregarProducto aggp = new AgregarProducto();
            aggp.Show();
        }
        private void AdministrarProductos_Activated(object sender, EventArgs e)
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
                AgregarProducto aggp = new AgregarProducto();
                aggp.Show();
            }
            catch
            {
                MessageBox.Show("Seleccione un producto a modificar");
            }
        }
        private void AdministrarProductos_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < Listas.Nombre.Count; x++)
                dataGridView1.Rows.Add();
            dgvfull();
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Listas.Codigo.Count > 1)
            {
                try
                {
                    int del = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
                    Listas.DelPr(del);
                    dataGridView1.Rows.Remove(dataGridView1.Rows[del]);
                    String actualizar = "";
                    for (int x = 0; x < Listas.Nombre.Count; x++)
                    {
                        actualizar += $"{Listas.Codigo[x]},{Listas.Nombre[x]},{Listas.Precio[x]}\n";
                    }
                    MessageBox.Show(actualizar);
                    csv.reescribir($"{csv.raiz}\\Data\\Productos\\Productos", actualizar);
                    dgvfull();
                }
                catch
                {
                    MessageBox.Show("Seleccione un producto a eliminar");
                }
            }
            else
                MessageBox.Show("No puede haber menos de un producto");

        }
        private void Atras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void AdministrarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}