namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "BZ4X";
            myCar.Year = 2024;
            
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine("That is a good Dealer!");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine("WOW! is that an EV car? nice!");
            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine("Holy smokes its brand new this year!");
        }
    }
}
