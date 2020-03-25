using System.Collections.Generic;
using escape_corona.Interfaces;

namespace escape_corona.Models
{
    class Player : IPlayer
    {
        public string Name { get; set; }
        public List<IItem> Inventory { get; set; }
    }
}