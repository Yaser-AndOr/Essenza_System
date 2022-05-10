using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresionPDF
{
    class csv
    {
        public static int conteopdf, diai, mesi, anioi;
        public static String sdia, anio;
        public static int mes = DateTime.Now.Month - 1;
        public static String raiz = $"{Directory.GetCurrentDirectory()}";
        public static String directorio, guardado;
        public static String[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        private static void tiempoinicial()
        {
            String[] Direc = Directory.GetDirectories($"{raiz}\\Data");
            List<int> anios = new List<int>();
            foreach (var carpeta in Direc)
            {
                String carp = carpeta.Split('\\').Last();
                try
                {
                    anios.Add(int.Parse(carp));
                }
                catch { }
            }
            try
            {
                anioi = anios.Min();
            }
            catch
            {
                anioi = DateTime.Now.Year;
                Directory.CreateDirectory($@"{raiz}\Data\{anioi}");
            }
            Direc = Directory.GetDirectories($@"{raiz}\Data\{anioi}");
            for (int x = 0; x < 11; x++)
            {
                foreach (var carpeta in Direc)
                {
                    String carp = carpeta.Split('\\').Last();
                    if (carp == meses[x])
                    {
                        mesi = x;
                        x = 12;
                        break;
                    }
                }
            }
            try
            {
                Direc = leer($@"{raiz}\Data\{anioi}\{meses[mesi]}\{anioi}_{meses[mesi]}_cuenta");
            }
            catch
            {
                Directory.CreateDirectory($@"{raiz}\Data\{anioi}\{meses[mesi]}");
                directorio = $@"{raiz}\Data\{anioi}\{meses[mesi]}\{anioi}_{meses[mesi]}_cuenta";
                crearArchivo();
                Direc = leer($@"{raiz}\Data\{anioi}\{meses[mesi]}\{anioi}_{meses[mesi]}_cuenta");
            }
            List<int> dias = new List<int>();
            foreach (var producto in Direc)
            {
                if (producto.Length > 1)
                {
                    String dia = producto.Split(',')[0].Split('_')[2];
                    dias.Add(int.Parse(dia));
                }
            }
            try
            {
                diai = dias.Min();
            }
            catch
            {
                diai = DateTime.Now.Day;
            }
        }
        public static void crearArchivo()
        {
            String Arch = $"{directorio}.csv";
            if (!File.Exists(Arch))
                File.Create(Arch);
            Task.Delay(25);
        }
        public static void crearCarpeta(String carpeta)
        {
            String Carp = $"{raiz}\\{carpeta}";
            if (!Directory.Exists(Carp))
                Directory.CreateDirectory(Carp);
        }
        public static void escribir(String archivo, String texto)
        {
            String Arch = $"{archivo}.csv";
            StreamWriter sw = new StreamWriter(Arch, true, Encoding.UTF8);
            sw.WriteLine(texto + "\n");
            sw.Close();
            conteopdf++;
        }
        public static void reescribir(String archivo, String texto)
        {
            String Arch = $"{archivo}.csv";
            using (StreamWriter sw = File.CreateText(Arch))
            {
                sw.Write(texto);
                sw.Close();
            }
        }
        public static String[] extraccion()
        {
            String[] datos = { };
            try
            {
                using (StreamReader sr = new StreamReader($"{directorio}.csv"))
                {
                    datos = sr.ReadToEnd().Split('\n');
                }
            }
            catch { }
            return datos;
        }
        public static String[] leer(String direct)
        {
            String[] datos = new String[0];
            try
            {
                using (StreamReader sr = new StreamReader($"{direct}.csv"))
                {
                    datos = sr.ReadToEnd().Split('\n');
                }
            }
            catch { }
            return datos;
        }
        public static void conteoFactura()
        {
            List<int> codigos = new List<int>();
            directorio = guardado;
            String[] cuentas = extraccion();
            foreach (var linea in cuentas)
            {
                if (linea.Length > 1)
                {
                    String cache = linea.Split(',')[0];
                    cache = cache.Split('_')[3];
                    codigos.Add(int.Parse(cache));
                }
            }
            if (codigos.Count == 0)
            {
                mes--;
                if (mes == -1)
                    mes = 11;
                directorio = $"{raiz}\\Data\\{anio}\\{meses[mes]}\\{anio}_{meses[mes]}_cuenta";
                cuentas = extraccion();
                foreach (var linea in cuentas)
                {
                    if (linea.Length > 1)
                    {
                        String cache = linea.Split(',')[0];
                        cache = cache.Split('_')[3];
                        codigos.Add(int.Parse(cache));
                        mes++;
                    }
                }
            }
            try
            {
                conteopdf = codigos.Max() + 1;
            }
            catch { conteopdf = 1; }
        }
        public static void obtProductos()
        {
            String[] productos = extraccion();
            foreach (var producto in productos)
            {
                if (producto.Length > 1)
                {
                    Listas.Codigo.Add(producto.Split(',')[0]);
                    Listas.Nombre.Add(producto.Split(',')[1]);
                    Listas.Precio.Add(producto.Split(',')[2].Trim());
                }
            }
        }
        public static void obtEmpleados()
        {
            String[] productos = extraccion();
            foreach (var producto in productos)
            {
                if (producto.Length > 0)
                {
                    Listas.NEmp.Add(producto.Split(',')[0]);
                    Listas.AEmp.Add(producto.Split(',')[1]);
                    Listas.CEmp.Add(producto.Split(',')[2]);
                    Listas.Pass.Add(producto.Split(',')[3].Trim());
                }
            }
        }
        public static void obtClientes()
        {
            String[] productos = extraccion();
            foreach (var producto in productos)
            {
                if (producto.Length > 1)
                {
                    Listas.NombreCliente.Add(producto.Split(',')[0]);
                    Listas.NumeroCliente.Add(producto.Split(',')[1]);
                    Listas.CorreoCliente.Add(producto.Split(',')[2]);
                }
            }
        }
        public static void arranqueDir()
        {
            crearCarpeta($"Data");
            int dia = DateTime.Now.Day;
            anio = "" + DateTime.Now.Year;
            tiempoinicial();
            if (dia < 10) { sdia = "0" + dia; }
            else { sdia += dia; }
            guardado = $"{raiz}\\Data\\{anio}\\{meses[mes]}\\{anio}_{meses[mes]}_cuenta";
            crearCarpeta($"Data\\Productos");
            directorio = $"{raiz}\\Data\\Productos\\Productos";
            crearArchivo();
            obtProductos();
            crearCarpeta($"Data\\Login");
            directorio = $"{raiz}\\Data\\Login\\Login";
            crearArchivo();
            obtEmpleados();
            crearCarpeta($"Data\\Clientes");
            directorio = $"{raiz}\\Data\\Clientes\\Clientes";
            crearArchivo();
            obtClientes();
            crearCarpeta($"Data\\{anio}");
            crearCarpeta($"Data\\{anio}\\{meses[mes]}");
            directorio = guardado;
            crearArchivo();
            conteoFactura();
            crearCarpeta($"Data\\{anio}\\{meses[mes]}\\{sdia}");
            directorio = $"{raiz}\\Data\\{anio}\\{meses[mes]}\\{sdia}\\{anio}_{meses[mes]}_{sdia}_cuenta";
        }
    }
}