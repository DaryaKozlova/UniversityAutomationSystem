using System;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Models
{
    public class Teacher : IEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Credentials Credentials { get; set; }

        public FacultyDepartment FacultyDepartment { get; set; }

        public DateTime HireDateTime { get; set; }

        public DateTime? FireDateTime { get; set; }
    }
}