using System.Collections.Generic;
using escape_corona.Interfaces;

namespace escape_corona.Models
{
    class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<IItem> Items { get; set; }
        public Dictionary<string, IRoom> Exits { get; set; }
    }
}