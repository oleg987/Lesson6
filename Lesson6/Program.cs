using System;
using UserData;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();

            acc.Name = "a;lkghd;flvk";
            acc.Email = "sdfbffbx";
            acc.Gender = Genders.Undefined;

            Console.WriteLine((int)Genders.Female);

            Genders g = (Genders)(Enum.Parse(typeof(Genders), "male", true));

            Genders g2 = (Genders)3;

            bool exists = Enum.IsDefined(typeof(Genders), g2);

            DayOfWeek day = DayOfWeek.Saturday;

            switch (day)
            {                 
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Time to work =(");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            var ba = new BankAccount();

            ba.Put(1500m);
            ba.Put(750m);
            ba.Withdraw(100m);
            ba.Put(-1m);
            ba.Withdraw(3000m);

            Console.WriteLine(ba.TransactionsInfo());
        }
    }
}
