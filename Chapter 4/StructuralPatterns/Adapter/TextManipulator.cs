using Adapter.Adapter;
using Adapter.Interfaces;

namespace Adapter
{
    class TextManipulator : IManipulator
    {
        private readonly TextShape shape;

        public TextManipulator(TextShape shape)
        {
            this.shape = shape;
        }

        public void MoveHorizontally(double offset)
        {
            throw new System.NotImplementedException();
        }
    }
}
