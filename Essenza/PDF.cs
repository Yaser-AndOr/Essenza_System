using System;
using System.Drawing;
using System.Drawing.Printing;

namespace ImpresionPDF
{
    class PDF
    {
        public static void ccpdf(PrintDocument pD1, String ruta)
        {
            pD1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            ps.PrintFileName = ruta;
            ps.PrintToFile = true;
            pD1.PrinterSettings = ps;
            pD1.PrintPage += Imprimir;
            pD1.Print();
        }
        private static void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font titulo = new Font("Calibri", 13, FontStyle.Bold, GraphicsUnit.Point);
            Font subtitulo = new Font("Calibri", 10, FontStyle.Bold, GraphicsUnit.Point);
            Font general = new Font("Calibri", 9, FontStyle.Regular, GraphicsUnit.Point);
            Pen pen = new Pen(Color.Gray, 1);
            Image img = Image.FromFile($"{csv.raiz}\\logo.png");
            e.Graphics.DrawImage(img, new Rectangle(30, 30, 283, 80));
            e.Graphics.DrawRectangle(pen, new Rectangle(30, 210, 789, 300));
            e.Graphics.DrawRectangle(pen, new Rectangle(30, 510, 789, 30));
            e.Graphics.DrawRectangle(pen, new Rectangle(30, 540, 394, 30));
            e.Graphics.DrawRectangle(pen, new Rectangle(424, 540, 395, 30));
            e.Graphics.DrawString("NOTA: NO SE ACEPTAN PAGOS CON BILLETES DE 50 Y 100", general, Brushes.Black, new RectangleF(285, 512, 350, 30));
            e.Graphics.DrawString($"Forma de Pago: {Listas.pago}", general, Brushes.Black, new RectangleF(32, 542, 300, 30));
            e.Graphics.DrawString($"ENTREGADO POR: {Listas.Atendio}", general, Brushes.Black, new RectangleF(426, 542, 300, 30));
            e.Graphics.DrawString("ESSENZA HAIR & NAILS", titulo, Brushes.Black, new RectangleF(352, 30, 223, 30));
            e.Graphics.DrawString("Condominio Altos del Paseo, local #40, 2a planta,", general, Brushes.Black, new RectangleF(316, 60, 283, 30));
            e.Graphics.DrawString("Paseo Gral Escalón, Colonia Escalón, San Salvador.", general, Brushes.Black, new RectangleF(313, 75, 283, 30));
            e.Graphics.DrawString("Teléfono: 2279 0372", general, Brushes.Black, new RectangleF(382, 90, 217, 30));
            e.Graphics.DrawString("Cliente:\nTeléfono:\nCorreo:", subtitulo, Brushes.Black, new RectangleF(30, 130, 60, 80));
            e.Graphics.DrawString($"{Listas.SNombreCl}", general, Brushes.Black, new RectangleF(90, 130, 300, 80));
            e.Graphics.DrawString($"{Listas.SNumero}", general, Brushes.Black, new RectangleF(90, 148, 300, 80));
            e.Graphics.DrawString($"{Listas.SCorreo}", general, Brushes.Black, new RectangleF(90, 164, 300, 80));
            e.Graphics.DrawString($"Recibo:", subtitulo, Brushes.Black, new RectangleF(609, 130, 80, 20));
            e.Graphics.DrawString($"Fecha:", subtitulo, Brushes.Black, new RectangleF(609, 150, 80, 20));
            e.Graphics.DrawString($"Hora Emitido:", subtitulo, Brushes.Black, new RectangleF(609, 170, 100, 20));
            e.Graphics.DrawString($"{csv.conteopdf-1}", general, Brushes.Black, new RectangleF(709, 130, 100, 20));
            e.Graphics.DrawString($"{csv.sdia}/{csv.mes + 1}/{csv.anio}", general, Brushes.Black, new RectangleF(709, 150, 100, 20));
            String minuto = DateTime.Now.Minute.ToString();
            if (minuto.Length == 1) { minuto = "0" + minuto; }
            String hora = DateTime.Now.Hour.ToString();
            if (hora.Length == 1) { hora = "0" + hora; }
            e.Graphics.DrawString($"{hora}:{minuto}", general, Brushes.Black, new RectangleF(709, 170, 100, 20));
            e.Graphics.DrawString($"CANT.", subtitulo, Brushes.Black, new RectangleF(32, 212, 60, 20));
            e.Graphics.DrawString($"DESCRIPCIÓN", subtitulo, Brushes.Black, new RectangleF(92, 212, 200, 20));
            e.Graphics.DrawString($"VENTAS", subtitulo, Brushes.Black, new RectangleF(611, 212, 100, 20));
            e.Graphics.DrawString($"GRAVADAS", subtitulo, Brushes.Black, new RectangleF(711, 212, 100, 20));
            double subtotal = 0;
            for (int x = 1; x < Listas.SCodigo.Count + 1; x++)
            {
                double monto = double.Parse(Listas.SPrecio[x - 1]) * Listas.Cantidad[x - 1];
                subtotal += monto;
                e.Graphics.DrawString($"{Listas.Cantidad[x - 1]}", general, Brushes.Black, new RectangleF(35, 210 + 30 * x, 60, 20));
                e.Graphics.DrawString($"{Listas.SNombre[x - 1]}", general, Brushes.Black, new RectangleF(95, 210 + 30 * x, 500, 20));
                e.Graphics.DrawString($"${Listas.SPrecio[x - 1]}", general, Brushes.Black, new RectangleF(614, 210 + 30 * x, 60, 20));
                e.Graphics.DrawString($"${monto}", subtitulo, Brushes.Black, new RectangleF(714, 210 + 30 * x, 60, 20));
            }
            e.Graphics.DrawString($"TOTAL:", general, Brushes.Black, new RectangleF(614, 490, 100, 20));
            e.Graphics.DrawString($"${subtotal}", subtitulo, Brushes.Black, new RectangleF(714, 490, 100, 20));
        }
    }
}