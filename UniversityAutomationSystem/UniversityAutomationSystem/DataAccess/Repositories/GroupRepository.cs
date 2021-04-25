using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class GroupRepository : CommonRepository<Group>, IGroupRepository
    {
        public GroupRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        protected override IQueryable<Group> CollectionWithIncludes => Collection
            .Include(e => e.Specialty).ThenInclude(e => e.Department);
    }
}