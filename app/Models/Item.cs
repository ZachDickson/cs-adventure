using escape_corona.Interfaces;

namespace escape_corona.Models
{
    class Item : IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}