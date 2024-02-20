using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_InterfaceandIEnumerable_StephanieLopez
{
    public class Door : IOpen, IClose
    {
        public void Open()
        {
            Console.WriteLine("Door is opening to " + IOpen.maxRotation + " degrees");
        }

        public void Close()
        {
            Console.WriteLine("Door is closing");
        }
    }
}
