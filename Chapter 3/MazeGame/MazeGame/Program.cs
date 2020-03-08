using System;
using MazeGame.Impl;

namespace MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ordinary maze, not particularly interesting.
            MazeFactory factory = new MazeFactory();
            MazeGame.CreateMaze(factory);
            
            MazeFactory enchangedMazeFactory = new EnchangedMazeFactory();
            var enchantedMaze = MazeGame.CreateMaze(enchangedMazeFactory);

            if (enchantedMaze.RoomNo(1) is EnchantedRoom)
            {
                Console.WriteLine("The second maze is enchanted, factory did its work.");
            }
            else
            {
                Console.WriteLine("Something wrong with the Absctract factory, the maze is still ordinary.");
            }

            var oneMoreEnchantedMaze = new EnchantedMazeGame().CreateMaze();

            if (oneMoreEnchantedMaze.RoomNo(1) is EnchantedRoom)
            {
                Console.WriteLine("The third maze is enchanted, overriden factory methods did their work.");
            }
            else
            {
                Console.WriteLine("Something wrong with the factory methods, the maze is still ordinary.");
            }
        }
    }
}
