namespace Domain.Entity
{
    public class Products
    {
        public long Id { get; set; }
        public string Name { get; set; } = default;
        public string  Description { get; set; } = default;
        public short Amount { get; set; }
    }
}