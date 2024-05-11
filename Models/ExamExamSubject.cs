// Name change decision 
﻿namespace ResultProcessingSystem.Models
{
    // To Establish Many-to-Many relationship between ExamExamSubject
    public class ExamExamSubject
    {
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        public int ExamSubjectId { get; set; }
        public ExamSubject ExamSubject { get; set; }
    }
}
