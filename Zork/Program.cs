using System;
using System.ComponentModel.Design;
using System.Linq;

namespace Zork
{
    enum Commands
    {
        QUIT,
        LOOK,
        NORTH,
        SOUTH,
        EAST,
        WEST,
        UNKNOWN
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine();
           // Commands command = ToCommand(inputString.Trim().ToUpper());
           // Console.WriteLine(command);
        }

        private static Commands ToCommand(string commandString)
        {
            Commands command;
            switch (commandString)
            {
                case "QUIT":
                    command = Commands.QUIT;
                    break;

                case "LOOK":
                    command = Commands.LOOK;
                    break;

                case "NORTH":
                    command = Commands.NORTH;
                    break;

                case "SOUTH":
                    command = Commands.SOUTH;
                    break;

                case "EAST":
                    command = Commands.EAST;
                    break;

                case "WEST":
                    command = Commands.WEST;
                    break;

                default:
                    command = Commands.UNKOWN;
                    break;
            };

            return command;

           /* if (commandString == "QUIT")
            {
                command = Commands.QUIT;
            }
            else if (commandString == "LOOK")
            {
                command = Commands.LOOK;
            }
            else if (commandString == "NORTH")
            {
                command = Commands.NORTH;
            }
            else if (commandString == "SOUTH")
            {
                command = Commands.SOUTH;
            }
            else if (commandString == "EAST")
            {
                command = Commands.EAST;
            }
            else if (commandString == "WEST")
            {
                command = Commands.WEST;
            }
            else
            {
                command = Commands.UNKNOWN;
            }

            return command;*/
        }
    }
}
         
