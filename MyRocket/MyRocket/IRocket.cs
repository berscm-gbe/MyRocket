

namespace MyRocket
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// Interface to access a flyable rocket.
    /// </summary>
    public interface IRocket
    {
        /// <summary>
        /// Gets the flying state.
        /// </summary>
        /// <value>
        /// The current flying state.
        /// </value>
        FlyState State { get; }

        /// <summary>
        /// Gets the current flying position.
        /// </summary>
        /// <value>
        /// The current flying position.
        /// </value>
        Point3D CurrentPosition { get; }

        /// <summary>
        /// Gets the distance to destination.
        /// </summary>
        /// <value>
        /// The distance to destination in [lightyears].
        /// </value>
        uint DistanceToDestination { get; }

        /// <summary>
        /// Gets the remaining seconds to destination.
        /// </summary>
        /// <value>
        /// The seconds to destination.
        /// </value>
        uint SecondsToDestination { get; }

        /// <summary>
        ///Call me to prepare the rocket before the flight.
        /// </summary>
        /// <param name="fuel">The amount of fuel.</param>
        /// <param name="destination">The destination.</param>
        void Prepare(uint fuel, Point3D destination);

        /// <summary>
        /// Tries to start the rocket.
        /// </summary>
        /// <returns>true, if starting sequence was successful; otherwise false.</returns>
        bool TryStart();
    }

    /// <summary>
    /// The allowed fyling states.
    /// </summary>
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
