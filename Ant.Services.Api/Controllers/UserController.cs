using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ant.Application.Interfaces;
using Ant.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ant.Services.Api.Controllers
{
    [Route("v1")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserAppService _userAppService;
        public  UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;

        }
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("M101")]
        public IActionResult Get()
        {
            var result = _userAppService.GetAll();
            return Ok(result);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("M102")]
        public IActionResult Get(Guid id)
        {
            var result = _userAppService.GetById(id);

            return Ok(result);
        }
        [HttpPost]
        [Route("M103")]
        public IActionResult Post([FromBody]UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                //NotifyModelStateErrors();
                return Ok(userViewModel);
            }

            _userAppService.Register(userViewModel);

            return Ok(userViewModel);
        }
    }
}
