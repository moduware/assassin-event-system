using System;

namespace AssassinEventSystem.Legacy
{
    public class ErrorEventArgs : EventArgs
    {
        /// <summary>
        /// The exception.
        /// </summary>
        public Exception Exception;

        /// <summary>
        /// The message.
        /// </summary>
        public string Message;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Nexpaq.EventArguments.ErrorEventArgs"/> class.
        /// </summary>
        /// <param name="e">E.</param>
        /// <param name="m">M.</param>
        public ErrorEventArgs(Exception e, string m)
        {
            Exception = e;
            Message = m;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Nexpaq.EventArguments.ErrorEventArgs"/> class.
        /// </summary>
        /// <param name="m">M.</param>
        public ErrorEventArgs(string m)
        {
            Message = m;
            Exception = new Exception(m);
        }
    }
}
