using Adapter.Adaptee;
using Adapter.Interfaces;
using Adapter.Target;
using System.Drawing;

namespace Adapter.Adapter
{
    class TextShape : Shape
    {
        private readonly TextView text;

        public TextShape(TextView text)
        {
            this.text = text;
        }

        public override (Point bottomLeft, Point topRight) BoundingBox()
        {
            double bottom, left, width, height;

            text.GetOrigin(out bottom, out left);
            text.GetExtent(out width, out height);
            var bottomLeft = new Point((int)left, (int)bottom);
            var topRight = new Point((int)(left + width), (int)(bottom + height));
            return (bottomLeft, topRight);
        }

        public override IManipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }

        public bool IsEmpty()
        {
            return text.IsEmpty();
        }
    }
}
