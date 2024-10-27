namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int countCommands = int.Parse(Console.ReadLine());

            for (int count = 1; count <= countCommands; count++)
            {
                string command = Console.ReadLine();

                if (command.Contains("unregister")){
                    string ownerOut = command.Split()[1];

                    if (!parking.ContainsKey(ownerOut))
                    {
                        //несъществуващ собственик
                        Console.WriteLine($"ERROR: user {ownerOut} not found");
                    }
                    else
                    {
                        //имам такъв собственик
                        parking.Remove(ownerOut);
                        Console.WriteLine($"{ownerOut} unregistered successfully");
                    }
                    

                }
                else if (command.Contains("register"))
                {
                    //command.Split() -> ["register", "{username}", {licensePlateNumber}]
                    string owner = command.Split()[1];
                    string carNumber = command.Split()[2];
                    
                    if (!parking.ContainsKey(owner))
                    {
                        //нямаме записан такъв собственик
                        parking.Add(owner, carNumber);
                        Console.WriteLine($"{owner} registered {carNumber} successfully");
                    }
                    else
                    {
                        //вече имаме такъв собственик в паркинга
                        Console.WriteLine($"ERROR: already registered with plate number {parking[owner]}");
                    }
                }
            }

            foreach (KeyValuePair<string, string> entry in parking)
            {
                Console.WriteLine(entry.Key + " => " + entry.Value);
            }
        }
    }
}
