using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaRectaPOOGUI
{
    internal class Recta
    {
        // Atributos privados
        public int PuntoX_1 { get; set; }
        public int PuntoY_1 { get; set; }
        public int PuntoX_2 { get; set; }
        public int PuntoY_2 { get; set; }
        //Constructor sin parametros
        public Recta()
        {
            PuntoX_1 = 0;
            PuntoY_1 = 0;
            PuntoX_2 = 0;
            PuntoY_2 = 0;
        }
        // Metodo para calcular la distancia
        public double CalcularDistancia_2()
        {
            double distancia = Math.Sqrt(Math.Pow((PuntoX_2 - PuntoX_1), 2) + Math.Pow((PuntoY_2 - PuntoY_1), 2));
            return distancia;
        }
    }
}
