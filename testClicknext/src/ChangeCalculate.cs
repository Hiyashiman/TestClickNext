namespace testClicknext.src
{
	public class ChangeCalculate
	{
        public void CalculateChange()
        {
            Console.Write("Enter Price (1-1000 Baht): ");
            int amountPaid;
            if (!int.TryParse(Console.ReadLine(), out amountPaid) || amountPaid < 1 || amountPaid > 1000)
            {
                Console.WriteLine("Invalid Input. Please enter a value amount between 1 and 1000 Baht.");
                return;
            }

            if (amountPaid < 1000)
            {
                int change = 1000 - amountPaid;
                Console.WriteLine($"Change {change} Baht");

                int[] banknotes = { 500, 100, 50, 10, 5, 1 };
                int[] changeCount = new int[banknotes.Length];

                for (int i = 0; i < banknotes.Length; i++)
                {
                    while (change >= banknotes[i])
                    {
                        change = change - banknotes[i];
                        changeCount[i]++;
                    }
                }

                for (int i = 0; i < banknotes.Length; i++)
                {
                    if (changeCount[i] > 0)
                    {
                        string currencyType = banknotes[i] >= 10 ? "Banknote" : "Coin";
                        Console.WriteLine($"{banknotes[i]} {currencyType} {changeCount[i]}");
                    }
                }
            }
          
        }
    }
	
	
}

