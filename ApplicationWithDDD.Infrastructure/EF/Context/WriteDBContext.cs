using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.Entities.PaymentManagement;
using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Infrastructure.EF.Configs.WriteConfigs;
using Microsoft.EntityFrameworkCore;

namespace ApplicationWithDDD.Infrastructure.EF.Context
{
    public sealed class WriteDBContext : DbContext
    {
        #region    Course Management DbSets
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCatalog> CourseCatalogs { get; set; }
        public DbSet<CourseAttendee> CourseAttendees { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        #endregion

        #region User Management DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        #region Payment Management DbSets
        public DbSet<Invoice> Invoices { get; set; }
        #endregion

        public WriteDBContext(DbContextOptions<WriteDBContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configuration = new WriteConfiguration();

            // Course Management Configuration
            modelBuilder.ApplyConfiguration<Course>(configuration);
            modelBuilder.ApplyConfiguration<CourseCatalog>(configuration);
            modelBuilder.ApplyConfiguration<CourseAttendee>(configuration);
            modelBuilder.ApplyConfiguration<Lesson>(configuration);
            modelBuilder.ApplyConfiguration<Instructor>(configuration);

            // User Management Configurations
            modelBuilder.ApplyConfiguration<User>(configuration);
            modelBuilder.ApplyConfiguration<Role>(configuration);
            modelBuilder.ApplyConfiguration<UserRole>(configuration);

            // Payment Management Configurations
            modelBuilder.ApplyConfiguration<Invoice>(configuration);
        }
    }
}
