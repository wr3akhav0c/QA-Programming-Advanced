namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            
            //число -> брой срещания

            SortedDictionary<double, int> countNumbers = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (countNumbers.ContainsKey(number))
                {
                    //вече имам записано числото с някакъв брой срещания,
                    //увеличаваме броя на срещанията с 1
                    countNumbers[number]++;
                }
                else
                {
                    //срещаме числото за пръв път
                    countNumbers.Add(number, 1);
                }
            }

            foreach (KeyValuePair<double, int> entry in countNumbers)
            {
                //всеки един запис се съхранява в entry
                //entry.Key -> число
                //entry.Value -> брой срещания

                Console.WriteLine(entry.Key + " -> " + entry.Value);

            }
        }
    }
}
