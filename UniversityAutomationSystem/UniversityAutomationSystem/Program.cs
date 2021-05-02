using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using UniversityAutomationSystem.DataAccess;
using UniversityAutomationSystem.DataAccess.Models;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;
using UniversityAutomationSystem.DataAccess.Repositories;
using UniversityAutomationSystem.DataAccess.Repositories.Interfaces;

namespace UniversityAutomationSystem
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static void Main()
        {
            ConfigureServices();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInForm());
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<DatabaseContext>();

            services.AddScoped<IAdministratorRepository, AdministratorRepository>();
            services.AddScoped<IAcademicPerformanceRepository, AcademicPerformanceRepository>();
            services.AddScoped<IAssessmentTypeRepository, AssessmentTypeRepository>();
            //services.AddScoped<IRepository<Credentials>, IRepository<Credentials>>();
            //services.AddScoped<IRepository<DeansOfficeWorker>, IRepository<DeansOfficeWorker>>();
            services.AddScoped<IFacultyDepartmentRepository, FacultyDepartmentRepository>();
            //services.AddScoped<IRepository<FacultyDepartment>, IRepository<FacultyDepartment>>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            //services.AddScoped<IRepository<Language>, IRepository<Language>>();
            services.AddScoped<IPassingHistoryRepository, PassingHistoryRepository>();
            //services.AddScoped<IRepository<Specialty>, IRepository<Specialty>>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            //services.AddScoped<IRepository<SubjectTeacher>, IRepository<SubjectTeacher>>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            //services.AddScoped<IRepository<TeacherType>, IRepository<TeacherType>>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
