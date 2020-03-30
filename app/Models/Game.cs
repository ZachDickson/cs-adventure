using escape_corona.Interfaces;

namespace escape_corona.Models
{
  class Game : IGame
  {
    public IPlayer CurrentPlayer { get; set; }
    public IRoom CurrentRoom { get; set; }

    ///<summary>Initalizes data and establishes relationships</summary>
    public Game()
    {
      // NOTE ALL THESE VARIABLES ARE REMOVED AT THE END OF THIS METHOD
      // We retain access to the objects due to the linked list

      // NOTE Create all Items
      Item torch = new Item("Torch", "You now have a single lit Torch");
      Item key = new Item("key", "This could come in handy");

      // NOTE Create all rooms
      Room entrance = new Room("Entry room", "An empty room lit by torches. its ominous and scary. You're not sure about the decision to come in here, but the door you came through is gone now. ");
      Room bloodRoom = new Room("Blood Room", "Theres blood and bones everywhere.", torch, "Not only is there blood everywhere but there is a dead body in here!");
      Room snakeRoom = new Room("Snake Room", "You can hear a sssss sound, but its too dark to see");
      Room spiderRoom = new Room("spider Room", "There's lots of spiders in here. You see a skeleton holding a key in the corner. He's covered in spiders. You hate spiders...");
      EndRoom treasureRoom = new EndRoom("Treasure Room", "Before you is a room gleaming with treasures of all types", true, "You have done it! you have conquered the Labyrinth!");
      EndRoom deathtrap = new EndRoom("Death Trap", "The door slams shut behind you. Spikes protrude from the walls and the room grows smaller", false, "Theres no escape. The Labyrinth has claimed another soul. ");



      // NOTE Make Room Relationships
      entrance.Exits.Add("east", bloodRoom);
      bloodRoom.Exits.Add("west", entrance);
      bloodRoom.Exits.Add("north", snakeRoom);
      snakeRoom.Exits.Add("west", deathtrap);
      snakeRoom.Exits.Add("south", bloodRoom);
      snakeRoom.Exits.Add("east", spiderRoom);
      spiderRoom.Exits.Add("west", snakeRoom);
      spiderRoom.AddLockedRoom(key, "north", treasureRoom);
      treasureRoom.Exits.Add("south", spiderRoom);


      // NOTE put Items in Rooms
      bloodRoom.Items.Add(torch);
      spiderRoom.Items.Add(key);


      CurrentRoom = entrance;
    }
  }
}