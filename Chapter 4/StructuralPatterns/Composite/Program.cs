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

            chassis.Add(m2ssd);
            chassis.Add(ram1);
            chassis.Add(ram2);
            cabinet.Add(chassis);

            Console.WriteLine($"My dream machine net price is {cabinet.NetPrice} USD.");
        }
    }
}
