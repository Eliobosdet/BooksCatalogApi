using System.ComponentModel.DataAnnotations;

namespace BooksCatalogApi.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public required string Title { get; set; }

        public string? Author {  get; set; }
        public int? PublicationYear { get; set; }

    }
}
