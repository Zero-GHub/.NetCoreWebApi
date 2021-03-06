﻿using Core.Model;
using Core.Model.Models;
using Core.Model.SearchModels;
using Core.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.IServices.Mis
{
    public interface ISystemUserServices : IDependencyMsi
    {
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        Task<TableModel<UserInfoVM>> GetUserList(UserSearch search);
    }
}
