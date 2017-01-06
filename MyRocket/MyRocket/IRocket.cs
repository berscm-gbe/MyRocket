using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MyRocket
{
    public interface IRocket
    {
        FlyState State { get; }

        Point3D CurrentPosition { get; }

        uint DistanceToDestination { get; }

        uint SecondsToDestination { get; }

        void Prepare(uint fuel, Point3D destination);

        bool TryStart();
    }

    public enum FlyState
    {
        Initial,
        Preparing,
        Starting,
        Flying,
        Landing,
        Landed,
        Crashed
    }
}
