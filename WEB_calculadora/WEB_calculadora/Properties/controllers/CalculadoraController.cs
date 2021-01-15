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
        
    }
}
