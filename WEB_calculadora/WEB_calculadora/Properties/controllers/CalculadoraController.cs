using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_calculadora.Properties.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : Controller
    {
        // GET y POST de SUMA
        [HttpGet]
        public int sumaget(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpPost]
        public int sumapost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 + num2;
        }
        // --------------------------------------------------------------
       

    }
}
