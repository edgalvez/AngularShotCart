using Microsoft.EntityFrameworkCore;
using PosApi.Data.Models;
using PosApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosApi.Data
{
    public class PosContex :DbContext
    {
        public PosContex(DbContextOptions<PosContex> options):base(options)
        {
            
        }

        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategory { get; set; }
    }
}
