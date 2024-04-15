namespace ResultProcessingSystem.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamExamSubjectId { get; set; }
        public decimal Marks { get; set; }
    }
}
