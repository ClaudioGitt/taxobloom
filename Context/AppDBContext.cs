using Microsoft.EntityFrameworkCore;
using WebAppBloom.Models;
namespace WebAppBloom.Context;

public class AppDbContext:DbContext
{
    public DbSet<Competencia> Competencias => Set<Competencia>();


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("LAB-F08-02, Database WebAppBloom, user=sa,Password=senai@123,TrustServerCertificate=True,");
    }




}


