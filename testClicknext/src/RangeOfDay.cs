namespace testClicknext.src
{
    public class RangeOfDay
    {
        public string RangeDay(int[] array)
        {
            string result = string.Empty;
            if (array.Length == 0)
            {
                return string.Empty;
            }
            Array.Sort(array);

            result += array[0].ToString();
            bool inRange = false;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] + 1 == array[i])
                {
                    if (!inRange)
                    {
                        result += "-";
                        inRange = true;
                    }
                }
                else
                {
                    if (inRange)
                    {
                        result += array[i - 1];
                        inRange = false;
                    }
                    result += "," + array[i];
                }
            }

            if (inRange)
            {
                result += array[array.Length - 1];
            }
            return result;

        }
    }
}
