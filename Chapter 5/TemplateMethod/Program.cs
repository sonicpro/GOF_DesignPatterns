using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var screenSectionView = new MyView();
            // The only public method available for Drawing is the template method from Abstract class.
            screenSectionView.Display();
        }
    }
}
