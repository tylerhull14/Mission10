using Microsoft.EntityFrameworkCore;

namespace Mission10_API.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }
        //public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers.Include("Team");
        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers
            //.Include(b => b.Team)
            .Include("Team")
            .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks");


    }
}
