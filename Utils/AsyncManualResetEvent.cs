using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProboTankiLibCS.Utils
{
    /// <summary>
    /// Provides an asynchronous version of ManualResetEvent
    /// </summary>
    public class AsyncManualResetEvent
    {
        private TaskCompletionSource<bool> _tcs = new TaskCompletionSource<bool>();
        private volatile bool _isSet;

        /// <summary>
        /// Gets whether the event is set
        /// </summary>
        public bool IsSet => _isSet;

        /// <summary>
        /// Creates a new instance of AsyncManualResetEvent
        /// </summary>
        /// <param name="initialState">Initial state of the event</param>
        public AsyncManualResetEvent(bool initialState = false)
        {
            if (initialState)
                Set();
        }

        /// <summary>
        /// Sets the event, allowing all waiting tasks to proceed
        /// </summary>
        public void Set()
        {
            if (!_isSet)
            {
                _isSet = true;
                _tcs.TrySetResult(true);
            }
        }

        /// <summary>
        /// Resets the event, causing new waiters to block
        /// </summary>
        public void Reset()
        {
            if (_isSet)
            {
                _isSet = false;
                _tcs = new TaskCompletionSource<bool>();
            }
        }

        /// <summary>
        /// Waits for the event to be set
        /// </summary>
        /// <param name="cancellationToken">Token to cancel the wait</param>
        /// <returns>Task that completes when the event is set</returns>
        public Task WaitAsync(CancellationToken cancellationToken = default)
        {
            if (_isSet)
                return Task.CompletedTask;

            var tcs = new TaskCompletionSource<bool>();
            cancellationToken.Register(() => tcs.TrySetCanceled());

            return Task.WhenAny(_tcs.Task, tcs.Task);
        }
    }
} 