using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class Facturar : Form
    {
        public Facturar()
        {
            InitializeComponent();
        }
        private void Print_Click(object sender, EventArgs e)
        {
            if (NumeroCl.Text.Trim() == "")
                MessageBox.Show("Ingrese un cliente");
            else
            {
                if (Listas.SPrecio.Count == 0)
                    MessageBox.Show("Ingrese al menos un producto, no se pueden generar facturas vacías");
                else
                {
                    if (Listas.pago == "")
                        MessageBox.Show("Escoja un método de pago");
                    else
                    {
                        Listas.buscar = 3;
                        Buscar buscar = new Buscar();
                        buscar.Show();
                    }
                }
            }
        }
        private void imprimir()
        {
            String Cuenta = Listas.texto();
            csv.escribir(csv.guardado, Cuenta);
            PDF.ccpdf(printDocument1, $"{csv.directorio}_{Listas.Sconteo}.pdf");
            int filas = dataGridView1.Rows.Count;
            for (int x = 0; x < filas - 1; x++)
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            Listas.clear();
            NombreCl.Text = "";
            CodigoProducto.Text = "";
            Efectivo.Checked = false;
            Tarjeta.Checked = false;
            Listas.pago = "";
            Listas.Buscado = "";
            Listas.buscar = 0;
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void CodigoProducto_TextChanged(object sender, EventArgs e)
        {
            int existe = Listas.Exists(Listas.Codigo, CodigoProducto.Text.Trim());
            if (existe != -1)
            {
                NombreProducto.Text = Listas.Nombre[existe];
                PrecioUnitario.Text = Listas.Precio[existe];
            }
            else
            {
                NombreProducto.Clear();
                PrecioUnitario.Clear();
            }
        }
        private void Agregar_Click(object sender, EventArgs e)
        {

            if (NombreProducto.Text.Trim() != "")
            {
                Agregardgv();
                CodigoProducto.Text = "";
                Cantidad.Value = 1;
            }
        }
        private void dgvfull()
        {
            int fila = 0;
            foreach (var llenar in Listas.SCodigo)
            {
                dataGridView1[0, fila].Value = Listas.SCodigo[fila];
                dataGridView1[1, fila].Value = Listas.SNombre[fila];
                dataGridView1[2, fila].Value = Listas.SPrecio[fila];
                dataGridView1[3, fila].Value = Listas.Cantidad[fila];
                fila++;
            }
        }
        private void Agregardgv()
        {
            if (NombreProducto.Text.Trim() != "")
            {
                int producto = Listas.Exists(Listas.SCodigo, CodigoProducto.Text);
                if (producto == -1)
                {
                    Listas.SCodigo.Add(CodigoProducto.Text.Trim());
                    Listas.SNombre.Add(NombreProducto.Text.Trim());
                    Listas.SPrecio.Add(PrecioUnitario.Text.Trim('\n'));
                    Listas.Cantidad.Add(int.Parse(Cantidad.Text.Trim()));
                    dataGridView1.Rows.Add();
                }
                else
                {
                    Listas.Cantidad[producto] += int.Parse(Cantidad.Text);
                }
                dgvfull();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(10, 34, 64);
            label5.ForeColor = Color.FromArgb(232, 31, 118); ;
            Efectivo.ForeColor = Color.FromArgb(232, 31, 118);
            Tarjeta.ForeColor = Color.FromArgb(232, 31, 118);
            Cupon.ForeColor = Color.FromArgb(232, 31, 118);
            Transferencia.ForeColor = Color.FromArgb(232, 31, 118);
            label1.ForeColor = Color.FromArgb(232, 31, 118);
            label2.ForeColor = Color.FromArgb(232, 31, 118);
            L1.ForeColor = Color.FromArgb(232, 31, 118);
            L2.ForeColor = Color.FromArgb(232, 31, 118);
            L3.ForeColor = Color.FromArgb(232, 31, 118);
            L4.ForeColor = Color.FromArgb(232, 31, 118);
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int del = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
                Listas.Cantidad[del]--;
                if (Listas.Cantidad[del] < 1)
                {
                    Listas.Delete(del);
                    dataGridView1.Rows.Remove(dataGridView1.Rows[del]);
                }
                dgvfull();
            }
            catch
            {
                MessageBox.Show("Seleccione un producto a eliminar");
            }
        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            Listas.buscar = 1;
            Buscar f2 = new Buscar();
            f2.Show();
        }
        private void regreso(object sender, EventArgs e)
        {
            if (Listas.Buscado != "")
            {
                if (Listas.buscar == 1)
                    CodigoProducto.Text = Listas.Buscado;
                if (Listas.buscar == 2)
                    NombreCl.Text = Listas.Buscado;
                if (Listas.buscar == 3)
                {
                    Listas.Atendio = Listas.Buscado.Split(',')[0];
                    imprimir();
                }
                Listas.Buscado = "";
                Listas.buscar = 0;
            }
        }
        private void Cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (Cantidad.Value < 1)
            {
                Cantidad.Value = 1;
            }
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void BuscarPe_Click(object sender, EventArgs e)
        {
            Listas.buscar = 2;
            Buscar Bc = new Buscar();
            Bc.Show();
        }
        private void NombreCl_TextChanged(object sender, EventArgs e)
        {
            int existe = Listas.Exists(Listas.NombreCliente, NombreCl.Text.Trim());
            if (existe != -1)
            {
                NombreCl.Text = Listas.NombreCliente[existe];
                NumeroCl.Text = Listas.NumeroCliente[existe];
                Listas.SNombreCl = NombreCl.Text;
                Listas.SNumero = NumeroCl.Text;
                Listas.SCorreo = Listas.CorreoCliente[existe];
            }
            else
            {
                NombreCl.Clear();
                NumeroCl.Clear();
            }
        }
        private void Efectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (Efectivo.Checked == true)
            {
                Tarjeta.Checked = false;
                Cupon.Checked = false;
                Transferencia.Checked = false;
                Listas.pago = "EFECTIVO";
            }
        }
        private void Tarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (Tarjeta.Checked == true)
            {
                Efectivo.Checked = false;
                Cupon.Checked = false;
                Transferencia.Checked = false;
                Listas.pago = "TARJETA";
            }
        }
        private void Atras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void Cupon_CheckedChanged(object sender, EventArgs e)
        {
            if (Cupon.Checked == true)
            {
                Efectivo.Checked = false;
                Tarjeta.Checked = false;
                Transferencia.Checked = false;
                Listas.pago = "CUPON";
            }
        }
        private void Transferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (Transferencia.Checked == true)
            {
                Efectivo.Checked = false;
                Cupon.Checked = false;
                Tarjeta.Checked = false;
                Listas.pago = "TRANSFERENCIA";
            }
        }
    }
}