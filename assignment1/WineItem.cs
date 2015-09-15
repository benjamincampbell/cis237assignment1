using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        //Class Variables
        private string id;
        private string description;
        private string pack;

        public WineItem(string id, string desc, string pack)
        {
            this.id = id;
            this.description = desc;
            this.pack = pack;
        }

        public string ToString()
        {
            string itemOutput = "";

            itemOutput += this.id;
            itemOutput += this.description;
            itemOutput += this.pack;

            return itemOutput;
        }


        //Properties
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }

        }

        public string Pack
        {
            get
            {
                return this.pack;
            }

            set
            {
                this.pack = value;
            }
        }

    }
}
