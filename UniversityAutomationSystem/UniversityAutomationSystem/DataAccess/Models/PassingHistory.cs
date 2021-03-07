using System;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Models
{
    public class PassingHistory : IEntity
    {
        public Guid Id { get; set; }

        public AcademicPerformance AcademicPerformance { get; set; }

        public int? Grade { get; set; }

        public bool IsPassed { get; set; }

        public DateTimeOffset PassingDateTime { get; set; }
    }
}