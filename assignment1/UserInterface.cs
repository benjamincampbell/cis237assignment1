using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        /* This class handles all of the progam I/O (Input/Output) */

        CSVProcessor processor = new CSVProcessor();

        public void loadWineList()
        {   //Method to show we are loading CSV File, calls CSVProcessor.load()

            Console.WriteLine("Attempting to load CSV file...");

            processor.load();//Load the file

        }

        public void showMenu()
        {
            string menu = "Please select an option" + Environment.NewLine + 
                        "1.) Print all items" + Environment.NewLine + 
                        "2.) Search for item by ID" + Environment.NewLine + 
                        "3.) Add new item" + Environment.NewLine + 
                        "4.) Exit" + Environment.NewLine;

            Console.WriteLine(menu);
            string userInput = Console.ReadLine().ToString();
        }

        public void printList()
        {

        }

        public void itemSearch()
        {

        }

        public void itemAdd()
        {

        }

        public void exit()
        {
            Environment.Exit(0);
        }
    }
}
