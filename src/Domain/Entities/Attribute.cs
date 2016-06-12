namespace Domain.Entities
{
    public class Attribute
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public long ProductTypeId { get; set; }
    }
}

