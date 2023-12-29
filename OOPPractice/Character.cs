using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    class Character
    {
        private string name; 

        public string Name 
        {
            get { return name; }   
            set { name = value; } 
        }

        private List<Item> items = new List<Item>();

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }
    }
}
