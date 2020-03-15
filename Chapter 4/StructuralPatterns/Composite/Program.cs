using Composite.Composite;
using Composite.Leafs;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var cabinet = new Cabinet("PC Cabinet", 80);
            var chassis = new Chassis("PC Chassis", 145);

            var m2ssd = new M2SSD("Kingston SSD");
            var ram1 = new RAM("Kingston DDR4 module");
            var ram2 = new RAM("Kingston DDR4 module");

            chassis.Add(m2ssd); // Adds $50 to the price.
            chassis.Add(ram1); // Adds $40 to the price.
            chassis.Add(ram2); // Adds another $40 to the price.
            cabinet.Add(chassis);

            Console.WriteLine($"My dream machine net price is {cabinet.NetPrice} USD.");
        }
    }
}
