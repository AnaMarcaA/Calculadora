using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICalculadora2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }
        [HttpPost]
        [Route("Multiply")]
        public int Multiply([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa * numb;
        }

        [HttpPost]
        [Route("Subtracion")]
        public int Subtraction([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa - numb;
        }

        [HttpPost]
        [Route("Divide")]
        public int Divide([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa / numb;
        }

    }
}
