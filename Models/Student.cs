﻿namespace ResultProcessingSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameBn { get; set; }
        public string FathersName { get; set; }
        public string FathersNameBn { get; set; }
        public string MothersName { get; set; }
        public string MothersNameBn { get; set; }
        public int SessionId { get; set; }
        public int SectionId { get; set; }
        public int SubjectId { get; set; }
        public int RollNumber { get; set; }
        public int BatchId { get; set; }
        public int Status { get; set; }
        public int IsActive { get; set; }
    }
}
