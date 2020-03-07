using MazeGame.Interfaces;

namespace MazeGame.Impl
{
    public class Door : IMapSite
    {
        //private bool isOpen;
        private Room room1;
        private Room room2;

        public Door(Room room1, Room room2) =>
            (this.room1, this.room2) = (room1, room2);

        public void Enter()
        {
            throw new System.NotImplementedException();
        }
    }
}
