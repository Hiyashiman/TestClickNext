namespace testClicknext.src
{
	public class StringsEqual
	{
        public bool AreStringsEqual(string s1, string s2)
        {
            string string1 = new string(s1.ToUpper().OrderBy(c => c).ToArray());
            string string2 = new string(s2.ToUpper().OrderBy(c => c).ToArray());

            if (s1.Length != s2.Length)
            {
                return false;
            }

            if (string1 != string2) {

                return false;
            }

            return true;

        }


    }
}

