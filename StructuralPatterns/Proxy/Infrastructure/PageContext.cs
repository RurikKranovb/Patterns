using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Infrastructure
{
    internal class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}
