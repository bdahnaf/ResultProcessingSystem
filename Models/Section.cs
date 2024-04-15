namespace ResultProcessingSystem.Models
{
    // Different Sections like A, B, C, D or Ka, Kha etc.
    // Each Section will have a SubjectId which it falls to. Like A, B, C will be for Science Subject.
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameBn { get; set; }
        public int SubjectId { get; set; }
    }
}
