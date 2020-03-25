using System.Collections.Generic;

namespace escape_corona.Interfaces
{
    interface IGameService
    {
        //go, look, take, use, inventory, Rest, setup, help
        List<string> Messages { get; set; }

        void Setup(string playerName);
        void Reset();

        #region Console Commands
        void Go(string direction);
        void Look();
        void Take(string itemName);
        void Use(string itemName);
        void Inventory();
        void Help();
        #endregion
    }
}