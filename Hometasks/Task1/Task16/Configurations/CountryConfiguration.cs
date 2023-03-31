using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task16.Entities;

namespace Task16.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<CountyEntity>
    {
        public void Configure(EntityTypeBuilder<CountyEntity> builder)
        {
            builder.ToTable("Countries").HasKey(country => country.Id);
        }
    }
}