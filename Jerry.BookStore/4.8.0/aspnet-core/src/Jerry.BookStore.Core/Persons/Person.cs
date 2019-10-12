using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jerry.BookStore.Persons
{
    [Table("AppPersons")]
   public class Person:AuditedEntity<Guid>
    {
        public const int maxNameLength = 32;

        [Required]
        [StringLength(maxNameLength)]
        public string Name { get; set; }

        public Person() { }

        public Person(string name)
        {
            Name = name;
        }



    }
}
