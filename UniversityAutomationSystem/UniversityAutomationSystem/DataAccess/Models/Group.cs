using System;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Models
{
    public class Group : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Specialty Specialty { get; set; }
    }
}