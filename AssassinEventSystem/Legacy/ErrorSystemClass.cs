using System;

namespace AssassinEventSystem.Legacy
{
    /// <summary>
    /// Class with support of error reporting system 
    /// (for comman errors, not exceptions)
    /// </summary>
    public class ErrorSystemClass
    {
        #region METHODS
        /// <summary>
        /// Triggers the error.
        /// </summary>
        /// <param name="message">Message of error.</param>
        protected void TriggerError(string message)
        {
            Error(this, new ErrorEventArgs(message));
        }
        #endregion

        #region EVENTS
        /// <summary>
        /// Occurs when error.
        /// </summary>
        public event EventHandler<ErrorEventArgs> Error = delegate { };
        #endregion
    }
}