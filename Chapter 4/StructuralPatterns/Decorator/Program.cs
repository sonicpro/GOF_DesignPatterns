using Decorator.ConcreteComponent;
using Decorator.Decorator;
using Decorator.Interfaces;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cost of Decaf with Whipped cream and Mochs must be 21.8
            var myHealtyBeverage = new DecafFirstAttempt(hasMocha: true, hasWhip: true);
            Console.WriteLine($"Cost of Decaf with Whipped cream and Mochs must be 21.8. Thas is {myHealtyBeverage.Cost() == 21.8}.");

            var mySimpleHealthyBeverage = new Decaf();
            IBeverage mySimpleHealthyBeverageDecorated = new WhipDecorator(
                new MochaDecorator(mySimpleHealthyBeverage));
            Console.WriteLine($"Cost of Decaf with Whipped cream and Mochs must be 21.8. Thas is {mySimpleHealthyBeverageDecorated.Cost() == 21.8}.");
        }
    }
}
