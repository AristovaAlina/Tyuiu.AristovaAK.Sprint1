using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.AristovaAK.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string text)
        {
            string[] words = text.Split(' ');
            string result = "";

            foreach (string word in words)
            {
                bool isSymmetric = true;
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isSymmetric = false;
                        break;
                    }
                }
                if (isSymmetric)
                {
                    result += word + " ";
                }
            }

            return result.Trim();
        }
    }
}
