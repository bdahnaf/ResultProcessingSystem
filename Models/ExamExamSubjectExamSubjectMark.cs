namespace ResultProcessingSystem.Models
{
    public class ExamExamSubjectExamSubjectMark
    {
        public int ExamExamSubjectId { get; set; }
        public ExamExamSubject ExamExamSubject { get; set; }

        public int ExamSubjectMarkId { get; set; }
        public ExamSubjectMark ExamSubjectMark { get; set; }
    }
}
