using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        /*This class reads in the CSV file and creates the item list*/
        bool listLoaded = false;

        public CSVProcessor()
        {

        }

        public void load(WineItemCollection collection)
        {
            if (!listLoaded)//Make sure the list can only be loaded once
            {
                StreamReader reader = new StreamReader("..\\..\\..\\datafiles\\WineList.csv");//Create parser object
                string[] lineSplit;

                while (!reader.EndOfStream)
                {
                    lineSplit = reader.ReadLine().Split(','); //Splits the line, using commas as delimiters

                    WineItem item = new WineItem(lineSplit[0], lineSplit[1], lineSplit[2]);//Create the WineItem using the information from the line
                    collection.addWineItem(item);//Load the item into the collection

                }

                listLoaded = true;

            }

        }
    }
}
