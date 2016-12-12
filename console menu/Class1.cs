using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_menu
{
    public delegate void MenuValgt();
    public class Menu
    {
        
        public List<MenuItem> menu = new List<MenuItem>();
        public void AddItem(MenuItem m)
        {
            menu.Add(m);
        }
       
    }
    public class MenuItem
    {
        public string navn;
        public MenuValgt mv;
    }
}
