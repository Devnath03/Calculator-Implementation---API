//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Calculator_Service.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CalculatorController : ControllerBase
//    {
//    }
//}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Calculator_Service.Model;

namespace Calculator_Service.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        [Route("api/calculate")]

            public IHttpActionResult Add([FromBody] CalculationRequest model)
            {
                if (model == null)
                    return BadRequest("Invalid Input");

                double result = model.Number1 + model.Number1;
                return Ok(new { Result = result });
            }
            [HttpPost]
            [Route("subtract")]

            public IHttpActionResult Subtract([FromBody] CalculatorModel model)
            {
                if (model == null)
                    return BadRequest("Invalid Input");

                double result = model.Number1 - model.Number1;
                return Ok(new { Result = result });
            }

            [HttpPost]
            [Route("multiply")]

            public IHttpActionResult Multiply([FromBody] CalculatorModel model)
            {
                if (model == null)
                    return BadRequest("Invalid Input");

                double result = model.Number1 * model.Number1;
                return Ok(new { Result = result });
            }

            [HttpPost]
            [Route("division")]
            public IHttpActionResult Division([FromBody] CalculatorModel model)
            {
                if (model == null)
                    return BadRequest("Invalid Input");

                if (model.Number1 == 0 || model.Number2 == 0)
                    return BadRequest("zero is not allowed");

                double result = model.Number1 / model.Number2;
                return Ok(new { Result = result });
            }

        }
    }


