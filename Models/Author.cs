namespace BooksCatalogApi.Models
{
    public class Author
    {
        public int Id { get; init; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required DateOnly BirthDay { get; set; }
        
    }
}
