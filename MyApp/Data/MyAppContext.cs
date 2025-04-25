using System;
using Microsoft.EntityFrameworkCore;
using MyAPP.Models;

namespace MyAPP.Data;

public class MyAppContext : DbContext
{
    public MyAppContext(DbContextOptions<MyAppContext> options) :base(options) {}

    public DbSet<Item> Items {get; set;}
    
}
