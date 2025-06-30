using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineaRectaPOOGUI
{
    public partial class LineaRectaGUI : Form
    {
        // Creamos un objeo de la clase Recta
        Recta recta1 = new Recta();
        public LineaRectaGUI()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Iniciamos los atributos de la clase Recta por medio del objeto
            recta1.PuntoX_1 = Convert.ToInt32(txtPuntoX_1.Text);
            recta1.PuntoY_1 = Convert.ToInt32(txtPuntoY_1.Text);
            recta1.PuntoX_2 = Convert.ToInt32(txtPuntoX_2.Text);
            recta1.PuntoY_2 = Convert.ToInt32(txtPuntoY_2.Text);
            //Metodo especial que nos permite mostrar un mensaje en una ventana emergente
            MessageBox.Show($"Sus puntos son: \nPunto A:({recta1.PuntoX_1.ToString()},{recta1.PuntoY_1.ToString()}) \nPunto B:({recta1.PuntoX_2.ToString()},{recta1.PuntoY_2.ToString()})");
            //Invocamos el metodo para calcular la distancia ente los puntos, asignamos el valor a lbRespuesta
            LbRespuesta.Text = recta1.CalcularDistancia_2().ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //.close Cerramos el programa
            this.Close();
        }
        private void lbPunto1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
