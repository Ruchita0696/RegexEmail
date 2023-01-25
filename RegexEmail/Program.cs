namespace RegexEmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Email ID : ");
            string email = Console.ReadLine();
            RegexPattern.Pattern(email);
        }
    }
}