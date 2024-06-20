using PeopleKPMG.Application.DTOs;

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
