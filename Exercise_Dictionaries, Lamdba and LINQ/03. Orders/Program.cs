namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            Dictionary<string, int> productsQuantity = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] productData = input.Split();
                string productName = productData[0];
                double price = double.Parse(productData[1]);
                int quantity = int.Parse(productData[2]);

                input = Console.ReadLine();

                //проверка, че не сме срещали такъв продукт
                if (!productsPrice.ContainsKey(productName) && !productsQuantity.ContainsKey(productName))
                {
                    productsPrice.Add(productName, price);
                    productsQuantity.Add(productName, quantity);
                }
                else //вече имаме такъв продукт
                {
                    //увеличаваме наличното количестяо
                    productsQuantity[productName] += quantity;

                    //заменяме текущата цена с новата въведена
                    productsPrice[productName] = price;
                }              
            }

            foreach (KeyValuePair<string, double> entry in productsPrice)
            {
                string productName = entry.Key;
                double price = entry.Value;
                int quantity = productsQuantity[productName];

                double totalPrice = price * quantity;

                Console.WriteLine($"{productName} -> {totalPrice:F2}");
            }            
        }
    }
}
