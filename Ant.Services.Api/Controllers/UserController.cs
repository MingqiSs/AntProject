using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ant.Application.Interfaces;
using Ant.Application.ViewModels;
using DotNetCore.CAP;
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
        ICapPublisher _capPublisher;
        public  UserController(IUserAppService userAppService, ICapPublisher capPublisher)
        {
            _userAppService = userAppService;
            _capPublisher = capPublisher;

        }
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("M101")]
        public IActionResult GetAll()
        {
            var result = _userAppService.GetAll();
            return Ok(result);
        }
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        [Route("M102")]
        public IActionResult Get(Guid id)
        {
            var result = _userAppService.GetById(id);

            return Ok(result);
        }
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="userViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(bool), 200)]
        [Route("M103")]
        public async Task<IActionResult> Post([FromBody]UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                //NotifyModelStateErrors();
                return Ok(false);
            }
            var r = await _userAppService.Register(userViewModel);

            return Ok(r);
        }
        /// <summary>
        /// cap测试
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("M104")]
        public IActionResult CapTest()
        {
             _capPublisher.PublishAsync("OrderCreated", 1);
            return Ok();
        }
    }
}
