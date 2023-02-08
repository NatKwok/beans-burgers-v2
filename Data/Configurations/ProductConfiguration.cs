using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeansBurgers_v2.Data
{
    public class ProductConfiguration : IEntityTypeConfiguration<Burger>
    {
        public void Configure(EntityTypeBuilder<Burger> builder)
        {
        }
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
        }

    }
}