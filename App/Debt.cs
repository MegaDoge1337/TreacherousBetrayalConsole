using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreacherousBetrayalConsole.App
{
    public class Debt
    {
        public static string GetDebt() 
        {
            Random trick = new Random();
            int fakeDebt = trick.Next(100, 999);

            string postfix = "тысяч";
            int reminder = fakeDebt % 10;
            postfix = (reminder <= 1) ? postfix + "у" : postfix;
            postfix = (reminder > 1 && reminder < 5) ? postfix + "и" : postfix;

            return string.Format("Из-за наших внутренних конфликтов я встрял на {0} {1}!", fakeDebt.ToString(), postfix);
        }
    }
}
