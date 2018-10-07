using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Validacion
{
    public class LadosPositivos
    {
        public bool Verificar (double elLado)
        {
            var elResultado = (elLado > 0);
            return elResultado;
        }
    }
}