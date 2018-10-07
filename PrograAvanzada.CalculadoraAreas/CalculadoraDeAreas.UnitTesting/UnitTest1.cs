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
            // preparación del escenario de la prueba
            double miLado = 37.5;
            double elResultadoEsperado = 1406.25;
            double elResultadoActual = 0.0;
            var elServicio = new PrograAvanzada.CalculadoraAreas.BL.Logica.Especificacion.AreaDeUnCuadrado();

            // ejecución de la prueba
            elResultadoActual = elServicio.Calcule(miLado);

            // verificación del resultado obtenido
            Assert.AreEqual(elResultadoEsperado, elResultadoActual);
        }


        [TestMethod]
        public void AreaNegativa()
        {
            // preparación del escenario de la prueba
            double miLado = -5354.09;
            double elResultadoActual = 0;
            bool seLevantoLaExcepcion = false;
            //bool seEsperaLevantarLaExcepcion = true;
            var elServicio = new PrograAvanzada.CalculadoraAreas.BL.Logica.Especificacion.AreaDeUnCuadrado();

            try
            {
                elResultadoActual = elServicio.Calcule(miLado);
            }
            catch (Exception laExcepcion)
            {
                var mensaje = laExcepcion.Message;
                seLevantoLaExcepcion = true;
            }

            // ejecución de la prueba

            // verificación del resultado obtenido
            //Assert.AreEqual(seEsperaLevantarLaExcepcion, seLevantoLaExcepcion);
            Assert.IsTrue(seLevantoLaExcepcion);
        }
    }
}
