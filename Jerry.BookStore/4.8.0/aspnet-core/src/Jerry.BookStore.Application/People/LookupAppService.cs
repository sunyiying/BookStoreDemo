﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;

namespace Jerry.BookStore.People
{
    public class LookupAppService : BookStoreAppServiceBase, ILookupAppService
    {
        private readonly IRepository<Persons.Person, Guid> _personRepository;

        public LookupAppService(IRepository<Persons.Person, Guid> personRepository)
        {
            _personRepository = personRepository;
        }


        public async Task<ListResultDto<ComboboxItemDto>> GetPeopleComboboxItems()
        {
            var people = await _personRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                people.Select(
                                 p => new ComboboxItemDto(p.Id.ToString("D"), p.Name)
                            ).ToList());
        }
    }
}
