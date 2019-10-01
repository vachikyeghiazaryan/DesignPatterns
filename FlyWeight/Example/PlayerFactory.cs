using System.Collections;

namespace FlyWeight.Example
{
    public class PlayerFactory
    {
        private readonly Hashtable _players = new Hashtable();

        public Player GetPlayer(string playerType)
        {
            if (_players.Contains(playerType))
            {
                return (Player)_players[playerType];
            }

            switch (playerType)
            {
                case "Terrorist":
                    _players.Add(playerType, new Terrorist());
                    break;
                case "CounterTerrorist":
                    _players.Add(playerType, new CounterTerrorist());
                    break;
            }

            return (Player)_players[playerType];
        }
    }
}
