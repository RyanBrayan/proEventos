using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.models;
using Microsoft.EntityFrameworkCore;

namespace back.Data
{
    
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet<Evento> eventos { get; set; }
    }
}