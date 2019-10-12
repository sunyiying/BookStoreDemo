using Jerry.BookStore.EntityFrameworkCore;
using Jerry.BookStore.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jerry.BookStore.Tests.Tasks
{
    public class TestDataBuilder
    {
        private readonly BookStoreDbContext _context;

        public TestDataBuilder(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.Tasks.AddRange(
                new Task("Flow the white rabbit", "Follow the white rabbit in order to know the reality."),
                new Task("Clean your room") { State = Task.TaskState.Completed }
                );
        }
    }
}
