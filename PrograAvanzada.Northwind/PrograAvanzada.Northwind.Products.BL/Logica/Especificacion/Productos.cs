using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.Northwind.Products.BL.Logica.Especificacion
{
    public class Productos
    {
        public IList<Model.Products> ListarProductosPorRangoDePrecio(decimal PrecioMinimo, decimal PrecioMaximo, bool IncluirDescontinuados)
        {
            var laAccion = new Logica.Accion.Productos();
            var elResultado = laAccion.ListarProductosPorRangoDePrecio(PrecioMinimo, PrecioMaximo, IncluirDescontinuados);
            return elResultado;

        }

    }
}