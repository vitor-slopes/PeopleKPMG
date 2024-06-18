using PeopleKPMG.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleKPMG.Core.Interfaces
{
    internal interface Interface1
    {
        Task<IEnumerable<Person>> GetAll();
        Task<Person> GetById(int id);
        Task Add(Person person);
        Task Update(Person person);
        Task Delete(int id);
    }
}
