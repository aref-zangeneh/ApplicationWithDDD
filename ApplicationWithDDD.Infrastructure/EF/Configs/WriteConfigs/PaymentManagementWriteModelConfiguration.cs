using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.Entities.PaymentManagement;
using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApplicationWithDDD.Infrastructure.EF.Configs.WriteConfigs
{
    internal sealed partial class WriteConfiguration :
        IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            var amountConverter = new ValueConverter<Amount, decimal>(a => a.Value, a => new Amount(a));

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .HasConversion(IdConeverter);

            builder.Property(typeof(Amount), "_amount")
                .HasConversion(amountConverter)
                .HasColumnName("Amount")
                .IsRequired();

            builder.Property(typeof(DateTime), "_date")
                .HasColumnName("Date");

            builder.Property("_userId")
                .HasConversion(IdConeverter)
                .HasColumnName("UserId")
                .IsRequired();

            builder.Property("_courseId")
                .HasConversion(IdConeverter)
                .HasColumnName("CourseId")
                .IsRequired();

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey("_userId");

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey("_courseId");

            builder.ToTable("Invoices");
        }
    }

}
