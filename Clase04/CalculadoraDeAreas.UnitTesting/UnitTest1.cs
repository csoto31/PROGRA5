using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrograAvanzada.CalculadoraAreas;

namespace CalculadoraDeAreas.UnitTesting
{
    [TestClass]
    public class Cuadrado
    {

        [TestMethod]
        public void AreaPositiva()
        {
            //Preparacion del escenario de la prueba
            double miLado = 37.5;
            double elResultadoEsperado = 1406.25;
            double elResultadoActual = 0.0;
            var elServicio = new PrograAvanzada.CalculadoraAreas.BL.
                Logica.Especificacion.AreaDeUnCuadrado();


            //Ejecucion de la pureba
            elResultadoActual = elServicio.Calcule(miLado);



            //Verificacion del resultado
            Assert.AreEqual(elResultadoEsperado, elResultadoActual);


        }


        [TestMethod]
        public void AreaNegativa()
        {
            //Preparacion del escenario de la prueba
            double miLado = -5354.09;
            double elResultadoActual = 0.0;
            bool seLevantoLaExcepcion = false;
            
            
            

            var elServicio = new PrograAvanzada.CalculadoraAreas.BL.
                Logica.Especificacion.AreaDeUnCuadrado();

            try
            {
                elResultadoActual = elServicio.Calcule(miLado);
            }
            catch (Exception laExcepcion)
            {
                var mensaje = laExcepcion.Message;
                seLevantoLaExcepcion = true;
            }
            //Ejecucion de la pureba
           



            //Verificacion del resultado
            Assert.IsTrue(seLevantoLaExcepcion);


        }
    }
}
