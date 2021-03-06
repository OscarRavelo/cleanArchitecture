using Cebolla.Infraestructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Cebolla.Infraestructure.Context
{
    public class EntityContext: DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options)
            : base(options)
        {



        }

        public DbSet<User> User { get; set; }

    }
}
