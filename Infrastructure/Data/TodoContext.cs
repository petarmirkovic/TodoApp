using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users {get;set;}
        public DbSet<SubTask> SubTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubTask>()
            .HasOne(s => s.Todo)
            .WithMany(t => t.SubTasks)
            .HasForeignKey(s => s.TodoId);

            modelBuilder.Entity<Todo>()
            .HasOne(t => t.User)
            .WithMany(u=>u.UserTodos)
            .HasForeignKey(t=>t.UserId);

        }
    }
}