using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using static Jerry.BookStore.Tasks.Task;

namespace Jerry.BookStore.Tasks.Dto
{
    [AutoMapFrom(typeof(Task))]
    public class TaskListDto : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State  { get; set; }

        public Guid? AssignedPersonId { get; set; }
        public string AssignedPersonName { get; set; }

    }
}
