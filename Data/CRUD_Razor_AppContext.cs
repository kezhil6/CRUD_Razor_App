using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Razor_App.Model;

namespace CRUD_Razor_App.Data
{
    public class CRUD_Razor_AppContext : DbContext
    {
        public CRUD_Razor_AppContext (DbContextOptions<CRUD_Razor_AppContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_Razor_App.Model.Employee> Employee { get; set; } = default!;
    }
}
