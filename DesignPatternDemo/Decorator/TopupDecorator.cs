using System;
namespace Decorator
{
    public class TopupDecorator : IPizza
    {
        protected IPizza basePizza;
        public TopupDecorator(IPizza pbasePizza)
        {
            basePizza = pbasePizza;
        }
        public virtual double GetCost()
        {
            return basePizza.GetCost();
        }
    }

    public class Mushroom : TopupDecorator
    {
        public Mushroom(IPizza pbasePizza) : base(pbasePizza)
        {
        }

        public override double GetCost()
        {
            return basePizza.GetCost() + 30.0;
        }
    }

    public class ExtraCheese : TopupDecorator
    {
        public ExtraCheese(IPizza pbasePizza) : base(pbasePizza)
        {
        }

        public override double GetCost()
        {
            return basePizza.GetCost() + 40.0;
        }
    }
}

