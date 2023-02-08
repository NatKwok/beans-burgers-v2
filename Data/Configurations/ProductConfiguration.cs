using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeansBurgers_v2.Data
{
    public class ProductConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
        }
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
        }

    }
}