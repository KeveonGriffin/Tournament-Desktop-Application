using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        //TODO: Make the CreatePrize method actually save prize to database
        /// <summary>
        /// Saves new prize to database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Prize Informatino</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
