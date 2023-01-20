namespace MultiplicationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;
            for(int i=0; i<num1; i++)
            {
                result += num2;
            }
            Console.WriteLine(num1 + " * " + num2 +" : " + result);


        }
    }
}