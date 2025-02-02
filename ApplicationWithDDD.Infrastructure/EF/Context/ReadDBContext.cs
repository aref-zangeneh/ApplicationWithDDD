
using ApplicationWithDDD.Infrastructure.EF.Configs.ReadConfigs;
using ApplicationWithDDD.Infrastructure.EF.Models.CourseManagement;
using ApplicationWithDDD.Infrastructure.EF.Models.PaymentManagement;
using ApplicationWithDDD.Infrastructure.EF.Models.UserManagement;
using Microsoft.EntityFrameworkCore;

namespace ApplicationWithDDD.Infrastructure.EF.Context
{
    public sealed class ReadDBContext : DbContext
    {
        #region    Course Management DbSets
        public DbSet<CourseReadModel> Courses { get; set; }
        public DbSet<CourseCatalogReadModel> CourseCatalogs { get; set; }
        public DbSet<CourseAttendeeReadModel> CourseAttendees { get; set; }
        public DbSet<LessonReadModel> Lessons { get; set; }
        public DbSet<InstructorReadModel> Instructors { get; set; }
        #endregion

        #region User Management DbSets
        public DbSet<UserReadModel> Users { get; set; }
        public DbSet<RoleReadModel> Roles{ get; set; }
        public DbSet<UserRoleReadModel> UserRoles { get; set; }
        #endregion

        #region Payment Management DbSets
        public DbSet<InvoiceReadModel> Invoices { get; set; }
        #endregion

        public ReadDBContext(DbContextOptions<ReadDBContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configuration = new ReadConfiguration();

            // Course Management Configuration
            modelBuilder.ApplyConfiguration<CourseReadModel>(configuration);
            modelBuilder.ApplyConfiguration<CourseCatalogReadModel>(configuration);
            modelBuilder.ApplyConfiguration<CourseAttendeeReadModel>(configuration);
            modelBuilder.ApplyConfiguration<LessonReadModel>(configuration);
            modelBuilder.ApplyConfiguration<InstructorReadModel>(configuration);

            // User Management Configurations
            modelBuilder.ApplyConfiguration<UserReadModel>(configuration);
            modelBuilder.ApplyConfiguration<RoleReadModel>(configuration);
            modelBuilder.ApplyConfiguration<UserRoleReadModel>(configuration);

            // Payment Management Configurations
            modelBuilder.ApplyConfiguration<InvoiceReadModel>(configuration);
        }
    }
}
