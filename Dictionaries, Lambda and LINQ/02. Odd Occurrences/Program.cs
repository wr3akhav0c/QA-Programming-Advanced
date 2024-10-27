namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                //toLower за да взима всички думи в малки букви
                string wordWithLowerCase = word.ToLower();

                if (!wordsCount.ContainsKey(wordWithLowerCase))
                {
                    //срещаме думата за пръв път
                    wordsCount.Add(wordWithLowerCase, 1);
                }
                else
                {
                    //вече сме я срещнали
                    wordsCount[wordWithLowerCase]++;
                }
            }

            foreach (KeyValuePair<string, int> entry in wordsCount)
            {
                //entry.Key -> дума с малки букви
                //entry.Value -> брой срещания
                int countOccurences = entry.Value;
                if (countOccurences % 2 != 0)
                {
                    Console.Write(entry.Key + " ");
                }

            }
        }
    }
}
