using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Encryption.Config;
using Encryption.DI.Algorithm.Container;
using Encryption.View.Helper;

using Cmd = Encryption.View.Commands.Commands;

namespace Encryption.View
{
    partial class Program
    {
        private const int ClearSleep = 1000;

        private readonly Dictionary<int, Cmd> _commands = new();

        private IAlgorithmContainer _encryptionAlgContainer;
        private readonly AlgorithmsConfiguration algorithmsConfiguration;

        public Program()
        {
            Cmd[] cmdArray = Enum.GetValues(typeof(Cmd)) as Cmd[];

            cmdArray.ForEach((index, item) => _commands.Add(++index, item));

            algorithmsConfiguration = new AlgorithmsConfiguration();
        }

        Cmd? GetCommand()
        {
            bool parseResult = int.TryParse(Console.ReadLine(), out var commandIndex);

            return parseResult ? _commands[commandIndex] : null;
        }

        void Run()
        {
            while (true)
            {
                OutCurrentAlgorithm(_encryptionAlgContainer);
                OutCommands(_commands);
                var cmd = GetCommand();

                if (!cmd.HasValue)
                    Console.WriteLine("Invalid command");
                else
                    ExecuteCommand(cmd.Value);

                Thread.Sleep(ClearSleep);
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

                case Cmd.SelectAlgorithm:
                    _encryptionAlgContainer = SelectAlgorithm();
                    break;

                case Cmd.Cipher:
                    Cipher();
                    break;

                case Cmd.Decipher:
                    Decipher();
                    break;

                default:
                    throw new InvalidOperationException($"{cmd} operation is not recognized");
            }
        }

        private int SelectLabNum()
        {
            Console.WriteLine("Here are all available labs:");
            algorithmsConfiguration.GetAvailableLabs()
                                   .ForEach(x => Console.WriteLine($"Lab {x}"));
            return GetIntFromConsole("Enter lab number");
        }

        private IAlgorithmContainer SelectAlg(IEnumerable<string> availableAlgs)
        {
            Console.WriteLine("Enter alg name:");
            availableAlgs.ForEach(x => Console.WriteLine(x));
            string algName = GetLineFromConsole((str) => !string.IsNullOrWhiteSpace(str));

            return availableAlgs.Contains(algName) ? algorithmsConfiguration.GetAlg(algName) : null;
        }

        private IAlgorithmContainer SelectAlgorithm()
        {
            int labNumber = SelectLabNum();
            IEnumerable<string> availableAlgs = algorithmsConfiguration.GetAvailableAlgs(labNumber);
            if (!availableAlgs.Any())
            {
                OutImportantMessage("Invalid Lab number");
                return null;
            }

            IAlgorithmContainer selectedAlg = SelectAlg(availableAlgs);
            if (selectedAlg is null)
                OutImportantMessage("Alg is not selected!");

            return selectedAlg;
        }

        private void Decipher()
        {
            if (_encryptionAlgContainer is null)
            {
                Console.WriteLine("Select algorithm first!");
                return;
            }

            string toBeDeciphered = GetLineFromConsole(inputType: "Input text to be deciphered",
                                                       validator: _encryptionAlgContainer.ValidateSource);
            string result = _encryptionAlgContainer.EncryptionAlg.Decipher(toBeDeciphered);
            OutResult($"Decipher result is {result}");
        }

        private void Cipher()
        {
            if (_encryptionAlgContainer is null)
            {
                Console.WriteLine("Select algorithm first!");
                return;
            }

            string toBeCiphered = GetLineFromConsole(inputType: "Input text to be ciphered",
                                                     validator: _encryptionAlgContainer.ValidateSource);
            string result = _encryptionAlgContainer.EncryptionAlg.Cipher(toBeCiphered);
            OutResult($"Cipher result is {result}");
        }
    }
}
