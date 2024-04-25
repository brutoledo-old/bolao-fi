using System.Text.Json.Serialization;

namespace BolaoDoFi.Core.Models
{
    public class BetOnTheGame
    {
        public int Team1Goals { get; set; }
        public int Team2Goals { get; set; }

        [JsonIgnore]
        public string Formatted
        {
            get
            {
                return $"{Team1Goals}x{Team2Goals}";
            }
        }

        public BetOnTheGame()
        {

        }

        public BetOnTheGame(string team1Goals, string team2Goals)
        {
            Team1Goals = Convert.ToInt32(team1Goals);
            Team2Goals = Convert.ToInt32(team2Goals);
        }
    }
}
