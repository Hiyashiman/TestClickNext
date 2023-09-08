namespace testClicknext.src
{
    class SumCalculator
    {
        public void CalSum()
        {
            int item;
            int sum;
            List<int> listItem = new List<int>();
            string input = string.Empty;

            Console.WriteLine("input number to add or input char to exit.");
            while (true)
            {
                Console.Write("your input: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out item))
                {
                    listItem.Add(item);
                }
                else
                {
                    break;
                }
            }

            Console.Write("input sum: ");
            input = Console.ReadLine();
            int.TryParse(input, out sum);

            Console.Write("your Array: [");
            for (int i = 0; i < listItem.Count; i++)
            {
                Console.Write(listItem[i]);
                if (i < listItem.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            Console.WriteLine("sum: " + sum);
            FindSum(listItem, sum);
        }

        private void FindSum(List<int> listItem, int Sum)
        {
            List<int> seenNumbers = new List<int>();
            HashSet<int> uniqueItems = new HashSet<int>(listItem);
            listItem.Clear();
            listItem.AddRange(uniqueItems);

            Console.Write("Results: ");
            for (int i = 0; i < listItem.Count; i++)
            {
                int complement = Sum - listItem[i];
                seenNumbers.Add(listItem[i]);
                if (seenNumbers.Contains(complement))
                {
                    Console.Write("[" + complement + ", " + listItem[i] + "]");
                    seenNumbers.Remove(complement);
                    seenNumbers.Remove(listItem[i]);
                }
            }
            Console.WriteLine();

        }
    }
}