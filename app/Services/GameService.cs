using System.Collections.Generic;
using escape_corona.Interfaces;

namespace escape_corona.Services
{
    class GameService : IGameService
    {
        public List<string> Messages { get; set; }

        public void Go(string direction)
        {
            throw new System.NotImplementedException();
        }

        public void Help()
        {
            throw new System.NotImplementedException();
        }

        public void Inventory()
        {
            throw new System.NotImplementedException();
        }

        public void Look()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public void Setup(string playerName)
        {
            throw new System.NotImplementedException();
        }

        public void Take(string itemName)
        {
            throw new System.NotImplementedException();
        }

        public void Use(string itemName)
        {
            throw new System.NotImplementedException();
        }
    }
}