using Microsoft.EntityFrameworkCore;
using PeopleKPMG.Core.Entities;
using PeopleKPMG.Core.Interfaces;

namespace PeopleKPMG.Infrastructure.Data
{
    public class PersonRepository : IPersonRepository
    {

        private readonly PeopleContext _context;

        public PersonRepository(PeopleContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var person = await _context.Persons.Include(p => p.Dependents).FirstOrDefaultAsync(p => p.Id == id);
            if (person != null)
            {
                _context.Persons.Remove(person);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _context.Persons.Include(p => p.Dependents).ToListAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _context.Persons.Include(p => p.Dependents).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(Person person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
