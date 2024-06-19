using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents all teams are present. 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner team.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the matchup round.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
