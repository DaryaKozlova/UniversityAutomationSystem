using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class AcademicPerformanceRepository : CommonRepository<AcademicPerformance>, IAcademicPerformanceRepository
    {
        public AcademicPerformanceRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        protected override IQueryable<AcademicPerformance> CollectionWithIncludes => Collection
            .Include(e => e.AssessmentType)
            .Include(e => e.Student).ThenInclude(e => e.Credentials)
            .Include(e => e.Student).ThenInclude(e => e.Group).ThenInclude(e => e.Specialty)
            .ThenInclude(e => e.Department)
            .Include(e => e.Subject);
    }
}