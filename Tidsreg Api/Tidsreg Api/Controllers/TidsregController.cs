﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tidsreg_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TidsregController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Hello");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return 
        }
    }
}
