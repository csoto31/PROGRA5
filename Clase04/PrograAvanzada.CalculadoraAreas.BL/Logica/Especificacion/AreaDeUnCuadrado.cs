using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Especificacion
{
    public class AreaDeUnCuadrado
    {
        public double Calcule(double elLado)
        {
            var laValidacion = new Validacion.LadosPositivos();

            if (laValidacion.Verificar(elLado))
            {

                var laAccion = new Accion.CalcularCuadrado();
                var elResultado = laAccion.CalcularElArea(elLado);
                return elResultado;
            }
            else
                throw new Exception("El Valor de los lados debe ser positivo");

        }
    } 
}