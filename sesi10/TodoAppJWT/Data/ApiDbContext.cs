using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoAppJwt.Models;


namespace TodoAppJwt.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}
