﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.AuthHelper.OverWrite;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Produces("application/json")]
    [EnableCors("LimitRequests")]
    public class LoginController : Controller
    {
        /// <summary>
        /// 获取token
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="sub">角色</param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetJWTStr(long id , string sub)
        {
            //这里就是用户登陆以后，通过数据库去调取数据，分配权限的操作
            TokenModelJWT tokenModel = new TokenModelJWT();
            tokenModel.Uid = id;
            tokenModel.Role = sub;

            // 获取token
            string jwtStr = JwtHelper.IssueJWT(tokenModel);
            return Json(jwtStr);
        }
    }
}