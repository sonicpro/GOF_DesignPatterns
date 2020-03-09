using Adapter.Interfaces;
using System.Drawing;

namespace Adapter.Target
{
    class Shape : IShape
    {
        public virtual IManipulator CreateManipulator()
        {
            throw new System.NotImplementedException();
        }

        public virtual (Point bottomLeft, Point topRight) BoundingBox()
        {
            throw new System.NotImplementedException();
        }
    }
}
