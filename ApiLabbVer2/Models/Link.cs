using System.ComponentModel.DataAnnotations;

namespace ApiLabbVer2.Models
{
    public class Link
    {
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }
        public int PersonId { get; set; }
        public int InterstId { get; set; }

    }
}
