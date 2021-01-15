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
       
    }
}
