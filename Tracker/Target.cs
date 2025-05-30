using System;

namespace ProboTankiLibCS.Tracker
{
    /// <summary>
    /// Represents a tracked target with status information
    /// </summary>
    public class Target
    {
        /// <summary>
        /// Gets the name of the target
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets or sets whether the target is online
        /// </summary>
        public bool Online { get; set; }

        /// <summary>
        /// Gets or sets the battle ID if the target is in a battle
        /// </summary>
        public string BattleID { get; set; }

        /// <summary>
        /// Gets or sets whether the target's status has been received
        /// </summary>
        public bool StatusRecv { get; set; }

        /// <summary>
        /// Gets or sets whether the target's online status has been received
        /// </summary>
        public bool OnlineStatusRecv { get; set; }

        /// <summary>
        /// Gets or sets whether the target is in names mode
        /// </summary>
        public bool NamesMode { get; set; }

        /// <summary>
        /// Gets or sets whether to ignore the next status update
        /// </summary>
        public bool IgnoreFlag { get; set; }

        /// <summary>
        /// Gets or sets whether the target has been tracked for the first time
        /// </summary>
        public bool TrackedFirstTime { get; set; }

        /// <summary>
        /// Creates a new instance of Target
        /// </summary>
        /// <param name="name">The name of the target</param>
        public Target(string name)
        {
            Name = name;
            Online = false;
            BattleID = null;
            StatusRecv = false;
            OnlineStatusRecv = false;
            NamesMode = false;
            IgnoreFlag = false;
            TrackedFirstTime = false;
        }
    }
} 