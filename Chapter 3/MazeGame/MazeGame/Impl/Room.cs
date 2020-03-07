using MazeGame.Interfaces;

namespace MazeGame.Impl
{
    public class Room : IMapSite
    {
        private IMapSite[] sides = new IMapSite[4];

        public Room(int number)
        {
            this.Number = number;
        }

        public int Number { get; }

        public IMapSite GetSide(Direction direction)
        {
            return sides[(int)direction];
        }

        public void SetSide(Direction direction, IMapSite site)
        {
            sides[(int)direction] = site;
        }

        public void Enter()
        {
            throw new System.NotImplementedException();
        }
    }
}
