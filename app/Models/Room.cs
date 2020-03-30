using System.Collections.Generic;
using escape_corona.Interfaces;

namespace escape_corona.Models
{
  class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string HiddenDescription { get; set; }
    public IItem HiddenDescriptionRevealer { get; set; }
    public List<IItem> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }
    public Dictionary<IItem, KeyValuePair<string, IRoom>> LockedExits { get; set; }

    public void AddLockedRoom(IItem key, string direction, IRoom room)
    {
      var lockedRoom = new KeyValuePair<string, IRoom>(direction, room);
      LockedExits.Add(key, lockedRoom);
    }

    public string Use(IItem item)
    {
      if (LockedExits.ContainsKey(item))
      {
        Exits.Add(LockedExits[item].Key, LockedExits[item].Value);
        LockedExits.Remove(item);
        if (item.Name.ToLower() == "key")
        {
          return "You grab the key";
        }
        return "You have unlocked a room";
      }
      if (HiddenDescriptionRevealer != null && item == HiddenDescriptionRevealer)
      {
        Description = HiddenDescription;
        return "A great plan new secrets have been revealed";
      }
      return "No use for that here";
    }

    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      Items = new List<IItem>();
      Exits = new Dictionary<string, IRoom>();
      LockedExits = new Dictionary<IItem, KeyValuePair<string, IRoom>>();
    }

    public Room(string name, string description, IItem itemRevealer, string hiddenDescription)
    {
      Name = name;
      Description = description;
      HiddenDescriptionRevealer = itemRevealer;
      HiddenDescription = hiddenDescription;
      Items = new List<IItem>();
      Exits = new Dictionary<string, IRoom>();
      LockedExits = new Dictionary<IItem, KeyValuePair<string, IRoom>>();
    }
  }
}