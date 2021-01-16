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
        // UNITtest MULTIPLICACION POST
        // POST 1
        [Test]
        public void TestMultiplicacionPOST1()
        {
            // Arrange = preparacion
            int num1 = 12;
            int num2 = 12;
            int esperado = 144;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.multiplicacionpost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // POST 2
        [Test]
        public void TestMultiplicacionPOST2()
        {
            // Arrange = preparacion
            int num1 = 10;
            int num2 = 10;
            int esperado = 100;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.multiplicacionpost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // POST 3
        [Test]
        public void TestMultiplicacionPOST3()
        {
            // Arrange = preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 35;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.multiplicacionpost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // UNITtest MULTIPLICACION GET
        // GET 1
        [Test]
        public void TestMultiplicacionGET1()
        {
            // Arrange = preparacion
            int num1 = 2;
            int num2 = 2;
            int esperado = 4;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.multiplicacionget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // GET 2
        [Test]
        public void TestMultiplicacionGET2()
        {
            // Arrange = preparacion
            int num1 = 11;
            int num2 = 11;
            int esperado = 121;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.multiplicacionget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // GET 3
        [Test]
        public void TestMultiplicacionGET3()
        {
            // Arrange = preparacion
            int num1 = 8;
            int num2 = 8;
            int esperado = 64;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.multiplicacionget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------

    }
}