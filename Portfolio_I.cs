using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Portfolio_I.Controllers
{
    public class Portfolio_IController : Controller
    {
        [HttpGet]
        [Route ("")]
        public string Index ()
        {
            return $"This is my Index!";
        }
        [HttpGet("projects")]
        public string projects()
        {
            return $"This is my project";
        }
        [HttpGet("contact")]
        public string contact()
        {
            return $"This is my Contact!";
        }
        
    }
}