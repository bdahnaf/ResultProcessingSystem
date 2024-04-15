namespace ResultProcessingSystem.Models
{
    // This will store the actual marks based on the subject and the student id
    public class Result
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamExamSubjectId { get; set; }
        public decimal Marks { get; set; }
    }
}
