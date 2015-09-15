using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        //Class Variables
        private WineItem[] wineItems;
        int lengthOfArray;

        public WineItemCollection()
        {
            wineItems = new WineItem[4000];
            lengthOfArray = 0;
        }

        public void addWineItem(WineItem item)
        {
            wineItems[lengthOfArray] = item;
            lengthOfArray++;
        }

        public string getWineItemsString()
        {
            string output = "";
            foreach (WineItem item in wineItems)
            {
                output += item.ToString() + Environment.NewLine;
            }

            return output;
        }
    }
}
