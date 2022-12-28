using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchhaltung
{
    abstract class Menu
    {
        //Konstruktor
        public Menu()
        {
            Console.Clear();
            DisplayMenu();
        }
        //abstrakte Methode
        public abstract void DisplayMenu();
    }
}
