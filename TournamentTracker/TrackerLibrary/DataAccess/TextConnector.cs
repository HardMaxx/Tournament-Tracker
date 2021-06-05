using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        //TODO - Make the CreatePrize method actually save to the text file
        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //load the text file and convert the text to the list>prizemodel>
            List<PrizeModel> prizes = PrizesFile.FullFilePatch().LoadFile().ConvertToPrizeModels();

            //find the max id
            int currentId = 1;

            if (prizes.Count>0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            //add the new record with the new id(max+1)
            prizes.Add(model);

            //conver the prizes to list<sting>
            //save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
