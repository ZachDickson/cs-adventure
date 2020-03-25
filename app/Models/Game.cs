using escape_corona.Interfaces;

namespace escape_corona.Models
{
    class Game : IGame
    {
        public IPlayer CurrentPlayer { get; set; }
        public IRoom CurrentRoom { get; set; }

        public void Setup()
        {
            throw new System.NotImplementedException();
        }
    }
}