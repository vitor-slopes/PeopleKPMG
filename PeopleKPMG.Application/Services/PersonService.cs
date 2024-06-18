using PeopleKPMG.Application.DTOs;
using PeopleKPMG.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleKPMG.Application.Services
{
    public class PersonService : IPersonService
    {
        public Task AddPerson(PersonDto personDto)
        {
            throw new NotImplementedException();
        }

        public Task DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PersonDto>> GetAllPersons()
        {
            throw new NotImplementedException();
        }

        public Task<PersonDto> GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePerson(int id, PersonDto personDto)
        {
            throw new NotImplementedException();
        }
    }
}
