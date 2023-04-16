namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? yourName = "";
            string? yourAnimal = "";
            string? yourColor = "";
            string? yourBand = "";

            yourName = DataEntry("What is your name? > ");
            yourColor = DataEntry("What is your favorite color? > ");
            yourAnimal = DataEntry("What is your favorite animal? > ");
            yourBand = DataEntry("What is your favorite band? >");

            WriteStory(yourName, yourColor, yourAnimal, yourBand);
        }

        public static void WriteStory(string ynam, string ycol, string yan, string yban)
        {
            Console.WriteLine($"My Short Story");
            Console.WriteLine($"Hi!  My name is {ynam}.");
            Console.WriteLine($"I grew up collecting {yan}.");
            Console.WriteLine($"I found that while a {yan} may be {ycol}, not all of them are.");
            Console.WriteLine($"I played music for the {yan} from {yban} but I don't think they cared.");
        }

        public static string DataEntry(string msg)
        {
            Console.Write(msg);
            string? field1 = Console.ReadLine();
            if (field1 == "" || field1 is null )
            {
                field1 = "NO VALUE";
            }
            return field1;
        }
    }
}
