using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade_Structural
    {
        public static void Run()
        {
            Console.WriteLine("\nThis structural code demonstrates the Facade pattern which provides a simplified and uniform interface to a large subsystem of classes.");
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
            /*
             MethodA() ----
            SubSystemOne Method
            SubSystemTwo Method
            SubSystemFour Method

            MethodB() ----
            SubSystemTwo Method
            SubSystemThree Method
             */
        }

        class SubSystemOne
        {
            public void MethodOne()
            {
                Console.WriteLine(" SubSystemOne Method");
            }
        }

        class SubSystemTwo
        {
            public void MethodTwo()
            {
                Console.WriteLine(" SubSystemTwo Method");
            }
        }

        class SubSystemThree
        {
            public void MethodThree()
            {
                Console.WriteLine(" SubSystemThree Method");
            }
        }

        class SubSystemFour
        {
            public void MethodFour()
            {
                Console.WriteLine(" SubSystemFour Method");
            }
        }

        class Facade
        {
            private SubSystemOne _one;
            private SubSystemTwo _two;
            private SubSystemThree _three;
            private SubSystemFour _four;

            public Facade()
            {
                _one = new SubSystemOne();
                _two = new SubSystemTwo();
                _three = new SubSystemThree();
                _four = new SubSystemFour();
            }

            public void MethodA()
            {
                Console.WriteLine("\nMethodA() ---- ");
                _one.MethodOne();
                _two.MethodTwo();
                _four.MethodFour();
            }

            public void MethodB()
            {
                Console.WriteLine("\nMethodB() ---- ");
                _two.MethodTwo();
                _three.MethodThree();
            }
        }
    }
}
