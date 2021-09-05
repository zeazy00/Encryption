using System;
using System.Reflection;

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

        void OutCommands()
        {
            Console.WriteLine("Select action:");
            _commands.ForEach(x => Console.WriteLine($"{x.Key} - {x.Value.GetStrAttribute()}"));
        }

        private static void Clear() => Console.Clear();
    }
}
