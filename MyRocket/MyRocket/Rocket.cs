

namespace MyRocket
{
    using System;
    using System.Windows.Media.Media3D;

    /// <summary>
    /// Sample implementation of a virtual rocket.
    /// </summary>
    public class Rocket : IRocket
    {
        /// <summary>
        /// Gets the flying state.
        /// </summary>
        /// <value>
        /// The current flying state.
        /// </value>
        /// <exception cref="System.NotImplementedException"></exception>
        public FlyState State
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the current flying position.
        /// </summary>
        /// <value>
        /// The current flying position.
        /// </value>
        /// <exception cref="System.NotImplementedException"></exception>
        public Point3D CurrentPosition
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the distance to destination.
        /// </summary>
        /// <value>
        /// The distance to destination in [lightyears].
        /// </value>
        /// <exception cref="System.NotImplementedException"></exception>
        public uint DistanceToDestination
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the remaining seconds to destination.
        /// </summary>
        /// <value>
        /// The seconds to destination.
        /// </value>
        /// <exception cref="System.NotImplementedException"></exception>
        public uint SecondsToDestination
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Call me to prepare the rocket before the flight.
        /// </summary>
        /// <param name="fuel">The amount of fuel.</param>
        /// <param name="destination">The destination.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Prepare(uint fuel, Point3D destination)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Tries to start the rocket.
        /// </summary>
        /// <returns>
        /// true, if starting sequence was successful; otherwise false.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool TryStart()
        {
            throw new NotImplementedException();
        }
    }
}
