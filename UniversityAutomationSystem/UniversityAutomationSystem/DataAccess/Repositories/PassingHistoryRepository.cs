using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class PassingHistoryRepository : CommonRepository<PassingHistory>, IPassingHistoryRepository
    {
        public PassingHistoryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        protected override IQueryable<PassingHistory> CollectionWithIncludes => Collection
            .Include(e => e.AcademicPerformance).ThenInclude(e => e.AssessmentType)
            .Include(e => e.AcademicPerformance.Student).ThenInclude(e => e.Credentials)
            .Include(e => e.AcademicPerformance).ThenInclude(e => e.Subject);
    }
}