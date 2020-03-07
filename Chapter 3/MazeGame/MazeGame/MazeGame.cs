using MazeGame.Impl;

namespace MazeGame
{
    // "Client" implementation from "Abstract Factory" pattern.
    public static class MazeGame
    {
        // Non-flexible implemantation, replaced.
        //public static Maze CreateMaze()
        //{
        //    Maze maze = new Maze();
        //    Room room1 = new Room(1);
        //    Room room2 = new Room(2);
        //    Door door = new Door(room1, room2);

        //    maze.AddRoom(room1);
        //    maze.AddRoom(room2);

        //    room1.SetSide(Direction.North, new Wall());
        //    room1.SetSide(Direction.East, door);
        //    room1.SetSide(Direction.South, new Wall());
        //    room1.SetSide(Direction.West, new Wall());

        //    room2.SetSide(Direction.North, new Wall());
        //    room2.SetSide(Direction.East, new Wall());
        //    room2.SetSide(Direction.South, new Wall());
        //    room2.SetSide(Direction.West, door);

        //    return maze;
        //}

        public static Maze CreateMaze(MazeFactory factory)
        {
            Maze maze = factory.MakeMaze();
            Room room1 = factory.MakeRoom(1);
            Room room2 = factory.MakeRoom(2);
            Door door = factory.MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());

            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.South, new Wall());
            room2.SetSide(Direction.West, door);

            return maze;
        }
    }
}
