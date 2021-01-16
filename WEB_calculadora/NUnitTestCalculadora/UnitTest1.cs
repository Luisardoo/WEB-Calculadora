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
        // UNITtest DIVISION POST
        // POST 1
        [Test]
        public void TestDivisionPOST1()
        {
            // Arrange = preparacion
            int num1 = 50;
            int num2 = 50;
            int esperado = 1;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            float resultado = calc.divisionpost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // POST 2
        [Test]
        public void TestDivisionPOST2()
        {
            // Arrange = preparacion
            int num1 = 25;
            int num2 = 5;
            int esperado = 5;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            float resultado = calc.divisionpost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // POST 3
        [Test]
        public void TestDivisionPOST3()
        {
            // Arrange = preparacion
            int num1 = 21;
            int num2 = 3;
            int esperado = 7;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            float resultado = calc.divisionpost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // UNITtest DIVISION GET
        // GET 1
        [Test]
        public void TestDivisionGET1()
        {
            // Arrange = preparacion
            int num1 = 50;
            int num2 = 5;
            int esperado = 10;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            float resultado = calc.divisionget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // GET 2
        [Test]
        public void TestDivisionGET2()
        {
            // Arrange = preparacion
            int num1 = 20;
            int num2 = 10;
            int esperado = 2;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            float resultado = calc.divisionget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // GET 3
        [Test]
        public void TestDivisionGET3()
        {
            // Arrange = preparacion
            int num1 = 49;
            int num2 = 7;
            int esperado = 7;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            float resultado = calc.divisionget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------

    }
}