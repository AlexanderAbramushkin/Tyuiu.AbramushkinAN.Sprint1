using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AbramushkinAN.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string strres = "";
            string [] words = value.Split(" ");
            for (int i = 0; i < words.Length; i++) 
            {
             strres += words[i].Substring(1) + " ";
            }
            strres = strres.Trim();
            return strres;
        }   
    }
}
