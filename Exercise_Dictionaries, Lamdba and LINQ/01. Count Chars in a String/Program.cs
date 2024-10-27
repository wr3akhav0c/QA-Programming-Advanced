namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();                    

            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (char symbol in words)
            {
                if (symbol == ' ')
                {
                    continue; //пропуска кода след оператора continue, преминава към следващия символ
                }

                if (!characterCount.ContainsKey(symbol))
                {
                    //не сме срещали символа до момента
                    characterCount.Add(symbol, 1);
                }
                else
                {
                    characterCount[symbol]++;
                }
            }

            foreach (KeyValuePair<char, int> entry in characterCount)
            {
                Console.WriteLine(entry.Key + " -> " + entry.Value);
            }
        }
    }
}
