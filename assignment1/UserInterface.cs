﻿using System;
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
        string menu = "Please select an option" + Environment.NewLine +
            "1 - Print all items" + Environment.NewLine +
            "2 - Search for item by ID" + Environment.NewLine +
            "3 - Add new item" + Environment.NewLine +
            "4 - Exit" + Environment.NewLine;
        WineItemCollection wineItemCollection;

        public UserInterface(WineItemCollection collection)
        {
            this.wineItemCollection = collection;
        }

        public void loadWineList()
        {   //Method to show we are loading CSV File, calls CSVProcessor.load()

            Console.WriteLine("Attempting to load CSV file...");

            processor.load(wineItemCollection);//Load the file, passing along the collection we will fill

        }

        public void showMenu()
        {
            while (true)
            {   //We want to run the menu forever now, until the user exits
                Console.WriteLine(menu);
                string userInput = Console.ReadLine().ToString();
                switch (userInput)
                {
                    case "1":
                        itemList();
                        showMenu();
                        break;
                    case "2":
                        itemSearch();
                        showMenu();
                        break;
                    case "3":
                        itemAdd();
                        showMenu();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }


        }

        public void itemList()
        {
            Console.WriteLine(wineItemCollection.getWineItemsString());
        }

        public void itemSearch()
        {
            Console.WriteLine("Please enter the ID of the item: ");
            string userInput = Console.ReadLine().ToString();

            if (userInput != "")
            {
                Console.WriteLine(wineItemCollection.search(userInput));
            }
            else
            {
                Console.WriteLine("Please enter an ID");
            }
        }

        public void itemAdd()
        {
            Console.WriteLine("Please enter the ID of the new item:" + Environment.NewLine);
            string newID = Console.ReadLine().ToString();
            Console.WriteLine("Please enter the desciption of the new item:" + Environment.NewLine);
            string newDesc = Console.ReadLine().ToString();
            Console.WriteLine("Please enter the pack of the new item:" + Environment.NewLine);
            string newPack = Console.ReadLine().ToString();

            WineItem newItem = new WineItem(newID, newDesc, newPack);
            wineItemCollection.addWineItem(newItem);
        }

        public void exit()
        {
            Environment.Exit(0);
        }
    }
}