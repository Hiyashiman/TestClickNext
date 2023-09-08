namespace testClicknext.src
{
	public class Sorting
	{
		public void sortMaxtoMin(int[] arr) {
  
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }

                }

            Console.Write("sort Max to Min: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }

        public void sortMintoMax(int[] arr)
        {

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }

            Console.Write("sort Min to Max: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }
    }
}

