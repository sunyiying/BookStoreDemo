using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Jerry.BookStore.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jerry.BookStore.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        /// <summary>
        /// 查询任务
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTaskInput input);


        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task Create(CreateTaskInput input);


    }
}
