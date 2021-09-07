using System;
using System.Collections.Generic;
using System.Reflection;

using Encryption.DI.Algorithm.Container;
using Encryption.View.Commands;
using Encryption.View.Helper;

using Cmd = Encryption.View.Commands.Commands;
namespace Encryption.View
{
    partial class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        static void OutCommands(Dictionary<int, Cmd> commands)
        {
            Console.WriteLine("Select action by enter required number:");
            commands.ForEach(x => Console.WriteLine($"{x.Key} - {x.Value.GetStrAttribute()}"));
        }

        private static void OutCurrentAlgorithm(IAlgorithmContainer encryptionAlgContainer)
        {
            if (encryptionAlgContainer is null)
                OutImportantMessage("No algorithm is selected");
            else
                OutImportantMessage($"{encryptionAlgContainer.AlgorithmName} algorithm is selected");
        }

        static void OutResult(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        static void OutImportantMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static int GetIntFromConsole(string inputType)
        {
            Console.WriteLine(inputType);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Wrong input! Please enter integer number");
            }

            return result;
        }

        static string GetLineFromConsole(Func<string, bool> validator, string inputType = "")
        {
            Console.WriteLine(inputType);
            string res = Console.ReadLine();
            //TODO: must be some kind of method from Alg
            while (!validator.Invoke(res))
            {
                Console.WriteLine("Invalid input, try again");
                res = Console.ReadLine();
            }

            return res;
        }

        private static void Clear() => Console.Clear();
    }
}
