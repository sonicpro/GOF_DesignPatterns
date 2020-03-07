using MazeGame.Impl;

namespace MazeGame
{
    class EnchangedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int number)
        {
            return new EnchantedRoom(number, GetSpell());
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }

        protected Spell GetSpell()
        {
            return new Spell();
        }
    }
}
