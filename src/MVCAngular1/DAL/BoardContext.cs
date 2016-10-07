using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCAngular1.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCAngular1.DAL
{
    public class BoardContext : DbContext
    {
        public BoardContext()
            : base()
        { }

        public DbSet<Board> data { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=BoardDB;user id=SRV_Test;password=Test123.;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
