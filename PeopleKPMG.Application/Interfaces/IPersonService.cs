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
        Task<IEnumerable<PersonDto>> GetAllPersonsAsync();
        Task<PersonDto> GetPersonByIdAsync(int id);
        Task AddPersonAsync(PersonDto personDto);
        Task UpdatePersonAsync(int id, PersonDto personDto);
        Task DeletePersonAsync(int id);
    }
}
