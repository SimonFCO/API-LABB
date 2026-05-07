using System.ComponentModel.DataAnnotations;

namespace ApiLabbVer2.Models
{
    public class Interest
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Link> Links { get; set; }
    }
}
