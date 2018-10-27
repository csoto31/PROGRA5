using PrograAvanzada.Northwind.Products.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.Northwind.Products.BL.Logica.Repositorio
{
    internal class Productos
    {
        northwindEntities _miContexto = new northwindEntities();
        public IList<Model.Products> ListarProductosPorRangoDePrecio(decimal PrecioMinimo, decimal PrecioMaximo, bool IncluirDescontinuados)
        {
            var elResultado = _miContexto.Products.Where(p => PrecioMinimo 
            <= p.UnitPrice && p.UnitPrice <= PrecioMaximo && p.Discontinued
            == IncluirDescontinuados).ToList();


            return elResultado;
        }
    }
}