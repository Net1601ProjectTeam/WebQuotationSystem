using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentApi
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            //builder.HasKey(x => x.AccountID);
            //builder.Property(x => x.AccountID).ValueGeneratedOnAdd();
            //builder.Property(x => x.Username).HasMaxLength(100);
            //builder.Property(x => x.Password).HasMaxLength(100);
            //builder.Property(x => x.Role).HasMaxLength(100);
        }
    }
}
