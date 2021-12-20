using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ManitasWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ManitasWeb.Models.Categoria> Categoria { get; set; }
        public DbSet<ManitasWeb.Models.Material> Material { get; set; }
        public DbSet<ManitasWeb.Models.Producto> Producto { get; set; }
    }
}
