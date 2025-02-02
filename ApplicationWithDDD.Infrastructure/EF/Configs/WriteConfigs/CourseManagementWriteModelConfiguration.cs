using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApplicationWithDDD.Infrastructure.EF.Configs.WriteConfigs
{
    internal sealed partial class WriteConfiguration :
        IEntityTypeConfiguration<Course>,
        IEntityTypeConfiguration<CourseCatalog>,
        IEntityTypeConfiguration<CourseAttendee>,
        IEntityTypeConfiguration<Lesson>,
        IEntityTypeConfiguration<Instructor>
    {
        private ValueConverter IdConeverter = new ValueConverter<BaseId, Guid>(id => id.Value, id => new BaseId(id));
        private ValueConverter TitleConeverter = new ValueConverter<Title, string>(t => t.Value, t => new Title(t));
        private ValueConverter DescriptionConeverter = new ValueConverter<Description, string>(d => d.Value, d => new Description(d));

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            var priceConeverter = new ValueConverter<Price, decimal>(p => p.Value, p => new Price(p));

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasConversion(IdConeverter);

            builder.Property(typeof(Title), "_title")
                .HasConversion(TitleConeverter)
                .HasColumnName("Title")
                .IsRequired();

            builder.Property(typeof(Description), "_description")
                .HasConversion(DescriptionConeverter)
                .HasColumnName("Description")
                .IsRequired();


            builder.Property(typeof(bool), "_isFree")
                .HasColumnName("IsFree");

            builder.Property(typeof(Price), "_price")
                .HasConversion(priceConeverter)
                .HasColumnName("Price")
                .IsRequired();

            builder.Property(typeof(BaseId), "_instructorId")
                .HasConversion(IdConeverter)
                .HasColumnName("InstructorId");

            builder.HasOne<Instructor>()
                .WithMany()
                .HasForeignKey("_instructorId")
                .IsRequired();

            builder.HasMany(typeof(CourseAttendee), "_courseAttendees")
                .WithOne()
                .HasForeignKey("_courseId");

            builder.ToTable("Courses");
        }

        public void Configure(EntityTypeBuilder<CourseCatalog> builder)
        {
            builder.HasKey(cc => cc.Id);
            builder.Property(cc => cc.Id)
                .HasConversion(IdConeverter);

            builder.Property(typeof(Title), "_title")
                .HasConversion(TitleConeverter)
                .HasColumnName("Title")
                .IsRequired();

            builder.Property(typeof(Description), "_description")
                .HasConversion(DescriptionConeverter)
                .HasColumnName("Description")
                .IsRequired();

            builder.Property(typeof(BaseId), "_courseId")
                .HasConversion(IdConeverter)
                .HasColumnName("CourseId");

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey("_courseId")
                .IsRequired();

            builder.HasMany(typeof(Lesson), "_lessons")
                .WithOne()
                .HasForeignKey("_courseCatalogId")
                .IsRequired();
        }

        public void Configure(EntityTypeBuilder<CourseAttendee> builder)
        {
            builder.HasKey(ca => ca.Id);
            builder.Property(ca => ca.Id)
                .HasConversion(IdConeverter);

            builder.Property(typeof(BaseId), "_userId")
                .HasConversion(IdConeverter)
                .HasColumnName("UserId");

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey("_userId")
                .IsRequired();

            builder.Property(typeof(BaseId), "_courseId")
                .HasConversion(IdConeverter)
                .HasColumnName("CourseId");

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey("_courseId")
                .IsRequired();

            builder.ToTable("CourseAttendees");
        }

        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            var urlConeverter = new ValueConverter<VideoUrl, string>(v =>v.Value, v => new VideoUrl(v));

            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id)
                .HasConversion(IdConeverter);

            builder.Property(typeof(Title), "_title")
                .HasConversion(TitleConeverter)
                .HasColumnName("Title")
                .IsRequired();

            builder.Property(typeof(VideoUrl), "_videoUrl")
                .HasConversion(urlConeverter)
                .HasColumnName("VideoUrl")
                .IsRequired();

            builder.Property(typeof(BaseId), "_courseCatalogId")
                .HasConversion(IdConeverter)
                .HasColumnName("CourseCatalogId");

            builder.HasOne<CourseCatalog>()
                .WithMany()
                .HasForeignKey("_courseCatalogId")
                .IsRequired();

            builder.ToTable("Lessons");
        }

        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            var fullNameConeverter = new ValueConverter<FullName, string>(f => f.Value, f => new FullName(f));
            var bioConeverter = new ValueConverter<Biography, string>(b => b.Value, b => new Biography(b));

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .HasConversion(IdConeverter);

            builder.Property(typeof(FullName), "_fullName")
                .HasConversion(fullNameConeverter)
                .HasColumnName("FullName")
                .IsRequired();

            builder.Property(typeof(Biography), "_bio")
                .HasConversion(bioConeverter)
                .HasColumnName("Biography")
                .IsRequired();

            builder.Property(typeof(double), "_rating")
                .HasColumnName("Rating"); 
            
            builder.Property(typeof(int), "_experience")
                .HasColumnName("Experience");

            builder.HasMany(typeof(Course), "_courses")
                .WithOne()
                .HasForeignKey("_instructorId");

            builder.ToTable("Instructors");
        }
    }
}
