using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreacherousBetrayalConsole.App
{
    public class Psina
    {
        public static bool IsKnifeInserted = false;

        public static string InsertKnife() 
        {
            if (PoliticallyImportant.IsEnabled) 
            {
                IsKnifeInserted = true;
                return "В режиме политической важности выполнение этого запроса приведет к критическим репутационным потерям";
            }

            return "Ты же сетевик, ты это можешь, я тебе доверяю (пока что)!";
        }

        public static string MakeCommit() 
        {
            if (PoliticallyImportant.IsEnabled && IsKnifeInserted) 
            {
                throw new Exception("Репутационные потери превысили критически допустимые значения, нож в псине привел к сдвигу кукухи и бизнес будет аварийно закрыт");
            }

            return "Незаменимых людей нет, когда все сделаем, ты не удел будешь!";
        }
    }
}
