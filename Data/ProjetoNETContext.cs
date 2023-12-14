using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto.NET.Models;

namespace Projeto.NET.Data
{
    public class ProjetoNETContext : DbContext
    {
        public ProjetoNETContext (DbContextOptions<ProjetoNETContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto.NET.Models.Department> Department { get; set; } = default!;
    }
}
