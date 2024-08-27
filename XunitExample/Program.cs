namespace XunitExample
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int tal1 = 10;
            int tal2 = 21;

            MyMath myMath = new MyMath();

            Console.WriteLine($"Tal {tal1} är {(myMath.EvenOrOdd(tal1) ? "Jämt" : "Ojämt")}");
            Console.WriteLine($"Tal {tal2} är {(myMath.EvenOrOdd(tal2) ? "Jämt" : "Ojämt")}");

            Console.WriteLine($"Summan av {tal1} och {tal2} är {myMath.Add(tal1, tal2)}");
        }

    }
}
