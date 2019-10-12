using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jerry.BookStore.Controllers;
using Jerry.BookStore.Tasks;
using Jerry.BookStore.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jerry.BookStore.Web.Mvc.Controllers
{
    public class TaskController : BookStoreControllerBase
    {
        private readonly ITaskAppService _taskAppService;

        public TaskController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }



        public async Task<ActionResult> Index(GetAllTaskInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items)
            {
                 SelectedTaskState=input.State
            };
            return View(model);
        }
    }
}