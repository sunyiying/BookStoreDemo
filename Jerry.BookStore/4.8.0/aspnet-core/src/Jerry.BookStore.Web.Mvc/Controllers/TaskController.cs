using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Jerry.BookStore.Controllers;
using Jerry.BookStore.People;
using Jerry.BookStore.Tasks;
using Jerry.BookStore.Web.Models.People;
using Jerry.BookStore.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jerry.BookStore.Web.Mvc.Controllers
{
    public class TaskController : BookStoreControllerBase
    {
        private readonly ITaskAppService _taskAppService;
        private readonly ILookupAppService _lookupAppService;

        public TaskController(ITaskAppService taskAppService, ILookupAppService lookupAppService)
        {
            _taskAppService = taskAppService;
            _lookupAppService = lookupAppService;
        }



        public async Task<ActionResult> Index(GetAllTaskInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items)
            {
                SelectedTaskState = input.State
            };
            return View(model);
        }

        public async Task<ActionResult> Create()
        {
            var peopleSelectListItems = (await _lookupAppService.GetPeopleComboboxItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            peopleSelectListItems.Insert(0, new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Value = string.Empty,
                Text = L("Unassigned"),
                Selected = true
            });

            return View(new CreateTaskViewModel(peopleSelectListItems));
        }



    }
}