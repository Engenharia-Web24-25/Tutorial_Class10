using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Class10.Models;

namespace Class10.Data
{
    public class Class10Context : DbContext
    {
        public Class10Context (DbContextOptions<Class10Context> options)
            : base(options)
        {
        }

        public DbSet<Class10.Models.Person> Person { get; set; } = default!;
    }
}
