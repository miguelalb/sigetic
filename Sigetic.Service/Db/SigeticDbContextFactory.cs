using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sigetic.Service.Db
{
    public class SigeticDbContextFactory : IDesignTimeDbContextFactory<SigeticDbContext>
    {
        public SigeticDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SigeticDbContext>();
            //optionsBuilder.UseSqlServer("Persist Security Info=False;Integrated Security=True;Initial Catalog=GestionProyectoTI;Server=.\\SQLEXPRESS");
            optionsBuilder.UseSqlServer("Persist Security Info=False;Integrated Security=True;Initial Catalog=GestionProyectoTI;Server=mopc-srv-db-01");

            return new SigeticDbContext(optionsBuilder.Options);
        }
    }
}
