using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrograAvanzada.Northwind.Products.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductosEntreVeinteYTreintaDolares()
        {
            //Definir El Escenario de inicio
            decimal elPrecioInferior = 20;
            decimal elPrecioSuperior = 30;
            var IncluirProdcutoDescontinuado = false;
            var laEspecificacion = new 
                BL.Logica.Especificacion.Productos();
            IList<Model.Products> elResultadoActual;
            var elResultadoEsperado = 13;

            //Ejecutar  el metodo especificado
            elResultadoActual = laEspecificacion.ListarProductosPorRangoDePrecio
                (elPrecioInferior, elPrecioSuperior, IncluirProdcutoDescontinuado);

            //Verificar el Resultado
            Assert.IsNotNull(elResultadoActual);
            Assert.AreEqual(elResultadoEsperado, elResultadoActual.Count);


        }
    }
}
