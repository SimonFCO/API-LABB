using System.ComponentModel.DataAnnotations;

namespace ApiLabbVer2.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        public ICollection<Link> Links { get; set; }

    }
}
