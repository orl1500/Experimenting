using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calculadora;

namespace Calculadora_Teste

{
    [TestClass]
    public class TestedaCalculadora
    {
        [TestMethod]
        public void TestMethod1()
        {

            Calculadora c = Calculadora();
            int resultado = c.Soma(3, 4);
            Assert.AreEqual(7, resultado);

        }
    }
}
