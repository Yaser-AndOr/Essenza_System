using System;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class AdministrarEmpleados : Form
    {
        public AdministrarEmpleados()
        {
            InitializeComponent();
        }
        private void dgvfull()
        {
            int fila = 0;
            foreach (var llenar in Listas.NEmp)
            {
                dataGridView1[0, fila].Value = Listas.NEmp[fila];
                dataGridView1[1, fila].Value = Listas.AEmp[fila];
                dataGridView1[2, fila].Value = Listas.Codigo[fila];
                fila++;
            }
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Listas.buscar = -1;
            AgregarEmpleados agge = new AgregarEmpleados();
            agge.Show();
        }
        private void AdministrarEmpleados_Activated(object sender, EventArgs e)
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
                AgregarEmpleados agge = new AgregarEmpleados();
                agge.Show();
            }
            catch
            {
                MessageBox.Show("Seleccione un empleado a modificar");
            }
        }
        private void AdministrarEmpleados_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < Listas.NEmp.Count; x++)
                dataGridView1.Rows.Add();
            dgvfull();
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Listas.NEmp.Count > 1)
            {
                try
                {
                    int del = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
                    Listas.DelEmp(del);
                    dataGridView1.Rows.Remove(dataGridView1.Rows[del]);
                    String actualizar = "";
                    for (int x = 0; x < Listas.NEmp.Count; x++)
                    {
                        actualizar += $"{Listas.NEmp[x]},{Listas.AEmp[x]},{Listas.Codigo[x]},{Listas.Pass[x]}\n";
                        MessageBox.Show(actualizar);
                    }
                    csv.reescribir($"{csv.raiz}\\Data\\Login\\Login", actualizar);
                    dgvfull();
                }
                catch
                {
                    MessageBox.Show("Seleccione un empleado a eliminar");
                }
            }
            else
                MessageBox.Show("No puede haber menos de un empleado");
        }
        private void Atras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void AdministrarEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}