using System;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Models
{
    public class SubjectTeacher : IEntity
    {
        public Guid Id { get; set; }

        public Teacher Teacher { get; set; }

        public Subject Subject { get; set; }

        //public TeacherType TeacherType { get; set; }

        public int Semester { get; set; }

        public int PracticalHours { get; set; }
        
        public int LectureHours { get; set; }
        
        public int SeminarHours { get; set; }
       
        public int LabHours { get; set; }

        public Language Language { get; set; }
    }
}