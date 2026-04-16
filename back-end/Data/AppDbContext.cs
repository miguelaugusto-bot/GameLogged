using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace back_end.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){}

        //criação do banco de dados, mas preciso saber como coloca um if notexists
        public DbSet<Usuario> gamelogged { get; set; } //cria tabelas
    }
}