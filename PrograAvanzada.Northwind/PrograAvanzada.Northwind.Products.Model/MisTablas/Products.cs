using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograAvanzada.Northwind.Products.Model
{
    public partial class Products
    {
        public Nullable<short> UnidadesDeDesabastecimiento
        {
            get
            {
                Nullable<short> elResultado = 0;
                if (ReorderLevel > UnitsInStock)
                    elResultado = (short?)(ReorderLevel - UnitsInStock);
                return elResultado;
                ;
            }
        }
    }
}
