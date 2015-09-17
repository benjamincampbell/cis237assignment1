using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            WineItemCollection wineItemCollection = new WineItemCollection();
            UserInterface UI = new UserInterface(wineItemCollection); //Create UI Object


            UI.loadWineList();
            UI.showMenu();
        }
    }
}
