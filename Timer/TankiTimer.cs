using System;

namespace ProboTankiLibCS.Timer
{
    /// <summary>
    /// Thread-safe timer for client time tracking
    /// </summary>
    public class TankiTimer
    {
        private long _clientTime;
        private long _lastTimestamp;
        private long _lastReturnedTime;  // Global monotonic counter
        private long _lastPhysicsTime;   // Track last physics time separately
        private readonly object _lock = new object();

        /// <summary>
        /// Creates a new instance of TankiTimer
        /// </summary>
        public TankiTimer()
        {
            _lastTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        /// <summary>
        /// Gets or sets the current client time with thread-safe updates
        /// </summary>
        public long ClientTime
        {
            get
            {
                lock (_lock)
                {
                    long currentTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    long elapsedTime = currentTimestamp - _lastTimestamp;

                    // Update client time based on elapsed time
                    _clientTime += elapsedTime;
                    _lastTimestamp = currentTimestamp;

                    // Ensure monotonicity against global counter (only if going backward)
                    if (_clientTime < _lastReturnedTime)
                        _clientTime = _lastReturnedTime;

                    // Update global counter
                    _lastReturnedTime = _clientTime;
                    return _clientTime;
                }
            }
            set
            {
                lock (_lock)
                {
                    // Allow setting time to a future or equal value
                    if (value < _lastReturnedTime)
                        return;

                    _clientTime = value;
                    _lastTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    _lastReturnedTime = value;
                    // Also update physics time if needed
                    if (value >= _lastPhysicsTime)
                        _lastPhysicsTime = value;
                }
            }
        }

        /// <summary>
        /// Gets time for battle ping responses that respects monotonicity
        /// </summary>
        /// <returns>The current client time</returns>
        public long PingTime()
        {
            // Use regular client time for ping responses
            return ClientTime;
        }

        /// <summary>
        /// Gets or sets time with consistent 33ms intervals between calls
        /// </summary>
        public long PhysicsTime
        {
            get
            {
                lock (_lock)
                {
                    // Get current client time (updates internal state)
                    long timeValue = ClientTime;

                    // Calculate next physics time based on 33ms increments from last physics time
                    long result;
                    if (_lastPhysicsTime == 0)
                    {
                        // First physics update - just use current time
                        result = timeValue;
                    }
                    else
                    {
                        // Subsequent updates - maintain exact 33ms intervals
                        long timeDiff = timeValue - _lastPhysicsTime;
                        long steps = Math.Max(1, (timeDiff + 16) / 33);  // Always at least 1 step, better rounding
                        long oldResult = _lastPhysicsTime + (steps * 33);
                        result = oldResult;
                    }

                    // Simple monotonicity check - just ensure we don't go backward
                    if (result < _lastReturnedTime)
                    {
                        while (result < _lastReturnedTime)
                            result += 33;
                    }

                    // Update time counters
                    _lastPhysicsTime = result;
                    _lastReturnedTime = result;

                    return result;
                }
            }
            set
            {
                lock (_lock)
                {
                    // Ensure value is a multiple of 33ms from the last physics time
                    long remainder = (value - _lastPhysicsTime) % 33;
                    if (remainder != 0)
                        throw new ArgumentException($"Physics time must be a multiple of 33ms: {remainder} != 0");

                    // Ensure monotonicity against global counter
                    if (value < _lastReturnedTime)
                        throw new ArgumentException($"Physics time cannot go backward: {value} < {_lastReturnedTime}");

                    // Update physics time and global counter
                    _lastPhysicsTime = value;
                    _lastReturnedTime = value;
                }
            }
        }

        /// <summary>
        /// Resets the timer
        /// </summary>
        public void Reset()
        {
            lock (_lock)
            {
                _clientTime = 0;
                _lastTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                _lastReturnedTime = 0;
                _lastPhysicsTime = 0;
            }
        }
    }
} 