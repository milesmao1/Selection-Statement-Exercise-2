namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a challenging subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is interesting!");
                    break;
                case "english":
                    Console.WriteLine("English is an expressive subject!");
                    break;
                default:
                    Console.WriteLine("Oh Wow! I never took that subject.");
                    break;


            }
            
        }
    }
}