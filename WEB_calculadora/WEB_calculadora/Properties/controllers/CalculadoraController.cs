using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_calculadora.Properties.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        // GET y POST de SUMA
        [HttpGet]
        [Route("suma")]
        public int sumaget(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpPost]
        [Route("suma")]
        public int sumapost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 + num2;
        }
        //------------------------------------
        // GET y POST de RESTA
        [HttpGet]
        [Route("resta")]
        public int restaget(int num1, int num2)
        {
            return num1 - num2;
        }
        [HttpPost]
        [Route("resta")]
        public int restapost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 - num2;
        }
        //------------------------------------
        // GET y POST de MULTIPLICACION
        [HttpGet]
        [Route("multiplicacion")]
        public int multiplicacionget(int num1, int num2)
        {
            return num1 * num2;
        }
        [HttpPost]
        [Route("multiplicacion")]
        public int multiplicacionpost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 * num2;
        }
        //------------------------------------
        // GET y POST de DIVISION
        [HttpGet]
        [Route("division")]
        public float divisionget(int num1, int num2)
        {
            if (num2 == 0)
            {
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }
        [HttpPost]
        [Route("division")]
        public float divisionpost([FromHeader] int num1, [FromHeader] int num2)
        {
           return num1 / num2; 
        }
        //------------------------------------------
    }
}
