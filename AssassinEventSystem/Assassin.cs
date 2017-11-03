using System;
using AssassinEventSystem.EventArguments;
using AssassinEventSystem.Infrastructure;

namespace AssassinEventSystem
{
    /// <summary>
    /// Responsible for raising error, warnings, and notifications, for example you can raise an error 
    /// using the the RaiseError method and also you can subscribe for errors, warnings, and notification events 
    /// to handle them 
    /// </summary>
    public static class Assassin
    {
        //public delegate void BadErrorHappenedHandler(ErrorEventArgs args);

        //public static event BadErrorHappenedHandler OnBadErrorHappened;

        //public static void RaiseBadError<T>(T error) where T : Error
        //{
        //    OnBadErrorHappened?.Invoke(new ErrorEventArgs(error));
        //}

        /// <summary>
        /// Occurs when [on error].
        /// </summary>
        public static event EventHandler<ErrorEventArgs> Error = delegate { };

        /// <summary>
        /// Occurs when [on warning].
        /// </summary>
        public static event EventHandler<WarningEventArgs> Warning = delegate { };

        /// <summary>
        /// Occurs when [on notification].
        /// </summary>
        public static event EventHandler<NotificationEventArgs> Notification = delegate { };

        /// <summary>
        /// Occurs when [on information].
        /// </summary>
        public static event EventHandler<InformationEventArgs> Information = delegate { };

        /// <summary>
        /// Raises the error.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="error">The error.</param>
        public static void RaiseError<T>(T error) where T : Error
        {
            Error(null, new ErrorEventArgs(error));
        }

        /// <summary>
        /// Raises the warning.
        /// </summary>
        /// <param name="warning">The warning.</param>
        public static void RaiseWarning<T>(T warning) where T: Warning
        {
            Warning(null, new WarningEventArgs(warning));
        }

        /// <summary>
        /// Raises the notification.
        /// </summary>
        /// <param name="notification">The notification.</param>
        public static void RaiseNotification<T>(T notification) where T: Notification
        {
            Notification(null, new NotificationEventArgs(notification));
        }

        /// <summary>
        /// Raises the information.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="information">The information.</param>
        public static void RaiseInformation<T>(T information) where T : Information
        {
            Information(null, new InformationEventArgs(information));
        }



    }
}