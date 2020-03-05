using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ant.Services.Api.Controllers
{
    [Route("v1")]
    [ApiController]
    public class UserController : ControllerBase
    {

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("M101")]
        public IActionResult Get()
        {

            return Ok();
        }


    }
}
