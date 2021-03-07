using System;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Models
{
    public class Administrator : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Credentials Credentials { get; set; }
    }
}