using PeopleKPMG.Application.DTOs;
using PeopleKPMG.Application.Interfaces;
using PeopleKPMG.Core.Entities;
using PeopleKPMG.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleKPMG.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        public async Task AddPersonAsync(PersonDto personDto)
        {
            var person = new Person
            {
                Name = personDto.Name,
                Age = personDto.Age,
                Dependents = personDto.Dependents.Select(d => new Dependent
                {
                    Name = d.Name,
                    Age = d.Age
                }).ToList()
            };
            await _personRepository.AddAsync(person);
        }

        public async Task DeletePersonAsync(int id)
        {
            await _personRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PersonDto>> GetAllPersonsAsync()
        {
            var persons = await _personRepository.GetAllAsync();
            return persons.Select(p => new PersonDto
            {
                Id = p.Id,
                Name = p.Name,
                Age = p.Age,
                Dependents = p.Dependents.Select(d => new DependentDto
                {
                    Id = d.Id,
                    Name = d.Name,
                    Age = d.Age
                }).ToList()
            }).ToList();
        }

        public async Task<PersonDto> GetPersonByIdAsync(int id)
        {
            var person = await _personRepository.GetByIdAsync(id);
            if(person == null) return null;

            return new PersonDto
            {
                Id = person.Id,
                Name = person.Name,
                Age = person.Age,
                Dependents = person.Dependents.Select(d => new DependentDto
                {
                    Id = d.Id,
                    Name = d.Name,
                    Age = d.Age
                }).ToList()
            };
        }

        public async Task UpdatePersonAsync(int id, PersonDto personDto)
        {
            var person = await _personRepository.GetByIdAsync(id);
            if (person == null) return;

            person.Name = personDto.Name;
            person.Age = personDto.Age;
            person.Dependents = personDto.Dependents.Select(d => new Dependent
            {
                Id = d.Id,
                Name = d.Name,
                Age = d.Age,
                PersonId = id
            }).ToList();

            await _personRepository.UpdateAsync(person);
        }
    }
}
