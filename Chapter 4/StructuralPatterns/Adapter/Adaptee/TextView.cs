// Library class that provides necessary for TextShape functionality but
// has an interface incompatible with IShape.
namespace Adapter.Adaptee
{
    class TextView
    {
        private const double Dimensions = 12;

        public TextView()
        {
        }

        public void GetOrigin(out double x, out double y)
        {
            x = default;
            y = default;
        }

        public void GetExtent(out double width, out double height)
        {
            width = Dimensions;
            height = Dimensions;
        }

        public virtual bool IsEmpty()
        {
            double width, height;
            GetExtent(out width, out height);
            return width == 0 || height == 0;
        }
    }
}
