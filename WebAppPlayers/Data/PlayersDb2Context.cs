using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProblem_4.Models;

namespace PracticeProblem_4.Data
{
    public class PlayersDb2Context : DbContext
    {
        public PlayersDb2Context (DbContextOptions<PlayersDb2Context> options)
            : base(options)
        {
        }

        public DbSet<PracticeProblem_4.Models.Player> Player { get; set; } = default!;
    }
}
