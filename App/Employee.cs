using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreacherousBetrayalConsole.App
{
    public class Employee
    {
        public static string GetEmployee(string name) 
        {
            switch (name)
            {
                case "Olga":
                    return "Да она какая-то вся больная и никчемная.";
                case "Alena":
                    return "Ее надо двигать, выпендривается много!";
                default:
                    return "Меня все предали! Наберу студентов!";
            }
        }
    }
}
