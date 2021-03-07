using System;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Models
{
    public class AcademicPerformance : IEntity
    {
        public Guid Id { get; set; }

        public Subject Subject { get; set; }

        public AssessmentType AssessmentType { get; set; }

        public Student Student { get; set; }
    }
}