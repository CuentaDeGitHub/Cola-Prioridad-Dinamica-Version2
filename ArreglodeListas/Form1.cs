using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArreglodeListas
{
    public partial class Form1 : Form
    {
        Cola MiCola = new Cola();
        Nodo n;
        public Form1()
        {
            InitializeComponent();
            MiCola = new Cola();

        }


        private void btnEncolar_Click(object sender, EventArgs e)
        {
            int prioridad = int.Parse(txtPrioridad.Text);
            if (prioridad > 3 | prioridad < 0)
            {
                MessageBox.Show("Error en la prioridad");
                return;
            }
            try
            {
                n = new Nodo();
                n.Dato = txtDato.Text;
                n.Prioridad = int.Parse(txtPrioridad.Text);
                MiCola.Encolar(n);
                txtDato.Clear();
                txtPrioridad.Clear();
                lblCola0.Text = MiCola.Texto(0);
                lblCola1.Text = MiCola.Texto(1);
                lblCola2.Text = MiCola.Texto(2);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }



        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            MiCola.Desencolar();
            lblCola0.Text = MiCola.Texto(0);
            lblCola1.Text = MiCola.Texto(1);
            lblCola2.Text = MiCola.Texto(2);
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            MiCola.IncrementarPrioridad();
            lblCola0.Text = MiCola.Texto(0);
            lblCola1.Text = MiCola.Texto(1);
            lblCola2.Text = MiCola.Texto(2);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog Dialogo = new FolderBrowserDialog();
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    lblCola0.Text = MiCola.Texto(0);
                    lblCola1.Text = MiCola.Texto(1);
                    lblCola2.Text = MiCola.Texto(2);
                    string prioridad0 = lblCola0.Text;
                    if (prioridad0 == "La cola esta vacia")
                    {
                        prioridad0 = "";
                    }
                    string prioridad1 = lblCola1.Text;
                    if (prioridad1 == "La cola esta vacia")
                    {
                        prioridad1 = "";
                    }
                    string prioridad2 = lblCola2.Text;
                    if (prioridad2 == "La cola esta vacia")
                    {
                        prioridad2 = "";
                    }
                    string[] Colas = { prioridad0, prioridad1, prioridad2 };
                    string nombreDelArchivo;
                    if (txtArchivo.Text == "")
                    {
                        nombreDelArchivo = "Cola";
                    }
                    else
                    {
                        nombreDelArchivo = txtArchivo.Text;
                    }
                    string ruta = Dialogo.SelectedPath + "\\" + nombreDelArchivo + ".txt";
                    using (var writer = new StreamWriter(ruta))
                    {
                        writer.Close();
                    }
                    File.WriteAllLines(ruta, Colas);
                    MessageBox.Show("Datos guardados en la ruta : " + ruta);

                }
            }
            catch
            {

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            if (Seleccionar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ruta = Seleccionar.FileName;
                    string[] ColasdePrioridad = File.ReadAllLines(ruta);
                    string[] cola0Arreglo = ColasdePrioridad[0].Split(',');
                    string[] cola1Arreglo = ColasdePrioridad[1].Split(',');
                    string[] cola2Arreglo = ColasdePrioridad[2].Split(',');
                    CargarColas(cola0Arreglo, 0);
                    CargarColas(cola1Arreglo, 1);
                    CargarColas(cola2Arreglo, 2);
                    lblCola0.Text = MiCola.Texto(0);
                    lblCola1.Text = MiCola.Texto(1);
                    lblCola2.Text = MiCola.Texto(2);
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                }
                catch
                {

                }
            }
        }
        public void CargarColas(string[] arreglo, int prioridad)
        {
            int contador = 0;
            foreach (string i in arreglo)
            {
                n = new Nodo();
                n.Dato = arreglo[contador];
                n.Prioridad = prioridad;
                MiCola.Encolar(n);
                contador++;
            }
        }
    }
}
