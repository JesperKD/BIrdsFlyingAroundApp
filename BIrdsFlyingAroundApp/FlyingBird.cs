using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIrdsFlyingAroundApp
{
    public abstract class FlyingBird : Bird
    {
        public abstract void SetAltitude(double altitude);
    }
}
