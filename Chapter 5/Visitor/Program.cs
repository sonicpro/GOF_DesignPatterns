using System;
using Visitor.Composite;
using Visitor.Leafs;

namespace Visitor
{
    class Program
    {
        // Uses modified code from Chapter 4 "Composite" pattern demo.
        static void Main(string[] args)
        {
            var cabinet = new Cabinet("PC Cabinet", 80);
            var chassis = new Chassis("PC Chassis", 145);

            var m2ssd = new M2SSD("Kingston SSD", 50);
            var ram1 = new RAM("Kingston DDR4 module", 40);
            var ram2 = new RAM("Kingston DDR4 module", 40);

            chassis.Add(m2ssd);
            chassis.Add(ram1);
            chassis.Add(ram2);
            cabinet.Add(chassis);

            var visitor = new PricingVisitor();
            cabinet.Accept(visitor);
            Console.WriteLine($"My dream machine net price is {visitor.TotalPrice} USD.");
        }
    }
}
