using System;
using Adapter.Adaptee;
using Adapter.Adapter;
using Adapter.Interfaces;

namespace Adapter
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "<Pending>")]
        static void Main(string[] args)
        {
            // Suppose that our client needs to get a TextShape and then get its BoundingBox as well as the manipulator.
            // Bacause the needed methods are adapted from the ones existing in TextView library, we must pass a TextView instance to the adapter.
            var TextShape = new TextShape(new TextView());
            if (!TextShape.IsEmpty())
            {
                Console.WriteLine("Here is the bounding rect for out text shape:\n" +
                    $"bottom-left coordinates: {TextShape.BoundingBox().bottomLeft.X}, {TextShape.BoundingBox().bottomLeft.Y}\n" +
                    $"top-right coordinates: {TextShape.BoundingBox().topRight.X}, {TextShape.BoundingBox().topRight.Y}");
            }

            IManipulator manipulator;
            try
            {
                manipulator = TextShape.CreateManipulator();
                Console.WriteLine("Successfully get the text shape manipulator.");
            }
            catch
            {
                Console.WriteLine("Error occurred while creating the text shape manipulator.");
                throw;
            }
        }
    }
}
