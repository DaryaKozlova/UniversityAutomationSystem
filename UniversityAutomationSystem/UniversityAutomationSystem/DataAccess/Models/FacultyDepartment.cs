﻿using System;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Models
{
    public class FacultyDepartment : IEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
    }
}