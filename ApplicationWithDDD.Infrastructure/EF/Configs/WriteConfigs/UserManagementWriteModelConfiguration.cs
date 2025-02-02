using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApplicationWithDDD.Infrastructure.EF.Configs.WriteConfigs
{
    internal sealed partial class WriteConfiguration :
        IEntityTypeConfiguration<User>,
        IEntityTypeConfiguration<Role>,
        IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.Property(typeof(BaseId), "_userId")
                .HasConversion(IdConeverter)
                .HasColumnName("UserId")
                .IsRequired();

            builder.Property(typeof(BaseId), "_roleId")
                .HasConversion(IdConeverter)
                .HasColumnName("RoleId")
                .IsRequired();

            builder.HasKey("_userId", "_roleId");

            builder.HasOne<User>()
                .WithMany("_userRoles")
                .HasForeignKey("_userId");

            builder.HasOne<Role>()
                .WithMany("_userRoles")
                .HasForeignKey("_roleId");

            builder.ToTable("UserRoles");
        }

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            var roleNameConverter = new ValueConverter<RoleName, string>(rn => rn.Value, rn => new RoleName(rn));

            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
                .HasConversion(IdConeverter);

            builder.Property(typeof(RoleName), "_roleName")
                .HasConversion(roleNameConverter)
                .HasColumnName("RoleName")
                .IsRequired();

            builder.HasMany(typeof(UserRole), "_userRoles")
                .WithOne()
                .HasForeignKey("_roleId");

            builder.ToTable("Roles");
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            var usernameConverter = new ValueConverter<Username, string>(un => un.Value, un => new Username(un));
            var passwordConverter = new ValueConverter<Password, string>(p => p.Value, p => new Password(p));
            var emailConverter = new ValueConverter<Email, string>(e => e.Value, e => new Email(e));

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
                .HasConversion(IdConeverter);

            builder.Property(typeof(Username), "_username")
                .HasConversion(usernameConverter)
                .HasColumnName("Username")
                .IsRequired();

            builder.Property(typeof(Password), "_password")
                .HasConversion(passwordConverter)
                .HasColumnName("Password")
                .IsRequired();

            builder.Property(typeof(Email), "_email")
                .HasConversion(emailConverter)
                .HasColumnName("Email")
                .IsRequired();

            builder.Property(typeof(bool), "_isConfirmed")
                .HasColumnName("IsConfirmed");

            builder.HasMany(typeof(CourseAttendee), "_courseAttendees")
                .WithOne()
                .HasForeignKey("_userId");

            builder.HasMany(typeof(UserRole), "_userRoles")
                .WithOne()
                .HasForeignKey("_userId");

            builder.ToTable("Users");

        }
    }
}
