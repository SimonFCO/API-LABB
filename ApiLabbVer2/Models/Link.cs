using System.ComponentModel.DataAnnotations;

namespace ApiLabbVer2.Models
{
    public class Link
    {
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public ICollection<Person> Persons { get; set; }

        [Required]
        public ICollection<Interest> Interests { get; set; }

    }
}
