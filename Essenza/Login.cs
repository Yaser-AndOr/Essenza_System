using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImpresionPDF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Ingresar_Click(object sender, EventArgs e)
        {
            ingreso();
        }
        private void ingreso()
        {
            String CodigoBox = Codigo.Text;
            String ContraBox = Contrasenia.Text;
            String Clist, Plist;
            for (int x = 0; x < Listas.NEmp.Count; x++)
            {
                Clist = Listas.CEmp[x];
                Plist = Listas.Pass[x];
                if (Clist == CodigoBox && Plist == ContraBox)
                {
                    if (Listas.inicio == 0)
                    {
                        Listas.inicio = -1;
                        Menu elec = new Menu();
                        elec.Show();
                        this.Hide();
                    }
                    else if (Listas.inicio == 1)
                    {
                        Listas.inicio = -1;
                        Corte corte = new Corte();
                        corte.Show();
                        this.Hide();
                    }
                    else if (Listas.inicio == 2)
                    {
                        Listas.inicio = -1;
                        AdministrarEmpleados admemp = new AdministrarEmpleados();
                        admemp.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("Digite correctamente sus datos de ingreso");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            if (Listas.inicio == 0)
                Atras.Visible = false;
            Ingresar.BackColor = Color.FromArgb(232, 31, 118);
            Ingresar.ForeColor = Color.FromArgb(10, 34, 64);
            this.BackColor = Color.FromArgb(10, 34, 64);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Contrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ingreso();
            }
        }
        private void Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Contrasenia.Focus();
            }
        }
        private void Atras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}