using System.Linq;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class SubjectRepository: CommonRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        protected override IQueryable<Subject> CollectionWithIncludes => Collection;
    }
}