using DevBase.Entities.ORM.Concerte;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.Map.Option
{
    public class ProductMapping:BaseMapping<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.Property(i => i.ProductName).IsRequired().HasMaxLength(100);
            builder.Property(i => i.ProductDescription).IsRequired().HasMaxLength(200);

            builder.HasOne(i => i.Category)
                .WithMany(i => i.Product)
                .HasForeignKey(i => i.CategoryID).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);

                

            base.Configure(builder);
        }

    }
}
