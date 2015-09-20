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
                if (item != null)//Make sure if there is no item, this isn't ran
                {
                    output += item.ToString() + Environment.NewLine;
                }
            }

            return output;
        }

        public string search(string ID)
        {
            int lengthOfArraySearch = 0;
            string result = "";

            while (lengthOfArraySearch < wineItems.Length)
            {
                try
                {
                    if (wineItems[lengthOfArraySearch].ID == ID)
                    {
                        result += wineItems[lengthOfArraySearch].ID + ", " + wineItems[lengthOfArraySearch].Description + ", " + wineItems[lengthOfArraySearch].Pack;
                        lengthOfArraySearch = wineItems.Length;
                    }
                    else
                    {
                        lengthOfArraySearch++;
                    }
                }
                catch
                {
                    result = "There was no item found matching the ID " + ID;
                    lengthOfArraySearch = wineItems.Length;
                }
            }

            return result;
        }

        public bool idExists(string ID)
        {
            int lengthOfArrayIDExists = 0;

            try
            {
                while (lengthOfArrayIDExists < wineItems.Length)
                {
                    if (wineItems[lengthOfArrayIDExists].ID == ID)
                    {
                        return true;
                    }
                    else
                    {
                        lengthOfArrayIDExists++;
                    }

                }

            }

            catch
            {
                return false;
            }

            return false;
        }
    }
}
