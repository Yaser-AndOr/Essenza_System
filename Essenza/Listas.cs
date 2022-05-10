using System;
using System.Collections.Generic;

namespace ImpresionPDF
{
    class Listas
    {
        public static String Buscado;
        public static List<String> Codigo;
        public static List<String> Nombre;
        public static List<String> Precio;
        public static List<String> NEmp;
        public static List<String> AEmp;
        public static List<String> CEmp;
        public static List<String> Pass;
        public static List<String> SNombre;
        public static List<String> SCodigo;
        public static List<String> SPrecio;
        public static List<String> ClCache;
        public static List<int> Cantidad;
        public static String SNombreCl;
        public static String SCorreo;
        public static String SNumero;
        public static String Atendio;
        public static List<String> NombreCliente;
        public static List<String> CorreoCliente;
        public static List<String> NumeroCliente;
        public static int buscar;
        public static String pago;
        public static int inicio;
        public static string Sconteo;
        public static void init()
        {
            inicio = 0;
            pago = "";
            Buscado = "";
            Codigo = new List<String>();
            ClCache = new List<String>();
            Nombre = new List<String>();
            Precio = new List<String>();
            NEmp = new List<String>();
            AEmp = new List<String>();
            CEmp = new List<String>();
            Pass = new List<String>();
            SNombre = new List<String>();
            SCodigo = new List<String>();
            SPrecio = new List<String>();
            Cantidad = new List<int>();
            SNombre = new List<String>();
            SCodigo = new List<String>();
            SPrecio = new List<String>();
            Cantidad = new List<int>();
            NombreCliente = new List<String>();
            CorreoCliente = new List<String>();
            NumeroCliente = new List<String>();
            buscar = 0;
        }
        public static void clear()
        {
            SNombre.Clear();
            SCodigo.Clear();
            SPrecio.Clear();
            Cantidad.Clear();
        }
        public static int Exists(List<String> lista, String codigo)
        {
            int salida = lista.IndexOf(codigo);
            return salida;
        }
        public static void Delete(int element)
        {
            SCodigo.RemoveAt(element);
            SNombre.RemoveAt(element);
            SPrecio.RemoveAt(element);
            Cantidad.RemoveAt(element);
        }
        public static void DelCl(int element)
        {
            NombreCliente.RemoveAt(element);
            NumeroCliente.RemoveAt(element);
            CorreoCliente.RemoveAt(element);
        }
        public static void DelEmp(int element)
        {
            NEmp.RemoveAt(element);
            AEmp.RemoveAt(element);
            CEmp.RemoveAt(element);
            Pass.RemoveAt(element);
        }
        public static void DelPr(int element)
        {
            Codigo.RemoveAt(element);
            Nombre.RemoveAt(element);
            Precio.RemoveAt(element);
        }
        public static String texto()
        {
            String textoSalida = "";
            int cantProductos = SNombre.Count;
            Sconteo = "" + csv.conteopdf;
            do
            {
                Sconteo = "0" + Sconteo;
            } while (Sconteo.Length < 5);
            for (int x = 0; x < cantProductos; x++)
            {
                textoSalida += $"{csv.anio}_{csv.meses[csv.mes]}_{csv.sdia}_{Sconteo},{SCodigo[x]},{SNombre[x]},{SPrecio[x]},{Cantidad[x]}\n";
            }
            return textoSalida;
        }
    }
}