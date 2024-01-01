using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one of the teams
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score of the matchup
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the previous matchup
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
