using System.ComponentModel.DataAnnotations;

namespace Class10.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
