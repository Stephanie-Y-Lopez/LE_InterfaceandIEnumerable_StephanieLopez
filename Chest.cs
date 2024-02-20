using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_InterfaceandIEnumerable_StephanieLopez
{
    public class Chest : IOpen, IClose
    {
        public void Open()
        {
            Console.WriteLine("Chest is opening to " + IOpen.maxRotation + " degrees");
        }

        public void Close()
        {
            Console.WriteLine("Chest is closing");
        }
    }
}
