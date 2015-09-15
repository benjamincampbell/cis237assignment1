using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO

namespace assignment1
{
    class CSVProcessor
    {
        /*This class reads in the CSV file and creates the item list*/

        WineItemCollection wineItemCollection = new WineItemCollection();

        public CSVProcessor()
        {

        }

        public void load()
        {
            StreamReader reader = new StreamReader("../datafiles/WineList.csv");//Create parser object

            while (!reader.EndOfStream)
            {
                string[] lineSplit = reader.ReadLine().Split(','); //Splits the line, using commas as delimiters

                WineItem item = new WineItem(lineSplit[0], lineSplit[1], lineSplit[2]);//Create the WineItem using the information from the line
                wineItemCollection.addWineItem(item);

            }

        }
    }
}
