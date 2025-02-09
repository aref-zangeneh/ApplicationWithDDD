

using ApplicationWithDDD.Application.Models.CourseManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationWithDDD.Infrastructure.EF.Configs.ReadConfigs
{
    internal sealed partial class ReadConfiguration :
        IEntityTypeConfiguration<CourseReadModel>,
        IEntityTypeConfiguration<CourseCatalogReadModel>,
        IEntityTypeConfiguration<CourseAttendeeReadModel>,
        IEntityTypeConfiguration<LessonReadModel>,
        IEntityTypeConfiguration<InstructorReadModel>

    {
        public void Configure(EntityTypeBuilder<InstructorReadModel> builder)
        {
            builder.ToTable("Instructors");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.FullName);
            builder.Property(i => i.Biography);
            builder.Property(i => i.Rating);
            builder.Property(i => i.Experience);
            // relations
            builder.HasMany(i => i.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(c => c.InstructorId);
        }

        public void Configure(EntityTypeBuilder<LessonReadModel> builder)
        {
            builder.ToTable("Lessons");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Title).IsRequired();
            builder.Property(l => l.VideoUrl);
            builder.Property(l => l.CatalogId);

            // relations
            builder.HasOne(l => l.CourseCatalog)
                .WithMany(cc => cc.Lessons)
                .HasForeignKey(l => l.CatalogId);
        }

        public void Configure(EntityTypeBuilder<CourseAttendeeReadModel> builder)
        {
            builder.ToTable("CourseAttendees");
            builder.HasKey(ca => ca.Id);
            builder.Property(ca => ca.UserId);
            builder.HasOne(ca => ca.User)
                .WithMany(u => u.CourseAttendees)
                .HasForeignKey(ca => ca.UserId);
            builder.HasOne(ca =>ca.Course)
                .WithMany(c => c.CourseAttendees)
                .HasForeignKey(ca => ca.CourseId);
        }

        public void Configure(EntityTypeBuilder<CourseCatalogReadModel> builder)
        {
            builder.ToTable("CourseCatalogs");
            builder.HasKey(cc => cc.Id);
            builder.Property(cc => cc.Title).IsRequired();
            builder.Property(cc => cc.Description).IsRequired();

            //relations
            builder.Property(cc => cc.CourseId);
            builder.HasOne(cc => cc.Course)
                .WithMany(c => c.CourseCatalogs)
                .HasForeignKey(cc => cc.CourseId);

            builder.HasMany(cc => cc.Lessons)
                .WithOne(l => l.CourseCatalog)
                .HasForeignKey(l => l.CatalogId);

        }

        public void Configure(EntityTypeBuilder<CourseReadModel> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).IsRequired();
            builder.Property(c => c.Desctription);
            builder.Property(c => c.IsFree);
            builder.Property(c => c.Price);

            // relations 
            builder.Property(c => c.InstructorId);
            builder.HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId);

            builder.HasMany(c => c.CourseAttendees)
                .WithOne(ca => ca.Course)
                .HasForeignKey(ca => ca.CourseId);

            builder.HasMany(c => c.CourseCatalogs)
                .WithOne(cc => cc.Course)
                .HasForeignKey(cc => cc.CourseId);
        }
    }
}
