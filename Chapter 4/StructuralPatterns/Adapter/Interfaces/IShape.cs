using System.Drawing;

namespace Adapter.Interfaces
{
    public interface IShape
    {
        (Point bottomLeft, Point topRight) BoundingBox();

        IManipulator CreateManipulator();
    }
}
