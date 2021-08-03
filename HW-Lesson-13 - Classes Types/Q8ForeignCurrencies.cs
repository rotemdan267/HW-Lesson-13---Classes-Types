using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_13___Classes_Types
{
    static class Q8ForeignCurrencies
    {
        public static float Dollar { get; private set; }
        public static float Euro { get; private set; }
        public static string Type { get; set; }

        static Q8ForeignCurrencies()
        {
            Type = "I'm a static class";
            Console.WriteLine(Type);
        }

        public static bool USAGovernmentAuthorization { get; }
        public static bool EuropeanUnionGovernmentAuthorization { get; }
        public static void ChangeDollarCurrency(float value)
        {
            if (USAGovernmentAuthorization)
            {
                Dollar = value;
            }
        }
        public static void ChangeEuroCurrency(float value)
        {
            if (EuropeanUnionGovernmentAuthorization)
            {
                Euro = value;
            }
        }

    }
}
