using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Accion
{
    public class CalcularCuadrado
    {
        /// <summary>
        /// Realiza el calculo del area de un cuadrado de lado especifico
        /// </summary>
        /// <param name="elLado">Medida del lado del cuadrado</param>
        /// <returns>El area de un cuadrado</returns>
        public double CalcularElArea(double elLado) {

            double elArea = elLado * elLado;
            return elArea;

        }
    }
}