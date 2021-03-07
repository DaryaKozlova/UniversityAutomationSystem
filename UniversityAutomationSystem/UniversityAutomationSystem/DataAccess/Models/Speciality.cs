using System;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Models
{
    public class Specialty : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public FacultyDepartment Department { get; set; }
    }
}