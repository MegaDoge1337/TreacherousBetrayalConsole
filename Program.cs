using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreacherousBetrayalConsole.App;

namespace TreacherousBetrayalConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Func<string>> commands = new Dictionary<string, Func<string>>();
            commands["set politically important on;"] = () => PoliticallyImportant.EnablePoliticallyImportant();
            commands["set politically important off;"] = () => PoliticallyImportant.DisablePoliticallyImportant();
            commands["select salary;"] = () => Salary.PaySalary();
            commands["show debts;"] = () => Debt.GetDebt();
            commands["show reputation loss;"] = () => Reputation.GetLoss();
            commands["select workers;"] = () => Employee.GetEmployee(null);
            commands["select olga;"] = () => Employee.GetEmployee("Olga");
            commands["select alena;"] = () => Employee.GetEmployee("Alena");
            commands["inser knife into psina;"] = () => Psina.InsertKnife();
            commands["commit knife in psina;"] = () => Psina.MakeCommit();
            commands["exit;"] = () => Exit.MakeExit();
            commands["exit force;"] = () => Exit.MakeForceExit();

            string prefix = "TBC";
            string mode = PoliticallyImportant.IsEnabled ? "#" : ">";
            Console.Write(string.Format("{0}{1}", prefix, mode));
            string input = Console.ReadLine().ToLower();
            while (true) 
            {
                if (!commands.ContainsKey(input))
                {
                    Console.WriteLine("Среда 'Руководятел 1.0' не смогла распознать командлету");
                }
                else 
                {
                    var output = commands[input]();
                    Console.WriteLine(output);
                    if (input == "exit force;")
                    {
                        break;
                    }
                }

                mode = PoliticallyImportant.IsEnabled ? "#" : ">";
                Console.Write(string.Format("{0}{1}", prefix, mode));
                input = Console.ReadLine().ToLower();
            }

            Console.Write("У тебя такая каша в голове (нажмите любую клавишу, чтобы продолжить спокойно жить дальше)...");
            Console.ReadKey();
        }
    }
}
