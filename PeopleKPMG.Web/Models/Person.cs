using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PeopleKPMG.Web.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome não pode exceder 50 caracteres.")]
        public string Name { get; set; }

        [Range(18, 120, ErrorMessage = "A idade deve ser entre 18 e 120.")]
        public int Age { get; set; }

        public List<Dependent> Dependents { get; set; } = new List<Dependent>();
    }

    public class Dependent
    {
        [Required(ErrorMessage = "O nome do dependente é obrigatório.")]
        public string Name { get; set; }

        [Range(18, 120, ErrorMessage = "A idade deve ser entre 18 e 120.")]
        public int Age { get; set; }
    }
}
