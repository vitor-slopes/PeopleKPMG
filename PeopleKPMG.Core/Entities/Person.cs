
namespace PeopleKPMG.Core.Entities
{
    public class Person
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
        public Person Person { get; set; }
    }
}
