using System;
using System.Collections.Generic;
using System.Text;

namespace Dizajn_LV_5
{
    interface IShipable
    {
        //1.Zadatak
        double Price { get; }

        double Weight { get; }

        string Description(int depth = 0);
        
    }
}
