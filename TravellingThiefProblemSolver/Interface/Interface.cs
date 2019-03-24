using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellingThiefProblemSolver.Data;
using TravellingThiefProblemSolver.Loaders;
using TravellingThiefProblemSolver.TravellingSalesmanProblem;

namespace TravellingThiefProblemSolver
{
    public class Interface
    {
    
        public const string TITLE = "\t\t\tTTP PROBLEM SOLVER APPLICATION";
        public const string COMMANDS = "\nCommands:\n" +
            "0 - load data from file \n" +
            "1 - solve TTP \n" +
            "2 - solve KNP \n" +
            "3 - solve TTP \n" +
            "4 - display loaded data\n" +
            "9 - exit\n\n";
        public const string SOME = "\t\t\tTTP PROBLEM SOLVER";

        private readonly IEnumerable<string> _commands = new string[] { "0", "1", "2", "3", "4", "9"};

        private bool _exit;
        private FileLoader _fileLoader;
        
        public void Start()
        {
            Console.WriteLine(TITLE);

            _exit = false;
            while ( _exit != true )
            {
                DisplayStartMessage();
                DoActionDependOnCommand(ValidateCommand());
            }

        }

        private void DisplayStartMessage()
        {
            Console.WriteLine(COMMANDS);
        }

        private string ValidateCommand()
        {
            Console.Write(">");
            string myCommand = Console.ReadLine();
            if (_commands.Contains(myCommand))
            {
                return myCommand;
            }
            else
            {
                return "error";
            }
        }

        private void DoActionDependOnCommand(string command)
        {
            switch (command)
            {
                case "0":
                    if (!DoLoad())
                    {
                        return;
                    };
                    ParseData();
                    break;
                case "1":
                    SolveTSP();
                    break;
                case "2":
                    SolveKNP();
                    break;
                case "3":
                    SolveTTP();
                    break;
                case "4":
                    DisplayLoadedData();
                    break;
                case "9":
                    _exit = true;
                    break;

                case "error":
                    Console.WriteLine("BAD COMMAND"); ;
                    break;

            }
                
        }
        
        private bool DoLoad()
        {
            Console.WriteLine("Give file's name: ");
            string fileName = Console.ReadLine();
            _fileLoader = new FileLoader(fileName);
            if (!_fileLoader.IsFileGood())
            {
                Console.WriteLine("Bad loading file");
                return false;
            }
            else
            {
                Console.WriteLine("file loaded;");
                return true;
            }
        }

        private bool ParseData()
        {
            DataParser dataParser = new DataParser();
            dataParser.ParseDataFromFileStream(_fileLoader.GetFileStream());

            return true;
        }

        private void SolveTSP()
        {
            TTP oTSP = new TTP();
            oTSP.StartTTP(Env.POP_SIZE, Env.GENERATION_COUNT, Env.SORT_TYPE, Env.MUT_RATE);
        }

        private void SolveKNP()
        {
            throw new NotImplementedException();
        }

        private void SolveTTP()
        {
            throw new NotImplementedException();
        }

        private void DisplayLoadedData()
        {
            DataContainer box = DataContainer.Instance;
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("Dimension: {0}", box.Dimension);
            Console.WriteLine("Number of items: {0}", box.NumberOfItems);
            Console.WriteLine("Capacity: {0}", box.Capacity);
            Console.WriteLine("min speed: {0}", box.MinSpeed);
            Console.WriteLine("max speed: {0}", box.MaxSpeed);
            Console.WriteLine("renting ratio: {0}", box.RentingRatio);
            for(int i=0; i<box._Cities.Count; i++)
            {
                Console.WriteLine("{0}", box._Cities[i]);
            }
            for (int i = 0; i < box._Items.Count; i++)
            {
                Console.WriteLine("{0}", box._Items[i]);
            }
            Console.WriteLine("");
        }

    }
}
