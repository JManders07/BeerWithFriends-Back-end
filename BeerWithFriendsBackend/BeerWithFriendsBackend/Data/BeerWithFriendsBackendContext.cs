using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeerWithFriendsBackend.Models;

namespace BeerWithFriendsBackend.Data
{
    public class BeerWithFriendsBackendContext : DbContext
    {
        public BeerWithFriendsBackendContext (DbContextOptions<BeerWithFriendsBackendContext> options)
            : base(options)
        {
        }

        public DbSet<BeerWithFriendsBackend.Models.Beer> Beer { get; set; } = default!;
    }
}
