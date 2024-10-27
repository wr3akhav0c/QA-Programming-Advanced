namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();

            int countWords = int.Parse(Console.ReadLine()); //брой на думите

            for (int count = 1; count <= countWords; count++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordSynonyms.ContainsKey(word))
                {
                    //за първи път срещаме думата
                    wordSynonyms.Add(word, new List<string>());
                    wordSynonyms[word].Add(synonym);
                }
                else
                {
                    //вече сме срещали думата
                    wordSynonyms [word].Add(synonym);
                }
            }

            foreach (KeyValuePair <string, List<string>> entry in wordSynonyms)
            {
                //entry.Key -> дума
                //entry.Value -> списък със синоними (List<string>)
                Console.WriteLine(entry.Key + " - " + string.Join(", ", entry.Value));
            }
        }
    }
}
