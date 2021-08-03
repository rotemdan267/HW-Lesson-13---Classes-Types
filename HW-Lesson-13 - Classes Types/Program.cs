using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_13___Classes_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q-8

            Console.WriteLine("Hello from Main");
            Q8ForeignCurrencies.ChangeDollarCurrency(3.12f);

            #endregion

            #region Q-9

            Car c1 = new Car(4, "Ford", 5);
            Car c2 = new Car(8, "mazda", 56);
            Car c3 = new Car(42, "Audi", 2);
            Motorcycle m1 = new Motorcycle(2, "Honda", 22);
            Motorcycle m2 = new Motorcycle(3, "asd", 2);
            Motorcycle m3 = new Motorcycle(5, "Hdda", 29);

            Carrier carrier = new Carrier(c1, m1, c2, m2, c3, m3);

            Console.WriteLine(carrier);

            #endregion

            Console.ReadLine();
        }
    }

    #region Q-7

    sealed class BankCustomer
    {
        private string name;
        private double balance;
        private void ChangeBalance(double change)
        {
            balance += change;
        }
    }

    //class HakerThief : BankCustomer
    //{

    //}

    #endregion
}
