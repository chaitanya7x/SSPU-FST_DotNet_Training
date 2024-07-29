using System;

namespace ConsoleApp2.Inheritance
{
    class ChildClass : BaseClass
    {
        public void CallDemo()
        {
            base.Display(); // Calling parent class method
        }
    }
}
