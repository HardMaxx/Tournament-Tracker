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

        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePatch().LoadFile().ConvertToPersonModels();

            int currentId = 1;

            if (people.Count>0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            people.Add(model);

            people.SaveToPeopleFile();
        }

        //TODO - Make the CreatePrize method actually save to the text file
        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public void CreatePrize(PrizeModel model)
        {
            //load the text file and convert the text to the list>prizemodel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePatch().LoadFile().ConvertToPrizeModels();

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
            prizes.SaveToPrizeFile();
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePatch().LoadFile().ConvertToTeamModels();

            //find the max id
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile();
        }

        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePatch().LoadFile().ConvertToTeamModels();
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePatch().LoadFile().ConvertToPersonModels();


        }

        public void  CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
                .FullFilePatch()
                .LoadFile().
                ConvertToTournamentModels();

            //find the max id
            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentile();

            TournamentLogic.UpdateTournamentResults(model);

        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile
                .FullFilePatch()
                .LoadFile().
                ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }

        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
                 .FullFilePatch()
                 .LoadFile().
                 ConvertToTournamentModels();

            tournaments.Remove(model);

            tournaments.SaveToTournamentile();

            TournamentLogic.UpdateTournamentResults(model);

        }
    }
}
