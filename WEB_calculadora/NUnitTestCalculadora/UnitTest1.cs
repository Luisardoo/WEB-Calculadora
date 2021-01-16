using NUnit.Framework;
using WEB_calculadora.Properties.controllers;

namespace NUnitTestCalculadora
{
    public class TestCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }
        //-----------------------------------------------------------
        // UNITtest SUMA POST
        // POST 1
        [Test]
        public void TestSumaPOST1()
        {
            // Arrange = preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.sumapost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // POST 2
        [Test]
        public void TestSumaPOST2()
        {
            // Arrange = preparacion
            int num1 = 10;
            int num2 = 10;
            int esperado = 20;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.sumapost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // POST 3
        [Test]
        public void TestSumaPOST3()
        {
            // Arrange = preparacion
            int num1 = 25;
            int num2 = 25;
            int esperado = 50;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.sumapost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // UNITtest SUMA GET
        // GET 1
        [Test]
        public void TestSumaGET1()
        {
            // Arrange = preparacion
            int num1 = -10;
            int num2 = 10;
            int esperado = 0;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.sumaget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // GET 2
        [Test]
        public void TestSumaGET2()
        {
            // Arrange = preparacion
            int num1 = 35;
            int num2 = 5;
            int esperado = 40;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.sumaget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // GET 3
        [Test]
        public void TestSumaGET3()
        {
            // Arrange = preparacion
            int num1 = 100;
            int num2 = -80;
            int esperado = 20;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.sumaget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        
    }
}