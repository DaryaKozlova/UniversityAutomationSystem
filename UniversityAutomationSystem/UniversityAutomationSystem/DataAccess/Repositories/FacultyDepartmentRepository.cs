using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class FacultyDepartmentRepository : CommonRepository<FacultyDepartment>, IFacultyDepartmentRepository
    {
        public FacultyDepartmentRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        protected override IQueryable<FacultyDepartment> CollectionWithIncludes => Collection;
    }
}