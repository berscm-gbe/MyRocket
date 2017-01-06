using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MyRocket
{
    public class Rocket : IRocket
    {
        public FlyState State
        {
            get { throw new NotImplementedException(); }
        }

        public Point3D CurrentPosition
        {
            get { throw new NotImplementedException(); }
        }

        public uint DistanceToDestination
        {
            get { throw new NotImplementedException(); }
        }

        public uint SecondsToDestination
        {
            get { throw new NotImplementedException(); }
        }

        public void Prepare(uint fuel, Point3D destination)
        {
            throw new NotImplementedException();
        }

        public bool TryStart()
        {
            throw new NotImplementedException();
        }
    }
}
