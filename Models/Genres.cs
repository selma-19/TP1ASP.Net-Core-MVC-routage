namespace tp1.Models
{
    public class Genres
    {
        public int Id { get; set; }
        public string? GenreName { get; set; }
        public ICollection<Movie>? movies { get; set; }
    }
}
