
using System.Text.RegularExpressions;
using System;

namespace DemoNetcore.Models
{
    public class Pro
    {
        public static string AutoKey(string id)
        {
            string newKey, NumPart, StrPart;
            NumPart = Regex.Match(id, @"\d+").Value;
            StrPart = Regex.Match(id, @"\D+").Value;
            int newNum = Convert.ToInt32(NumPart) + 1;
            for (int i = 0; i < NumPart.Length - newNum.ToString().Length; i++)
            {
                StrPart += "0";
            }
            return newKey = StrPart + newNum;
        }
    }
}