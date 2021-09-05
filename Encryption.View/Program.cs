﻿using System;
using System.Collections.Generic;

using Encryption.View.Helper;

using Cmd = Encryption.View.Commands.Commands;

namespace Encryption.View
{
    partial class Program
    {
        private readonly Dictionary<int, Cmd> _commands = new();

        public Program()
        {
            Cmd[] cmdArray = Enum.GetValues(typeof(Cmd)) as Cmd[];

            cmdArray.ForEach((index, item) => _commands.Add(++index, item));
        }

        void Run()
        {
            while (true)
            {
                OutCommands();
                var cmd = GetCommand();

                if (!cmd.HasValue)
                    Console.WriteLine("Invalid command");
                else
                    ExecuteCommand(cmd.Value);

                Clear();
            }
        }

        private void ExecuteCommand(Cmd cmd)
        {
            switch (cmd)
            {
                case Cmd.Exit:
                    Environment.Exit(0);
                    break;

                case Cmd.ShowAvailableLabs:
                    break;

                case Cmd.Cypher:
                    break;

                case Cmd.Decipher:
                    break;

                default:
                    throw new InvalidOperationException($"{cmd} operation is not recognized");
            }
        }
    }
}
