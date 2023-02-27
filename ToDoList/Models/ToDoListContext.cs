using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}