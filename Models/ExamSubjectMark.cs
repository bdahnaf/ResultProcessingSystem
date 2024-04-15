namespace ResultProcessingSystem.Models
{
    public class ExamSubjectMark
    {
        public int Id { get; set; }
        public decimal FullMark { get; set; }
        public decimal PassMark { get; set; }
        public int ExamId { get; set; }
    }
}
