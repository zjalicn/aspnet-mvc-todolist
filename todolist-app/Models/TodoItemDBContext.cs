using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace todolist_app.Models
{
    public partial class TodoItemDBContext : DbContext
    {
        public TodoItemDBContext()
        {
        }

        public TodoItemDBContext(DbContextOptions<TodoItemDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TodoItem> TodoItems { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>(entity =>
            {
                entity.HasKey("Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsComplete).HasColumnName("isComplete");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
