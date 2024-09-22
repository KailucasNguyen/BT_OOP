using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi4
{
    public interface ICircle
    {
        string printCircle();
        double cal_area();
        IPoint GetPoint();
    }
}
