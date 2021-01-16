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
        // UNITtest RESTA POST
        // POST 1
        [Test]
        public void TestRestaPOST1()
        {
            // Arrange = preparacion
            int num1 = 30;
            int num2 = 7;
            int esperado = 23;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.restapost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // POST 2
        [Test]
        public void TestRestaPOST2()
        {
            // Arrange = preparacion
            int num1 = 25;
            int num2 = -25;
            int esperado = 50;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.restapost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // POST 3
        [Test]
        public void TestRestaPOST3()
        {
            // Arrange = preparacion
            int num1 = 75;
            int num2 = 19;
            int esperado = 56;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.restapost(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // UNITtest RESTA GET
        // GET 1
        [Test]
        public void TestRestaGET1()
        {
            // Arrange = preparacion
            int num1 = 40;
            int num2 = 20;
            int esperado = 20;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.restaget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // GET 2
        [Test]
        public void TestRestaGET2()
        {
            // Arrange = preparacion
            int num1 = -60;
            int num2 = 20;
            int esperado = -80;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.restaget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        // GET 3
        [Test]
        public void TestRestaGET3()
        {
            // Arrange = preparacion
            int num1 = 15;
            int num2 = 20;
            int esperado = -5;
            CalculadoraController calc = new CalculadoraController();
            // Act = ejecucion
            int resultado = calc.restaget(num1, num2);
            // Assert = verificacion
            Assert.AreEqual(esperado, resultado);

        }
        //-----------------------------------------------------------
        

    }
}