using System;
namespace Decorator
{
	public interface IPizza
	{
		public double GetCost();
	}

    public class PlainPizza : IPizza
    {
        public double GetCost()
        {
            return 100.0;
        }
    }
}

