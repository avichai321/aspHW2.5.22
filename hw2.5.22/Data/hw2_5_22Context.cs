using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hw2._5._22.Models;

namespace hw2._5._22.Data
{
    public class hw2_5_22Context : DbContext
    {
        public hw2_5_22Context (DbContextOptions<hw2_5_22Context> options)
            : base(options)
        {
        }

        public DbSet<hw2._5._22.Models.Recipe> Recipe { get; set; }
    }
}
