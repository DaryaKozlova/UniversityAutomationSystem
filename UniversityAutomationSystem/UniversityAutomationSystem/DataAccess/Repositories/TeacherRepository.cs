using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class TeacherRepository : CommonRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        protected override IQueryable<Teacher> CollectionWithIncludes => Collection
            .Include(e => e.Credentials)
            .Include(e => e.FacultyDepartment);

        //.Include(e => e.TeacherType);
    }
}