using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerWithFriendsDAL.Data
{
    public class BeerWithFriendsContext : DbContext
    {
        public BeerWithFriendsContext(DbContextOptions<BeerWithFriendsContext> options)
            : base(options)
        {
        }

        public DbSet<BeerWithFriendsDTO.BeerDTO> Beer { get; set; } = default!;
    }
}
