﻿using MazeGame.Impl;

namespace MazeGame
{
    // "ConcreteFactory" implementation from "Abstract factory" pattern.
    public class MazeFactory
    {
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int number)
        {
            return new Room(number);
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
