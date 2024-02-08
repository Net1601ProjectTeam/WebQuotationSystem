using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentApi
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //builder.HasKey(x => x.CustomerID);
            //builder.Property(x => x.CustomerID).ValueGeneratedOnAdd();
            //builder.Property(x => x.AccountId).HasMaxLength(100);
            //builder.Property(x => x.FirstName).HasMaxLength(100);
            //builder.Property(x => x.LastName).HasMaxLength(100);
            //builder.Property(x => x.Email).HasMaxLength(100);
            //builder.Property(x => x.Phone).HasMaxLength(100);
            //builder.Property(x => x.Address).HasMaxLength(100);
            //builder.HasOne(x => x.Account)
            //    .WithOne(x => x.Customer)
            //    .HasForeignKey<Customer>(x => x.AccountId)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
