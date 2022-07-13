using System;
using AccessBu;
namespace ProjectBudget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connect = "Server=LAPTOP-L4RD8ILN; Database=MonthlyBudget;Integrated Security = True;";
            int rent, food, toilet, gym, trans, clothes, family, Electricity, Inter;

            

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("Please Enter The Fields Required");
                Console.WriteLine("Please Enter Your rent fee");
                rent = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter Your food fee");
                food = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter Your toiletry's price");
                toilet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter Your gym fee");
                gym = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter your transport fee");
                trans = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter you Intertainment Fee");
                Inter = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter your clothes fee");
                clothes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter your family Allowence");
                family = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter you Electricity Fee");
                Electricity = Convert.ToInt32(Console.ReadLine());


                int totalExp = rent + clothes + Electricity + family + food + gym + toilet + trans + Inter;
                Access.AddExpense(rent, food, toilet, gym, trans, Inter, clothes, family, Electricity, totalExp, connect);
               
                Console.WriteLine($"Your Monthly expenses are {totalExp}");
            }


        }
    }
}
