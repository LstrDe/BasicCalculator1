using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorPrivateAssembly;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public static float getAddition(float x, float y)
        {
            return x + y;
        }

        public static float getSubtraction(float x, float y)
        {
            return x - y;
        }

        public static float getMultiplication(float x, float y)
        {
            return x * y;
        }

        public static float getDivision(float x, float y)
        {
            return x / y;
        }
    }
}
