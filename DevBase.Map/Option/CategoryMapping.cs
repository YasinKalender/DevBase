using DevBase.Entities.ORM.Concerte;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Map.Option
{
    public class CategoryMapping:BaseMapping<Category>
    {

        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(i => i.CategoryName).IsRequired().HasMaxLength(100);

            builder.HasMany(i => i.Product)
                .WithOne(i => i.Category)
                .HasForeignKey(i => i.CategoryID);


            base.Configure(builder);
        }
    }
}
