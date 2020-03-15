using System;

namespace TemplateMethod
{
    class MyView : View
    {
        // Abstract operation realization.
        protected override void DoDisplay()
        {
            Console.WriteLine("Do some drawing on the context set by \"SetFocus\" operation.");
        }
    }
}
