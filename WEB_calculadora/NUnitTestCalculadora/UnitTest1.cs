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