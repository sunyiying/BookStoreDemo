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

        public void Create()
        {
            Build();
        }

        public void Build()
        {
            var jerry = new Persons.Person("Jerry");
            _context.People.Add(jerry);
            _context.SaveChanges();


            _context.Tasks.AddRange(
                new Task("Flow the white rabbit", "Follow the white rabbit in order to know the reality.",jerry.Id),
                new Task("Clean your room") { State = Task.TaskState.Completed }
                );
        }
    }
}
