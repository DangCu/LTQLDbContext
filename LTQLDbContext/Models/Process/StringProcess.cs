using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace LTQLDbContext.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string id)
        {
            string numPart, strPart, newKey = "",  newNumPart = "";
            int intNumber;
            numPart = Regex.Match(id, @"\d+").Value;
            strPart = Regex.Match(id, @"\D+").Value;
            intNumber = Convert.ToInt32(numPart) + 1;
            for (int i = 0; i < numPart.Length - intNumber.ToString().Length; i++)
            {
                newNumPart += "0";
            }
            newNumPart += intNumber;
            newKey = strPart + newNumPart;
            return newKey;

        }
    }
}