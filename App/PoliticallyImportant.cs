using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreacherousBetrayalConsole.App
{
    public class PoliticallyImportant
    {
        public static bool IsEnabled = false;

        public static string EnablePoliticallyImportant() 
        {
            IsEnabled = true;
            return "Режим политической важности активирован!";
        }

        public static string DisablePoliticallyImportant()
        {
            IsEnabled = false;
            return "Режим политической важности деактивирован, несем репутационные потери!";
        }
    }
}
