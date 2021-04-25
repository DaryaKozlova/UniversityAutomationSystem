using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class AdministratorRepository : CommonRepository<Administrator>, IAdministratorRepository
    {
        public AdministratorRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        protected override IQueryable<Administrator> CollectionWithIncludes => Collection
            .Include(e => e.Credentials);
    }
}