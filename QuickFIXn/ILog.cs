﻿using System;

namespace QuickFix
{
    /// <summary>
    /// (Renamed per naming convention.)
    /// </summary>
    [Obsolete("Use ILog instead.")]
    public interface Log : ILog { }

    /// <summary>
    /// Session log for messages and events
    /// </summary>
    [Obsolete]
    public interface ILog : IDisposable
    {
        /// <summary>
        /// Clears the log and removes any persistent log data
        /// </summary>
        void Clear();

        /// <summary>
        /// Logs an incoming message
        /// </summary>
        /// <param name="msg">a raw FIX message</param>
        void OnIncoming(string msg);

        /// <summary>
        /// Logs an outgoing message
        /// </summary>
        /// <param name="msg">a raw FIX message</param>
        void OnOutgoing(string msg);
    }
}
