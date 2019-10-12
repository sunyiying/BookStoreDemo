using Jerry.BookStore.Tasks;
using Shouldly;
using Xunit;
using System.Linq;
using Abp.Runtime.Validation;

namespace Jerry.BookStore.Tests.Tasks
{

    public class TaskAppService_Tests : BookStoreTestBase
    {
        private readonly ITaskAppService _taskAppService;

        //public TaskAppService_Tests(ITaskAppService taskAppService)
        //{
        //    _taskAppService = taskAppService;
        //}

        public TaskAppService_Tests()
        {
            _taskAppService = Resolve<ITaskAppService>();
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Tasks()
        {
            //Act
            var output = await _taskAppService.GetAll(new GetAllTaskInput());

            //Assert
            output.Items.Count.ShouldBe(2);
            output.Items.Count(t => t.AssignedPersonName != null).ShouldBe(1);
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_Filtered_Tasks()
        {
            var output = await _taskAppService.GetAll(new GetAllTaskInput { State = Task.TaskState.Open });

            //Assert
            output.Items.ShouldAllBe(t => t.State == Task.TaskState.Open);
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Create_New_Task_With_Title()
        {
            await _taskAppService.Create(new BookStore.Tasks.Dto.CreateTaskInput
            {
                Title = "Newly created task #1"
            });
            UsingDbContext(context =>
            {
                var task1 = context.Tasks.FirstOrDefault(t => t.Title == "Newly created task #1");
                task1.ShouldNotBeNull();
            });
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Create_New_Task_With_Title_And_Assigned_Person()
        {
            var jerry = UsingDbContext(context => context.People.Single(p => p.Name == "Jerry"));
            await _taskAppService.Create(new BookStore.Tasks.Dto.CreateTaskInput
            {
                Title = "Newly created task #1",
                AssignedPersonId = jerry.Id
            });
            UsingDbContext(context =>
            {
                var task = context.Tasks.FirstOrDefault(t => t.Title == "Newly created task #1");
                task.ShouldNotBeNull();
                task.AssignedPersonId.ShouldBe(jerry.Id);
            });
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Not_Create_New_Task_Without_Title()
        {
            await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _taskAppService.Create(new BookStore.Tasks.Dto.CreateTaskInput
                {
                    Title = null
                });
            });
        }
        
    }

}
