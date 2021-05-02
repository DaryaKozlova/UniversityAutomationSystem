using System.Linq;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class AssessmentTypeRepository : CommonRepository<AssessmentType>, IAssessmentTypeRepository
    {
        public AssessmentTypeRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        protected override IQueryable<AssessmentType> CollectionWithIncludes => Collection;
    }
}