using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleKPMG.Application.DTOs
{
    public class PersonDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public List<DependentDto>? Dependents { get; set; }
    }

    public class DependentDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
    }
}
