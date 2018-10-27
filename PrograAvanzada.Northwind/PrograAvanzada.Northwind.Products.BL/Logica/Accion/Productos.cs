using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.Northwind.Products.BL.Logica.Accion
{
    public class Productos
    {
        public IList<Model.Products> ListarProductosPorRangoDePrecio(decimal PrecioMinimo, decimal PrecioMaximo, bool IncluirDescontinuados)
        {
            var elRepositorio = new Repositorio.Productos();
            var elResultado = elRepositorio.ListarProductosPorRangoDePrecio
                (PrecioMinimo, PrecioMaximo, IncluirDescontinuados);
            return elResultado;

        }

    }
}