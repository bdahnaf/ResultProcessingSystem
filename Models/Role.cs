namespace ResultProcessingSystem.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameBn { get; set; }
        public string Description { get; set; }
        public string DescriptionBn { get; set; }
        public bool IsActive { get; set; }
    }
}
