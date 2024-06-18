using PeopleKPMG.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleKPMG.Application.Interfaces
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDto>> GetAllPersons();
        Task<PersonDto> GetPersonById(int id);
        Task AddPerson(PersonDto personDto);
        Task UpdatePerson(int id, PersonDto personDto);
        Task DeletePerson(int id);
    }
}
