using System;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Models
{
    public class Student : IEntity
    {
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        public Group Group { get; set; }
        
        public DateTime EnteringDate { get; set; }
        
        public DateTime? GraduationDate { get; set; }
        
        public Credentials Credentials { get; set; }
    }
}