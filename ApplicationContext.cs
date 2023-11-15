﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miration_Bd
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Human> Humans { get; set; } = null!;
        public ApplicationContext() 
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=hello.db");
        }
    }
}
