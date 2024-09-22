using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi4
{
    public interface IPoint
    {
        string printPoint();
        double cal_dist(IPoint v);
    }
}
