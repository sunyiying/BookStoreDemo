using Jerry.BookStore.Tasks;
using Shouldly;
using Xunit;

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
            var output = await _taskAppService.GetAll(new GetAllTaskInput());

            output.Items.Count.ShouldBe(2);
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_Filtered_Tasks()
        {
            var output =await _taskAppService.GetAll(new GetAllTaskInput { State = Task.TaskState.Open });

            //Assert
            output.Items.ShouldAllBe(t => t.State == Task.TaskState.Open);
        }



    }

}
