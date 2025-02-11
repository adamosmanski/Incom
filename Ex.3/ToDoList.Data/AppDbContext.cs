using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDoList.Model.ToDoList.Model;

namespace ToDoList.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=Incom-Rekrutacja;Trusted_Connection=True;");
        }
    }
}
