using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBFirstDemo.Models;

public partial class Ccad9accountingContext : DbContext
{
    public Ccad9accountingContext()
    {
    }

    public Ccad9accountingContext(DbContextOptions<Ccad9accountingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6DJ6U5N\\SQLEXPRESS;Database=CCAD9Accounting;integrated security=True;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.Property(e => e.BookId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BookID");
            entity.Property(e => e.Author).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
