using System;

namespace MazeGame.Impl
{
    public class DoorNeedingSpell : Door
    {
        public DoorNeedingSpell(Room room1, Room room2): base(room1, room2)
        { }

        public bool TrySpell(Spell spell)
        {
            throw new NotImplementedException("This method is not implemented");
        }
    }
}
