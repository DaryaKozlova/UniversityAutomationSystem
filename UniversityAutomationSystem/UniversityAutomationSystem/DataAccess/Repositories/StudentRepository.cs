using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class StudentRepository: CommonRepository<Student>, IStudentRepository
    {
        public StudentRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

        protected override IQueryable<Student> CollectionWithIncludes => Collection
            .Include(e => e.Credentials)
            .Include(e => e.Group).ThenInclude(e => e.Specialty).ThenInclude(e => e.Department);
    }
}