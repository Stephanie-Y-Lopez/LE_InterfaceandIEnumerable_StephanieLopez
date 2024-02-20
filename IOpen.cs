using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_InterfaceandIEnumerable_StephanieLopez
{
    internal interface IOpen
    {
        const double maxRotation = 120;
        const double minRotation = 0;

        void Open();
    }
}
