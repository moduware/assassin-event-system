﻿using AssassinEventSystem.EventArguments;
using System;

namespace AssassinEventSystem
{
    /// <summary>
    /// Responsible for raising error, warnings, and notifications, for example you can raise an error 
    /// using the the RaiseError method and also you can subscribe for errors, warnings, and notification events 
    /// to handle them 
    /// </summary>
    public static class Assassin
    {
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

        public static void RaiseError(string error) 
        {
            Error(null, new ErrorEventArgs(error));
        }

        public static void RaiseWarning(string warning) 
        {
            Warning(null, new WarningEventArgs(warning));
        }

        public static void RaiseNotification(string notification) 
        {
            Notification(null, new NotificationEventArgs(notification));
        }

        public static void RaiseInformation(string information)
        {
            Information(null, new InformationEventArgs(information));
        }

    }
}