using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreacherousBetrayalConsole.App
{
    public class Salary
    {
        public static string PaySalary() 
        {
            if (PoliticallyImportant.IsEnabled)
            {
                Random trick = new Random();
                int fakeDebt = trick.Next(100, 999);

                string postfix = "тысяч";
                int reminder = fakeDebt % 10;
                postfix = (reminder <= 1) ? postfix + "у" : postfix;
                postfix = (reminder > 1 && reminder < 5) ? postfix + "и" : postfix;

                return string.Format("Я договорился с большими дядьками, мне будут безотчетно давать {0} {1}!", fakeDebt.ToString(), postfix);
            }
            else 
            {
                return "Я уже со всеми договорился, обещали скоро все отдать...";
            }
        }
    }
}
