using System;
using Microsoft.AspNetCore.Mvc;
using LoveCalculator.Model;
using LoveCalculator.Algorithms;
using LoveCalculator.Mappers;
using System.IO;

namespace LoveCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoveCalcController : ControllerBase
    {
        [HttpGet("{a}/{b}")]
        public ActionResult<LoveResult> GetMatch(string a, string b)
        {
            int percentage = new LoveAlgorithm().Calculate(a, b);
            string comment = new LoveAlgorithm().Comment(percentage);
            return Ok(Mapper.Map(percentage, comment));
        }
    }
}
