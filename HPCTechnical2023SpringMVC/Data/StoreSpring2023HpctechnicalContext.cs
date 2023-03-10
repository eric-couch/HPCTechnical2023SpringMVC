using System;
using System.Collections.Generic;
using HPCTechnical2023SpringMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace HPCTechnical2023SpringMVC.Data;

public partial class StoreSpring2023HpctechnicalContext : DbContext
{
    public StoreSpring2023HpctechnicalContext()
    {
    }

    public StoreSpring2023HpctechnicalContext(DbContextOptions<StoreSpring2023HpctechnicalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
