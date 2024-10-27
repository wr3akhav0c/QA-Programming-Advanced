namespace Dictionaries__Lambda_and_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EGN(text) -- name(text)
            Dictionary<string, string> peopleData = new Dictionary<string, string>();

            peopleData["9902125834"] = "Natalia Ivanova Dimitrova";

            peopleData.Add("9902241124", "Marina Ivanova Ivanova");

            Console.WriteLine(peopleData["9902125834"]);

            Dictionary<string, int> fruits = new()
            {
                {"Kiwi", 3 },
                {"Banana", 2 }
            };

            fruits.Add("Orange", 4);

            fruits.Remove("Kiwi");

            Console.WriteLine(fruits.Count); //number of stuff in the Dictionary

            Console.WriteLine(fruits.ContainsKey("Banana")); //True or False

            foreach (KeyValuePair<string, int> entry in fruits)
            {
                Console.WriteLine(entry.Key + " -> " + entry.Value + " kg.");
            }

            // филтриране на позитивни числа
            int[] positiveNumbers = Console.ReadLine().Split().Select(int.Parse).Where(n => n > 0).ToArray();

        }
    }
}
