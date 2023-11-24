using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoccerPlayer
{
    public class SoccerPlayer
    {
        

        //ATTRIBUTES (Property) - data
        //Instance Fields
        private string _playerName;
        private int _jerseyNumber;
        private int _goalsScored;
        private int _assists;

        //METHODS - behaviors
        //ACCESSORS AND MUTATORS
        
        //4 accessor methods
        public string GetPlayerName() { return _playerName; }
        public int GetJerseyNumber() => _jerseyNumber;
        public int GetGoalsScored() => _goalsScored;
        public int GetAssists() => _assists;


        //4 mutator methods
        public void SetPlayerName(string playerName)
        {
            _playerName = playerName;
        }

        public void SetJerseyNumber(int jerseyNumber) => _jerseyNumber = jerseyNumber;

        public void SetGoalsScored(int goalsScored) => _goalsScored = goalsScored;

        public void SetAssists(int assists) => _assists = assists;

    }
}
