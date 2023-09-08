namespace testClicknext.src
{
	public class Reverse
	{
        public void ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            string[] reversedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                reversedWords[i] = ReverseWord(words[i]);
            }

            string reversedSentence = string.Join(" ", reversedWords);

            Console.WriteLine("Before: " + sentence);
            Console.WriteLine("After: " + reversedSentence);
        }

        private string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}

