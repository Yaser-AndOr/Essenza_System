using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class Corte : Form
    {
        public Corte()
        {
            InitializeComponent();
        }
        private static Double Total;
        private void Diario_CheckedChanged(object sender, EventArgs e)
        {
            if (Diario.Checked == true)
            {
                Tiempo.Checked = false;
                Desde.Enabled = false;
                Hasta.Enabled = false;
            }
            else if (Diario.Checked == false)
                Tiempo.Checked = true;
        }
        private void Tiempo_CheckedChanged(object sender, EventArgs e)
        {
            if (Tiempo.Checked == true)
            {
                Diario.Checked = false;
                Desde.Enabled = true;
                Hasta.Enabled = true;
            }
            else if (Tiempo.Checked == false)
                Diario.Checked = true;
        }
        private bool exists(int buscado, String comp, int factor)
        {
            String[] Direc = Directory.GetDirectories($@"{csv.raiz}\Data{comp}");
            List<int> anios = new List<int>();
            List<String> meses = new List<String>();
            foreach (var carpeta in Direc)
            {
                String carp = carpeta.Split('\\').Last();
                try
                {
                    anios.Add(int.Parse(carp));
                }
                catch
                {
                    meses.Add(carp);
                }
            }
            switch (factor)
            {
                case 0:
                    if (anios.IndexOf(buscado) != -1)
                        return true;
                    break;
                case 1:
                    String Buscado = csv.meses[buscado - 1];
                    if (meses.IndexOf(Buscado) != -1)
                        return true;
                    break;
            }
            return false;
        }
        private void canio(List<int> desde, List<int> hasta)
        {
            switch (hasta[2] - desde[2])
            {
                case 0:
                    cmes(desde, hasta, desde[2]);
                    break;
                default:
                    if (exists(desde[1], $"\\{desde[2]}", 1))
                        buscar(desde[0].ToString(), desde[1].ToString(), desde[2].ToString(), 1);
                    for (int x = desde[1] + 1; x < 13; x++)
                        if (exists(x, $"\\{desde[2]}", 1))
                            buscar(x.ToString(), desde[2].ToString());
                    for (int x = desde[2] + 1; x < hasta[2]; x++)
                        if (exists(x, $"", 0))
                            for (int y = 1; y < 13; y++)
                                if (exists(y, $"\\{x}", 1))
                                    buscar(y.ToString(), x.ToString());
                    for (int x = 1; x < hasta[1]; x++)
                        if (exists(x, $"\\{hasta[2]}", 1))
                            buscar(x.ToString(), hasta[2].ToString());
                    if (exists(hasta[1], $"\\{hasta[2]}", 1))
                        buscar(hasta[0].ToString(), hasta[1].ToString(), hasta[2].ToString(), 2);
                    break;
            }
        }
        private void cmes(List<int> desde, List<int> hasta, int anio)
        {
            switch (hasta[1] - desde[1])
            {
                case 0:
                    if (exists(desde[1], $"\\{anio}", 1))
                        buscar(desde[0].ToString(), hasta[0].ToString(), desde[1].ToString(), anio.ToString());
                    break;
                default:
                    if (exists(desde[1], $"\\{anio}", 1))
                        buscar(desde[0].ToString(), desde[1].ToString(), anio.ToString(), 1);

                    for (int x = desde[1] + 1; x < hasta[1]; x++)
                        if (exists(x, $"\\{anio}", 1))
                            buscar(x.ToString(), anio.ToString());

                    if (exists(hasta[1], $"\\{anio}", 1))
                        buscar(hasta[0].ToString(), hasta[1].ToString(), anio.ToString(), 2);
                    break;
            }
        }
        private void buscar(String lim, String mes, String anio, int factor)
        {
            int limite = int.Parse(lim);
            String[] facturas = csv.leer($@"{csv.raiz}\Data\{anio}\{csv.meses[int.Parse(mes) - 1]}\{anio}_{csv.meses[int.Parse(mes) - 1]}_cuenta");
            foreach (var factura in facturas)
            {
                if (factura.Length > 1)
                {
                    String[] producto = factura.Split(',');
                    int dia = int.Parse(producto[0].Split('_')[2]);
                    switch (factor)
                    {
                        case 1:
                            if (limite <= dia)
                            {
                                Total += Double.Parse(producto[3]) * Double.Parse(producto[4]);
                            }
                            break;
                        case 2:
                            if (dia <= limite)
                            {
                                Total += Double.Parse(producto[3]) * Double.Parse(producto[4]);
                            }
                            break;
                    }
                }
            }
        }
        private void buscar(String mes, String anio)
        {
            String[] facturas = csv.leer($@"{csv.raiz}\Data\{anio}\{csv.meses[int.Parse(mes) - 1]}\{anio}_{csv.meses[int.Parse(mes) - 1]}_cuenta");
            foreach (var factura in facturas)
            {
                if (factura.Length > 1)
                {
                    String[] producto = factura.Split(',');
                    Total += Double.Parse(producto[3]) * Double.Parse(producto[4]);
                }
            }
        }
        private void buscar(String di, String df, String mes, String anio)
        {
            int diaini = int.Parse(di);
            int diafin = int.Parse(df);
            String[] facturas = csv.leer($@"{csv.raiz}\Data\{anio}\{csv.meses[int.Parse(mes) - 1]}\{anio}_{csv.meses[int.Parse(mes) - 1]}_cuenta");
            foreach (var factura in facturas)
            {
                if (factura.Length > 1)
                {
                    String[] producto = factura.Split(',');
                    int dia = int.Parse(producto[0].Split('_')[2]);
                    if (dia >= diaini && dia <= diafin)
                    {
                        Total += Double.Parse(producto[3]) * Double.Parse(producto[4]);
                    }
                }
            }
        }
        private void cortar()
        {
            List<int> desde = new List<int>(), hasta = new List<int>();
            for (int x = 0; x < 3; x++)
            {
                desde.Add(int.Parse(Desde.SelectionStart.ToString().Split(' ')[0].Split('/')[x]));
                hasta.Add(int.Parse(Hasta.SelectionStart.ToString().Split(' ')[0].Split('/')[x]));
            }
            canio(desde, hasta);
        }
        private void Corte_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(10, 34, 64);
            L1.ForeColor = Color.FromArgb(232, 31, 118);
            L2.ForeColor = Color.FromArgb(232, 31, 118);
            Diario.ForeColor = Color.FromArgb(232, 31, 118);
            Tiempo.ForeColor = Color.FromArgb(232, 31, 118);
            Obtener.BackColor = Color.FromArgb(232, 31, 118);
            Diario.Checked = true;
            Hasta.MinDate = new System.DateTime(csv.anioi, csv.mesi - 1, csv.diai);
            Desde.MinDate = new System.DateTime(csv.anioi, csv.mesi - 1, csv.diai);
            Hasta.MaxDate = DateTime.Today;
            Desde.MaxDate = DateTime.Today;
        }
        private void Desde_DateChanged(object sender, DateRangeEventArgs e)
        {
            Hasta.MinDate = Desde.SelectionStart;
        }
        private void Hasta_DateChanged(object sender, DateRangeEventArgs e)
        {
            Desde.MaxDate = Hasta.SelectionStart;
        }
        private void Obtener_Click(object sender, EventArgs e)
        {
            String dia = DateTime.Now.Day.ToString();
            String mes = DateTime.Now.Month.ToString();
            String anio = DateTime.Now.Year.ToString();
            if (Diario.Checked == true)
            {
                buscar(dia, dia, mes, anio);
            }
            else
            {
                cortar();
            }
            MessageBox.Show($"El total de ventas es: ${Total}");
            Total = 0;
        }
        private void Atras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void Corte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}