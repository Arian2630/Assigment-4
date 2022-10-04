using Football;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Assigment_4.Managers
{
    public class FootballPlayersManager
    {
        private static int _nextid = 1;

        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer {Id = _nextid, Name = "Cristiano Ronaldo", Age = 37, ShirtNumber = 7 },
            new FootballPlayer {Id = _nextid, Name = "Lionel Messi", Age = 35, ShirtNumber = 10 },
            new FootballPlayer {Id = _nextid, Name = "Christian Eriksen", Age = 30, ShirtNumber = 14 },
            new FootballPlayer {Id = _nextid, Name = "Kylian Mpappe", Age = 23, ShirtNumber = 7 },
        };
        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }
       

        public FootballPlayer GetById(int id)
        {
            return Data.Find(players => players.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newFootballPlayer)
        {
            newFootballPlayer.Id = _nextid++;
            Data.Add(newFootballPlayer);
            return newFootballPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer footballplayers = Data.Find(footballplayers1 => footballplayers1.Id == id);
            if (footballplayers == null) return null;
            Data.Remove(footballplayers);
            return footballplayers;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer footballplayers = Data.Find(footballplayers1 => footballplayers1.Id == id);
            if (footballplayers == null) return null;
            footballplayers.Name = updates.Name;
            return footballplayers;
        }
    }
}
