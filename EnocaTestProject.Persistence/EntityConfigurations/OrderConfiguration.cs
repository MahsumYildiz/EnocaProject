using EnocaTestProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaTestProject.Persistence.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.OrderDesi).IsRequired();
            builder.Property(o=>o.OrderDate).IsRequired();
            builder.Property(o=>o.OrderCarrierCost).IsRequired();
            builder.HasOne(o => o.Carrier).WithMany(c => c.Orders).HasForeignKey(c => c.CarrierId);



        }
    }
}
