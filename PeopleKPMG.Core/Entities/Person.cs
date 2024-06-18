using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleKPMG.Core.Entities
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Dependent>? Dependents { get; set; }
    }

    public class Dependent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PersonId { get; set; }
        public required Person Person { get; set; }
    }
}
