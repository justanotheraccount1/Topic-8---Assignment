namespace Topic_8___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 10/15/24
            int count = 0;
            Random generator = new Random();
            int num0Nums, minVal, maxVal;

            //List<string> colours = new List<string> { "Red", "Orange", "Yellow", "Green", "Blue", "Purple" };
            //for (int i = 0; i < colours.Count; i++)
            //{
            //    if (colours[count] == "Purple")
            //        Console.Write(colours[count] + ".");
            //    else
            //        Console.Write(colours[count] + ", ");
            //        count++;

            //}
            //Console.WriteLine();
            //Console.WriteLine(colours[generator.Next(colours.Count)]);


            Console.WriteLine("How many numbers do you want to generate?");
            int.TryParse(Console.ReadLine(), out num0Nums);
            Console.WriteLine("What is the minimum value?");
            int.TryParse(Console.ReadLine(), out minVal);
            Console.WriteLine("What is the maximum value?");
            int.TryParse(Console.ReadLine(), out maxVal);
            count = 0;
            for (int i = 0; i < num0Nums; i++)
            {
                List<int> numbers = new List<int>(generator.Next(minVal, (maxVal + 1)));
                Console.WriteLine(numbers[count] + ", ");
                count += 1;
            }

        }
    }
}
