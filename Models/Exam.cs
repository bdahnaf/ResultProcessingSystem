namespace ResultProcessingSystem.Models
{
    // 1st Term, Second Term, Half Yearly, Yearly, Monthly Exams
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameBn { get; set; }
        // Add more properties
        public ICollection<ExamExamSubject> Exams { get; set; }
    }
}
