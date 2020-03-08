using MazeGame.Impl;

namespace MazeGame
{
    // "ConcreteCreator" subclass from "Factory Method" pattern.
    class EnchantedMazeGame : MazeGame
    {
        public override Room MakeRoom(int number)
        {
            return new EnchantedRoom(number, GetSpell());
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }

        #region Helper methods

        private static Spell GetSpell()
        {
            return new Spell();
        }

        #endregion
    }
}
