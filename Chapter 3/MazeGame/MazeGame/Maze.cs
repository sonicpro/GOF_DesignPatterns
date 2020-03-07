using System.Collections.Generic;
using System.Linq;
using MazeGame.Impl;

namespace MazeGame
{
    // "ConcreteProduct" implementation from "Abstract Factory" pattern.
    public class Maze
    {
        private readonly List<Room> rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        // Returns a room by the number
        public Room RoomNo(int number)
        {
            return rooms.Where(r => r.Number == number).FirstOrDefault();
        }
    }
}
