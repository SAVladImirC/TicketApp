using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TicketAppDbContextFactory : IDesignTimeDbContextFactory<TicketAppDbContext>
    {
        public TicketAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TicketAppDbContext>();
            optionsBuilder.UseSqlServer("Server=BGWDame;Database=TicketApp;User=vladimir;Password=vladimir;TrustServerCertificate=True");

            return new TicketAppDbContext(optionsBuilder.Options);
        }
    }
}
