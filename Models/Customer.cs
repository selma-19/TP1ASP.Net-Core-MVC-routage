namespace tp1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public int MembershipTypeId { get; set; }
        public virtual MembershipType? MembershipType { get; set; }
        public ICollection<Movie>? Movies { get; set; }

    }
}
