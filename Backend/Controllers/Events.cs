using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class Events : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var events = new List<Event>()
            {
                new Event { Id = 1, Title = "A", Details = "A Details", DateTime = DateTime.Now},
                new Event { Id = 2, Title = "B", Details = "B Details", DateTime = DateTime.Now},
                new Event { Id = 3, Title = "C", Details = "C Details", DateTime = DateTime.Now},
            };

            return Ok(events);
        }
    }
}