using System;

namespace ProboTankiLibCS.Communications
{
    /// <summary>
    /// Base class for all commands in the system
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// Gets the unique identifier for this command type
        /// </summary>
        public abstract int Id { get; }

        /// <summary>
        /// Gets the name of this command
        /// </summary>
        public abstract string Name { get; }
    }
} 