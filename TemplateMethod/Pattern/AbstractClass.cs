using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Pattern
{
    public abstract class AbstractClass
    {
        protected abstract void PrimitiveMethod1();

        protected abstract void PrimitiveMethod2();

        public void TemplateMethod()
        {
            PrimitiveMethod1();
            PrimitiveMethod2();
        }
    }

    public class ConcreteClass : AbstractClass
    {
        protected override void PrimitiveMethod1()
        {
            Console.WriteLine("PrimitiveMethod1");
        }

        protected override void PrimitiveMethod2()
        {
            Console.WriteLine("PrimitiveMethod2");
        }
    }
}
