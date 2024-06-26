﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents the one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this perticular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup this team came from as the winner.
        /// </summary>
        public MatchupModel Parentmatchup { get; set; }


    }
}
