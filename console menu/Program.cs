using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_menu
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.run();

        }

        public void run()
        {
            Menu menu = new Menu();
            menu.AddItem(new MenuItem() { navn = "opret", mv = new MenuValgt(opret) });
            menu.AddItem(new MenuItem() { navn = "rediger", mv = new MenuValgt(EditItem) });
            menu.AddItem(new MenuItem() { navn = "slet", mv = new MenuValgt(DeleteItem) });

            menu.menu[Convert.ToInt32( Console.ReadLine())].mv();
            Console.ReadLine();
        }

        public void opret()
        {
            Console.WriteLine("opret");
        }
        public void EditItem()
        {
            Console.WriteLine("rediger");
        }
        public void DeleteItem()
        {
            Console.WriteLine("slet");
        }
    }
}
